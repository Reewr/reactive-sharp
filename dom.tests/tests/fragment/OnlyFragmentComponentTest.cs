namespace ReactiveSharp.Dom.Tests;

using ReactiveSharp;

class FragmentOnly : Component
{
	public override Component Render()
	{
		return new Fragment() { };
	}
}

internal class OnlyFragmentComponentTest : Component, ITestRun<OnlyFragmentComponentTest>
{
	public override Component Render()
	{
		return new Fragment() { new FragmentOnly() };
	}

	public static string Expected => "";
}
