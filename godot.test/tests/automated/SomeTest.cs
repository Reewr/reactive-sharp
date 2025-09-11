namespace ReactiveSharpGodotTest;

using Chickensoft.GoDotTest;
using Shouldly;

public class SomeTest(Godot.Node testScene) : TestClass(testScene)
{
	[Test]
	public static void Test()
	{
		1.ShouldBeEquivalentTo(1);
	}
}
