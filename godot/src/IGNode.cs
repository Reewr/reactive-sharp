namespace ReactiveSharpGodot;

public interface IGNode : ReactiveSharp.INode
{
	public Godot.Node Node { get; }

	void ReactiveSharp.INode.AddChild(ReactiveSharp.INode child)
	{
		if (child is not IGNode ch) throw new Exception("Child must be a GodotNode");
		Node.AddChild(ch.Node);
	}

	ReactiveSharp.INode? ReactiveSharp.INode.GetChild(int index) => Node.GetChildOrNull<ReactiveSharp.INode>(index);

	int ReactiveSharp.INode.GetChildCount() => Node.GetChildCount();

	ReactiveSharp.INode? ReactiveSharp.INode.GetParentNode() => Node.GetParent<IGNode>();

	void ReactiveSharp.INode.Remove() => Node.GetParent<Godot.Node>()?.RemoveChild(Node);

	void ReactiveSharp.INode.ReplaceChild(ReactiveSharp.INode oldChild, ReactiveSharp.INode newChild)
	{
		if (oldChild is not IGNode old) throw new Exception("Old child must be a GodotNode");
		if (newChild is not IGNode newC) throw new Exception("New child must be a GodotNode");
		old.Node.ReplaceBy(newC.Node);
	}

	void ReactiveSharp.INode.RemoveChild(ReactiveSharp.INode child)
	{
		if (child is not IGNode ch) throw new Exception("Child must be a GodotNode");
		Node.RemoveChild(ch.Node);
	}

	void ReactiveSharp.INode.Reset()
	{
		NodeStateManager.Reset(this);
	}
}
