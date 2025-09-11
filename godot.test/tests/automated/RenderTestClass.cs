namespace ReactiveSharpGodotTest;

using System.Text.RegularExpressions;
using Chickensoft.GoDotTest;

public partial class TestRenderer : ReactiveSharpGodot.Renderer
{
	private Godot.Node TestScene;
	public TestRenderer(Godot.Node testScene)
	{
		TestScene = testScene;
		TestScene.AddChild(this);
	}
}
public abstract partial class RenderTestClass(Godot.Node testScene) : TestClass(testScene)
{
	protected TestRenderer renderer = new(testScene);

	[Setup]
	public void Setup()
	{
		renderer.Free();
		foreach (var node in TestScene.GetChildren())
			node.Free();
		renderer = new TestRenderer(TestScene);
	}

	protected string ToTreeString(bool replaceDigits = true, bool removeStartingDot = true, bool removeTrailingSpace = true)
	{
		var tree = renderer.GetTreeString();
		if (replaceDigits) tree = DigitRegex().Replace(tree, "{d}");
		if (removeStartingDot) tree = tree.Replace('.', ' ').TrimStart();
		if (removeTrailingSpace) tree = tree.TrimEnd();

		return tree;
	}

	protected void Render(ReactiveSharp.Component c) => renderer.Render(c);
	protected void Rerender() => renderer._Process(1);

	protected T? GetFirstOf<T>() where T : Godot.Node => GetAllOf<T>().First();
	protected IEnumerable<T> GetAllOf<T>() where T : Godot.Node => GetAllOf<T>(renderer);

	private IEnumerable<T> GetAllOf<T>(Godot.Node node) where T : Godot.Node
	{
		if (node is T t) yield return t;

		foreach (var child in node.GetChildren())
			foreach (var n in GetAllOf<T>(child))
				yield return n;
	}

	[GeneratedRegex("\\d+")]
	private static partial Regex DigitRegex();
}
