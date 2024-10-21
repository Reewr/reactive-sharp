namespace ReactiveSharp.Dom.Tests;

using System;
using ReactiveSharp;
using ReactiveSharp.Dom;

internal class NodeReplacementCompontentTest : Component, ITestRunWithActionAfter<NodeReplacementCompontentTest>
{
	private State<int>? counter;

	public void IncrementCounter()
	{
		if (counter is not null)
			counter.Value++;
	}

	public override Component Render()
	{
		counter = UseState(0);
		return new Div
		{
			new P {
				Text = counter.Value == 0
					? "Click the button to increment the counter"
					: $"The counter is {counter.Value}"
			},
			new Div { },
			counter.Value == 0
				? new Div { }
				: counter.Value % 2 == 0
					? new P { Text = "The counter is even." }
					: new P { Text = "The counter is odd." },
			new Button { Title = "Click me!" }
		};
	}

	public static string Expected => "<div><p>The counter is 1</p><div></div><p>The counter is odd.</p><button>Click me!</button></div>";

	public static Action<NodeReplacementCompontentTest>? ActionAfter => (component) =>
	{
		component.IncrementCounter();
	};
}
