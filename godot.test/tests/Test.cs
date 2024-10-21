namespace ReactiveSharpGodotTest;

public partial class Test : ReactiveSharpGodot.Renderer
{
	public override void _Ready()
	{
		base._Ready();
		Render(new MyComponent());
	}
}
