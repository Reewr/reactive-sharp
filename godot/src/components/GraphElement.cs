namespace ReactiveSharpGodot.Components
{
    public class GraphElement : Container
    {
        public Godot.Vector2? PositionOffset { protected get; init; }
        public System.Boolean? Resizable { protected get; init; }
        public System.Boolean? Draggable { protected get; init; }
        public System.Boolean? Selectable { protected get; init; }
        public System.Boolean? Selected { protected get; init; }
        public System.Action? NodeSelected { protected get; init; }
        public System.Action? NodeDeselected { protected get; init; }
        public System.Action? RaiseRequest { protected get; init; }
        public System.Action? DeleteRequest { protected get; init; }
        public Godot.GraphElement.ResizeRequestEventHandler? ResizeRequest { protected get; init; }
        public Godot.GraphElement.ResizeEndEventHandler? ResizeEnd { protected get; init; }
        public Godot.GraphElement.DraggedEventHandler? Dragged { protected get; init; }
        public System.Action? PositionOffsetChanged { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.INode> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GGraphElement(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.GraphElement)node.Node;
            base.UpdateProperties(node);
            if (PositionOffset is Godot.Vector2 n0)
                castedNode.PositionOffset = n0;
            if (Resizable is System.Boolean n1)
                castedNode.Resizable = n1;
            if (Draggable is System.Boolean n2)
                castedNode.Draggable = n2;
            if (Selectable is System.Boolean n3)
                castedNode.Selectable = n3;
            if (Selected is System.Boolean n4)
                castedNode.Selected = n4;
            if (NodeSelected is System.Action e0)
                castedNode.NodeSelected += e0;
            if (NodeDeselected is System.Action e1)
                castedNode.NodeDeselected += e1;
            if (RaiseRequest is System.Action e2)
                castedNode.RaiseRequest += e2;
            if (DeleteRequest is System.Action e3)
                castedNode.DeleteRequest += e3;
            if (ResizeRequest is Godot.GraphElement.ResizeRequestEventHandler e4)
                castedNode.ResizeRequest += e4;
            if (ResizeEnd is Godot.GraphElement.ResizeEndEventHandler e5)
                castedNode.ResizeEnd += e5;
            if (Dragged is Godot.GraphElement.DraggedEventHandler e6)
                castedNode.Dragged += e6;
            if (PositionOffsetChanged is System.Action e7)
                castedNode.PositionOffsetChanged += e7;
        }
    }
}
