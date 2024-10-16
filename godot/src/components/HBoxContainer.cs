namespace ReactiveSharpGodot.Components
{
    public class HBoxContainer : BoxContainer
    {
        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.INode> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GHBoxContainer(), builtChildren);
    }
}
