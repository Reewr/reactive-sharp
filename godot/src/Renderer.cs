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
		Position = new Godot.Vector2(0, 0);
		MouseFilter = Godot.Control.MouseFilterEnum.Ignore;
		RendererNode.Name = $"RenderRoot{instanceCount}";
		RendererNode.Position = new Godot.Vector2(0, 0);
		RendererNode.MouseFilter = Godot.Control.MouseFilterEnum.Ignore;
	}

	public override void _Ready()
	{
		GetViewport().SizeChanged += OnViewportSizeChanged;
		OnViewportSizeChanged();
	}

	private void OnViewportSizeChanged()
	{
		RendererNode.Size = GetViewportRect().Size;
		Size = GetViewportRect().Size;
	}

	public override void _EnterTree()
	{
		AddChild(RendererNode);
		OnViewportSizeChanged();
	}

	public override void _Process(double delta)
	{
		ComponentRenderer.RenderRequested();
	}

	public void Render(ReactiveSharp.Component component) => ComponentRenderer.Render(component);
}
