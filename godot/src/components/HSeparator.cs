namespace ReactiveSharpGodot.Components
{
    public class HSeparator : Separator
    {
        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.INode> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GHSeparator(), builtChildren);
    }
}
