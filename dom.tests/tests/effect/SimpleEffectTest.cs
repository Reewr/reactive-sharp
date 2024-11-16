namespace ReactiveSharp.Dom.Tests;

using ReactiveSharp;
using ReactiveSharp.Dom;

internal class SimpleEffectTest : Component, ITestRun<SimpleEffectTest>
{
	public override Component Render()
	{
		var orderOfCalls = UseState(new List<string>());
		var count = UseState(0);
		var notDependenent = UseState(0);
		UseEffect(
			() =>
			{
				// otherwise, it'll be an endless loop
				if (count.Value == 0) count.Value++;

				orderOfCalls.Value = [.. orderOfCalls.Value, "Effect"];
				notDependenent.Value++;
				return () =>
				{
					orderOfCalls.Value = [.. orderOfCalls.Value, "Cleanup"];

					// this will trigger re-renders, but it should not trigger the effect
					// as it does not depend on it
					notDependenent.Value++;
				};
			},
			[count]
		);

		return new Div {
			new P { Text = $"Count: {count.Value}" },
			new P { Text = $"Not dependent: {notDependenent.Value}" },
			orderOfCalls.Value.Select(order => new P { Text = $"Item: {order}" }).ToArray(),
		};
	}

	public static string Expected => string.Join("", [
		"<div>",
		"<p>Count: 1</p>",
		"<p>Not dependent: 3</p>",
		"<p>Item: Effect</p>",
		"<p>Item: Cleanup</p>",
		"<p>Item: Effect</p>",
		"</div>",
	]);
}
