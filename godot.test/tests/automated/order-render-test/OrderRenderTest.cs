namespace ReactiveSharpGodotTest;

using Chickensoft.GoDotTest;
using ReactiveSharp;
using ReactiveSharpGodot.Components;
using Shouldly;

class SimpleStateComponent : Component
{
	public State<int>? TestState;
	public required string Text { get; init; }
	public override Component Render()
	{
		TestState = UseState(0);
		return new Label { Text = Text + " - " + TestState.Value };
	}
}

public class OrderRenderTest(Godot.Node testScene) : RenderTestClass(testScene)
{
	[Test]
	public void ShouldNotReorderOnRerender()
	{
		var expected =
			"""
			HBoxContainer-0
			  Label-1
			  Button-2
			""";

		var x = new SimpleStateComponent() { Text = "Text" };
		Render(new HBoxContainer() { x, new Button() });

		ToTreeString(removeDigits: false).ShouldBeEquivalentTo(expected);

		// Trigger a state change and then re-render
		x.TestState!.SetValue(1);
		Rerender();

		ToTreeString(removeDigits: false).ShouldBeEquivalentTo(expected);
	}
}
