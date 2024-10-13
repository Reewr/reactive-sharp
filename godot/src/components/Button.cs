namespace ReactiveSharpGodot.Components
{
    public class Button : BaseButton
    {
        public System.String? Text { protected get; init; }
        public Godot.Texture2D? Icon { protected get; init; }
        public System.Boolean? Flat { protected get; init; }
        public Godot.HorizontalAlignment? Alignment { protected get; init; }
        public Godot.TextServer.OverrunBehavior? TextOverrunBehavior { protected get; init; }
        public Godot.TextServer.AutowrapMode? AutowrapMode { protected get; init; }
        public System.Boolean? ClipText { protected get; init; }
        public Godot.HorizontalAlignment? IconAlignment { protected get; init; }
        public Godot.VerticalAlignment? VerticalIconAlignment { protected get; init; }
        public System.Boolean? ExpandIcon { protected get; init; }
        public Godot.Control.TextDirection? TextDirection { protected get; init; }
        public System.String? Language { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GButton(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.Button)node.Node;
            base.UpdateProperties(node);
            if (Text is System.String n0)
                castedNode.Text = n0;
            if (Icon is Godot.Texture2D n1)
                castedNode.Icon = n1;
            if (Flat is System.Boolean n2)
                castedNode.Flat = n2;
            if (Alignment is Godot.HorizontalAlignment n3)
                castedNode.Alignment = n3;
            if (TextOverrunBehavior is Godot.TextServer.OverrunBehavior n4)
                castedNode.TextOverrunBehavior = n4;
            if (AutowrapMode is Godot.TextServer.AutowrapMode n5)
                castedNode.AutowrapMode = n5;
            if (ClipText is System.Boolean n6)
                castedNode.ClipText = n6;
            if (IconAlignment is Godot.HorizontalAlignment n7)
                castedNode.IconAlignment = n7;
            if (VerticalIconAlignment is Godot.VerticalAlignment n8)
                castedNode.VerticalIconAlignment = n8;
            if (ExpandIcon is System.Boolean n9)
                castedNode.ExpandIcon = n9;
            if (TextDirection is Godot.Control.TextDirection n10)
                castedNode.TextDirection = n10;
            if (Language is System.String n11)
                castedNode.Language = n11;
        }
    }
}