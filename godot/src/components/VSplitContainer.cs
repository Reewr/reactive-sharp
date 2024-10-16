namespace ReactiveSharpGodot.Components
{
    public class VSplitContainer : SplitContainer
    {
        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.INode> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GVSplitContainer(), builtChildren);
    }
}
