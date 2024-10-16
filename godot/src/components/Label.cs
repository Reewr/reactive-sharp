namespace ReactiveSharpGodot.Components
{
    public class Label : Control
    {
        public System.String? Text { protected get; init; }
        public Godot.LabelSettings? LabelSettings { protected get; init; }
        public Godot.HorizontalAlignment? HorizontalAlignment { protected get; init; }
        public Godot.VerticalAlignment? VerticalAlignment { protected get; init; }
        public Godot.TextServer.AutowrapMode? AutowrapMode { protected get; init; }
        public Godot.TextServer.JustificationFlag? JustificationFlags { protected get; init; }
        public System.Boolean? ClipText { protected get; init; }
        public Godot.TextServer.OverrunBehavior? TextOverrunBehavior { protected get; init; }
        public System.String? EllipsisChar { protected get; init; }
        public System.Boolean? Uppercase { protected get; init; }
        public System.Single[]? TabStops { protected get; init; }
        public System.Int32? LinesSkipped { protected get; init; }
        public System.Int32? MaxLinesVisible { protected get; init; }
        public System.Int32? VisibleCharacters { protected get; init; }
        public Godot.TextServer.VisibleCharactersBehavior? VisibleCharactersBehavior { protected get; init; }
        public System.Single? VisibleRatio { protected get; init; }
        public Godot.Control.TextDirection? TextDirection { protected get; init; }
        public System.String? Language { protected get; init; }
        public Godot.TextServer.StructuredTextParser? StructuredTextBidiOverride { protected get; init; }
        public Godot.Collections.Array? StructuredTextBidiOverrideOptions { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.INode> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GLabel(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.Label)node.Node;
            base.UpdateProperties(node);
            if (Text is System.String n0)
                castedNode.Text = n0;
            if (LabelSettings is Godot.LabelSettings n1)
                castedNode.LabelSettings = n1;
            if (HorizontalAlignment is Godot.HorizontalAlignment n2)
                castedNode.HorizontalAlignment = n2;
            if (VerticalAlignment is Godot.VerticalAlignment n3)
                castedNode.VerticalAlignment = n3;
            if (AutowrapMode is Godot.TextServer.AutowrapMode n4)
                castedNode.AutowrapMode = n4;
            if (JustificationFlags is Godot.TextServer.JustificationFlag n5)
                castedNode.JustificationFlags = n5;
            if (ClipText is System.Boolean n6)
                castedNode.ClipText = n6;
            if (TextOverrunBehavior is Godot.TextServer.OverrunBehavior n7)
                castedNode.TextOverrunBehavior = n7;
            if (EllipsisChar is System.String n8)
                castedNode.EllipsisChar = n8;
            if (Uppercase is System.Boolean n9)
                castedNode.Uppercase = n9;
            if (TabStops is System.Single[] n10)
                castedNode.TabStops = n10;
            if (LinesSkipped is System.Int32 n11)
                castedNode.LinesSkipped = n11;
            if (MaxLinesVisible is System.Int32 n12)
                castedNode.MaxLinesVisible = n12;
            if (VisibleCharacters is System.Int32 n13)
                castedNode.VisibleCharacters = n13;
            if (VisibleCharactersBehavior is Godot.TextServer.VisibleCharactersBehavior n14)
                castedNode.VisibleCharactersBehavior = n14;
            if (VisibleRatio is System.Single n15)
                castedNode.VisibleRatio = n15;
            if (TextDirection is Godot.Control.TextDirection n16)
                castedNode.TextDirection = n16;
            if (Language is System.String n17)
                castedNode.Language = n17;
            if (StructuredTextBidiOverride is Godot.TextServer.StructuredTextParser n18)
                castedNode.StructuredTextBidiOverride = n18;
            if (StructuredTextBidiOverrideOptions is Godot.Collections.Array n19)
                castedNode.StructuredTextBidiOverrideOptions = n19;
        }
    }
}
