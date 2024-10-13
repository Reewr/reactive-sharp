using ReactiveSharp;
using ReactiveSharpGodot.Components;

namespace ReactiveSharpGodotTest;

public class MyComponent : Component
{
	public override Component Render()
	{
		return new VBoxContainer() {
			new Label() {
				Text = "Hello"
			},
			new VSeparator(),
			new Button() {
				Text = "Hello",
			},
		};
	}
}
