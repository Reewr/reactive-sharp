namespace ReactiveSharpGodot.Gen;

using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

internal class ComponentGenerator : CodeGenerator
{
	private static string[] CreatePropertyAssignments(PropertyInfo[] properties)
	{
		var i = 0;
		return properties.Select(property =>
		{
			var name = property.Name;
			var t = GetFullQualifiedTypeName(property.PropertyType).Replace("+", ".").Replace(" ", "");
			var num = i++;
			return $"if ({name} is {t} n{num}) castedNode.{name} = n{num};";
		}).ToArray();
	}

	private static string CreatePropertyDefinitions(PropertyInfo[] properties) => string.Join("\n", properties.Select(property =>
	{
		var name = property.Name;
		var t = GetFullQualifiedTypeName(property.PropertyType).Replace("+", ".").Replace(" ", "");
		return $"public {t}? {name} {{ protected get; init; }}";
	}));

	private static string CreateUpdatePropertiesMethod(Type type, PropertyInfo[] properties, bool callBase = false) =>
		$"public override void UpdateProperties(ReactiveSharpGodot.IGNode node) {{" +
			$"var castedNode = (Godot.{type.Name})node.Node;" +
			(callBase ? "base.UpdateProperties(node);" : "") +
			string.Join("\n", CreatePropertyAssignments(properties)) +
			"\n" +
			string.Join("\n", CreateEventAssignments(type)) +
		"}";

	private static string CreateEventProperties(Type type)
	{
		var events = type.GetEvents(BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Instance);
		return string.Join("\n", events.Select(e =>
		{
			var name = e.Name;
			var handlerType = GetFullQualifiedTypeName(e.EventHandlerType!).Replace("+", ".").Replace(" ", "");
			return $"public {handlerType}? {name} {{ protected get; init; }}";
		}));
	}

	private static string CreateEventAssignments(Type type)
	{
		var i = 0;
		var events = type.GetEvents(BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Instance);
		return string.Join("\n", events.Select(e =>
		{
			var name = e.Name;
			var handlerType = GetFullQualifiedTypeName(e.EventHandlerType!).Replace("+", ".").Replace(" ", "");
			var num = i++;
			return $"if ({name} is {handlerType} e{num}) castedNode.{name} += e{num};";
		}));
	}

	public static ClassDeclarationSyntax GetBaseControlComponent()
	{
		var props = GetUniqueProperties(typeof(Godot.Control), includeInheritedProperties: true);
		return ParseClass(
		"public class Control : ReactiveSharp.NodeComponent<ReactiveSharpGodot.IGNode> " +
		"{ " +
		string.Join("\n", CreatePropertyDefinitions(props)) +
		"" +
		CreateEventProperties(typeof(Godot.Control)) +
		"" +
		"    protected ReactiveSharpGodot.IGNode DefaultBuild( " +
		"      ReactiveSharpGodot.IGNode node, " +
		"      List<ReactiveSharp.Node> builtChildren) " +
		"    { " +
		"        UpdateProperties(node); " +
		"        foreach (var child in builtChildren) node.AddChild(child); " +
		"        return node; " +
		"    } " +
		"    public override ReactiveSharpGodot.IGNode Build(List<ReactiveSharp.Node> builtChildren) => DefaultBuild(" +
		"      new ReactiveSharpGodot.Nodes.GControl(), builtChildren); " +
		"" +
		CreateUpdatePropertiesMethod(typeof(Godot.Control), props, callBase: false) +
		"}"
	);
	}

	public static ClassDeclarationSyntax GenerateComponent(Type type)
	{
		var inherited = type.BaseType ?? throw new Exception("Base type not found");
		var fullTypeName = type.FullName!.Replace("+", ".").Replace(" ", "");
		var inheritedFullTypeName = inherited.FullName!.Replace("+", ".").Replace(" ", "");
		var godotNodeName = "ReactiveSharpGodot.Nodes.G" + type.Name;
		var isAbstract = false;

		if (type == typeof(Godot.Slider))
			isAbstract = true;
		else if (type == typeof(Godot.ScrollBar))
			isAbstract = true;
		else if (type == typeof(Godot.Separator))
			isAbstract = true;


		// Retrieve properties unique to X
		var igNode = "ReactiveSharpGodot.IGNode";
		PropertyInfo[] uniqueProperties = GetUniqueProperties(type);
		List<string> code = [
			$"public {(isAbstract ? "abstract " : "")} class {type.Name} : {inherited.Name} {{",
		];

		code.Add(CreatePropertyDefinitions(uniqueProperties));
		code.Add("\n");
		code.Add(string.Join("\n", CreateEventProperties(type)));

		if (!isAbstract)
		{
			code.AddRange([
				$"public override {igNode} Build(",
					"System.Collections.Generic.List<ReactiveSharp.Node> builtChildren",
				$") => DefaultBuild(new {godotNodeName}(), builtChildren);",
			]);
		}

		if (uniqueProperties.Length != 0)
			code.Add(CreateUpdatePropertiesMethod(type, uniqueProperties, callBase: true));

		return ParseClass(code.Aggregate((a, b) => a + "\n" + b) + "}");
	}
}
