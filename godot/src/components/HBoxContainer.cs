namespace ReactiveSharpGodot.Components
{
    public class HBoxContainer : BoxContainer
    {
        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GHBoxContainer(), builtChildren);
    }
}