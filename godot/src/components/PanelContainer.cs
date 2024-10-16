namespace ReactiveSharpGodot.Components
{
    public class PanelContainer : Container
    {
        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.INode> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GPanelContainer(), builtChildren);
    }
}
