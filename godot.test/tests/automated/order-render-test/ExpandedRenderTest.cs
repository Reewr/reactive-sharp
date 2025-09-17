namespace ReactiveSharpGodotTest;

using Chickensoft.GoDotTest;
using ReactiveSharp;
using ReactiveSharpGodot.Components;
using Shouldly;

class MultiChildrenIfProperState : Component
{
	public State<bool>? render;
	public override Component Render()
	{
		render = UseState(false);
		return render.Value ? new Fragment() { new Button(), new Label() } : new BoxContainer();
	}
}

public class ExpandedRenderTest(Godot.Node testScene) : RenderTestClass(testScene)
{
	[Test]
	public void ShouldInsertNewItemsCorrectlyInBetween()
	{
		var x = new MultiChildrenIfProperState();
		Render(new HBoxContainer()
		{
			new Label(),
			x,
			new Label()
		});

		ToTreeString(removeDigits: false).ShouldBeEquivalentTo(
			"""
			HBoxContainer-0
			  Label-1
			  BoxContainer-2
			  Label-3
			"""
		);

		x.render!.Value = true;
		Rerender();

		ToTreeString(removeDigits: false).ShouldBeEquivalentTo(
			"""
			HBoxContainer-0
			  Label-1
			  Button-4
			  Label-5
			  Label-3
			"""
		);

		x.render!.Value = false;
		Rerender();

		ToTreeString(removeDigits: false).ShouldBeEquivalentTo(
			"""
			HBoxContainer-0
			  Label-1
			  BoxContainer-6
			  Label-3
			"""
		);
	}
}
