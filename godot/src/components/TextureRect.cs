namespace ReactiveSharpGodot.Components
{
    public class TextureRect : Control
    {
        public Godot.Texture2D? Texture { protected get; init; }
        public Godot.TextureRect.ExpandModeEnum? ExpandMode { protected get; init; }
        public Godot.TextureRect.StretchModeEnum? StretchMode { protected get; init; }
        public System.Boolean? FlipH { protected get; init; }
        public System.Boolean? FlipV { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.INode> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GTextureRect(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.TextureRect)node.Node;
            base.UpdateProperties(node);
            if (Texture is Godot.Texture2D n0)
                castedNode.Texture = n0;
            if (ExpandMode is Godot.TextureRect.ExpandModeEnum n1)
                castedNode.ExpandMode = n1;
            if (StretchMode is Godot.TextureRect.StretchModeEnum n2)
                castedNode.StretchMode = n2;
            if (FlipH is System.Boolean n3)
                castedNode.FlipH = n3;
            if (FlipV is System.Boolean n4)
                castedNode.FlipV = n4;
        }
    }
}
