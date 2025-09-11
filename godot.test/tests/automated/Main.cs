namespace ReactiveSharpGodotTest;

using Godot;
using System.Reflection;
using Chickensoft.GoDotTest;

public partial class Main : Node2D
{
	public TestEnvironment Environment = default!;

	public override void _Ready()
	{
		// If this is a debug build, use GoDotTest to examine the
		// command line arguments and determine if we should run tests.
		Environment = TestEnvironment.From(OS.GetCmdlineArgs());
		if (Environment.ShouldRunTests)
		{
			CallDeferred("RunTests");
			return;
		}
	}

	private void RunTests()
	  => _ = GoTest.RunTests(Assembly.GetExecutingAssembly(), this, Environment);
}
