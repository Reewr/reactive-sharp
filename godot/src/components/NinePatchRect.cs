namespace ReactiveSharpGodot.Components
{
    public class NinePatchRect : Control
    {
        public Godot.Texture2D? Texture { protected get; init; }
        public System.Boolean? DrawCenter { protected get; init; }
        public Godot.Rect2? RegionRect { protected get; init; }
        public System.Int32? PatchMarginLeft { protected get; init; }
        public System.Int32? PatchMarginTop { protected get; init; }
        public System.Int32? PatchMarginRight { protected get; init; }
        public System.Int32? PatchMarginBottom { protected get; init; }
        public Godot.NinePatchRect.AxisStretchMode? AxisStretchHorizontal { protected get; init; }
        public Godot.NinePatchRect.AxisStretchMode? AxisStretchVertical { protected get; init; }
        public System.Action? TextureChanged { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GNinePatchRect(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.NinePatchRect)node.Node;
            base.UpdateProperties(node);
            if (Texture is Godot.Texture2D n0)
                castedNode.Texture = n0;
            if (DrawCenter is System.Boolean n1)
                castedNode.DrawCenter = n1;
            if (RegionRect is Godot.Rect2 n2)
                castedNode.RegionRect = n2;
            if (PatchMarginLeft is System.Int32 n3)
                castedNode.PatchMarginLeft = n3;
            if (PatchMarginTop is System.Int32 n4)
                castedNode.PatchMarginTop = n4;
            if (PatchMarginRight is System.Int32 n5)
                castedNode.PatchMarginRight = n5;
            if (PatchMarginBottom is System.Int32 n6)
                castedNode.PatchMarginBottom = n6;
            if (AxisStretchHorizontal is Godot.NinePatchRect.AxisStretchMode n7)
                castedNode.AxisStretchHorizontal = n7;
            if (AxisStretchVertical is Godot.NinePatchRect.AxisStretchMode n8)
                castedNode.AxisStretchVertical = n8;
            if (TextureChanged is System.Action e0)
                castedNode.TextureChanged += e0;
        }
    }
}