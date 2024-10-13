namespace ReactiveSharpGodot.Components
{
    public class VSeparator : Separator
    {
        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GVSeparator(), builtChildren);
    }
}