namespace ReactiveSharpGodot.Components
{
    public class GraphElement : Container
    {
        public Godot.Vector2? PositionOffset { protected get; init; }
        public System.Boolean? Resizable { protected get; init; }
        public System.Boolean? Draggable { protected get; init; }
        public System.Boolean? Selectable { protected get; init; }
        public System.Boolean? Selected { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GGraphElement(), builtChildren);
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
        }
    }
}