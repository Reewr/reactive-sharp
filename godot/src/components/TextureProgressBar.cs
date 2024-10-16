namespace ReactiveSharpGodot.Components
{
    public class TextureProgressBar : Range
    {
        public System.Int32? FillMode { protected get; init; }
        public System.Single? RadialInitialAngle { protected get; init; }
        public System.Single? RadialFillDegrees { protected get; init; }
        public Godot.Vector2? RadialCenterOffset { protected get; init; }
        public System.Boolean? NinePatchStretch { protected get; init; }
        public System.Int32? StretchMarginLeft { protected get; init; }
        public System.Int32? StretchMarginTop { protected get; init; }
        public System.Int32? StretchMarginRight { protected get; init; }
        public System.Int32? StretchMarginBottom { protected get; init; }
        public Godot.Texture2D? TextureUnder { protected get; init; }
        public Godot.Texture2D? TextureOver { protected get; init; }
        public Godot.Texture2D? TextureProgress { protected get; init; }
        public Godot.Vector2? TextureProgressOffset { protected get; init; }
        public Godot.Color? TintUnder { protected get; init; }
        public Godot.Color? TintOver { protected get; init; }
        public Godot.Color? TintProgress { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.INode> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GTextureProgressBar(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.TextureProgressBar)node.Node;
            base.UpdateProperties(node);
            if (FillMode is System.Int32 n0)
                castedNode.FillMode = n0;
            if (RadialInitialAngle is System.Single n1)
                castedNode.RadialInitialAngle = n1;
            if (RadialFillDegrees is System.Single n2)
                castedNode.RadialFillDegrees = n2;
            if (RadialCenterOffset is Godot.Vector2 n3)
                castedNode.RadialCenterOffset = n3;
            if (NinePatchStretch is System.Boolean n4)
                castedNode.NinePatchStretch = n4;
            if (StretchMarginLeft is System.Int32 n5)
                castedNode.StretchMarginLeft = n5;
            if (StretchMarginTop is System.Int32 n6)
                castedNode.StretchMarginTop = n6;
            if (StretchMarginRight is System.Int32 n7)
                castedNode.StretchMarginRight = n7;
            if (StretchMarginBottom is System.Int32 n8)
                castedNode.StretchMarginBottom = n8;
            if (TextureUnder is Godot.Texture2D n9)
                castedNode.TextureUnder = n9;
            if (TextureOver is Godot.Texture2D n10)
                castedNode.TextureOver = n10;
            if (TextureProgress is Godot.Texture2D n11)
                castedNode.TextureProgress = n11;
            if (TextureProgressOffset is Godot.Vector2 n12)
                castedNode.TextureProgressOffset = n12;
            if (TintUnder is Godot.Color n13)
                castedNode.TintUnder = n13;
            if (TintOver is Godot.Color n14)
                castedNode.TintOver = n14;
            if (TintProgress is Godot.Color n15)
                castedNode.TintProgress = n15;
        }
    }
}
