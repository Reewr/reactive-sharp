namespace ReactiveSharp;

using System;
using System.Collections.Generic;

public interface INodeComponent
{
	public List<Component?> Children { get; }
	public INode Build(List<INode> builtChildren);
	public void UpdateProperties(INode node);
	public Type NodeType { get; }
}


public abstract class NodeComponent<T> : Component, INodeComponent where T : INode
{
	public abstract T Build(List<INode> builtChildren);
	public abstract void UpdateProperties(T node);
	sealed override public Component Render() =>
		throw new InvalidOperationException("NodeComponents cannot be rendered.");

	public Type NodeType => typeof(T);
	void INodeComponent.UpdateProperties(INode node) => UpdateProperties((T)node);
	INode INodeComponent.Build(List<INode> builtChildren) => Build(builtChildren);
}
