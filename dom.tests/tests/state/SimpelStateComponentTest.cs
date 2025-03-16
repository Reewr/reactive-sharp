namespace ReactiveSharp.Dom.Tests;

using System;
using ReactiveSharp;
using ReactiveSharp.Dom;
using Shouldly;

public class SimpleStateComponentTest : TestComponent
{
	private Action? IncrementCounter { get; set; }

	public override Component Render()
	{
		var counter = UseState(0);
		IncrementCounter = () => counter.Value++;
		return new Div
		{
			new P { Text = $"Counter: {counter.Value}" },
		};
	}

	[Fact(DisplayName = "Shows correct state after incrementing")]
	public void Test1()
	{
		Renderer.Render(this);
		IncrementCounter!.Invoke();
		IncrementCounter!.Invoke();
		RerenderToString().ShouldBeEquivalentTo("<div><p>Counter: 2</p></div>");
	}
}
