﻿namespace ReactiveSharp.Dom;

using System.Text;
using ReactiveSharp;

abstract public class DomNode : ReactiveSharp.INode
{
	private readonly List<DomNode> nodes = [];
	public INode? ParentNode { get; set; }

	public void AddChild(INode child)
	{
		if (child is not DomNode ch) throw new Exception("Child must be a DomNode");
		if (child == this) throw new Exception("Cannot attach to self");
		if (nodes.Contains(ch)) return;
		if (ParentNode == ch) throw new Exception("Cannot add recursive");
		nodes.Add(ch);
		ch.ParentNode = this;
	}

	public void Dispose()
	{
		Console.Write("Disposed");
	}

	public INode? GetChild(int index) => nodes.Count > index && index >= 0 ? nodes[index] : null;

	private IEnumerable<DomNode> GetAllNodes()
	{
		foreach (var node in nodes)
		{
			yield return node;
			foreach (var item in node.GetAllNodes())
				yield return item;
		}
	}

	public IEnumerable<T> SelectAll<T>() where T : DomNode => GetAllNodes().OfType<T>();
	public T? Select<T>() where T : DomNode => SelectAll<T>().FirstOrDefault();

	public int GetChildCount() => nodes.Count;

	public INode? GetParentNode() => ParentNode;

	public void Remove() => ParentNode?.RemoveChild(this);

	public void ReplaceChild(INode oldChild, INode newChild)
	{
		if (oldChild is not DomNode old) throw new Exception("Old child must be a DomNode");
		if (newChild is not DomNode newC) throw new Exception("New child must be a DomNode");
		var index = nodes.IndexOf(old);
		if (index == -1) throw new Exception("Old child not found");
		nodes[index] = newC;
	}

	public void RemoveChild(INode child)
	{
		if (child is not DomNode ch) throw new Exception("Child must be a DomNode");
		nodes.Remove(ch);
		ch.ParentNode = null;
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
