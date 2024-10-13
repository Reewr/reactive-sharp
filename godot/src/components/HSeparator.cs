namespace ReactiveSharpGodot.Components
{
    public class HSeparator : Separator
    {
        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GHSeparator(), builtChildren);
    }
}