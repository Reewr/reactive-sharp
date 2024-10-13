namespace ReactiveSharpGodot.Components
{
    public class ReferenceRect : Control
    {
        public Godot.Color? BorderColor { protected get; init; }
        public System.Single? BorderWidth { protected get; init; }
        public System.Boolean? EditorOnly { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GReferenceRect(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.ReferenceRect)node.Node;
            base.UpdateProperties(node);
            if (BorderColor is Godot.Color n0)
                castedNode.BorderColor = n0;
            if (BorderWidth is System.Single n1)
                castedNode.BorderWidth = n1;
            if (EditorOnly is System.Boolean n2)
                castedNode.EditorOnly = n2;
        }
    }
}