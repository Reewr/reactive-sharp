namespace ReactiveSharpGodot.Components
{
    public class GraphFrame : GraphElement
    {
        public System.String? Title { protected get; init; }
        public System.Boolean? AutoshrinkEnabled { protected get; init; }
        public System.Int32? AutoshrinkMargin { protected get; init; }
        public System.Int32? DragMargin { protected get; init; }
        public System.Boolean? TintColorEnabled { protected get; init; }
        public Godot.Color? TintColor { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GGraphFrame(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.GraphFrame)node.Node;
            base.UpdateProperties(node);
            if (Title is System.String n0)
                castedNode.Title = n0;
            if (AutoshrinkEnabled is System.Boolean n1)
                castedNode.AutoshrinkEnabled = n1;
            if (AutoshrinkMargin is System.Int32 n2)
                castedNode.AutoshrinkMargin = n2;
            if (DragMargin is System.Int32 n3)
                castedNode.DragMargin = n3;
            if (TintColorEnabled is System.Boolean n4)
                castedNode.TintColorEnabled = n4;
            if (TintColor is Godot.Color n5)
                castedNode.TintColor = n5;
        }
    }
}