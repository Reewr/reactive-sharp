namespace ReactiveSharp.Dom.Tests;

using System;
using ReactiveSharp;
using ReactiveSharp.Dom;

internal class SimpleStateComponentTest : Component, ITestRunWithActionAfter<SimpleStateComponentTest>
{
	public Action? IncrementCounter { get; set; }

	public override Component Render()
	{
		var counter = UseState(0);
		IncrementCounter = () => counter.Value++;
		return new Div
		{
			new P { Text = $"Counter: {counter.Value}" },
		};
	}

	public static string Expected => "<div><p>Counter: 1</p></div>";

	public static Action<SimpleStateComponentTest>? ActionAfter => (SimpleStateComponentTest test) =>
	{
		test.IncrementCounter!.Invoke();
	};
}
