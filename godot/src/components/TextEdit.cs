namespace ReactiveSharpGodot.Components
{
    public class TextEdit : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GTextEdit>
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
        public System.Boolean? ClipContents { protected get; init; }
        public Godot.Vector2? CustomMinimumSize { protected get; init; }
        public Godot.Control.LayoutDirectionEnum? LayoutDirection { protected get; init; }
        public System.Int32? LayoutMode { protected get; init; }
        public System.Int32? AnchorsPreset { protected get; init; }
        public System.Single? AnchorLeft { protected get; init; }
        public System.Single? AnchorTop { protected get; init; }
        public System.Single? AnchorRight { protected get; init; }
        public System.Single? AnchorBottom { protected get; init; }
        public System.Single? OffsetLeft { protected get; init; }
        public System.Single? OffsetTop { protected get; init; }
        public System.Single? OffsetRight { protected get; init; }
        public System.Single? OffsetBottom { protected get; init; }
        public Godot.Control.GrowDirection? GrowHorizontal { protected get; init; }
        public Godot.Control.GrowDirection? GrowVertical { protected get; init; }
        public Godot.Vector2? Size { protected get; init; }
        public Godot.Vector2? Position { protected get; init; }
        public Godot.Vector2? GlobalPosition { protected get; init; }
        public System.Single? Rotation { protected get; init; }
        public System.Single? RotationDegrees { protected get; init; }
        public Godot.Vector2? Scale { protected get; init; }
        public Godot.Vector2? PivotOffset { protected get; init; }
        public Godot.Control.SizeFlags? SizeFlagsHorizontal { protected get; init; }
        public Godot.Control.SizeFlags? SizeFlagsVertical { protected get; init; }
        public System.Single? SizeFlagsStretchRatio { protected get; init; }
        public System.Boolean? LocalizeNumeralSystem { protected get; init; }
        public System.Boolean? AutoTranslate { protected get; init; }
        public System.String? TooltipText { protected get; init; }
        public Godot.NodePath? FocusNeighborLeft { protected get; init; }
        public Godot.NodePath? FocusNeighborTop { protected get; init; }
        public Godot.NodePath? FocusNeighborRight { protected get; init; }
        public Godot.NodePath? FocusNeighborBottom { protected get; init; }
        public Godot.NodePath? FocusNext { protected get; init; }
        public Godot.NodePath? FocusPrevious { protected get; init; }
        public Godot.Control.FocusModeEnum? FocusMode { protected get; init; }
        public Godot.Control.MouseFilterEnum? MouseFilter { protected get; init; }
        public System.Boolean? MouseForcePassScrollEvents { protected get; init; }
        public Godot.Control.CursorShape? MouseDefaultCursorShape { protected get; init; }
        public Godot.Node? ShortcutContext { protected get; init; }
        public Godot.Theme? Theme { protected get; init; }
        public Godot.StringName? ThemeTypeVariation { protected get; init; }
        public System.Boolean? Visible { protected get; init; }
        public Godot.Color? Modulate { protected get; init; }
        public Godot.Color? SelfModulate { protected get; init; }
        public System.Boolean? ShowBehindParent { protected get; init; }
        public System.Boolean? TopLevel { protected get; init; }
        public Godot.CanvasItem.ClipChildrenMode? ClipChildren { protected get; init; }
        public System.Int32? LightMask { protected get; init; }
        public System.UInt32? VisibilityLayer { protected get; init; }
        public System.Int32? ZIndex { protected get; init; }
        public System.Boolean? ZAsRelative { protected get; init; }
        public System.Boolean? YSortEnabled { protected get; init; }
        public Godot.CanvasItem.TextureFilterEnum? TextureFilter { protected get; init; }
        public Godot.CanvasItem.TextureRepeatEnum? TextureRepeat { protected get; init; }
        public Godot.Material? Material { protected get; init; }
        public System.Boolean? UseParentMaterial { protected get; init; }
        public Godot.StringName? Name { protected get; init; }
        public System.Boolean? UniqueNameInOwner { protected get; init; }
        public System.String? SceneFilePath { protected get; init; }
        public Godot.Node? Owner { protected get; init; }
        public Godot.Node.ProcessModeEnum? ProcessMode { protected get; init; }
        public System.Int32? ProcessPriority { protected get; init; }
        public System.Int32? ProcessPhysicsPriority { protected get; init; }
        public Godot.Node.ProcessThreadGroupEnum? ProcessThreadGroup { protected get; init; }
        public System.Int32? ProcessThreadGroupOrder { protected get; init; }
        public Godot.Node.ProcessThreadMessagesEnum? ProcessThreadMessages { protected get; init; }
        public Godot.Node.PhysicsInterpolationModeEnum? PhysicsInterpolationMode { protected get; init; }
        public Godot.Node.AutoTranslateModeEnum? AutoTranslateMode { protected get; init; }
        public System.String? EditorDescription { protected get; init; }
        public System.Action? TextSet { protected get; init; }
        public System.Action? TextChanged { protected get; init; }
        public Godot.TextEdit.LinesEditedFromEventHandler? LinesEditedFrom { protected get; init; }
        public System.Action? CaretChanged { protected get; init; }
        public Godot.TextEdit.GutterClickedEventHandler? GutterClicked { protected get; init; }
        public System.Action? GutterAdded { protected get; init; }
        public System.Action? GutterRemoved { protected get; init; }
        public System.Action? Resized { protected get; init; }
        public Godot.Control.GuiInputEventHandler? GuiInput { protected get; init; }
        public System.Action? MouseEntered { protected get; init; }
        public System.Action? MouseExited { protected get; init; }
        public System.Action? FocusEntered { protected get; init; }
        public System.Action? FocusExited { protected get; init; }
        public System.Action? SizeFlagsChanged { protected get; init; }
        public System.Action? MinimumSizeChanged { protected get; init; }
        public System.Action? ThemeChanged { protected get; init; }
        public System.Action? Draw { protected get; init; }
        public System.Action? VisibilityChanged { protected get; init; }
        public System.Action? Hidden { protected get; init; }
        public System.Action? ItemRectChanged { protected get; init; }
        public System.Action? Ready { protected get; init; }
        public System.Action? Renamed { protected get; init; }
        public System.Action? TreeEntered { protected get; init; }
        public System.Action? TreeExiting { protected get; init; }
        public System.Action? TreeExited { protected get; init; }
        public Godot.Node.ChildEnteredTreeEventHandler? ChildEnteredTree { protected get; init; }
        public Godot.Node.ChildExitingTreeEventHandler? ChildExitingTree { protected get; init; }
        public System.Action? ChildOrderChanged { protected get; init; }
        public Godot.Node.ReplacingByEventHandler? ReplacingBy { protected get; init; }
        public Godot.Node.EditorDescriptionChangedEventHandler? EditorDescriptionChanged { protected get; init; }
        public System.Action? ScriptChanged { protected get; init; }
        public System.Action? PropertyListChanged { protected get; init; }

        public override ReactiveSharpGodot.Nodes.GTextEdit Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GTextEdit();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GTextEdit node)
        {
            var castedNode = (Godot.TextEdit)node.Node;
            if (Text is System.String n0)
            {
                NodeStateManager.AddPropertyState(castedNode, "Text", castedNode.Text);
                castedNode.Text = n0;
            }

            if (PlaceholderText is System.String n1)
            {
                NodeStateManager.AddPropertyState(castedNode, "PlaceholderText", castedNode.PlaceholderText);
                castedNode.PlaceholderText = n1;
            }

            if (Editable is System.Boolean n2)
            {
                NodeStateManager.AddPropertyState(castedNode, "Editable", castedNode.Editable);
                castedNode.Editable = n2;
            }

            if (ContextMenuEnabled is System.Boolean n3)
            {
                NodeStateManager.AddPropertyState(castedNode, "ContextMenuEnabled", castedNode.ContextMenuEnabled);
                castedNode.ContextMenuEnabled = n3;
            }

            if (ShortcutKeysEnabled is System.Boolean n4)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutKeysEnabled", castedNode.ShortcutKeysEnabled);
                castedNode.ShortcutKeysEnabled = n4;
            }

            if (SelectingEnabled is System.Boolean n5)
            {
                NodeStateManager.AddPropertyState(castedNode, "SelectingEnabled", castedNode.SelectingEnabled);
                castedNode.SelectingEnabled = n5;
            }

            if (DeselectOnFocusLossEnabled is System.Boolean n6)
            {
                NodeStateManager.AddPropertyState(castedNode, "DeselectOnFocusLossEnabled", castedNode.DeselectOnFocusLossEnabled);
                castedNode.DeselectOnFocusLossEnabled = n6;
            }

            if (DragAndDropSelectionEnabled is System.Boolean n7)
            {
                NodeStateManager.AddPropertyState(castedNode, "DragAndDropSelectionEnabled", castedNode.DragAndDropSelectionEnabled);
                castedNode.DragAndDropSelectionEnabled = n7;
            }

            if (VirtualKeyboardEnabled is System.Boolean n8)
            {
                NodeStateManager.AddPropertyState(castedNode, "VirtualKeyboardEnabled", castedNode.VirtualKeyboardEnabled);
                castedNode.VirtualKeyboardEnabled = n8;
            }

            if (MiddleMousePasteEnabled is System.Boolean n9)
            {
                NodeStateManager.AddPropertyState(castedNode, "MiddleMousePasteEnabled", castedNode.MiddleMousePasteEnabled);
                castedNode.MiddleMousePasteEnabled = n9;
            }

            if (WrapMode is Godot.TextEdit.LineWrappingMode n10)
            {
                NodeStateManager.AddPropertyState(castedNode, "WrapMode", castedNode.WrapMode);
                castedNode.WrapMode = n10;
            }

            if (AutowrapMode is Godot.TextServer.AutowrapMode n11)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutowrapMode", castedNode.AutowrapMode);
                castedNode.AutowrapMode = n11;
            }

            if (IndentWrappedLines is System.Boolean n12)
            {
                NodeStateManager.AddPropertyState(castedNode, "IndentWrappedLines", castedNode.IndentWrappedLines);
                castedNode.IndentWrappedLines = n12;
            }

            if (ScrollSmooth is System.Boolean n13)
            {
                NodeStateManager.AddPropertyState(castedNode, "ScrollSmooth", castedNode.ScrollSmooth);
                castedNode.ScrollSmooth = n13;
            }

            if (ScrollVScrollSpeed is System.Single n14)
            {
                NodeStateManager.AddPropertyState(castedNode, "ScrollVScrollSpeed", castedNode.ScrollVScrollSpeed);
                castedNode.ScrollVScrollSpeed = n14;
            }

            if (ScrollPastEndOfFile is System.Boolean n15)
            {
                NodeStateManager.AddPropertyState(castedNode, "ScrollPastEndOfFile", castedNode.ScrollPastEndOfFile);
                castedNode.ScrollPastEndOfFile = n15;
            }

            if (ScrollVertical is System.Double n16)
            {
                NodeStateManager.AddPropertyState(castedNode, "ScrollVertical", castedNode.ScrollVertical);
                castedNode.ScrollVertical = n16;
            }

            if (ScrollHorizontal is System.Int32 n17)
            {
                NodeStateManager.AddPropertyState(castedNode, "ScrollHorizontal", castedNode.ScrollHorizontal);
                castedNode.ScrollHorizontal = n17;
            }

            if (ScrollFitContentHeight is System.Boolean n18)
            {
                NodeStateManager.AddPropertyState(castedNode, "ScrollFitContentHeight", castedNode.ScrollFitContentHeight);
                castedNode.ScrollFitContentHeight = n18;
            }

            if (MinimapDraw is System.Boolean n19)
            {
                NodeStateManager.AddPropertyState(castedNode, "MinimapDraw", castedNode.MinimapDraw);
                castedNode.MinimapDraw = n19;
            }

            if (MinimapWidth is System.Int32 n20)
            {
                NodeStateManager.AddPropertyState(castedNode, "MinimapWidth", castedNode.MinimapWidth);
                castedNode.MinimapWidth = n20;
            }

            if (CaretType is Godot.TextEdit.CaretTypeEnum n21)
            {
                NodeStateManager.AddPropertyState(castedNode, "CaretType", castedNode.CaretType);
                castedNode.CaretType = n21;
            }

            if (CaretBlink is System.Boolean n22)
            {
                NodeStateManager.AddPropertyState(castedNode, "CaretBlink", castedNode.CaretBlink);
                castedNode.CaretBlink = n22;
            }

            if (CaretBlinkInterval is System.Single n23)
            {
                NodeStateManager.AddPropertyState(castedNode, "CaretBlinkInterval", castedNode.CaretBlinkInterval);
                castedNode.CaretBlinkInterval = n23;
            }

            if (CaretDrawWhenEditableDisabled is System.Boolean n24)
            {
                NodeStateManager.AddPropertyState(castedNode, "CaretDrawWhenEditableDisabled", castedNode.CaretDrawWhenEditableDisabled);
                castedNode.CaretDrawWhenEditableDisabled = n24;
            }

            if (CaretMoveOnRightClick is System.Boolean n25)
            {
                NodeStateManager.AddPropertyState(castedNode, "CaretMoveOnRightClick", castedNode.CaretMoveOnRightClick);
                castedNode.CaretMoveOnRightClick = n25;
            }

            if (CaretMidGrapheme is System.Boolean n26)
            {
                NodeStateManager.AddPropertyState(castedNode, "CaretMidGrapheme", castedNode.CaretMidGrapheme);
                castedNode.CaretMidGrapheme = n26;
            }

            if (CaretMultiple is System.Boolean n27)
            {
                NodeStateManager.AddPropertyState(castedNode, "CaretMultiple", castedNode.CaretMultiple);
                castedNode.CaretMultiple = n27;
            }

            if (UseDefaultWordSeparators is System.Boolean n28)
            {
                NodeStateManager.AddPropertyState(castedNode, "UseDefaultWordSeparators", castedNode.UseDefaultWordSeparators);
                castedNode.UseDefaultWordSeparators = n28;
            }

            if (UseCustomWordSeparators is System.Boolean n29)
            {
                NodeStateManager.AddPropertyState(castedNode, "UseCustomWordSeparators", castedNode.UseCustomWordSeparators);
                castedNode.UseCustomWordSeparators = n29;
            }

            if (CustomWordSeparators is System.String n30)
            {
                NodeStateManager.AddPropertyState(castedNode, "CustomWordSeparators", castedNode.CustomWordSeparators);
                castedNode.CustomWordSeparators = n30;
            }

            if (SyntaxHighlighter is Godot.SyntaxHighlighter n31)
            {
                NodeStateManager.AddPropertyState(castedNode, "SyntaxHighlighter", castedNode.SyntaxHighlighter);
                castedNode.SyntaxHighlighter = n31;
            }

            if (HighlightAllOccurrences is System.Boolean n32)
            {
                NodeStateManager.AddPropertyState(castedNode, "HighlightAllOccurrences", castedNode.HighlightAllOccurrences);
                castedNode.HighlightAllOccurrences = n32;
            }

            if (HighlightCurrentLine is System.Boolean n33)
            {
                NodeStateManager.AddPropertyState(castedNode, "HighlightCurrentLine", castedNode.HighlightCurrentLine);
                castedNode.HighlightCurrentLine = n33;
            }

            if (DrawControlChars is System.Boolean n34)
            {
                NodeStateManager.AddPropertyState(castedNode, "DrawControlChars", castedNode.DrawControlChars);
                castedNode.DrawControlChars = n34;
            }

            if (DrawTabs is System.Boolean n35)
            {
                NodeStateManager.AddPropertyState(castedNode, "DrawTabs", castedNode.DrawTabs);
                castedNode.DrawTabs = n35;
            }

            if (DrawSpaces is System.Boolean n36)
            {
                NodeStateManager.AddPropertyState(castedNode, "DrawSpaces", castedNode.DrawSpaces);
                castedNode.DrawSpaces = n36;
            }

            if (TextDirection is Godot.Control.TextDirection n37)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextDirection", castedNode.TextDirection);
                castedNode.TextDirection = n37;
            }

            if (Language is System.String n38)
            {
                NodeStateManager.AddPropertyState(castedNode, "Language", castedNode.Language);
                castedNode.Language = n38;
            }

            if (StructuredTextBidiOverride is Godot.TextServer.StructuredTextParser n39)
            {
                NodeStateManager.AddPropertyState(castedNode, "StructuredTextBidiOverride", castedNode.StructuredTextBidiOverride);
                castedNode.StructuredTextBidiOverride = n39;
            }

            if (StructuredTextBidiOverrideOptions is Godot.Collections.Array n40)
            {
                NodeStateManager.AddPropertyState(castedNode, "StructuredTextBidiOverrideOptions", castedNode.StructuredTextBidiOverrideOptions);
                castedNode.StructuredTextBidiOverrideOptions = n40;
            }

            if (ClipContents is System.Boolean n41)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipContents", castedNode.ClipContents);
                castedNode.ClipContents = n41;
            }

            if (CustomMinimumSize is Godot.Vector2 n42)
            {
                NodeStateManager.AddPropertyState(castedNode, "CustomMinimumSize", castedNode.CustomMinimumSize);
                castedNode.CustomMinimumSize = n42;
            }

            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n43)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutDirection", castedNode.LayoutDirection);
                castedNode.LayoutDirection = n43;
            }

            if (LayoutMode is System.Int32 n44)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutMode", castedNode.LayoutMode);
                castedNode.LayoutMode = n44;
            }

            if (AnchorsPreset is System.Int32 n45)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorsPreset", castedNode.AnchorsPreset);
                castedNode.AnchorsPreset = n45;
            }

            if (AnchorLeft is System.Single n46)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorLeft", castedNode.AnchorLeft);
                castedNode.AnchorLeft = n46;
            }

            if (AnchorTop is System.Single n47)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorTop", castedNode.AnchorTop);
                castedNode.AnchorTop = n47;
            }

            if (AnchorRight is System.Single n48)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorRight", castedNode.AnchorRight);
                castedNode.AnchorRight = n48;
            }

            if (AnchorBottom is System.Single n49)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorBottom", castedNode.AnchorBottom);
                castedNode.AnchorBottom = n49;
            }

            if (OffsetLeft is System.Single n50)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetLeft", castedNode.OffsetLeft);
                castedNode.OffsetLeft = n50;
            }

            if (OffsetTop is System.Single n51)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetTop", castedNode.OffsetTop);
                castedNode.OffsetTop = n51;
            }

            if (OffsetRight is System.Single n52)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetRight", castedNode.OffsetRight);
                castedNode.OffsetRight = n52;
            }

            if (OffsetBottom is System.Single n53)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetBottom", castedNode.OffsetBottom);
                castedNode.OffsetBottom = n53;
            }

            if (GrowHorizontal is Godot.Control.GrowDirection n54)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowHorizontal", castedNode.GrowHorizontal);
                castedNode.GrowHorizontal = n54;
            }

            if (GrowVertical is Godot.Control.GrowDirection n55)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowVertical", castedNode.GrowVertical);
                castedNode.GrowVertical = n55;
            }

            if (Size is Godot.Vector2 n56)
            {
                NodeStateManager.AddPropertyState(castedNode, "Size", castedNode.Size);
                castedNode.Size = n56;
            }

            if (Position is Godot.Vector2 n57)
            {
                NodeStateManager.AddPropertyState(castedNode, "Position", castedNode.Position);
                castedNode.Position = n57;
            }

            if (GlobalPosition is Godot.Vector2 n58)
            {
                NodeStateManager.AddPropertyState(castedNode, "GlobalPosition", castedNode.GlobalPosition);
                castedNode.GlobalPosition = n58;
            }

            if (Rotation is System.Single n59)
            {
                NodeStateManager.AddPropertyState(castedNode, "Rotation", castedNode.Rotation);
                castedNode.Rotation = n59;
            }

            if (RotationDegrees is System.Single n60)
            {
                NodeStateManager.AddPropertyState(castedNode, "RotationDegrees", castedNode.RotationDegrees);
                castedNode.RotationDegrees = n60;
            }

            if (Scale is Godot.Vector2 n61)
            {
                NodeStateManager.AddPropertyState(castedNode, "Scale", castedNode.Scale);
                castedNode.Scale = n61;
            }

            if (PivotOffset is Godot.Vector2 n62)
            {
                NodeStateManager.AddPropertyState(castedNode, "PivotOffset", castedNode.PivotOffset);
                castedNode.PivotOffset = n62;
            }

            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n63)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsHorizontal", castedNode.SizeFlagsHorizontal);
                castedNode.SizeFlagsHorizontal = n63;
            }

            if (SizeFlagsVertical is Godot.Control.SizeFlags n64)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsVertical", castedNode.SizeFlagsVertical);
                castedNode.SizeFlagsVertical = n64;
            }

            if (SizeFlagsStretchRatio is System.Single n65)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsStretchRatio", castedNode.SizeFlagsStretchRatio);
                castedNode.SizeFlagsStretchRatio = n65;
            }

            if (LocalizeNumeralSystem is System.Boolean n66)
            {
                NodeStateManager.AddPropertyState(castedNode, "LocalizeNumeralSystem", castedNode.LocalizeNumeralSystem);
                castedNode.LocalizeNumeralSystem = n66;
            }

            if (AutoTranslate is System.Boolean n67)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslate", castedNode.AutoTranslate);
                castedNode.AutoTranslate = n67;
            }

            if (TooltipText is System.String n68)
            {
                NodeStateManager.AddPropertyState(castedNode, "TooltipText", castedNode.TooltipText);
                castedNode.TooltipText = n68;
            }

            if (FocusNeighborLeft is Godot.NodePath n69)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborLeft", castedNode.FocusNeighborLeft);
                castedNode.FocusNeighborLeft = n69;
            }

            if (FocusNeighborTop is Godot.NodePath n70)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborTop", castedNode.FocusNeighborTop);
                castedNode.FocusNeighborTop = n70;
            }

            if (FocusNeighborRight is Godot.NodePath n71)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborRight", castedNode.FocusNeighborRight);
                castedNode.FocusNeighborRight = n71;
            }

            if (FocusNeighborBottom is Godot.NodePath n72)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborBottom", castedNode.FocusNeighborBottom);
                castedNode.FocusNeighborBottom = n72;
            }

            if (FocusNext is Godot.NodePath n73)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNext", castedNode.FocusNext);
                castedNode.FocusNext = n73;
            }

            if (FocusPrevious is Godot.NodePath n74)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusPrevious", castedNode.FocusPrevious);
                castedNode.FocusPrevious = n74;
            }

            if (FocusMode is Godot.Control.FocusModeEnum n75)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusMode", castedNode.FocusMode);
                castedNode.FocusMode = n75;
            }

            if (MouseFilter is Godot.Control.MouseFilterEnum n76)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseFilter", castedNode.MouseFilter);
                castedNode.MouseFilter = n76;
            }

            if (MouseForcePassScrollEvents is System.Boolean n77)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseForcePassScrollEvents", castedNode.MouseForcePassScrollEvents);
                castedNode.MouseForcePassScrollEvents = n77;
            }

            if (MouseDefaultCursorShape is Godot.Control.CursorShape n78)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseDefaultCursorShape", castedNode.MouseDefaultCursorShape);
                castedNode.MouseDefaultCursorShape = n78;
            }

            if (ShortcutContext is Godot.Node n79)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutContext", castedNode.ShortcutContext);
                castedNode.ShortcutContext = n79;
            }

            if (Theme is Godot.Theme n80)
            {
                NodeStateManager.AddPropertyState(castedNode, "Theme", castedNode.Theme);
                castedNode.Theme = n80;
            }

            if (ThemeTypeVariation is Godot.StringName n81)
            {
                NodeStateManager.AddPropertyState(castedNode, "ThemeTypeVariation", castedNode.ThemeTypeVariation);
                castedNode.ThemeTypeVariation = n81;
            }

            if (Visible is System.Boolean n82)
            {
                NodeStateManager.AddPropertyState(castedNode, "Visible", castedNode.Visible);
                castedNode.Visible = n82;
            }

            if (Modulate is Godot.Color n83)
            {
                NodeStateManager.AddPropertyState(castedNode, "Modulate", castedNode.Modulate);
                castedNode.Modulate = n83;
            }

            if (SelfModulate is Godot.Color n84)
            {
                NodeStateManager.AddPropertyState(castedNode, "SelfModulate", castedNode.SelfModulate);
                castedNode.SelfModulate = n84;
            }

            if (ShowBehindParent is System.Boolean n85)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowBehindParent", castedNode.ShowBehindParent);
                castedNode.ShowBehindParent = n85;
            }

            if (TopLevel is System.Boolean n86)
            {
                NodeStateManager.AddPropertyState(castedNode, "TopLevel", castedNode.TopLevel);
                castedNode.TopLevel = n86;
            }

            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n87)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipChildren", castedNode.ClipChildren);
                castedNode.ClipChildren = n87;
            }

            if (LightMask is System.Int32 n88)
            {
                NodeStateManager.AddPropertyState(castedNode, "LightMask", castedNode.LightMask);
                castedNode.LightMask = n88;
            }

            if (VisibilityLayer is System.UInt32 n89)
            {
                NodeStateManager.AddPropertyState(castedNode, "VisibilityLayer", castedNode.VisibilityLayer);
                castedNode.VisibilityLayer = n89;
            }

            if (ZIndex is System.Int32 n90)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZIndex", castedNode.ZIndex);
                castedNode.ZIndex = n90;
            }

            if (ZAsRelative is System.Boolean n91)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZAsRelative", castedNode.ZAsRelative);
                castedNode.ZAsRelative = n91;
            }

            if (YSortEnabled is System.Boolean n92)
            {
                NodeStateManager.AddPropertyState(castedNode, "YSortEnabled", castedNode.YSortEnabled);
                castedNode.YSortEnabled = n92;
            }

            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n93)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureFilter", castedNode.TextureFilter);
                castedNode.TextureFilter = n93;
            }

            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n94)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureRepeat", castedNode.TextureRepeat);
                castedNode.TextureRepeat = n94;
            }

            if (Material is Godot.Material n95)
            {
                NodeStateManager.AddPropertyState(castedNode, "Material", castedNode.Material);
                castedNode.Material = n95;
            }

            if (UseParentMaterial is System.Boolean n96)
            {
                NodeStateManager.AddPropertyState(castedNode, "UseParentMaterial", castedNode.UseParentMaterial);
                castedNode.UseParentMaterial = n96;
            }

            if (Name is Godot.StringName n97)
            {
                NodeStateManager.AddPropertyState(castedNode, "Name", castedNode.Name);
                castedNode.Name = n97;
            }

            if (UniqueNameInOwner is System.Boolean n98)
            {
                NodeStateManager.AddPropertyState(castedNode, "UniqueNameInOwner", castedNode.UniqueNameInOwner);
                castedNode.UniqueNameInOwner = n98;
            }

            if (SceneFilePath is System.String n99)
            {
                NodeStateManager.AddPropertyState(castedNode, "SceneFilePath", castedNode.SceneFilePath);
                castedNode.SceneFilePath = n99;
            }

            if (Owner is Godot.Node n100)
            {
                NodeStateManager.AddPropertyState(castedNode, "Owner", castedNode.Owner);
                castedNode.Owner = n100;
            }

            if (ProcessMode is Godot.Node.ProcessModeEnum n101)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessMode", castedNode.ProcessMode);
                castedNode.ProcessMode = n101;
            }

            if (ProcessPriority is System.Int32 n102)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPriority", castedNode.ProcessPriority);
                castedNode.ProcessPriority = n102;
            }

            if (ProcessPhysicsPriority is System.Int32 n103)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPhysicsPriority", castedNode.ProcessPhysicsPriority);
                castedNode.ProcessPhysicsPriority = n103;
            }

            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n104)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroup", castedNode.ProcessThreadGroup);
                castedNode.ProcessThreadGroup = n104;
            }

            if (ProcessThreadGroupOrder is System.Int32 n105)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroupOrder", castedNode.ProcessThreadGroupOrder);
                castedNode.ProcessThreadGroupOrder = n105;
            }

            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n106)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadMessages", castedNode.ProcessThreadMessages);
                castedNode.ProcessThreadMessages = n106;
            }

            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n107)
            {
                NodeStateManager.AddPropertyState(castedNode, "PhysicsInterpolationMode", castedNode.PhysicsInterpolationMode);
                castedNode.PhysicsInterpolationMode = n107;
            }

            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n108)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslateMode", castedNode.AutoTranslateMode);
                castedNode.AutoTranslateMode = n108;
            }

            if (EditorDescription is System.String n109)
            {
                NodeStateManager.AddPropertyState(castedNode, "EditorDescription", castedNode.EditorDescription);
                castedNode.EditorDescription = n109;
            }

            if (TextSet is System.Action e0)
            {
                NodeStateManager.AddEventHandler(castedNode, "TextSet", e0);
                castedNode.TextSet += e0;
            }

            if (TextChanged is System.Action e1)
            {
                NodeStateManager.AddEventHandler(castedNode, "TextChanged", e1);
                castedNode.TextChanged += e1;
            }

            if (LinesEditedFrom is Godot.TextEdit.LinesEditedFromEventHandler e2)
            {
                NodeStateManager.AddEventHandler(castedNode, "LinesEditedFrom", e2);
                castedNode.LinesEditedFrom += e2;
            }

            if (CaretChanged is System.Action e3)
            {
                NodeStateManager.AddEventHandler(castedNode, "CaretChanged", e3);
                castedNode.CaretChanged += e3;
            }

            if (GutterClicked is Godot.TextEdit.GutterClickedEventHandler e4)
            {
                NodeStateManager.AddEventHandler(castedNode, "GutterClicked", e4);
                castedNode.GutterClicked += e4;
            }

            if (GutterAdded is System.Action e5)
            {
                NodeStateManager.AddEventHandler(castedNode, "GutterAdded", e5);
                castedNode.GutterAdded += e5;
            }

            if (GutterRemoved is System.Action e6)
            {
                NodeStateManager.AddEventHandler(castedNode, "GutterRemoved", e6);
                castedNode.GutterRemoved += e6;
            }

            if (Resized is System.Action e7)
            {
                NodeStateManager.AddEventHandler(castedNode, "Resized", e7);
                castedNode.Resized += e7;
            }

            if (GuiInput is Godot.Control.GuiInputEventHandler e8)
            {
                NodeStateManager.AddEventHandler(castedNode, "GuiInput", e8);
                castedNode.GuiInput += e8;
            }

            if (MouseEntered is System.Action e9)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseEntered", e9);
                castedNode.MouseEntered += e9;
            }

            if (MouseExited is System.Action e10)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseExited", e10);
                castedNode.MouseExited += e10;
            }

            if (FocusEntered is System.Action e11)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusEntered", e11);
                castedNode.FocusEntered += e11;
            }

            if (FocusExited is System.Action e12)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusExited", e12);
                castedNode.FocusExited += e12;
            }

            if (SizeFlagsChanged is System.Action e13)
            {
                NodeStateManager.AddEventHandler(castedNode, "SizeFlagsChanged", e13);
                castedNode.SizeFlagsChanged += e13;
            }

            if (MinimumSizeChanged is System.Action e14)
            {
                NodeStateManager.AddEventHandler(castedNode, "MinimumSizeChanged", e14);
                castedNode.MinimumSizeChanged += e14;
            }

            if (ThemeChanged is System.Action e15)
            {
                NodeStateManager.AddEventHandler(castedNode, "ThemeChanged", e15);
                castedNode.ThemeChanged += e15;
            }

            if (Draw is System.Action e16)
            {
                NodeStateManager.AddEventHandler(castedNode, "Draw", e16);
                castedNode.Draw += e16;
            }

            if (VisibilityChanged is System.Action e17)
            {
                NodeStateManager.AddEventHandler(castedNode, "VisibilityChanged", e17);
                castedNode.VisibilityChanged += e17;
            }

            if (Hidden is System.Action e18)
            {
                NodeStateManager.AddEventHandler(castedNode, "Hidden", e18);
                castedNode.Hidden += e18;
            }

            if (ItemRectChanged is System.Action e19)
            {
                NodeStateManager.AddEventHandler(castedNode, "ItemRectChanged", e19);
                castedNode.ItemRectChanged += e19;
            }

            if (Ready is System.Action e20)
            {
                NodeStateManager.AddEventHandler(castedNode, "Ready", e20);
                castedNode.Ready += e20;
            }

            if (Renamed is System.Action e21)
            {
                NodeStateManager.AddEventHandler(castedNode, "Renamed", e21);
                castedNode.Renamed += e21;
            }

            if (TreeEntered is System.Action e22)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeEntered", e22);
                castedNode.TreeEntered += e22;
            }

            if (TreeExiting is System.Action e23)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExiting", e23);
                castedNode.TreeExiting += e23;
            }

            if (TreeExited is System.Action e24)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExited", e24);
                castedNode.TreeExited += e24;
            }

            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e25)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildEnteredTree", e25);
                castedNode.ChildEnteredTree += e25;
            }

            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e26)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildExitingTree", e26);
                castedNode.ChildExitingTree += e26;
            }

            if (ChildOrderChanged is System.Action e27)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildOrderChanged", e27);
                castedNode.ChildOrderChanged += e27;
            }

            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e28)
            {
                NodeStateManager.AddEventHandler(castedNode, "ReplacingBy", e28);
                castedNode.ReplacingBy += e28;
            }

            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e29)
            {
                NodeStateManager.AddEventHandler(castedNode, "EditorDescriptionChanged", e29);
                castedNode.EditorDescriptionChanged += e29;
            }

            if (ScriptChanged is System.Action e30)
            {
                NodeStateManager.AddEventHandler(castedNode, "ScriptChanged", e30);
                castedNode.ScriptChanged += e30;
            }

            if (PropertyListChanged is System.Action e31)
            {
                NodeStateManager.AddEventHandler(castedNode, "PropertyListChanged", e31);
                castedNode.PropertyListChanged += e31;
            }
        }
    }
}