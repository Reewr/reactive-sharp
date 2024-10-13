namespace ReactiveSharpGodot.Components
{
    public class MarginContainer : Container
    {
        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GMarginContainer(), builtChildren);
    }
}