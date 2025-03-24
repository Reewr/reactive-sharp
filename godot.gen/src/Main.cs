using Microsoft.CodeAnalysis;
using ReactiveSharpGodot.Gen;

public class GodotNodeGeneration
{
	private static readonly string AUTO_GENERATED_COMMENT = "// This file is auto-generated. Please do not edit";
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
			.Where(t => t.IsClass)
			.Where(t => t.Namespace == targetNamespace)
			.Where(t => commonBaseType.IsAssignableFrom(t))
			.Where(t => !IsIgnored(t))
			.Append(typeof(Godot.Control));

		var nodes = derivedTypes
			.Select(NodeGenerator.GenerateGodotNode)
			.Select(cls => (cls.Identifier.Text, CodeGenerator.ToCode([cls], "ReactiveSharpGodot.Nodes")))
			.ToArray();

		var components = derivedTypes
			.Select(ComponentGenerator.GenerateComponent)
			.Select(cls => (cls.Identifier.Text, CodeGenerator.ToCode([cls], "ReactiveSharpGodot.Components")))
			.ToArray();

		var nodesDir = "../godot/src/nodes";
		var componentsDir = "../godot/src/components";
		Directory.CreateDirectory(nodesDir);
		Directory.CreateDirectory(componentsDir);

		foreach (var (name, code) in nodes) File.WriteAllText($"{nodesDir}/{name}.cs", $"{AUTO_GENERATED_COMMENT}\n{code}");
		foreach (var (name, code) in components) File.WriteAllText($"{componentsDir}/{name}.cs", $"{AUTO_GENERATED_COMMENT}\n{code}");
	}
}
