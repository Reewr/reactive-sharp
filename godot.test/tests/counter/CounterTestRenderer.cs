using ReactiveSharp;
using ReactiveSharpGodot.Components;

namespace ReactiveSharpGodotTest;

public partial class CounterTestRenderer : ReactiveSharpGodot.Renderer
{
	public override void _Ready()
	{
		base._Ready();
		Render(new CenterContainer()
		{
			new Counter()
		});
	}
}

public class CenterContainer : Component
{
	public override Component Render()
	{
		return new VBoxContainer()
		{
			LayoutMode = 1,
			AnchorsPreset = (int)Godot.Control.LayoutPreset.Center,
			Children = Children
		};
	}
}
