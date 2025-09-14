using ReactiveSharp;
using ReactiveSharpGodot.Components;

namespace ReactiveSharpGodotTest;

public class Counter : Component
{
	public override Component Render()
	{
		var counter = UseState(0);
		return new VBoxContainer() {
			new Label() {
				Text = counter.Value == 0
					? "Click the button to increment the counter."
					: $"The counter is {counter.Value}."
			},
			new HSeparator(),
			counter.Value == 0
				? new Fragment()
				: counter.Value % 2 == 0
					? new Label() {
						Text = "The counter is even."
					}
					: new Label() {
						Text = "The counter is odd."
					},
			new Button() {
				Text = "Press me",
				Pressed = () => {
					Godot.GD.Print("Button pressed");
					counter.Value++;
				}
			},
		};
	}
}
