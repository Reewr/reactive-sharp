namespace ReactiveSharpGodot;

public interface IGNode : ReactiveSharp.INode
{
	public Godot.Node Node { get; }
}

public interface IGNode<T> : IGNode where T : Godot.Node
{
	void ReactiveSharp.INode.AddChild(ReactiveSharp.INode child)
	{
		if (child is not IGNode ch) throw new Exception("Child must be a GodotNode");
		Node.AddChild(ch.Node);
	}

	ReactiveSharp.INode? ReactiveSharp.INode.GetChild(int index) => Node.GetChildOrNull<ReactiveSharp.INode>(index);

	int ReactiveSharp.INode.GetChildCount() => Node.GetChildCount();

	ReactiveSharp.INode? ReactiveSharp.INode.GetParentNode() => Node.GetParent<IGNode>();

	void ReactiveSharp.INode.Remove() => Node.GetParent<Godot.Node>()?.RemoveChild(Node);

	void ReactiveSharp.INode.RemoveChild(ReactiveSharp.INode child)
	{
		if (child is not IGNode ch) throw new Exception("Child must be a GodotNode");
		Node.RemoveChild(ch.Node);
	}

	void ReactiveSharp.INode.Reset()
	{
		PropertyInterceptorAttribute.Reset(this);
	}

	Type ReactiveSharp.INode.GetNodeType() => typeof(T);
}
