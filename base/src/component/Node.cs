using System.Collections.Generic;
using System.Linq;

namespace ReactiveSharp;

public interface INode
{
	/// <summary>
	/// This is expected to remove the current node from whatever three
	/// structure it is in. It should not dispose of the node, but rather
	/// just remove it from the tree.
	///
	/// In Dom terms, this would be like calling either `node.remove()` or `node.parentNode.removeChild(node)`.
	/// </summary>
	void Remove();

	/// <summary>
	/// This is expected to dispose of the node and all of its children.
	/// If your tree structure is garbage collected, then this does not
	/// need to do anything.
	/// </summary>
	void Dispose();

	/// <summary>
	/// Returns the parent node
	///
	/// In DOM terms, this would be like calling `node.parentNode`.
	/// </summary>
	INode? GetParentNode();

	/// <summary>
	/// Returns the number of children this node has.
	/// </summary>
	/// <returns></returns>
	int GetChildCount();

	List<INode> GetChildren()
	{
		return Enumerable
			.Range(0, GetChildCount())
			.Select(GetChild)
			.OfType<INode>()
			.ToList();
	}

	/// <summary>
	/// Returns the child at the given index, if it exists.
	/// </summary>
	/// <param name="index"></param>
	/// <returns></returns>
	INode? GetChild(int index);

	/// <summary>
	/// Replaces the old child with the new child. This function should
	/// make sure that they keep the same order in the list of children.
	/// </summary>
	void ReplaceChild(INode oldChild, INode newChild);

	/// <summary>
	/// Inserts the given node at index
	/// </summary>
	/// <param name="index"></param>
	/// <param name="node"></param>
	void Insert(int index, INode node);

	/// <summary>
	/// Removes the given child from the list of children.
	/// </summary>
	/// <param name="child"></param>
	void RemoveChild(INode child);

	/// <summary>
	/// Adds the given child to the list of children.
	/// </summary>
	/// <param name="child"></param>
	void AddChild(INode child);

	/// <summary>
	/// Resets the node to its default state.
	/// </summary>
	void Reset();
}
