namespace ReactiveSharpGodot;

public partial class Renderer : Godot.Control
{

	protected ReactiveSharp.Renderer ComponentRenderer;
	protected Nodes.GControl RendererNode = new();
	private static int instanceCount = 0;

	protected Renderer()
	{
		instanceCount++;
		ComponentRenderer = new ReactiveSharp.Renderer(RendererNode);
		RendererNode.Name = $"RenderRoot{instanceCount}";
	}

	public override void _EnterTree()
	{
		AddChild(RendererNode);
	}

	public override void _Process(double delta)
	{
		ComponentRenderer.RenderRequested();
	}

	public void Render(ReactiveSharp.Component component) => ComponentRenderer.Render(component);
}
