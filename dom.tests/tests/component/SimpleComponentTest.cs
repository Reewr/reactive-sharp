namespace ReactiveSharp.Dom.Tests;

using ReactiveSharp;
using ReactiveSharp.Dom;
using Shouldly;

public class SimpleComponentTest : TestComponent
{
	public override Component Render() => new Div
	{
		new P { Text = "Hello, world!" },
		new Button { Title = "Click me!" }
	};

	[Fact(DisplayName = "Should render a simple component")]
	public void Test1()
	{
		RenderToString(this).ShouldBeEquivalentTo("<div><p>Hello, world!</p><button>Click me!</button></div>");
	}
}
