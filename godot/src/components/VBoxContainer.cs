namespace ReactiveSharpGodot.Components
{
    public class VBoxContainer : BoxContainer
    {
        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GVBoxContainer(), builtChildren);
    }
}