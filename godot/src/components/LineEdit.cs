namespace ReactiveSharpGodot.Components
{
    public class LineEdit : Control
    {
        public System.String? Text { protected get; init; }
        public System.String? PlaceholderText { protected get; init; }
        public Godot.HorizontalAlignment? Alignment { protected get; init; }
        public System.Int32? MaxLength { protected get; init; }
        public System.Boolean? Editable { protected get; init; }
        public System.Boolean? ExpandToTextLength { protected get; init; }
        public System.Boolean? ContextMenuEnabled { protected get; init; }
        public System.Boolean? VirtualKeyboardEnabled { protected get; init; }
        public Godot.LineEdit.VirtualKeyboardTypeEnum? VirtualKeyboardType { protected get; init; }
        public System.Boolean? ClearButtonEnabled { protected get; init; }
        public System.Boolean? ShortcutKeysEnabled { protected get; init; }
        public System.Boolean? MiddleMousePasteEnabled { protected get; init; }
        public System.Boolean? SelectingEnabled { protected get; init; }
        public System.Boolean? DeselectOnFocusLossEnabled { protected get; init; }
        public System.Boolean? DragAndDropSelectionEnabled { protected get; init; }
        public Godot.Texture2D? RightIcon { protected get; init; }
        public System.Boolean? Flat { protected get; init; }
        public System.Boolean? DrawControlChars { protected get; init; }
        public System.Boolean? SelectAllOnFocus { protected get; init; }
        public System.Boolean? CaretBlink { protected get; init; }
        public System.Single? CaretBlinkInterval { protected get; init; }
        public System.Int32? CaretColumn { protected get; init; }
        public System.Boolean? CaretForceDisplayed { protected get; init; }
        public System.Boolean? CaretMidGrapheme { protected get; init; }
        public System.Boolean? Secret { protected get; init; }
        public System.String? SecretCharacter { protected get; init; }
        public Godot.Control.TextDirection? TextDirection { protected get; init; }
        public System.String? Language { protected get; init; }
        public Godot.TextServer.StructuredTextParser? StructuredTextBidiOverride { protected get; init; }
        public Godot.Collections.Array? StructuredTextBidiOverrideOptions { protected get; init; }
        public Godot.LineEdit.TextChangedEventHandler? TextChanged { protected get; init; }
        public Godot.LineEdit.TextChangeRejectedEventHandler? TextChangeRejected { protected get; init; }
        public Godot.LineEdit.TextSubmittedEventHandler? TextSubmitted { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GLineEdit(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.LineEdit)node.Node;
            base.UpdateProperties(node);
            if (Text is System.String n0)
                castedNode.Text = n0;
            if (PlaceholderText is System.String n1)
                castedNode.PlaceholderText = n1;
            if (Alignment is Godot.HorizontalAlignment n2)
                castedNode.Alignment = n2;
            if (MaxLength is System.Int32 n3)
                castedNode.MaxLength = n3;
            if (Editable is System.Boolean n4)
                castedNode.Editable = n4;
            if (ExpandToTextLength is System.Boolean n5)
                castedNode.ExpandToTextLength = n5;
            if (ContextMenuEnabled is System.Boolean n6)
                castedNode.ContextMenuEnabled = n6;
            if (VirtualKeyboardEnabled is System.Boolean n7)
                castedNode.VirtualKeyboardEnabled = n7;
            if (VirtualKeyboardType is Godot.LineEdit.VirtualKeyboardTypeEnum n8)
                castedNode.VirtualKeyboardType = n8;
            if (ClearButtonEnabled is System.Boolean n9)
                castedNode.ClearButtonEnabled = n9;
            if (ShortcutKeysEnabled is System.Boolean n10)
                castedNode.ShortcutKeysEnabled = n10;
            if (MiddleMousePasteEnabled is System.Boolean n11)
                castedNode.MiddleMousePasteEnabled = n11;
            if (SelectingEnabled is System.Boolean n12)
                castedNode.SelectingEnabled = n12;
            if (DeselectOnFocusLossEnabled is System.Boolean n13)
                castedNode.DeselectOnFocusLossEnabled = n13;
            if (DragAndDropSelectionEnabled is System.Boolean n14)
                castedNode.DragAndDropSelectionEnabled = n14;
            if (RightIcon is Godot.Texture2D n15)
                castedNode.RightIcon = n15;
            if (Flat is System.Boolean n16)
                castedNode.Flat = n16;
            if (DrawControlChars is System.Boolean n17)
                castedNode.DrawControlChars = n17;
            if (SelectAllOnFocus is System.Boolean n18)
                castedNode.SelectAllOnFocus = n18;
            if (CaretBlink is System.Boolean n19)
                castedNode.CaretBlink = n19;
            if (CaretBlinkInterval is System.Single n20)
                castedNode.CaretBlinkInterval = n20;
            if (CaretColumn is System.Int32 n21)
                castedNode.CaretColumn = n21;
            if (CaretForceDisplayed is System.Boolean n22)
                castedNode.CaretForceDisplayed = n22;
            if (CaretMidGrapheme is System.Boolean n23)
                castedNode.CaretMidGrapheme = n23;
            if (Secret is System.Boolean n24)
                castedNode.Secret = n24;
            if (SecretCharacter is System.String n25)
                castedNode.SecretCharacter = n25;
            if (TextDirection is Godot.Control.TextDirection n26)
                castedNode.TextDirection = n26;
            if (Language is System.String n27)
                castedNode.Language = n27;
            if (StructuredTextBidiOverride is Godot.TextServer.StructuredTextParser n28)
                castedNode.StructuredTextBidiOverride = n28;
            if (StructuredTextBidiOverrideOptions is Godot.Collections.Array n29)
                castedNode.StructuredTextBidiOverrideOptions = n29;
            if (TextChanged is Godot.LineEdit.TextChangedEventHandler e0)
                castedNode.TextChanged += e0;
            if (TextChangeRejected is Godot.LineEdit.TextChangeRejectedEventHandler e1)
                castedNode.TextChangeRejected += e1;
            if (TextSubmitted is Godot.LineEdit.TextSubmittedEventHandler e2)
                castedNode.TextSubmitted += e2;
        }
    }
}