namespace ReactiveSharpGodot.Components
{
    public class Container : Control
    {
        public System.Action? PreSortChildren { protected get; init; }
        public System.Action? SortChildren { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.INode> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GContainer(), builtChildren);
    }
}
