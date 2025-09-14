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

internal class BuiltNode
{
	public required Component Component { get; set; }
	public INode? Node { get; set; }
	public BuiltNode? Parent { get; set; }
	public BuiltNode[] Children { get; set; } = [];
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
	private readonly Dictionary<string, BuiltNode> _builtNodes = [];
	private readonly HashSet<Component> _dirtyComponents = [];
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
			EffectManager.RunAllEffects();
		}
	}

	public bool RenderingRequested()
	{
		return _dirtyComponents.Count > 0;
	}

	public void Render(Component component)
	{
		Render(component, true);
	}

	private void Render(Component component, bool triggerEffects = true)
	{
		Managers = new ThreadLocal<Managers>(() => new Managers(EffectManager, StateManager, this));
		if (_builtNodes.TryGetValue(component.Key, out var builtNode))
			builtNode = UpdateNode(builtNode);
		else
			builtNode = BuildNode(component);

		var firstNodes = FindFirstINodeDownwards(builtNode);
		var attachNode = FindFirstINodeUpwards(builtNode) ?? _rootNode;

		// it may be that the attachNode is the same as one of the nodes
		// in the first nodes. In that case, we need to use root node as
		// we can't attach a node to itself
		if (firstNodes.Contains(attachNode)) attachNode = _rootNode;

		foreach (var node in firstNodes)
			attachNode.AddChild(node);

		if (triggerEffects)
			EffectManager.RunAllEffects();
	}

	private BuiltNode UpdateNode(BuiltNode node)
	{
		var inodes = FindINodes(node).ToList();
		var newBuiltNode = BuildNode(node.Component, inodes);
		var newKeys = FindComponentKeys(newBuiltNode).ToList();
		var oldKeys = FindComponentKeys(node).ToList();
		foreach (var oldKey in oldKeys)
		{
			if (!newKeys.Contains(oldKey))
			{
				_builtNodes.GetValueOrDefault(oldKey)?.Component.ReleaseState();
				_builtNodes.Remove(oldKey);
			}
		}

		foreach (var inode in inodes)
		{
			inode.Remove();
			inode.Dispose();
		}

		newBuiltNode.Parent = node.Parent;
		return newBuiltNode;
	}

	private BuiltNode BuildNode(Component component) => BuildNode(component, []);
	private BuiltNode BuildNode(Component component, List<INode> existingINodes)
	{
		var builtNode = new BuiltNode() { Component = component };
		if (component is INodeComponent || component is Fragment)
		{
			var children = component.Children
				.OfType<Component>()
				.Select(child =>
				{
					var innerNode = BuildNode(child, existingINodes);
					innerNode.Parent = builtNode;
					return innerNode;
				})
				.ToArray();

			builtNode.Children = children;
			builtNode.Node = component is INodeComponent node
				? BuildINodeComponent(node, children, existingINodes)
				: null;
		}
		else
		{
			var renderedComponent = component.RenderWithReset();
			var node = BuildNode(renderedComponent, existingINodes);
			builtNode.Children = [node];
			node.Parent = builtNode;
		}

		_builtNodes[component.Key] = builtNode;
		return builtNode;

	}

	private static INode BuildINodeComponent(INodeComponent node, BuiltNode[] children, List<INode> inodes)
	{
		var found = inodes.Where(x => x.GetType() == node.NodeType).FirstOrDefault();
		if (found is not null)
		{
			found.Reset();
			foreach (var existingChild in found.GetChildren()) existingChild.Remove();

			found.Remove();
			inodes.Remove(found);
			foreach (var child in children)
			{
				foreach (var innerInode in FindFirstINodeDownwards(child))
					found.AddChild(innerInode);
			}

			node.UpdateProperties(found);
			return found;
		}

		return node.Build([.. children.SelectMany(FindFirstINodeDownwards).OfType<INode>()]);
	}

	private static INode[] FindFirstINodeDownwards(BuiltNode? builtNode)
	{
		if (builtNode is null) return [];
		if (builtNode.Node is not null) return [builtNode.Node];
		return [.. builtNode.Children.SelectMany(FindFirstINodeDownwards)];
	}

	private static INode? FindFirstINodeUpwards(BuiltNode? builtNode)
	{
		if (builtNode is null) return null;
		if (builtNode.Node is not null) return builtNode.Node;
		return FindFirstINodeUpwards(builtNode.Parent);
	}

	private static IEnumerable<INode> FindINodes(BuiltNode node)
	{
		if (node.Node is not null)
			yield return node.Node;

		foreach (var n in node.Children.SelectMany(FindINodes))
			yield return n;
	}

	private static IEnumerable<string> FindComponentKeys(BuiltNode node)
	{
		yield return node.Component.Key;
		foreach (var s in node.Children.SelectMany(FindComponentKeys))
			yield return s;
	}

}
