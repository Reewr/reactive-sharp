namespace ReactiveSharpGodot.Gen;

using System.Reflection;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

internal abstract class CodeGenerator
{
	protected static string GetFullQualifiedTypeName(Type type)
	{
		if (type.IsGenericType)
		{
			// Handle generic types, e.g., System.Collections.Generic.List<System.String>
			string genericTypeName = type.GetGenericTypeDefinition().FullName!;
			genericTypeName = genericTypeName.Substring(0, genericTypeName.IndexOf('`'));
			string genericArgs = string.Join(", ", type.GetGenericArguments().Select(t => GetFullQualifiedTypeName(t)));
			return $"{genericTypeName}<{genericArgs}>";
		}
		else
		{
			return type.FullName!;
		}
	}

	protected static ClassDeclarationSyntax ParseClass(string code) =>
		CSharpSyntaxTree
			.ParseText(code)
			.GetRoot()
			.DescendantNodes()
			.OfType<ClassDeclarationSyntax>()
			.First();


	protected static PropertyInfo[] GetUniqueProperties(Type type, bool includeInheritedProperties = false) => type.GetProperties(
		(includeInheritedProperties ? BindingFlags.Default : BindingFlags.DeclaredOnly) |
		BindingFlags.Public |
		BindingFlags.Instance
	).Where(p => p.CanWrite && !p.Name.StartsWith('_')).ToArray();

	protected static EventInfo[] GetUniqueEvents(Type type, bool includeInheritedEvents = false) => [.. type.GetEvents(
		(includeInheritedEvents ? BindingFlags.Default : BindingFlags.DeclaredOnly) |
		BindingFlags.Public |
		BindingFlags.Instance
	)];

	public static string ToCode(MemberDeclarationSyntax[] members, string @namespace) =>
		SyntaxFactory.CompilationUnit()
			.AddMembers(
				SyntaxFactory
					.NamespaceDeclaration(SyntaxFactory.ParseName(@namespace))
					.NormalizeWhitespace()
				 	.AddMembers(members)
			)
			.NormalizeWhitespace()
			.WithoutLeadingTrivia()
			.ToFullString();

}
