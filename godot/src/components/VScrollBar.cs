namespace ReactiveSharpGodot.Components
{
    public class VScrollBar : ScrollBar
    {
        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GVScrollBar(), builtChildren);
    }
}