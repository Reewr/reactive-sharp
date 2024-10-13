namespace ReactiveSharpGodot;

public interface IGNode : ReactiveSharp.Node
{
	public Godot.Node Node { get; }

	void ReactiveSharp.Node.AddChild(ReactiveSharp.Node child)
	{
		if (child is not IGNode ch) throw new Exception("Child must be a GodotNode");
		Node.AddChild(ch.Node);
	}

	ReactiveSharp.Node? ReactiveSharp.Node.GetChild(int index) => Node.GetChildOrNull<IGNode>(index);

	int ReactiveSharp.Node.GetChildCount() => Node.GetChildCount();

	ReactiveSharp.Node? ReactiveSharp.Node.GetParentNode() => Node.GetParent<IGNode>();

	void ReactiveSharp.Node.Remove() => Node.GetParent<Godot.Node>()?.RemoveChild(Node);

	void ReactiveSharp.Node.RemoveChild(ReactiveSharp.Node child)
	{
		if (child is not IGNode ch) throw new Exception("Child must be a GodotNode");
		Node.RemoveChild(ch.Node);
	}

	void ReactiveSharp.Node.Reset()
	{
		PropertyInterceptorAttribute.Reset(this);
	}
}
