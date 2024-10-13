namespace ReactiveSharpGodot.Components
{
    public class PanelContainer : Container
    {
        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GPanelContainer(), builtChildren);
    }
}