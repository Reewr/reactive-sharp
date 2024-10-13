namespace ReactiveSharpGodot.Components
{
    public abstract class Slider : Range
    {
        public System.Boolean? Editable { protected get; init; }
        public System.Boolean? Scrollable { protected get; init; }
        public System.Int32? TickCount { protected get; init; }
        public System.Boolean? TicksOnBorders { protected get; init; }

        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.Slider)node.Node;
            base.UpdateProperties(node);
            if (Editable is System.Boolean n0)
                castedNode.Editable = n0;
            if (Scrollable is System.Boolean n1)
                castedNode.Scrollable = n1;
            if (TickCount is System.Int32 n2)
                castedNode.TickCount = n2;
            if (TicksOnBorders is System.Boolean n3)
                castedNode.TicksOnBorders = n3;
        }
    }
}