namespace ReactiveSharp.Dom.Tests;

using ReactiveSharp;
using ReactiveSharp.Dom;

internal class SimpleComponentTest : Component, ITestRun<SimpleComponentTest>
{
	public override Component Render() => new Div
	{
		new P { Text = "Hello, world!" },
		new Button { Title = "Click me!" }
	};

	public static string Expected => "<div><p>Hello, world!</p><button>Click me!</button></div>";
}
