using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ReactiveSharpGodot.Gen;

internal class NodeGenerator : CodeGenerator
{
	public static ClassDeclarationSyntax GenerateGodotNode(Type type)
	{
		var fullTypeName = type.FullName!.Replace("+", ".").Replace(" ", "");
		return ParseClass(
				$"public class G{type.Name} : {fullTypeName}, ReactiveSharpGodot.IGNode {{" +
					"public Godot.Node Node => this;" +
				"}"
		);
	}

	internal static ClassDeclarationSyntax GetBaseControlNode() => GenerateGodotNode(typeof(Godot.Control));
}
