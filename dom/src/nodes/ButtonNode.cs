namespace ReactiveSharp.Dom;

public class ButtonNode : DomNode<ButtonNode>
{
	public override string Name() => "button";
	public override string Content() => Title;
	public string Title { get; set; } = "";
}
