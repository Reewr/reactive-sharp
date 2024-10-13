namespace ReactiveSharpGodot.Components
{
    public class HScrollBar : ScrollBar
    {
        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GHScrollBar(), builtChildren);
    }
}