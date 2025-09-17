namespace ReactiveSharpGodotTest;

using Chickensoft.GoDotTest;
using ReactiveSharp;
using ReactiveSharpGodot.Components;
using Shouldly;

public class FragmentRenderTest(Godot.Node testScene) : RenderTestClass(testScene)
{
	[Test]
	public void ShouldRenderButton()
	{
		Render(new Fragment() { new Button() });

		ToTreeString().ShouldBeEquivalentTo(
			"""
			Button
			"""
		);
	}
}
