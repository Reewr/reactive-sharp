namespace ReactiveSharpGodot.Components
{
    public class VScrollBar : ScrollBar
    {
        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.INode> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GVScrollBar(), builtChildren);
    }
}
