namespace ReactiveSharp.Dom.Tests;

using System;
using ReactiveSharp;
using ReactiveSharp.Dom;
using Shouldly;

internal class Counter : Component
{
	public override Component Render()
	{
		var counter = UseState(0);
		return new Button { Title = $"Counter: {counter.Value}", OnClick = () => counter.Value++ };
	}
}

public class StateReleaseComponentTest : TestComponent
{
	public Action? ToggleRenderTwo { get; set; }

	public override Component Render()
	{
		var renderTwo = UseState(true);
		ToggleRenderTwo = () => renderTwo.SetValue(!renderTwo.Value);
		if (renderTwo.Value)
		{
			return new Div { new Counter(), new Counter(), };
		}

		return new Div { new Counter() };
	}

	[Fact(DisplayName = "State is properly reset when component is removed")]
	public void Test()
	{
		RenderToString(this).ShouldBeEquivalentTo("<div><button>Counter: 0</button><button>Counter: 0</button></div>");
		var buttons = CurrentDOM.SelectAll<ButtonNode>().ToList();
		var button1 = buttons[0];
		var button2 = buttons[1];
		button1.OnClick!();
		button1.OnClick();
		button2.OnClick!();
		RerenderToString().ShouldBeEquivalentTo("<div><button>Counter: 2</button><button>Counter: 1</button></div>");
		ToggleRenderTwo!();
		RerenderToString().ShouldBeEquivalentTo("<div><button>Counter: 2</button></div>");
		ToggleRenderTwo();
		RerenderToString().ShouldBeEquivalentTo("<div><button>Counter: 2</button><button>Counter: 0</button></div>");
	}
	// public static Action<StateReleaseComponentTest>? ActionAfter => test =>
	// {
	// 	var x = test.GetSetup().CurrentDOM;
	// 	var button = x.Select(typeof(ButtonNode)) as ButtonNode;
	// 	button!.OnClick!();
	// 	test.GetSetup().Renderer.RenderRequested();
	// 	test.Increment!();
	// 	test.GetSetup().Renderer.RenderRequested();
	// };
}
