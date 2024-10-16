namespace ReactiveSharpGodot.Components
{
    public class HSplitContainer : SplitContainer
    {
        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.INode> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GHSplitContainer(), builtChildren);
    }
}
