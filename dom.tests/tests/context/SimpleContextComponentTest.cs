namespace ReactiveSharp.Dom.Tests;

using System;
using ReactiveSharp;
using ReactiveSharp.Dom;
using Shouldly;

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

public class SimpleContextComponentTest : TestComponent
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

	[Fact(DisplayName = "Context should apply correctly")]
	public void Test1()
	{
		RenderToString(this).ShouldBeEquivalentTo("<div><p>Hello, the world is red</p></div>");
		ChangeColor!.Invoke();
		RenderToString(this).ShouldBeEquivalentTo("<div><p>Hello, the world is blue</p></div>");
	}
}
