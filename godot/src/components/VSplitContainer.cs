namespace ReactiveSharpGodot.Components
{
    public class VSplitContainer : SplitContainer
    {
        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GVSplitContainer(), builtChildren);
    }
}