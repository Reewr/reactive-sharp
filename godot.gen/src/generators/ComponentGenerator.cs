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
			return string.Join("\n", [
				$"if ({name} is {t} n{num}) ",
				"{",
				$"  NodeStateManager.AddPropertyState(castedNode, \"{name}\", castedNode.{name});",
				$"  castedNode.{name} = n{num};",
				"}",
			]);
		}).ToArray();
	}

	private static string CreatePropertyDefinitions(PropertyInfo[] properties) => string.Join("\n", properties.Select(property =>
	{
		var name = property.Name;
		var t = GetFullQualifiedTypeName(property.PropertyType).Replace("+", ".").Replace(" ", "");
		return $"public {t}? {name} {{ protected get; init; }}";
	}));

	private static string CreateUpdatePropertiesMethod(Type type, PropertyInfo[] properties)
	{
		var godotNodeName = "ReactiveSharpGodot.Nodes.G" + type.Name;
		return $"public override void UpdateProperties({godotNodeName} node) {{" +
			$"var castedNode = (Godot.{type.Name})node.Node;" +
			string.Join("\n", CreatePropertyAssignments(properties)) +
			"\n" +
			string.Join("\n", CreateEventAssignments(type)) +
			"\n" +
			"castedNode.BeginBulkThemeOverride();\n" +
			"foreach (var (key, value) in ThemeConstantOverrides) {\n" +
			"    castedNode.AddThemeConstantOverride(key, value);\n" +
			"}" +
			"castedNode.EndBulkThemeOverride();\n" +
		"}";
	}

	private static string CreateEventProperties(Type type)
	{
		var events = GetUniqueEvents(type, includeInheritedEvents: true);
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
		var events = GetUniqueEvents(type, includeInheritedEvents: true);
		return string.Join("\n", events.Select(e =>
		{
			var name = e.Name;
			var handlerType = GetFullQualifiedTypeName(e.EventHandlerType!).Replace("+", ".").Replace(" ", "");
			var num = i++;
			return string.Join("\n", [
				$"if ({name} is {handlerType} e{num}) ",
				"{",
				$"  NodeStateManager.AddEventHandler(castedNode, \"{name}\", e{num});",
				$"  castedNode.{name} += e{num};",
				"}",
			]);
		}));
	}

	public static ClassDeclarationSyntax GenerateComponent(Type type)
	{
		var godotNodeName = "ReactiveSharpGodot.Nodes.G" + type.Name;
		PropertyInfo[] uniqueProperties = GetUniqueProperties(type, includeInheritedProperties: true);
		return ParseClass(string.Join("\n", [
			$"public class {type.Name} : ReactiveSharp.NodeComponent<{godotNodeName}>",
			"{",
			CreatePropertyDefinitions(uniqueProperties),
			string.Join("\n", CreateEventProperties(type)),
			$"public Dictionary<string, int> ThemeConstantOverrides {{ protected get; init; }} = [];",
			"",
			$"public override {godotNodeName} Build(List<ReactiveSharp.INode> builtChildren) ",
			"{ " +
			$"  var node = new {godotNodeName}(); ",
			"  var igNode = (ReactiveSharp.INode)node; ",
			"  UpdateProperties(node); ",
			"  foreach (var child in builtChildren) igNode.AddChild(child); ",
			"  return node; ",
			"} ",
			uniqueProperties.Length != 0
				? CreateUpdatePropertiesMethod(type, uniqueProperties)
				: "",
			"}"
		]));
	}
}
