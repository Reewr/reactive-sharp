namespace ReactiveSharpGodot.Components
{
    public class VSeparator : Separator
    {
        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.INode> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GVSeparator(), builtChildren);
    }
}
