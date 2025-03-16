namespace ReactiveSharp.Dom;

public class ButtonNode : DomNode
{
	public override string Name() => "button";
	public override string Content() => Title;
	public string Title { get; set; } = "";
	public Action? OnClick { get; set; } = null;
}
