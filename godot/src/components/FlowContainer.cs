namespace ReactiveSharpGodot.Components
{
    public class FlowContainer : Container
    {
        public Godot.FlowContainer.AlignmentMode? Alignment { protected get; init; }
        public Godot.FlowContainer.LastWrapAlignmentMode? LastWrapAlignment { protected get; init; }
        public System.Boolean? Vertical { protected get; init; }
        public System.Boolean? ReverseFill { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GFlowContainer(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.FlowContainer)node.Node;
            base.UpdateProperties(node);
            if (Alignment is Godot.FlowContainer.AlignmentMode n0)
                castedNode.Alignment = n0;
            if (LastWrapAlignment is Godot.FlowContainer.LastWrapAlignmentMode n1)
                castedNode.LastWrapAlignment = n1;
            if (Vertical is System.Boolean n2)
                castedNode.Vertical = n2;
            if (ReverseFill is System.Boolean n3)
                castedNode.ReverseFill = n3;
        }
    }
}