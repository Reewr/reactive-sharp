namespace ReactiveSharpGodot.Components
{
    public class HSplitContainer : SplitContainer
    {
        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GHSplitContainer(), builtChildren);
    }
}