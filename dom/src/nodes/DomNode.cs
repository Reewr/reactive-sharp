namespace ReactiveSharp.Dom;

using System.Text;
using ReactiveSharp;

abstract public class DomNode : ReactiveSharp.INode
{
	private readonly List<DomNode> nodes = [];
	public INode? ParentNode { get; set; }

	public void AddChild(INode child)
	{
		if (child is not DomNode ch) throw new Exception("Child must be a DomNode");
		nodes.Add(ch);
		ch.ParentNode = this;
	}

	public void Dispose()
	{
		Console.Write("Disposed");
	}

	public INode? GetChild(int index) => nodes.Count > index && index >= 0 ? nodes[index] : null;

	public int GetChildCount() => nodes.Count;

	public INode? GetParentNode() => ParentNode;

	public void Remove() => ParentNode?.RemoveChild(this);

	public void RemoveChild(INode child)
	{
		if (child is not DomNode ch) throw new Exception("Child must be a DomNode");
		nodes.Remove(ch);
	}

	public abstract string Name();
	public virtual string Content() => "";
	public virtual string Attributes() => "";

	public virtual string ToTree()
	{
		var tree = new StringBuilder();
		tree.Append($"<{Name()}");

		var attributes = Attributes();
		if (attributes.Length > 0) tree.Append($" {attributes}");

		tree.Append($">{Content()}");
		foreach (var node in nodes) tree.Append(node.ToTree());
		tree.Append($"</{Name()}>");
		return tree.ToString();
	}

	public void Reset() { }
}
