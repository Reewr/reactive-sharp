namespace ReactiveSharpGodot.Components
{
    public class HScrollBar : ScrollBar
    {
        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.INode> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GHScrollBar(), builtChildren);
    }
}
