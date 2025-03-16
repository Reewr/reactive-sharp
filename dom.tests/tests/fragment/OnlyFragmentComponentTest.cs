namespace ReactiveSharp.Dom.Tests;

using ReactiveSharp;
using Shouldly;

class FragmentOnly : Component
{
	public override Component Render()
	{
		return new Fragment() { };
	}
}

public class OnlyFragmentComponentTest : TestComponent
{
	public override Component Render()
	{
		return new Fragment() { new FragmentOnly() };
	}

	[Fact(DisplayName = "Fragments are not rendered")]
	public void Test1()
	{
		RenderToString(this).ShouldBeEquivalentTo("");
	}
}
