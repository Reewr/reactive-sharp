namespace ReactiveSharp;

using System;
using System.Collections.Generic;
using System.Linq;

public partial class Renderer
{
	private readonly INode _rootNode;
	private readonly Dictionary<Component, INode> _componentNodes = new();
	private readonly HashSet<Component> _dirtyComponents = new();
	internal static Renderer? CurrentRenderer;

	public Renderer(INode rootNode)
	{
		_rootNode = rootNode;
		CurrentRenderer = this;
	}

	public void RequestRender(Component dirtyComponent) =>
		_dirtyComponents.Add(dirtyComponent);

	public void RenderRequested()
	{
		if (_dirtyComponents.Count > 0)
		{
			foreach (var dirtyComponent in _dirtyComponents)
			{
				Render(dirtyComponent);
			}

			_dirtyComponents.Clear();
		}

	}

	public void Render(Component component)
	{
		var renderedComponent = component.RenderWithReset();
		if (_componentNodes.TryGetValue(component, out var node))
		{
			UpdateNode(node, renderedComponent);
		}
		else
		{
			node = BuildNode(renderedComponent);
			_rootNode.AddChild(node);
			_componentNodes[component] = node;
		}
	}

	private void DiffAndUpdate(INode node, Component? oldComponent, Component? newComponent)
	{
		if (newComponent == null)
		{
			if (oldComponent != null)
			{
				node.Remove();
				node.GetParentNode()?.RemoveChild(node);
				node.Dispose();
			}
			return;
		}

		// Update node properties
		UpdateNode(node, newComponent);
	}

	private INode BuildNode(Component component)
	{
		INode node;
		if (component is INodeComponent nodeComponent)
		{
			var children = nodeComponent.Children
				.Select(child =>
				{
					var innerNode = BuildNode(child);
					_componentNodes[child] = innerNode;
					return innerNode;
				})
				.ToList();

			node = nodeComponent.Build(children);
		}
		else
		{
			var renderedComponent = component.RenderWithReset();
			node = BuildNode(renderedComponent);
		}

		return node;
	}

	private void UpdateNode(INode node, Component newlyRenderedComponent)
	{
		if (newlyRenderedComponent is INodeComponent nodeComponent)
		{
			if (node.GetType() != nodeComponent.NodeType)
			{
				var newNode = BuildNode(newlyRenderedComponent);
				_componentNodes[newlyRenderedComponent] = newNode;
				node.GetParentNode()?.AddChild(newNode);
				node.GetParentNode()?.RemoveChild(node);
				node.Dispose();
				return;
			}

			int childCount = nodeComponent.Children.Count();
			int nodeChildCount = node.GetChildCount();

			// Remove extra nodes
			for (int i = nodeChildCount - 1; i >= childCount; i--)
			{
				var childNode = node.GetChild(i) ?? throw new InvalidOperationException("Child node is null");
				node.RemoveChild(childNode);
				childNode.Dispose();
			}

			// Update existing or add new nodes
			for (int i = 0; i < childCount; i++)
			{
				var childComponent = nodeComponent.Children[i];

				if (i < nodeChildCount)
				{
					DiffAndUpdate(
						node.GetChild(i) ?? throw new InvalidOperationException("Child node is null"),
						null,
						childComponent
					);
				}
				else
				{
					_componentNodes.TryGetValue(childComponent, out var existingNode);
					if (existingNode is not null)
						DiffAndUpdate(existingNode, null, childComponent);
					else
					{
						var newChildNode = BuildNode(childComponent);
						node.AddChild(newChildNode);
					}
				}
			}

			node.Reset();
			nodeComponent.UpdateProperties(node);
		}
		else
		{
			// Handle custom components
			var renderedComponent = newlyRenderedComponent.RenderWithReset();
			UpdateNode(node, renderedComponent);
		}
	}
}
