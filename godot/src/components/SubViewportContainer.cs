namespace ReactiveSharpGodot.Components
{
    public class SubViewportContainer : Container
    {
        public System.Boolean? Stretch { protected get; init; }
        public System.Int32? StretchShrink { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.INode> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GSubViewportContainer(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.SubViewportContainer)node.Node;
            base.UpdateProperties(node);
            if (Stretch is System.Boolean n0)
                castedNode.Stretch = n0;
            if (StretchShrink is System.Int32 n1)
                castedNode.StretchShrink = n1;
        }
    }
}
