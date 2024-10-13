namespace ReactiveSharpGodot.Components
{
    public class TextureButton : BaseButton
    {
        public Godot.Texture2D? TextureNormal { protected get; init; }
        public Godot.Texture2D? TexturePressed { protected get; init; }
        public Godot.Texture2D? TextureHover { protected get; init; }
        public Godot.Texture2D? TextureDisabled { protected get; init; }
        public Godot.Texture2D? TextureFocused { protected get; init; }
        public Godot.Bitmap? TextureClickMask { protected get; init; }
        public System.Boolean? IgnoreTextureSize { protected get; init; }
        public Godot.TextureButton.StretchModeEnum? StretchMode { protected get; init; }
        public System.Boolean? FlipH { protected get; init; }
        public System.Boolean? FlipV { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GTextureButton(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.TextureButton)node.Node;
            base.UpdateProperties(node);
            if (TextureNormal is Godot.Texture2D n0)
                castedNode.TextureNormal = n0;
            if (TexturePressed is Godot.Texture2D n1)
                castedNode.TexturePressed = n1;
            if (TextureHover is Godot.Texture2D n2)
                castedNode.TextureHover = n2;
            if (TextureDisabled is Godot.Texture2D n3)
                castedNode.TextureDisabled = n3;
            if (TextureFocused is Godot.Texture2D n4)
                castedNode.TextureFocused = n4;
            if (TextureClickMask is Godot.Bitmap n5)
                castedNode.TextureClickMask = n5;
            if (IgnoreTextureSize is System.Boolean n6)
                castedNode.IgnoreTextureSize = n6;
            if (StretchMode is Godot.TextureButton.StretchModeEnum n7)
                castedNode.StretchMode = n7;
            if (FlipH is System.Boolean n8)
                castedNode.FlipH = n8;
            if (FlipV is System.Boolean n9)
                castedNode.FlipV = n9;
        }
    }
}