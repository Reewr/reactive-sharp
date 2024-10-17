namespace ReactiveSharp.Dom;

public class PNode : DomNode<PNode>
{
	public override string Name() => "p";
	public override string Content() => Text;
	public string Text { get; set; } = "";
}
