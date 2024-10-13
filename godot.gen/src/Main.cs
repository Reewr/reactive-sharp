using Microsoft.CodeAnalysis;
using ReactiveSharpGodot.Gen;

public class GodotNodeGeneration
{
	private static bool IsIgnored(Type type) =>
		type == typeof(Godot.Slider) ||
		type == typeof(Godot.ScrollBar) ||
		type == typeof(Godot.Separator);

	public static void Main()
	{
		string targetNamespace = "Godot";
		Type commonBaseType = typeof(Godot.Control);
		var assemblies = AppDomain.CurrentDomain.GetAssemblies();
		var derivedTypes = assemblies
						   .SelectMany(assembly => assembly.GetTypes())
						   .Where(t => t.IsClass
									&& t.Namespace == targetNamespace
									&& commonBaseType.IsAssignableFrom(t)
									&& t != commonBaseType);

		var nodes = derivedTypes
			.Where(type => !IsIgnored(type))
			.Select(NodeGenerator.GenerateGodotNode)
			.Append(NodeGenerator.GetBaseControlNode())
			.Select(cls => (cls.Identifier.Text, CodeGenerator.ToCode([cls], "ReactiveSharpGodot.Nodes")))
			.ToArray();

		var components = derivedTypes
			.Select(ComponentGenerator.GenerateComponent)
			.Append(ComponentGenerator.GetBaseControlComponent())
			.Select(cls => (cls.Identifier.Text, CodeGenerator.ToCode([cls], "ReactiveSharpGodot.Components")))
			.ToArray();

		var nodesDir = "../godot/src/nodes";
		var componentsDir = "../godot/src/components";
		Directory.CreateDirectory(nodesDir);
		Directory.CreateDirectory(componentsDir);

		foreach (var (name, code) in nodes) File.WriteAllText($"{nodesDir}/{name}.cs", code);
		foreach (var (name, code) in components) File.WriteAllText($"{componentsDir}/{name}.cs", code);
	}
}
