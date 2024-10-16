namespace ReactiveSharpGodot.Components
{
    public class VBoxContainer : BoxContainer
    {
        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.INode> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GVBoxContainer(), builtChildren);
    }
}
