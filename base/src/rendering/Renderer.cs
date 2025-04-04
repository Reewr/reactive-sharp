namespace ReactiveSharp;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

internal class Managers(
	EffectManager effectManager,
	StateManager stateManager,
	Renderer renderer
)
{
	internal readonly EffectManager EffectManager = effectManager;
	internal readonly StateManager StateManager = stateManager;
	internal readonly Renderer Renderer = renderer;
}

/***
 *
 * The Renderer class is responsible for turning a Component into a tree of INode objects.
 * It keeps track of the root node and the nodes for each component, and
 * updates or builds the nodes when a component is rendered.
 *
 *
 *
 */
public partial class Renderer
{
	private readonly INode _rootNode;
	private readonly Dictionary<Component, INode[]> _componentNodes = [];
	private readonly HashSet<Component> _dirtyComponents = [];
	private readonly HashSet<INode> disposedNodes = [];
	private readonly EffectManager EffectManager = new();
	private readonly StateManager StateManager;

	internal Component? CurrentRenderingComponent { get; set; }

	internal static Renderer? GetCurrentRenderer() => Managers?.Value?.Renderer;
	internal static StateManager? GetCurrentStateManager() => Managers?.Value?.StateManager;
	internal static EffectManager? GetCurrentEffectManager() => Managers?.Value?.EffectManager;

	[ThreadStatic]
	private static ThreadLocal<Managers>? Managers;

	public Renderer(INode rootNode)
	{
		_rootNode = rootNode;
		StateManager = new StateManager { Renderer = this };
	}

	public void RequestRender(Component dirtyComponent) =>
		_dirtyComponents.Add(dirtyComponent);

	public void RenderRequested()
	{
		if (RenderingRequested())
		{
			foreach (var dirtyComponent in _dirtyComponents)
			{
				Render(dirtyComponent, false);
			}

			_dirtyComponents.Clear();
			Cleanup();
			EffectManager.RunAllEffects();
		}
	}

	public bool RenderingRequested()
	{
		return _dirtyComponents.Count > 0;
	}

	private void Cleanup()
	{
		var keysForRemoval = new List<Component>();
		foreach (var disposedNode in disposedNodes)
		{
			foreach (var item in _componentNodes.Where(x => x.Value.Contains(disposedNode)))
			{
				var prevLen = item.Value.Length;
				var changed = item.Value.Where(x => x != disposedNode).ToArray();
				var newLen = changed.Length;

				if (prevLen == 0 || newLen == 0) keysForRemoval.Add(item.Key);
				else if (prevLen != changed.Length) _componentNodes[item.Key] = changed;
			}

			disposedNode.Dispose();
		}

		foreach (var component in keysForRemoval)
		{
			component.ReleaseState();
			_componentNodes.Remove(component);
		}

		disposedNodes.Clear();
	}

	private void RequestCleanup(INode node)
	{
		disposedNodes.Add(node);
	}

	private void Render(Component component, bool triggerEffects = true)
	{
		Managers = new ThreadLocal<Managers>(() => new Managers(EffectManager, StateManager, this));
		var renderedComponent = component.RenderWithReset();
		if (_componentNodes.TryGetValue(component, out var nodes) && nodes.FirstOrDefault() is INode parentNode)
		{
			var newNodes = UpdateNode(new Queue<INode>(nodes), renderedComponent, parentNode);
			if (newNodes.Length == 0)
			{
				foreach (var node in nodes)
				{
					node.Remove();
					RequestCleanup(node);
				}
			}
			_componentNodes[component] = newNodes;
		}
		else
		{
			nodes = BuildNode(renderedComponent);
			foreach (var builtNode in nodes)
				_rootNode.AddChild(builtNode);
			_componentNodes[component] = nodes;
		}

		if (triggerEffects)
			EffectManager.RunAllEffects();
	}

	public void Render(Component component)
	{
		Render(component, true);
	}

	private void DiffAndUpdate(Queue<INode> nodes, Component? oldComponent, Component? newComponent, INode parent)
	{
		if (newComponent == null)
		{
			if (oldComponent != null)
			{
				var node = nodes.Dequeue();
				node.Remove();
				RequestCleanup(node);
			}
			return;
		}

		// Update node properties
		UpdateNode(nodes, newComponent, parent);
	}

	private INode[] BuildNode(Component component)
	{
		if (component is INodeComponent nodeComponent)
		{
			var children = nodeComponent.Children
				.OfType<Component>()
				.SelectMany(child =>
				{
					var innerNode = BuildNode(child);
					_componentNodes[child] = innerNode;
					return innerNode;
				})
				.ToList();

			var node = nodeComponent.Build(children);
			_componentNodes[component] = [node];
			return [node];
		}
		else if (component is Fragment fragment)
		{
			var children = fragment.Children
				.OfType<Component>()
				.SelectMany(child =>
				{
					var innerNode = BuildNode(child);
					_componentNodes[child] = innerNode;
					return innerNode;
				})
				.ToArray();

			_componentNodes[component] = children;
			return children;
		}
		else
		{

			var renderedComponent = component.RenderWithReset();
			var nodes = BuildNode(renderedComponent);
			_componentNodes[component] = nodes;
			return nodes;
		}
	}

	private IEnumerable<Component> FlattenFragment(Component component)
	{
		if (component is not Fragment fragment)
			return [component];

		return fragment
			.Children
			.OfType<Component>()
			.SelectMany(child =>
			{
				if (child is Fragment innerFragment)
					return FlattenFragment(innerFragment);
				return [child];
			});
	}

	private INode[] UpdateNode(Queue<INode> nodes, Component newlyRenderedComponent, INode parent)
	{
		if (newlyRenderedComponent is INodeComponent nodeComponent)
		{
			var node = nodes.Dequeue();
			if (node.GetType() != nodeComponent.NodeType)
			{
				var newNode = BuildNode(newlyRenderedComponent);
				if (newNode.Length != 1)
					throw new InvalidOperationException("Expected a single node");
				parent.ReplaceChild(node, newNode[0]);
				RequestCleanup(node);
				return newNode;
			}

			var nodeComponentChildren = nodeComponent
				.Children
				.OfType<Component>()
				.SelectMany(FlattenFragment)
				.ToList();
			int childCount = nodeComponentChildren.Count;
			int nodeChildCount = node.GetChildCount();

			// Remove extra nodes
			for (int i = nodeChildCount - 1; i >= childCount; i--)
			{
				var childNode = node.GetChild(i) ?? throw new InvalidOperationException("Child node is null");
				node.RemoveChild(childNode);
				RequestCleanup(childNode);
			}

			// Update existing or add new nodes
			for (int i = 0; i < childCount; i++)
			{
				var childComponent = nodeComponentChildren[i];

				if (i < nodeChildCount)
				{
					var queue = new Queue<INode>();
					queue.Enqueue(node.GetChild(i) ?? throw new InvalidOperationException("Child node is null"));
					queue = new Queue<INode>(queue.Concat(nodes));
					DiffAndUpdate(
						queue,
						null,
						childComponent,
						node
					);
				}
				else
				{
					if (_componentNodes.TryGetValue(childComponent, out var existingNodes))
						DiffAndUpdate(new Queue<INode>(existingNodes), null, childComponent, node);
					else
					{
						var newChildNode = BuildNode(childComponent);
						foreach (var newChild in newChildNode)
							node.AddChild(newChild);
					}
				}
			}

			node.Reset();
			nodeComponent.UpdateProperties(node);
			return [node];
		}
		else if (newlyRenderedComponent is Fragment fragment)
		{
			return fragment
				.Children
				.OfType<Component>()
				.Select(child => UpdateNode(nodes, child, parent))
				.SelectMany(x => x)
				.ToArray();
		}
		else
		{
			// Handle custom components
			var renderedComponent = newlyRenderedComponent.RenderWithReset();
			return UpdateNode(nodes, renderedComponent, parent);
		}
	}
}
