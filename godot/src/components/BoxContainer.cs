namespace ReactiveSharpGodot.Components
{
    public class BoxContainer : Container
    {
        public Godot.BoxContainer.AlignmentMode? Alignment { protected get; init; }
        public System.Boolean? Vertical { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.INode> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GBoxContainer(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.BoxContainer)node.Node;
            base.UpdateProperties(node);
            if (Alignment is Godot.BoxContainer.AlignmentMode n0)
                castedNode.Alignment = n0;
            if (Vertical is System.Boolean n1)
                castedNode.Vertical = n1;
        }
    }
}
