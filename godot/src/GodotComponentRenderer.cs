using ReactiveSharp;
using ReactiveSharpGodot.Nodes;

namespace ReactiveSharpGodot;

public class GodotComponentRenderer : GControl
{
	private readonly Renderer renderer;

	public GodotComponentRenderer()
	{
		renderer = new Renderer(this);
	}

	public override void _Process(double delta)
	{
		renderer.RenderRequested();
	}

	public void Render(Component component) => renderer.Render(component);
}
