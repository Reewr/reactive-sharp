// This file is auto-generated. Please do not edit
namespace ReactiveSharpGodot.Components
{
    public class TextEdit : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GTextEdit>
    {
        public System.String? Text { protected get; init; }
        public System.String? PlaceholderText { protected get; init; }
        public System.Boolean? Editable { protected get; init; }
        public System.Boolean? ContextMenuEnabled { protected get; init; }
        public System.Boolean? EmojiMenuEnabled { protected get; init; }
        public System.Boolean? ShortcutKeysEnabled { protected get; init; }
        public System.Boolean? SelectingEnabled { protected get; init; }
        public System.Boolean? DeselectOnFocusLossEnabled { protected get; init; }
        public System.Boolean? DragAndDropSelectionEnabled { protected get; init; }
        public System.Boolean? VirtualKeyboardEnabled { protected get; init; }
        public System.Boolean? MiddleMousePasteEnabled { protected get; init; }
        public System.Boolean? EmptySelectionClipboardEnabled { protected get; init; }
        public Godot.TextEdit.LineWrappingMode? WrapMode { protected get; init; }
        public Godot.TextServer.AutowrapMode? AutowrapMode { protected get; init; }
        public System.Boolean? IndentWrappedLines { protected get; init; }
        public System.Boolean? ScrollSmooth { protected get; init; }
        public System.Single? ScrollVScrollSpeed { protected get; init; }
        public System.Boolean? ScrollPastEndOfFile { protected get; init; }
        public System.Double? ScrollVertical { protected get; init; }
        public System.Int32? ScrollHorizontal { protected get; init; }
        public System.Boolean? ScrollFitContentHeight { protected get; init; }
        public System.Boolean? ScrollFitContentWidth { protected get; init; }
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
        public Godot.Node.AutoTranslateModeEnum? TooltipAutoTranslateMode { protected get; init; }
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
        public System.Action? EditorStateChanged { protected get; init; }
        public System.Action? ScriptChanged { protected get; init; }
        public System.Action? PropertyListChanged { protected get; init; }
        public Dictionary<string, int> ThemeConstantOverrides { protected get; init; } = [];
        public Dictionary<string, Godot.Color> ThemeColorOverrides { protected get; init; } = [];
        /// <summary>
        /// This property allows you to define an action that will be called right after the node
        /// it represents is updated within Godot. As godot has many functions that can be useful
        /// making bindings for all of them, even generated ones, is a huge task.
        ///
        /// This function allows you to use all the functionality of the godot node.
        ///
        /// <b>NOTE</b>: State changes done through this function are NOT reset on re-render.
        /// Therefore, you need to keep track of the state yourself and set it on every render
        /// <example>
        /// In the below example, the component uses a button. The button has a SetPressedNoSignal function
        /// that can be used to set the toggle state on the button without triggering an event
        /// Since this is a function and not a property, it is not exposed through the Button component itself
        /// and therefore we need to use the CustomNodeHandling to set this property.
        /// <code>
        /// class MyComponent : Component {
        /// 	Component Render() {
        /// 		var isToggled = UseState(false);
        /// 		return new Button()
        /// 		{
        /// 			ToggleMode = true,
        ///			CustomNodeHandling = (Button button) =>
        /// 			{
        /// 				button.SetPressedNoSignal(isToggled.Value);
        /// 			}
        /// 		};
        /// 	}
        /// }
        /// </code>
        /// </example>
        /// </summary>
        public Action<ReactiveSharpGodot.Nodes.GTextEdit>? CustomNodeHandling { protected get; init; }

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

            if (EmojiMenuEnabled is System.Boolean n4)
            {
                NodeStateManager.AddPropertyState(castedNode, "EmojiMenuEnabled", castedNode.EmojiMenuEnabled);
                castedNode.EmojiMenuEnabled = n4;
            }

            if (ShortcutKeysEnabled is System.Boolean n5)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutKeysEnabled", castedNode.ShortcutKeysEnabled);
                castedNode.ShortcutKeysEnabled = n5;
            }

            if (SelectingEnabled is System.Boolean n6)
            {
                NodeStateManager.AddPropertyState(castedNode, "SelectingEnabled", castedNode.SelectingEnabled);
                castedNode.SelectingEnabled = n6;
            }

            if (DeselectOnFocusLossEnabled is System.Boolean n7)
            {
                NodeStateManager.AddPropertyState(castedNode, "DeselectOnFocusLossEnabled", castedNode.DeselectOnFocusLossEnabled);
                castedNode.DeselectOnFocusLossEnabled = n7;
            }

            if (DragAndDropSelectionEnabled is System.Boolean n8)
            {
                NodeStateManager.AddPropertyState(castedNode, "DragAndDropSelectionEnabled", castedNode.DragAndDropSelectionEnabled);
                castedNode.DragAndDropSelectionEnabled = n8;
            }

            if (VirtualKeyboardEnabled is System.Boolean n9)
            {
                NodeStateManager.AddPropertyState(castedNode, "VirtualKeyboardEnabled", castedNode.VirtualKeyboardEnabled);
                castedNode.VirtualKeyboardEnabled = n9;
            }

            if (MiddleMousePasteEnabled is System.Boolean n10)
            {
                NodeStateManager.AddPropertyState(castedNode, "MiddleMousePasteEnabled", castedNode.MiddleMousePasteEnabled);
                castedNode.MiddleMousePasteEnabled = n10;
            }

            if (EmptySelectionClipboardEnabled is System.Boolean n11)
            {
                NodeStateManager.AddPropertyState(castedNode, "EmptySelectionClipboardEnabled", castedNode.EmptySelectionClipboardEnabled);
                castedNode.EmptySelectionClipboardEnabled = n11;
            }

            if (WrapMode is Godot.TextEdit.LineWrappingMode n12)
            {
                NodeStateManager.AddPropertyState(castedNode, "WrapMode", castedNode.WrapMode);
                castedNode.WrapMode = n12;
            }

            if (AutowrapMode is Godot.TextServer.AutowrapMode n13)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutowrapMode", castedNode.AutowrapMode);
                castedNode.AutowrapMode = n13;
            }

            if (IndentWrappedLines is System.Boolean n14)
            {
                NodeStateManager.AddPropertyState(castedNode, "IndentWrappedLines", castedNode.IndentWrappedLines);
                castedNode.IndentWrappedLines = n14;
            }

            if (ScrollSmooth is System.Boolean n15)
            {
                NodeStateManager.AddPropertyState(castedNode, "ScrollSmooth", castedNode.ScrollSmooth);
                castedNode.ScrollSmooth = n15;
            }

            if (ScrollVScrollSpeed is System.Single n16)
            {
                NodeStateManager.AddPropertyState(castedNode, "ScrollVScrollSpeed", castedNode.ScrollVScrollSpeed);
                castedNode.ScrollVScrollSpeed = n16;
            }

            if (ScrollPastEndOfFile is System.Boolean n17)
            {
                NodeStateManager.AddPropertyState(castedNode, "ScrollPastEndOfFile", castedNode.ScrollPastEndOfFile);
                castedNode.ScrollPastEndOfFile = n17;
            }

            if (ScrollVertical is System.Double n18)
            {
                NodeStateManager.AddPropertyState(castedNode, "ScrollVertical", castedNode.ScrollVertical);
                castedNode.ScrollVertical = n18;
            }

            if (ScrollHorizontal is System.Int32 n19)
            {
                NodeStateManager.AddPropertyState(castedNode, "ScrollHorizontal", castedNode.ScrollHorizontal);
                castedNode.ScrollHorizontal = n19;
            }

            if (ScrollFitContentHeight is System.Boolean n20)
            {
                NodeStateManager.AddPropertyState(castedNode, "ScrollFitContentHeight", castedNode.ScrollFitContentHeight);
                castedNode.ScrollFitContentHeight = n20;
            }

            if (ScrollFitContentWidth is System.Boolean n21)
            {
                NodeStateManager.AddPropertyState(castedNode, "ScrollFitContentWidth", castedNode.ScrollFitContentWidth);
                castedNode.ScrollFitContentWidth = n21;
            }

            if (MinimapDraw is System.Boolean n22)
            {
                NodeStateManager.AddPropertyState(castedNode, "MinimapDraw", castedNode.MinimapDraw);
                castedNode.MinimapDraw = n22;
            }

            if (MinimapWidth is System.Int32 n23)
            {
                NodeStateManager.AddPropertyState(castedNode, "MinimapWidth", castedNode.MinimapWidth);
                castedNode.MinimapWidth = n23;
            }

            if (CaretType is Godot.TextEdit.CaretTypeEnum n24)
            {
                NodeStateManager.AddPropertyState(castedNode, "CaretType", castedNode.CaretType);
                castedNode.CaretType = n24;
            }

            if (CaretBlink is System.Boolean n25)
            {
                NodeStateManager.AddPropertyState(castedNode, "CaretBlink", castedNode.CaretBlink);
                castedNode.CaretBlink = n25;
            }

            if (CaretBlinkInterval is System.Single n26)
            {
                NodeStateManager.AddPropertyState(castedNode, "CaretBlinkInterval", castedNode.CaretBlinkInterval);
                castedNode.CaretBlinkInterval = n26;
            }

            if (CaretDrawWhenEditableDisabled is System.Boolean n27)
            {
                NodeStateManager.AddPropertyState(castedNode, "CaretDrawWhenEditableDisabled", castedNode.CaretDrawWhenEditableDisabled);
                castedNode.CaretDrawWhenEditableDisabled = n27;
            }

            if (CaretMoveOnRightClick is System.Boolean n28)
            {
                NodeStateManager.AddPropertyState(castedNode, "CaretMoveOnRightClick", castedNode.CaretMoveOnRightClick);
                castedNode.CaretMoveOnRightClick = n28;
            }

            if (CaretMidGrapheme is System.Boolean n29)
            {
                NodeStateManager.AddPropertyState(castedNode, "CaretMidGrapheme", castedNode.CaretMidGrapheme);
                castedNode.CaretMidGrapheme = n29;
            }

            if (CaretMultiple is System.Boolean n30)
            {
                NodeStateManager.AddPropertyState(castedNode, "CaretMultiple", castedNode.CaretMultiple);
                castedNode.CaretMultiple = n30;
            }

            if (UseDefaultWordSeparators is System.Boolean n31)
            {
                NodeStateManager.AddPropertyState(castedNode, "UseDefaultWordSeparators", castedNode.UseDefaultWordSeparators);
                castedNode.UseDefaultWordSeparators = n31;
            }

            if (UseCustomWordSeparators is System.Boolean n32)
            {
                NodeStateManager.AddPropertyState(castedNode, "UseCustomWordSeparators", castedNode.UseCustomWordSeparators);
                castedNode.UseCustomWordSeparators = n32;
            }

            if (CustomWordSeparators is System.String n33)
            {
                NodeStateManager.AddPropertyState(castedNode, "CustomWordSeparators", castedNode.CustomWordSeparators);
                castedNode.CustomWordSeparators = n33;
            }

            if (SyntaxHighlighter is Godot.SyntaxHighlighter n34)
            {
                NodeStateManager.AddPropertyState(castedNode, "SyntaxHighlighter", castedNode.SyntaxHighlighter);
                castedNode.SyntaxHighlighter = n34;
            }

            if (HighlightAllOccurrences is System.Boolean n35)
            {
                NodeStateManager.AddPropertyState(castedNode, "HighlightAllOccurrences", castedNode.HighlightAllOccurrences);
                castedNode.HighlightAllOccurrences = n35;
            }

            if (HighlightCurrentLine is System.Boolean n36)
            {
                NodeStateManager.AddPropertyState(castedNode, "HighlightCurrentLine", castedNode.HighlightCurrentLine);
                castedNode.HighlightCurrentLine = n36;
            }

            if (DrawControlChars is System.Boolean n37)
            {
                NodeStateManager.AddPropertyState(castedNode, "DrawControlChars", castedNode.DrawControlChars);
                castedNode.DrawControlChars = n37;
            }

            if (DrawTabs is System.Boolean n38)
            {
                NodeStateManager.AddPropertyState(castedNode, "DrawTabs", castedNode.DrawTabs);
                castedNode.DrawTabs = n38;
            }

            if (DrawSpaces is System.Boolean n39)
            {
                NodeStateManager.AddPropertyState(castedNode, "DrawSpaces", castedNode.DrawSpaces);
                castedNode.DrawSpaces = n39;
            }

            if (TextDirection is Godot.Control.TextDirection n40)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextDirection", castedNode.TextDirection);
                castedNode.TextDirection = n40;
            }

            if (Language is System.String n41)
            {
                NodeStateManager.AddPropertyState(castedNode, "Language", castedNode.Language);
                castedNode.Language = n41;
            }

            if (StructuredTextBidiOverride is Godot.TextServer.StructuredTextParser n42)
            {
                NodeStateManager.AddPropertyState(castedNode, "StructuredTextBidiOverride", castedNode.StructuredTextBidiOverride);
                castedNode.StructuredTextBidiOverride = n42;
            }

            if (StructuredTextBidiOverrideOptions is Godot.Collections.Array n43)
            {
                NodeStateManager.AddPropertyState(castedNode, "StructuredTextBidiOverrideOptions", castedNode.StructuredTextBidiOverrideOptions);
                castedNode.StructuredTextBidiOverrideOptions = n43;
            }

            if (ClipContents is System.Boolean n44)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipContents", castedNode.ClipContents);
                castedNode.ClipContents = n44;
            }

            if (CustomMinimumSize is Godot.Vector2 n45)
            {
                NodeStateManager.AddPropertyState(castedNode, "CustomMinimumSize", castedNode.CustomMinimumSize);
                castedNode.CustomMinimumSize = n45;
            }

            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n46)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutDirection", castedNode.LayoutDirection);
                castedNode.LayoutDirection = n46;
            }

            if (LayoutMode is System.Int32 n47)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutMode", castedNode.LayoutMode);
                castedNode.LayoutMode = n47;
            }

            if (AnchorsPreset is System.Int32 n48)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorsPreset", castedNode.AnchorsPreset);
                castedNode.AnchorsPreset = n48;
            }

            if (AnchorLeft is System.Single n49)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorLeft", castedNode.AnchorLeft);
                castedNode.AnchorLeft = n49;
            }

            if (AnchorTop is System.Single n50)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorTop", castedNode.AnchorTop);
                castedNode.AnchorTop = n50;
            }

            if (AnchorRight is System.Single n51)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorRight", castedNode.AnchorRight);
                castedNode.AnchorRight = n51;
            }

            if (AnchorBottom is System.Single n52)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorBottom", castedNode.AnchorBottom);
                castedNode.AnchorBottom = n52;
            }

            if (OffsetLeft is System.Single n53)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetLeft", castedNode.OffsetLeft);
                castedNode.OffsetLeft = n53;
            }

            if (OffsetTop is System.Single n54)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetTop", castedNode.OffsetTop);
                castedNode.OffsetTop = n54;
            }

            if (OffsetRight is System.Single n55)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetRight", castedNode.OffsetRight);
                castedNode.OffsetRight = n55;
            }

            if (OffsetBottom is System.Single n56)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetBottom", castedNode.OffsetBottom);
                castedNode.OffsetBottom = n56;
            }

            if (GrowHorizontal is Godot.Control.GrowDirection n57)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowHorizontal", castedNode.GrowHorizontal);
                castedNode.GrowHorizontal = n57;
            }

            if (GrowVertical is Godot.Control.GrowDirection n58)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowVertical", castedNode.GrowVertical);
                castedNode.GrowVertical = n58;
            }

            if (Size is Godot.Vector2 n59)
            {
                NodeStateManager.AddPropertyState(castedNode, "Size", castedNode.Size);
                castedNode.Size = n59;
            }

            if (Position is Godot.Vector2 n60)
            {
                NodeStateManager.AddPropertyState(castedNode, "Position", castedNode.Position);
                castedNode.Position = n60;
            }

            if (GlobalPosition is Godot.Vector2 n61)
            {
                NodeStateManager.AddPropertyState(castedNode, "GlobalPosition", castedNode.GlobalPosition);
                castedNode.GlobalPosition = n61;
            }

            if (Rotation is System.Single n62)
            {
                NodeStateManager.AddPropertyState(castedNode, "Rotation", castedNode.Rotation);
                castedNode.Rotation = n62;
            }

            if (RotationDegrees is System.Single n63)
            {
                NodeStateManager.AddPropertyState(castedNode, "RotationDegrees", castedNode.RotationDegrees);
                castedNode.RotationDegrees = n63;
            }

            if (Scale is Godot.Vector2 n64)
            {
                NodeStateManager.AddPropertyState(castedNode, "Scale", castedNode.Scale);
                castedNode.Scale = n64;
            }

            if (PivotOffset is Godot.Vector2 n65)
            {
                NodeStateManager.AddPropertyState(castedNode, "PivotOffset", castedNode.PivotOffset);
                castedNode.PivotOffset = n65;
            }

            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n66)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsHorizontal", castedNode.SizeFlagsHorizontal);
                castedNode.SizeFlagsHorizontal = n66;
            }

            if (SizeFlagsVertical is Godot.Control.SizeFlags n67)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsVertical", castedNode.SizeFlagsVertical);
                castedNode.SizeFlagsVertical = n67;
            }

            if (SizeFlagsStretchRatio is System.Single n68)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsStretchRatio", castedNode.SizeFlagsStretchRatio);
                castedNode.SizeFlagsStretchRatio = n68;
            }

            if (LocalizeNumeralSystem is System.Boolean n69)
            {
                NodeStateManager.AddPropertyState(castedNode, "LocalizeNumeralSystem", castedNode.LocalizeNumeralSystem);
                castedNode.LocalizeNumeralSystem = n69;
            }

            if (AutoTranslate is System.Boolean n70)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslate", castedNode.AutoTranslate);
                castedNode.AutoTranslate = n70;
            }

            if (TooltipText is System.String n71)
            {
                NodeStateManager.AddPropertyState(castedNode, "TooltipText", castedNode.TooltipText);
                castedNode.TooltipText = n71;
            }

            if (TooltipAutoTranslateMode is Godot.Node.AutoTranslateModeEnum n72)
            {
                NodeStateManager.AddPropertyState(castedNode, "TooltipAutoTranslateMode", castedNode.TooltipAutoTranslateMode);
                castedNode.TooltipAutoTranslateMode = n72;
            }

            if (FocusNeighborLeft is Godot.NodePath n73)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborLeft", castedNode.FocusNeighborLeft);
                castedNode.FocusNeighborLeft = n73;
            }

            if (FocusNeighborTop is Godot.NodePath n74)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborTop", castedNode.FocusNeighborTop);
                castedNode.FocusNeighborTop = n74;
            }

            if (FocusNeighborRight is Godot.NodePath n75)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborRight", castedNode.FocusNeighborRight);
                castedNode.FocusNeighborRight = n75;
            }

            if (FocusNeighborBottom is Godot.NodePath n76)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborBottom", castedNode.FocusNeighborBottom);
                castedNode.FocusNeighborBottom = n76;
            }

            if (FocusNext is Godot.NodePath n77)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNext", castedNode.FocusNext);
                castedNode.FocusNext = n77;
            }

            if (FocusPrevious is Godot.NodePath n78)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusPrevious", castedNode.FocusPrevious);
                castedNode.FocusPrevious = n78;
            }

            if (FocusMode is Godot.Control.FocusModeEnum n79)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusMode", castedNode.FocusMode);
                castedNode.FocusMode = n79;
            }

            if (MouseFilter is Godot.Control.MouseFilterEnum n80)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseFilter", castedNode.MouseFilter);
                castedNode.MouseFilter = n80;
            }

            if (MouseForcePassScrollEvents is System.Boolean n81)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseForcePassScrollEvents", castedNode.MouseForcePassScrollEvents);
                castedNode.MouseForcePassScrollEvents = n81;
            }

            if (MouseDefaultCursorShape is Godot.Control.CursorShape n82)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseDefaultCursorShape", castedNode.MouseDefaultCursorShape);
                castedNode.MouseDefaultCursorShape = n82;
            }

            if (ShortcutContext is Godot.Node n83)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutContext", castedNode.ShortcutContext);
                castedNode.ShortcutContext = n83;
            }

            if (Theme is Godot.Theme n84)
            {
                NodeStateManager.AddPropertyState(castedNode, "Theme", castedNode.Theme);
                castedNode.Theme = n84;
            }

            if (ThemeTypeVariation is Godot.StringName n85)
            {
                NodeStateManager.AddPropertyState(castedNode, "ThemeTypeVariation", castedNode.ThemeTypeVariation);
                castedNode.ThemeTypeVariation = n85;
            }

            if (Visible is System.Boolean n86)
            {
                NodeStateManager.AddPropertyState(castedNode, "Visible", castedNode.Visible);
                castedNode.Visible = n86;
            }

            if (Modulate is Godot.Color n87)
            {
                NodeStateManager.AddPropertyState(castedNode, "Modulate", castedNode.Modulate);
                castedNode.Modulate = n87;
            }

            if (SelfModulate is Godot.Color n88)
            {
                NodeStateManager.AddPropertyState(castedNode, "SelfModulate", castedNode.SelfModulate);
                castedNode.SelfModulate = n88;
            }

            if (ShowBehindParent is System.Boolean n89)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowBehindParent", castedNode.ShowBehindParent);
                castedNode.ShowBehindParent = n89;
            }

            if (TopLevel is System.Boolean n90)
            {
                NodeStateManager.AddPropertyState(castedNode, "TopLevel", castedNode.TopLevel);
                castedNode.TopLevel = n90;
            }

            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n91)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipChildren", castedNode.ClipChildren);
                castedNode.ClipChildren = n91;
            }

            if (LightMask is System.Int32 n92)
            {
                NodeStateManager.AddPropertyState(castedNode, "LightMask", castedNode.LightMask);
                castedNode.LightMask = n92;
            }

            if (VisibilityLayer is System.UInt32 n93)
            {
                NodeStateManager.AddPropertyState(castedNode, "VisibilityLayer", castedNode.VisibilityLayer);
                castedNode.VisibilityLayer = n93;
            }

            if (ZIndex is System.Int32 n94)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZIndex", castedNode.ZIndex);
                castedNode.ZIndex = n94;
            }

            if (ZAsRelative is System.Boolean n95)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZAsRelative", castedNode.ZAsRelative);
                castedNode.ZAsRelative = n95;
            }

            if (YSortEnabled is System.Boolean n96)
            {
                NodeStateManager.AddPropertyState(castedNode, "YSortEnabled", castedNode.YSortEnabled);
                castedNode.YSortEnabled = n96;
            }

            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n97)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureFilter", castedNode.TextureFilter);
                castedNode.TextureFilter = n97;
            }

            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n98)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureRepeat", castedNode.TextureRepeat);
                castedNode.TextureRepeat = n98;
            }

            if (Material is Godot.Material n99)
            {
                NodeStateManager.AddPropertyState(castedNode, "Material", castedNode.Material);
                castedNode.Material = n99;
            }

            if (UseParentMaterial is System.Boolean n100)
            {
                NodeStateManager.AddPropertyState(castedNode, "UseParentMaterial", castedNode.UseParentMaterial);
                castedNode.UseParentMaterial = n100;
            }

            if (Name is Godot.StringName n101)
            {
                NodeStateManager.AddPropertyState(castedNode, "Name", castedNode.Name);
                castedNode.Name = n101;
            }

            if (UniqueNameInOwner is System.Boolean n102)
            {
                NodeStateManager.AddPropertyState(castedNode, "UniqueNameInOwner", castedNode.UniqueNameInOwner);
                castedNode.UniqueNameInOwner = n102;
            }

            if (SceneFilePath is System.String n103)
            {
                NodeStateManager.AddPropertyState(castedNode, "SceneFilePath", castedNode.SceneFilePath);
                castedNode.SceneFilePath = n103;
            }

            if (Owner is Godot.Node n104)
            {
                NodeStateManager.AddPropertyState(castedNode, "Owner", castedNode.Owner);
                castedNode.Owner = n104;
            }

            if (ProcessMode is Godot.Node.ProcessModeEnum n105)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessMode", castedNode.ProcessMode);
                castedNode.ProcessMode = n105;
            }

            if (ProcessPriority is System.Int32 n106)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPriority", castedNode.ProcessPriority);
                castedNode.ProcessPriority = n106;
            }

            if (ProcessPhysicsPriority is System.Int32 n107)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPhysicsPriority", castedNode.ProcessPhysicsPriority);
                castedNode.ProcessPhysicsPriority = n107;
            }

            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n108)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroup", castedNode.ProcessThreadGroup);
                castedNode.ProcessThreadGroup = n108;
            }

            if (ProcessThreadGroupOrder is System.Int32 n109)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroupOrder", castedNode.ProcessThreadGroupOrder);
                castedNode.ProcessThreadGroupOrder = n109;
            }

            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n110)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadMessages", castedNode.ProcessThreadMessages);
                castedNode.ProcessThreadMessages = n110;
            }

            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n111)
            {
                NodeStateManager.AddPropertyState(castedNode, "PhysicsInterpolationMode", castedNode.PhysicsInterpolationMode);
                castedNode.PhysicsInterpolationMode = n111;
            }

            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n112)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslateMode", castedNode.AutoTranslateMode);
                castedNode.AutoTranslateMode = n112;
            }

            if (EditorDescription is System.String n113)
            {
                NodeStateManager.AddPropertyState(castedNode, "EditorDescription", castedNode.EditorDescription);
                castedNode.EditorDescription = n113;
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

            if (EditorStateChanged is System.Action e30)
            {
                NodeStateManager.AddEventHandler(castedNode, "EditorStateChanged", e30);
                castedNode.EditorStateChanged += e30;
            }

            if (ScriptChanged is System.Action e31)
            {
                NodeStateManager.AddEventHandler(castedNode, "ScriptChanged", e31);
                castedNode.ScriptChanged += e31;
            }

            if (PropertyListChanged is System.Action e32)
            {
                NodeStateManager.AddEventHandler(castedNode, "PropertyListChanged", e32);
                castedNode.PropertyListChanged += e32;
            }

            castedNode.BeginBulkThemeOverride();
            foreach (var(key, value)in ThemeConstantOverrides)
            {
                castedNode.AddThemeConstantOverride(key, value);
            }

            foreach (var(key, value)in ThemeColorOverrides)
            {
                castedNode.AddThemeColorOverride(key, value);
            }

            castedNode.EndBulkThemeOverride();
            CustomNodeHandling?.Invoke(node);
        }
    }
}