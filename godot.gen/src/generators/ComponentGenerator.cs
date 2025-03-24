namespace ReactiveSharpGodot.Gen;

using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

internal class ComponentGenerator : CodeGenerator
{
	private static readonly string CustomHandlingName = "CustomNodeHandling";

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
		return string.Join("\n", [
			$"public override void UpdateProperties({godotNodeName} node) {{",
			$"var castedNode = (Godot.{type.Name})node.Node;",
			string.Join("\n", CreatePropertyAssignments(properties)),
			"",
			string.Join("\n", CreateEventAssignments(type)),
			"" +
			"castedNode.BeginBulkThemeOverride();",
			"foreach (var (key, value) in ThemeConstantOverrides) {",
			"    castedNode.AddThemeConstantOverride(key, value);",
			"}",
			"foreach (var (key, value) in ThemeColorOverrides) {",
			"    castedNode.AddThemeColorOverride(key, value);",
			"}",
			"castedNode.EndBulkThemeOverride();",
			$"{CustomHandlingName}?.Invoke(node);",
			"}"
		]);
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
			$"public Dictionary<string, Godot.Color> ThemeColorOverrides {{ protected get; init; }} = [];",
			"",
			"/// <summary>",
			"/// This property allows you to define an action that will be called right after the node",
			"/// it represents is updated within Godot. As godot has many functions that can be useful",
			"/// making bindings for all of them, even generated ones, is a huge task.",
			"///",
			"/// This function allows you to use all the functionality of the godot node.",
			"///",
			"/// <b>NOTE</b>: State changes done through this function are NOT reset on re-render.",
			"/// Therefore, you need to keep track of the state yourself and set it on every render",
			"/// <example>",
			"/// In the below example, the component uses a button. The button has a SetPressedNoSignal function",
			"/// that can be used to set the toggle state on the button without triggering an event",
			"/// Since this is a function and not a property, it is not exposed through the Button component itself",
			$"/// and therefore we need to use the {CustomHandlingName} to set this property.",
			"/// <code>",
			"/// class MyComponent : Component {",
			"/// 	Component Render() {",
			"/// 		var isToggled = UseState(false);",
			"/// 		return new Button()",
			"/// 		{",
			"/// 			ToggleMode = true,",
			$"///			{CustomHandlingName} = (Button button) =>",
			"/// 			{",
			"/// 				button.SetPressedNoSignal(isToggled.Value);",
			"/// 			}",
			"/// 		};",
			"/// 	}",
			"/// }",
			"/// </code>",
			"/// </example>",
			"/// </summary>",
			$"public Action<{godotNodeName}>? {CustomHandlingName} {{ protected get; init; }}",
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
