namespace ReactiveSharp.Dom;

public class Div : ReactiveSharp.NodeComponent<DivNode>
{
	public override DivNode Build(List<ReactiveSharp.INode> builtChildren)
	{
		var div = new DivNode();
		foreach (var child in builtChildren) div.AddChild(child);
		return div;
	}

	public override void UpdateProperties(DivNode node)
	{
	}
}
