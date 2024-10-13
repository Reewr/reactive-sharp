namespace ReactiveSharpGodot.Components
{
    public class VFlowContainer : FlowContainer
    {
        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GVFlowContainer(), builtChildren);
    }
}