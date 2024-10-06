namespace ReactiveSharp.Dom;

public class Button : ReactiveSharp.NodeComponent<ButtonNode>
{
	public string Title { get; set; } = "";

	public override ButtonNode Build(List<ReactiveSharp.Node> builtChildren)
	{
		var button = new ButtonNode();
		UpdateProperties(button);
		foreach (var child in builtChildren) button.AddChild(child);
		return button;
	}

	public override void UpdateProperties(ButtonNode node)
	{
		node.Title = Title;
	}
}
