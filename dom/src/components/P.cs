namespace ReactiveSharp.Dom;

public class P : ReactiveSharp.NodeComponent<PNode>
{
	public string Text { get; set; } = "";

	public override PNode Build(List<ReactiveSharp.Node> builtChildren)
	{
		var p = new PNode();
		UpdateProperties(p);
		foreach (var child in builtChildren) p.AddChild(child);
		return p;
	}

	public override void UpdateProperties(PNode node)
	{
		node.Text = Text;
	}
}
