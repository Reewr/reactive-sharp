namespace ReactiveSharpGodot.Components
{
    public class ColorRect : Control
    {
        public Godot.Color? Color { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.INode> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GColorRect(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.ColorRect)node.Node;
            base.UpdateProperties(node);
            if (Color is Godot.Color n0)
                castedNode.Color = n0;
        }
    }
}
