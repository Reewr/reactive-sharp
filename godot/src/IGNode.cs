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

	ReactiveSharp.INode? ReactiveSharp.INode.GetParentNode()
	{
		var parent = Node.GetParent<IGNode>();
		return parent is not null && Godot.GodotObject.IsInstanceValid(parent.Node) ? parent : null;
	}

	void ReactiveSharp.INode.Remove() => Node.GetParent<Godot.Node>()?.RemoveChild(Node);

	void ReactiveSharp.INode.ReplaceChild(ReactiveSharp.INode oldChild, ReactiveSharp.INode newChild)
	{
		if (oldChild is not IGNode old) throw new Exception("Old child must be a GodotNode");
		if (newChild is not IGNode newC) throw new Exception("New child must be a GodotNode");

		foreach (var child in old.Node.GetChildren())
		{
			old.Node.RemoveChild(child);
			child.Free();
		}

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

	void ReactiveSharp.INode.Dispose()
	{
		Node.Free();
	}

	bool ReactiveSharp.INode.IsDisposed() => !Godot.GodotObject.IsInstanceValid(Node);

	void ReactiveSharp.INode.Insert(int i, ReactiveSharp.INode node)
	{
		if (node is not IGNode n) throw new Exception("after must be a GodotNode");
		if (i < 0) throw new IndexOutOfRangeException("negative not allowed");

		var count = Node.GetChildCount();
		if (i != 0 && i >= count) throw new IndexOutOfRangeException();

		// cases were we can simply add at the end
		if ((i == 0 && count == 0) || (i == count))
		{
			Node.AddChild(n.Node);
			return;
		}

		// cases were we can add after a node
		if (i != 0 && i < count)
		{
			var after = Node.GetChild(i - 1);
			after.AddSibling(n.Node);
			return;
		}

		// last case, really, where i == 0, but count is not.
		// since AddSibiling always add after a node and there's no insert
		// before, we need to move the child
		Node.AddChild(n.Node);
		Node.MoveChild(n.Node, i);
	}
}
