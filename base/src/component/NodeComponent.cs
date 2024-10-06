namespace ReactiveSharp;

using System;
using System.Collections.Generic;

public interface INodeComponent
{
	public List<Component> Children { get; }
	public Node Build(List<Node> builtChildren);
	public void UpdateProperties(Node node);
	public Type NodeType { get; }
}


public abstract class NodeComponent<T> : Component, INodeComponent where T : Node
{
	public abstract T Build(List<Node> builtChildren);
	public abstract void UpdateProperties(T node);
	sealed override public Component Render() =>
		throw new InvalidOperationException("NodeComponents cannot be rendered.");

	public Type NodeType => typeof(T);
	void INodeComponent.UpdateProperties(Node node) => UpdateProperties((T)node);
	Node INodeComponent.Build(List<Node> builtChildren) => Build(builtChildren);
}
