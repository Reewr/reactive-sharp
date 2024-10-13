namespace ReactiveSharpGodot.Components
{
    public class Container : Control
    {
        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GContainer(), builtChildren);
    }
}