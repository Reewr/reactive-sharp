namespace ReactiveSharpGodot.Components
{
    public class RichTextLabel : Control
    {
        public System.Boolean? BbcodeEnabled { protected get; init; }
        public System.String? Text { protected get; init; }
        public System.Boolean? FitContent { protected get; init; }
        public System.Boolean? ScrollActive { protected get; init; }
        public System.Boolean? ScrollFollowing { protected get; init; }
        public Godot.TextServer.AutowrapMode? AutowrapMode { protected get; init; }
        public System.Int32? TabSize { protected get; init; }
        public System.Boolean? ContextMenuEnabled { protected get; init; }
        public System.Boolean? ShortcutKeysEnabled { protected get; init; }
        public Godot.Collections.Array? CustomEffects { protected get; init; }
        public System.Boolean? MetaUnderlined { protected get; init; }
        public System.Boolean? HintUnderlined { protected get; init; }
        public System.Boolean? Threaded { protected get; init; }
        public System.Int32? ProgressBarDelay { protected get; init; }
        public System.Boolean? SelectionEnabled { protected get; init; }
        public System.Boolean? DeselectOnFocusLossEnabled { protected get; init; }
        public System.Boolean? DragAndDropSelectionEnabled { protected get; init; }
        public System.Int32? VisibleCharacters { protected get; init; }
        public Godot.TextServer.VisibleCharactersBehavior? VisibleCharactersBehavior { protected get; init; }
        public System.Single? VisibleRatio { protected get; init; }
        public Godot.Control.TextDirection? TextDirection { protected get; init; }
        public System.String? Language { protected get; init; }
        public Godot.TextServer.StructuredTextParser? StructuredTextBidiOverride { protected get; init; }
        public Godot.Collections.Array? StructuredTextBidiOverrideOptions { protected get; init; }
        public Godot.RichTextLabel.MetaClickedEventHandler? MetaClicked { protected get; init; }
        public Godot.RichTextLabel.MetaHoverStartedEventHandler? MetaHoverStarted { protected get; init; }
        public Godot.RichTextLabel.MetaHoverEndedEventHandler? MetaHoverEnded { protected get; init; }
        public System.Action? Finished { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GRichTextLabel(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.RichTextLabel)node.Node;
            base.UpdateProperties(node);
            if (BbcodeEnabled is System.Boolean n0)
                castedNode.BbcodeEnabled = n0;
            if (Text is System.String n1)
                castedNode.Text = n1;
            if (FitContent is System.Boolean n2)
                castedNode.FitContent = n2;
            if (ScrollActive is System.Boolean n3)
                castedNode.ScrollActive = n3;
            if (ScrollFollowing is System.Boolean n4)
                castedNode.ScrollFollowing = n4;
            if (AutowrapMode is Godot.TextServer.AutowrapMode n5)
                castedNode.AutowrapMode = n5;
            if (TabSize is System.Int32 n6)
                castedNode.TabSize = n6;
            if (ContextMenuEnabled is System.Boolean n7)
                castedNode.ContextMenuEnabled = n7;
            if (ShortcutKeysEnabled is System.Boolean n8)
                castedNode.ShortcutKeysEnabled = n8;
            if (CustomEffects is Godot.Collections.Array n9)
                castedNode.CustomEffects = n9;
            if (MetaUnderlined is System.Boolean n10)
                castedNode.MetaUnderlined = n10;
            if (HintUnderlined is System.Boolean n11)
                castedNode.HintUnderlined = n11;
            if (Threaded is System.Boolean n12)
                castedNode.Threaded = n12;
            if (ProgressBarDelay is System.Int32 n13)
                castedNode.ProgressBarDelay = n13;
            if (SelectionEnabled is System.Boolean n14)
                castedNode.SelectionEnabled = n14;
            if (DeselectOnFocusLossEnabled is System.Boolean n15)
                castedNode.DeselectOnFocusLossEnabled = n15;
            if (DragAndDropSelectionEnabled is System.Boolean n16)
                castedNode.DragAndDropSelectionEnabled = n16;
            if (VisibleCharacters is System.Int32 n17)
                castedNode.VisibleCharacters = n17;
            if (VisibleCharactersBehavior is Godot.TextServer.VisibleCharactersBehavior n18)
                castedNode.VisibleCharactersBehavior = n18;
            if (VisibleRatio is System.Single n19)
                castedNode.VisibleRatio = n19;
            if (TextDirection is Godot.Control.TextDirection n20)
                castedNode.TextDirection = n20;
            if (Language is System.String n21)
                castedNode.Language = n21;
            if (StructuredTextBidiOverride is Godot.TextServer.StructuredTextParser n22)
                castedNode.StructuredTextBidiOverride = n22;
            if (StructuredTextBidiOverrideOptions is Godot.Collections.Array n23)
                castedNode.StructuredTextBidiOverrideOptions = n23;
            if (MetaClicked is Godot.RichTextLabel.MetaClickedEventHandler e0)
                castedNode.MetaClicked += e0;
            if (MetaHoverStarted is Godot.RichTextLabel.MetaHoverStartedEventHandler e1)
                castedNode.MetaHoverStarted += e1;
            if (MetaHoverEnded is Godot.RichTextLabel.MetaHoverEndedEventHandler e2)
                castedNode.MetaHoverEnded += e2;
            if (Finished is System.Action e3)
                castedNode.Finished += e3;
        }
    }
}