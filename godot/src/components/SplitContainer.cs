namespace ReactiveSharpGodot.Components
{
    public class SplitContainer : Container
    {
        public System.Int32? SplitOffset { protected get; init; }
        public System.Boolean? Collapsed { protected get; init; }
        public Godot.SplitContainer.DraggerVisibilityEnum? DraggerVisibility { protected get; init; }
        public System.Boolean? Vertical { protected get; init; }
        public Godot.SplitContainer.DraggedEventHandler? Dragged { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GSplitContainer(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.SplitContainer)node.Node;
            base.UpdateProperties(node);
            if (SplitOffset is System.Int32 n0)
                castedNode.SplitOffset = n0;
            if (Collapsed is System.Boolean n1)
                castedNode.Collapsed = n1;
            if (DraggerVisibility is Godot.SplitContainer.DraggerVisibilityEnum n2)
                castedNode.DraggerVisibility = n2;
            if (Vertical is System.Boolean n3)
                castedNode.Vertical = n3;
            if (Dragged is Godot.SplitContainer.DraggedEventHandler e0)
                castedNode.Dragged += e0;
        }
    }
}