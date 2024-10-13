namespace ReactiveSharpGodot.Components
{
    public class AspectRatioContainer : Container
    {
        public System.Single? Ratio { protected get; init; }
        public Godot.AspectRatioContainer.StretchModeEnum? StretchMode { protected get; init; }
        public Godot.AspectRatioContainer.AlignmentMode? AlignmentHorizontal { protected get; init; }
        public Godot.AspectRatioContainer.AlignmentMode? AlignmentVertical { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GAspectRatioContainer(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.AspectRatioContainer)node.Node;
            base.UpdateProperties(node);
            if (Ratio is System.Single n0)
                castedNode.Ratio = n0;
            if (StretchMode is Godot.AspectRatioContainer.StretchModeEnum n1)
                castedNode.StretchMode = n1;
            if (AlignmentHorizontal is Godot.AspectRatioContainer.AlignmentMode n2)
                castedNode.AlignmentHorizontal = n2;
            if (AlignmentVertical is Godot.AspectRatioContainer.AlignmentMode n3)
                castedNode.AlignmentVertical = n3;
        }
    }
}