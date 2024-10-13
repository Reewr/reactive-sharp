namespace ReactiveSharpGodotTest;

using Godot;

public partial class Test : Control
{
	private ReactiveSharpGodot.GodotComponentRenderer renderer = new();

	public override void _EnterTree()
	{
		AddChild(renderer);
		renderer.Render(new MyComponent());
	}
}
