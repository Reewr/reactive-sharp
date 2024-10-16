namespace ReactiveSharpGodot.Components
{
    public class MarginContainer : Container
    {
        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.INode> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GMarginContainer(), builtChildren);
    }
}
