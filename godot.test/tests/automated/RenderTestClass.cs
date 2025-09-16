namespace ReactiveSharpGodotTest;

using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using Chickensoft.GoDotTest;
using Godot;

public partial class TestRenderer : ReactiveSharpGodot.Renderer
{
	private Node TestScene;
	public TestRenderer(Node testScene)
	{
		TestScene = testScene;
		TestScene.AddChild(this);
	}
}
public abstract partial class RenderTestClass(Node testScene) : TestClass(testScene)
{
	protected TestRenderer? renderer;

	[Setup]
	public void Setup()
	{
		// Setup the renderer so that we can start the tests, making sure that there's
		// nothing already existing within the test scene.
		renderer?.Free();
		foreach (var node in TestScene.GetChildren())
			node.Free();
		renderer = new TestRenderer(TestScene);

		// The running engine has a counter that is incremented for
		// every single node creation.  This integer is used to make the
		// names of the nodes unique. Sadly, it does not reset until you
		// restart the engine.
		//
		// In order to have consistent names across test runs, we need to
		// set the names of the created nodes ourselves with a number
		// that we control
		int i = 0;
		TestScene.GetTree().NodeAdded += (node) =>
		{
			node.Name = DigitRegex().Replace(node.Name, (d) => i++.ToString());
		};
	}

	/// <summary>
	/// Uses `Godot.Node.GetTreeString()` to create a tree of the
	/// currently rendered items.
	/// All items will have name similar to `Button@<number>` where the number indicates
	/// the count of rendered items. Keep in mind that this number may start higher
	/// than expected as it is a count by Godot of how many Godot elements have been
	/// created
	/// </summary>
	/// <param name="removeDigits">Default true, removes the digit</param>
	/// <returns></returns>
	protected string ToTreeString(bool removeDigits = true)
	{
		// the initial format of GetTreeString is something like:
		// @RenderRoot-1
		// @RenderRoot-1/@Button@2
		// @RenderRoot-1/@Label@3
		// @RenderRoot-1/@Box@4
		// @RenderRoot-1/@Box@4/@Label@5
		//
		// We want to simplify this to (removeDigits = true)
		//
		// Button
		// Label
		// Box
		//     Label


		var tree = renderer!.GetTreeString();
		tree = RenderRootRegex().Replace(tree, "");
		tree = tree.Replace('.', ' ').TrimStart();
		tree = AtRegex().Replace(tree, "$2");
		tree = tree.Replace("@", "-");
		if (removeDigits) tree = DigitRegex().Replace(tree, "").Replace("-", "");
		tree = tree.TrimEnd();

		return tree;
	}

	protected void Render(ReactiveSharp.Component c) => renderer!.Render(c);
	protected void Rerender() => renderer!._Process(1);

	protected T? GetFirstOf<T>() where T : Godot.Node => GetAllOf<T>().First();
	protected IEnumerable<T> GetAllOf<T>() where T : Godot.Node => GetAllOf<T>(renderer!);

	private IEnumerable<T> GetAllOf<T>(Godot.Node node) where T : Godot.Node
	{
		if (node is T t) yield return t;

		foreach (var child in node.GetChildren())
			foreach (var n in GetAllOf<T>(child))
				yield return n;
	}

	[GeneratedRegex("@\\d+")]
	private static partial Regex DigitRegex();
	[GeneratedRegex("RenderRoot-\\d+/*")]
	private static partial Regex RenderRootRegex();
	[GeneratedRegex("(@)([a-zA-Z]+)")]
	private static partial Regex AtRegex();
}
