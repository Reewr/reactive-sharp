namespace ReactiveSharpGodot.Components
{
    public class VFlowContainer : FlowContainer
    {
        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.INode> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GVFlowContainer(), builtChildren);
    }
}
