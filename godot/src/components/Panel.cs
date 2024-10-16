namespace ReactiveSharpGodot.Components
{
    public class Panel : Control
    {
        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.INode> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GPanel(), builtChildren);
    }
}
