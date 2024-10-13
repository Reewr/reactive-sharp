namespace ReactiveSharpGodot.Components
{
    public class HFlowContainer : FlowContainer
    {
        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GHFlowContainer(), builtChildren);
    }
}