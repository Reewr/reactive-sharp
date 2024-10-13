namespace ReactiveSharpGodot.Components
{
    public class TextEdit : Control
    {
        public System.String? Text { protected get; init; }
        public System.String? PlaceholderText { protected get; init; }
        public System.Boolean? Editable { protected get; init; }
        public System.Boolean? ContextMenuEnabled { protected get; init; }
        public System.Boolean? ShortcutKeysEnabled { protected get; init; }
        public System.Boolean? SelectingEnabled { protected get; init; }
        public System.Boolean? DeselectOnFocusLossEnabled { protected get; init; }
        public System.Boolean? DragAndDropSelectionEnabled { protected get; init; }
        public System.Boolean? VirtualKeyboardEnabled { protected get; init; }
        public System.Boolean? MiddleMousePasteEnabled { protected get; init; }
        public Godot.TextEdit.LineWrappingMode? WrapMode { protected get; init; }
        public Godot.TextServer.AutowrapMode? AutowrapMode { protected get; init; }
        public System.Boolean? IndentWrappedLines { protected get; init; }
        public System.Boolean? ScrollSmooth { protected get; init; }
        public System.Single? ScrollVScrollSpeed { protected get; init; }
        public System.Boolean? ScrollPastEndOfFile { protected get; init; }
        public System.Double? ScrollVertical { protected get; init; }
        public System.Int32? ScrollHorizontal { protected get; init; }
        public System.Boolean? ScrollFitContentHeight { protected get; init; }
        public System.Boolean? MinimapDraw { protected get; init; }
        public System.Int32? MinimapWidth { protected get; init; }
        public Godot.TextEdit.CaretTypeEnum? CaretType { protected get; init; }
        public System.Boolean? CaretBlink { protected get; init; }
        public System.Single? CaretBlinkInterval { protected get; init; }
        public System.Boolean? CaretDrawWhenEditableDisabled { protected get; init; }
        public System.Boolean? CaretMoveOnRightClick { protected get; init; }
        public System.Boolean? CaretMidGrapheme { protected get; init; }
        public System.Boolean? CaretMultiple { protected get; init; }
        public System.Boolean? UseDefaultWordSeparators { protected get; init; }
        public System.Boolean? UseCustomWordSeparators { protected get; init; }
        public System.String? CustomWordSeparators { protected get; init; }
        public Godot.SyntaxHighlighter? SyntaxHighlighter { protected get; init; }
        public System.Boolean? HighlightAllOccurrences { protected get; init; }
        public System.Boolean? HighlightCurrentLine { protected get; init; }
        public System.Boolean? DrawControlChars { protected get; init; }
        public System.Boolean? DrawTabs { protected get; init; }
        public System.Boolean? DrawSpaces { protected get; init; }
        public Godot.Control.TextDirection? TextDirection { protected get; init; }
        public System.String? Language { protected get; init; }
        public Godot.TextServer.StructuredTextParser? StructuredTextBidiOverride { protected get; init; }
        public Godot.Collections.Array? StructuredTextBidiOverrideOptions { protected get; init; }
        public System.Action? TextSet { protected get; init; }
        public System.Action? TextChanged { protected get; init; }
        public Godot.TextEdit.LinesEditedFromEventHandler? LinesEditedFrom { protected get; init; }
        public System.Action? CaretChanged { protected get; init; }
        public Godot.TextEdit.GutterClickedEventHandler? GutterClicked { protected get; init; }
        public System.Action? GutterAdded { protected get; init; }
        public System.Action? GutterRemoved { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GTextEdit(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.TextEdit)node.Node;
            base.UpdateProperties(node);
            if (Text is System.String n0)
                castedNode.Text = n0;
            if (PlaceholderText is System.String n1)
                castedNode.PlaceholderText = n1;
            if (Editable is System.Boolean n2)
                castedNode.Editable = n2;
            if (ContextMenuEnabled is System.Boolean n3)
                castedNode.ContextMenuEnabled = n3;
            if (ShortcutKeysEnabled is System.Boolean n4)
                castedNode.ShortcutKeysEnabled = n4;
            if (SelectingEnabled is System.Boolean n5)
                castedNode.SelectingEnabled = n5;
            if (DeselectOnFocusLossEnabled is System.Boolean n6)
                castedNode.DeselectOnFocusLossEnabled = n6;
            if (DragAndDropSelectionEnabled is System.Boolean n7)
                castedNode.DragAndDropSelectionEnabled = n7;
            if (VirtualKeyboardEnabled is System.Boolean n8)
                castedNode.VirtualKeyboardEnabled = n8;
            if (MiddleMousePasteEnabled is System.Boolean n9)
                castedNode.MiddleMousePasteEnabled = n9;
            if (WrapMode is Godot.TextEdit.LineWrappingMode n10)
                castedNode.WrapMode = n10;
            if (AutowrapMode is Godot.TextServer.AutowrapMode n11)
                castedNode.AutowrapMode = n11;
            if (IndentWrappedLines is System.Boolean n12)
                castedNode.IndentWrappedLines = n12;
            if (ScrollSmooth is System.Boolean n13)
                castedNode.ScrollSmooth = n13;
            if (ScrollVScrollSpeed is System.Single n14)
                castedNode.ScrollVScrollSpeed = n14;
            if (ScrollPastEndOfFile is System.Boolean n15)
                castedNode.ScrollPastEndOfFile = n15;
            if (ScrollVertical is System.Double n16)
                castedNode.ScrollVertical = n16;
            if (ScrollHorizontal is System.Int32 n17)
                castedNode.ScrollHorizontal = n17;
            if (ScrollFitContentHeight is System.Boolean n18)
                castedNode.ScrollFitContentHeight = n18;
            if (MinimapDraw is System.Boolean n19)
                castedNode.MinimapDraw = n19;
            if (MinimapWidth is System.Int32 n20)
                castedNode.MinimapWidth = n20;
            if (CaretType is Godot.TextEdit.CaretTypeEnum n21)
                castedNode.CaretType = n21;
            if (CaretBlink is System.Boolean n22)
                castedNode.CaretBlink = n22;
            if (CaretBlinkInterval is System.Single n23)
                castedNode.CaretBlinkInterval = n23;
            if (CaretDrawWhenEditableDisabled is System.Boolean n24)
                castedNode.CaretDrawWhenEditableDisabled = n24;
            if (CaretMoveOnRightClick is System.Boolean n25)
                castedNode.CaretMoveOnRightClick = n25;
            if (CaretMidGrapheme is System.Boolean n26)
                castedNode.CaretMidGrapheme = n26;
            if (CaretMultiple is System.Boolean n27)
                castedNode.CaretMultiple = n27;
            if (UseDefaultWordSeparators is System.Boolean n28)
                castedNode.UseDefaultWordSeparators = n28;
            if (UseCustomWordSeparators is System.Boolean n29)
                castedNode.UseCustomWordSeparators = n29;
            if (CustomWordSeparators is System.String n30)
                castedNode.CustomWordSeparators = n30;
            if (SyntaxHighlighter is Godot.SyntaxHighlighter n31)
                castedNode.SyntaxHighlighter = n31;
            if (HighlightAllOccurrences is System.Boolean n32)
                castedNode.HighlightAllOccurrences = n32;
            if (HighlightCurrentLine is System.Boolean n33)
                castedNode.HighlightCurrentLine = n33;
            if (DrawControlChars is System.Boolean n34)
                castedNode.DrawControlChars = n34;
            if (DrawTabs is System.Boolean n35)
                castedNode.DrawTabs = n35;
            if (DrawSpaces is System.Boolean n36)
                castedNode.DrawSpaces = n36;
            if (TextDirection is Godot.Control.TextDirection n37)
                castedNode.TextDirection = n37;
            if (Language is System.String n38)
                castedNode.Language = n38;
            if (StructuredTextBidiOverride is Godot.TextServer.StructuredTextParser n39)
                castedNode.StructuredTextBidiOverride = n39;
            if (StructuredTextBidiOverrideOptions is Godot.Collections.Array n40)
                castedNode.StructuredTextBidiOverrideOptions = n40;
            if (TextSet is System.Action e0)
                castedNode.TextSet += e0;
            if (TextChanged is System.Action e1)
                castedNode.TextChanged += e1;
            if (LinesEditedFrom is Godot.TextEdit.LinesEditedFromEventHandler e2)
                castedNode.LinesEditedFrom += e2;
            if (CaretChanged is System.Action e3)
                castedNode.CaretChanged += e3;
            if (GutterClicked is Godot.TextEdit.GutterClickedEventHandler e4)
                castedNode.GutterClicked += e4;
            if (GutterAdded is System.Action e5)
                castedNode.GutterAdded += e5;
            if (GutterRemoved is System.Action e6)
                castedNode.GutterRemoved += e6;
        }
    }
}