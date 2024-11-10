namespace ReactiveSharp.Dom.Tests;

using System;
using ReactiveSharp;
using ReactiveSharp.Dom;

internal class FragmentedP : Component
{
	public override Component Render() => new Fragment
	{
		new P { Text = "Hello, other world!" }
	};
}

internal class FragmentComponentTest : Component, ITestRunWithActionAfter<FragmentComponentTest>
{
	State<string>? Text;

	public void ChangeText()
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

	public static string Expected => "<div><p>Hello, other world!<p>Hello, other world!</p></p><button>Click me!</button></div>";

	public static Action<FragmentComponentTest>? ActionAfter { get { return component => component.ChangeText(); } }
}
