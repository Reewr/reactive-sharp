namespace ReactiveSharp.Dom.Tests;

using System;
using ReactiveSharp;
using ReactiveSharp.Dom;

class MyTheme
{
	public string Color { get; set; } = "red";
}

internal class MyContext(MyTheme value) : ContextProvider<MyTheme>(value) { }

internal class MyComponentUsingContext : Component
{
	public override Component Render()
	{
		var theme = UseContext<MyContext, MyTheme>();
		return new Div { new P { Text = $"Hello, the world is {theme.Color}" } };
	}
}

internal class SimpleContextComponentTest : Component, ITestRunWithActionAfter<SimpleContextComponentTest>
{
	public Action? ChangeColor { get; set; }

	public override Component Render()
	{
		var color = UseState("red");
		ChangeColor = () => color.SetValue("blue");
		return new MyContext(new MyTheme { Color = color.Value })
		{
			new MyComponentUsingContext()
		};
	}

	public static string Expected => "<div><p>Hello, the world is blue</p></div>";

	public static Action<SimpleContextComponentTest>? ActionAfter => (SimpleContextComponentTest test) =>
	{
		test.ChangeColor!.Invoke();
	};
}
