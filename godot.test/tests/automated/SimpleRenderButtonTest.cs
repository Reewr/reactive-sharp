namespace ReactiveSharpGodotTest;

using Chickensoft.GoDotTest;
using Shouldly;

class SimpleComponent() : ReactiveSharp.Component
{
	public ReactiveSharp.State<bool>? WasClicked;
	public override ReactiveSharp.Component Render()
	{
		WasClicked = UseState(false);
		return new ReactiveSharpGodot.Components.Button()
		{
			Pressed = () =>
			{
				WasClicked.SetValue(true);
			}
		};
	}
}

public class SimpleRenderButtonTest(Godot.Node testScene) : RenderTestClass(testScene)
{
	[Test]
	public void ShouldRenderButton()
	{
		Render(new SimpleComponent());

		ToTreeString().ShouldBeEquivalentTo(
			"""
			Button
			"""
		);
	}

	[Test]
	public void ShouldAttachHandler()
	{
		var component = new SimpleComponent();
		Render(component);

		var button = GetFirstOf<Godot.Button>();
		button.ShouldNotBeNull();
		button.EmitSignal(Godot.BaseButton.SignalName.Pressed);

		Rerender();

		component.WasClicked.ShouldNotBeNull();
		component.WasClicked.Value.ShouldBeEquivalentTo(true);
	}
}
