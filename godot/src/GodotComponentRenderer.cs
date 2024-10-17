using System.Diagnostics;
using Godot;
using ReactiveSharp;
using ReactiveSharpGodot.Nodes;

namespace ReactiveSharpGodot;

public partial class GodotComponentRenderer : Control
{
	private static int instanceCount = 0;
	private readonly Renderer renderer;
	private readonly GControl gControl = new();

	public GodotComponentRenderer()
	{
		GD.Print("GodotComponentRenderer constructor", System.Environment.StackTrace);
		instanceCount++;
		Name = $"GodotComponentRenderer{instanceCount}";
		renderer = new Renderer(gControl);
		gControl.Name = $"RenderRoot{instanceCount}";
	}

	public override void _EnterTree()
	{
		AddChild(gControl);
	}

	public override void _Process(double delta)
	{
		renderer.RenderRequested();
	}

	public void Render(Component component) => renderer.Render(component);
}
