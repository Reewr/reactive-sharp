namespace ReactiveSharp.Dom.Tests;

using ReactiveSharp;
using ReactiveSharp.Dom;
using Shouldly;

internal class FragmentedP : Component
{
	public override Component Render() => new Fragment
	{
		new P { Text = "Hello, other world!" }
	};
}

public class FragmentComponentTest : TestComponent
{
	State<string>? Text;

	private void ChangeText()
	{
		Text!.Value = "Hello, other world!";
	}

	public override Component Render()
	{
		Text = UseState("Hello, world!");
		return new Div() {
			new Fragment() {
				new P {
					Text = Text.Value,
					Children = { new FragmentedP() }
				},
				new Button { Title = "Click me!" }
			}
		};
	}


	[Fact(DisplayName = "Fragments are handled as invisible containers")]
	public void Test1()
	{
		RenderToString(this).ShouldBeEquivalentTo("<div><p>Hello, world!<p>Hello, other world!</p></p><button>Click me!</button></div>");
		ChangeText();
		RerenderToString().ShouldBeEquivalentTo("<div><p>Hello, other world!<p>Hello, other world!</p></p><button>Click me!</button></div>");
	}
}
