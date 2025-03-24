// This file is auto-generated. Please do not edit
namespace ReactiveSharpGodot.Components
{
    public class CodeEdit : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GCodeEdit>
    {
        public System.Boolean? SymbolLookupOnClick { protected get; init; }
        public System.Boolean? LineFolding { protected get; init; }
        public Godot.Collections.Array<System.Int32>? LineLengthGuidelines { protected get; init; }
        public System.Boolean? GuttersDrawBreakpointsGutter { protected get; init; }
        public System.Boolean? GuttersDrawBookmarks { protected get; init; }
        public System.Boolean? GuttersDrawExecutingLines { protected get; init; }
        public System.Boolean? GuttersDrawLineNumbers { protected get; init; }
        public System.Boolean? GuttersZeroPadLineNumbers { protected get; init; }
        public System.Boolean? GuttersDrawFoldGutter { protected get; init; }
        public Godot.Collections.Array<System.String>? DelimiterStrings { protected get; init; }
        public Godot.Collections.Array<System.String>? DelimiterComments { protected get; init; }
        public System.Boolean? CodeCompletionEnabled { protected get; init; }
        public Godot.Collections.Array<System.String>? CodeCompletionPrefixes { protected get; init; }
        public System.Int32? IndentSize { protected get; init; }
        public System.Boolean? IndentUseSpaces { protected get; init; }
        public System.Boolean? IndentAutomatic { protected get; init; }
        public Godot.Collections.Array<System.String>? IndentAutomaticPrefixes { protected get; init; }
        public System.Boolean? AutoBraceCompletionEnabled { protected get; init; }
        public System.Boolean? AutoBraceCompletionHighlightMatching { protected get; init; }
        public Godot.Collections.Dictionary? AutoBraceCompletionPairs { protected get; init; }
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
        public Godot.CodeEdit.BreakpointToggledEventHandler? BreakpointToggled { protected get; init; }
        public System.Action? CodeCompletionRequested { protected get; init; }
        public Godot.CodeEdit.SymbolLookupEventHandler? SymbolLookup { protected get; init; }
        public Godot.CodeEdit.SymbolValidateEventHandler? SymbolValidate { protected get; init; }
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
        public Action<ReactiveSharpGodot.Nodes.GCodeEdit>? CustomNodeHandling { protected get; init; }

        public override ReactiveSharpGodot.Nodes.GCodeEdit Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GCodeEdit();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GCodeEdit node)
        {
            var castedNode = (Godot.CodeEdit)node.Node;
            if (SymbolLookupOnClick is System.Boolean n0)
            {
                NodeStateManager.AddPropertyState(castedNode, "SymbolLookupOnClick", castedNode.SymbolLookupOnClick);
                castedNode.SymbolLookupOnClick = n0;
            }

            if (LineFolding is System.Boolean n1)
            {
                NodeStateManager.AddPropertyState(castedNode, "LineFolding", castedNode.LineFolding);
                castedNode.LineFolding = n1;
            }

            if (LineLengthGuidelines is Godot.Collections.Array<System.Int32> n2)
            {
                NodeStateManager.AddPropertyState(castedNode, "LineLengthGuidelines", castedNode.LineLengthGuidelines);
                castedNode.LineLengthGuidelines = n2;
            }

            if (GuttersDrawBreakpointsGutter is System.Boolean n3)
            {
                NodeStateManager.AddPropertyState(castedNode, "GuttersDrawBreakpointsGutter", castedNode.GuttersDrawBreakpointsGutter);
                castedNode.GuttersDrawBreakpointsGutter = n3;
            }

            if (GuttersDrawBookmarks is System.Boolean n4)
            {
                NodeStateManager.AddPropertyState(castedNode, "GuttersDrawBookmarks", castedNode.GuttersDrawBookmarks);
                castedNode.GuttersDrawBookmarks = n4;
            }

            if (GuttersDrawExecutingLines is System.Boolean n5)
            {
                NodeStateManager.AddPropertyState(castedNode, "GuttersDrawExecutingLines", castedNode.GuttersDrawExecutingLines);
                castedNode.GuttersDrawExecutingLines = n5;
            }

            if (GuttersDrawLineNumbers is System.Boolean n6)
            {
                NodeStateManager.AddPropertyState(castedNode, "GuttersDrawLineNumbers", castedNode.GuttersDrawLineNumbers);
                castedNode.GuttersDrawLineNumbers = n6;
            }

            if (GuttersZeroPadLineNumbers is System.Boolean n7)
            {
                NodeStateManager.AddPropertyState(castedNode, "GuttersZeroPadLineNumbers", castedNode.GuttersZeroPadLineNumbers);
                castedNode.GuttersZeroPadLineNumbers = n7;
            }

            if (GuttersDrawFoldGutter is System.Boolean n8)
            {
                NodeStateManager.AddPropertyState(castedNode, "GuttersDrawFoldGutter", castedNode.GuttersDrawFoldGutter);
                castedNode.GuttersDrawFoldGutter = n8;
            }

            if (DelimiterStrings is Godot.Collections.Array<System.String> n9)
            {
                NodeStateManager.AddPropertyState(castedNode, "DelimiterStrings", castedNode.DelimiterStrings);
                castedNode.DelimiterStrings = n9;
            }

            if (DelimiterComments is Godot.Collections.Array<System.String> n10)
            {
                NodeStateManager.AddPropertyState(castedNode, "DelimiterComments", castedNode.DelimiterComments);
                castedNode.DelimiterComments = n10;
            }

            if (CodeCompletionEnabled is System.Boolean n11)
            {
                NodeStateManager.AddPropertyState(castedNode, "CodeCompletionEnabled", castedNode.CodeCompletionEnabled);
                castedNode.CodeCompletionEnabled = n11;
            }

            if (CodeCompletionPrefixes is Godot.Collections.Array<System.String> n12)
            {
                NodeStateManager.AddPropertyState(castedNode, "CodeCompletionPrefixes", castedNode.CodeCompletionPrefixes);
                castedNode.CodeCompletionPrefixes = n12;
            }

            if (IndentSize is System.Int32 n13)
            {
                NodeStateManager.AddPropertyState(castedNode, "IndentSize", castedNode.IndentSize);
                castedNode.IndentSize = n13;
            }

            if (IndentUseSpaces is System.Boolean n14)
            {
                NodeStateManager.AddPropertyState(castedNode, "IndentUseSpaces", castedNode.IndentUseSpaces);
                castedNode.IndentUseSpaces = n14;
            }

            if (IndentAutomatic is System.Boolean n15)
            {
                NodeStateManager.AddPropertyState(castedNode, "IndentAutomatic", castedNode.IndentAutomatic);
                castedNode.IndentAutomatic = n15;
            }

            if (IndentAutomaticPrefixes is Godot.Collections.Array<System.String> n16)
            {
                NodeStateManager.AddPropertyState(castedNode, "IndentAutomaticPrefixes", castedNode.IndentAutomaticPrefixes);
                castedNode.IndentAutomaticPrefixes = n16;
            }

            if (AutoBraceCompletionEnabled is System.Boolean n17)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoBraceCompletionEnabled", castedNode.AutoBraceCompletionEnabled);
                castedNode.AutoBraceCompletionEnabled = n17;
            }

            if (AutoBraceCompletionHighlightMatching is System.Boolean n18)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoBraceCompletionHighlightMatching", castedNode.AutoBraceCompletionHighlightMatching);
                castedNode.AutoBraceCompletionHighlightMatching = n18;
            }

            if (AutoBraceCompletionPairs is Godot.Collections.Dictionary n19)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoBraceCompletionPairs", castedNode.AutoBraceCompletionPairs);
                castedNode.AutoBraceCompletionPairs = n19;
            }

            if (Text is System.String n20)
            {
                NodeStateManager.AddPropertyState(castedNode, "Text", castedNode.Text);
                castedNode.Text = n20;
            }

            if (PlaceholderText is System.String n21)
            {
                NodeStateManager.AddPropertyState(castedNode, "PlaceholderText", castedNode.PlaceholderText);
                castedNode.PlaceholderText = n21;
            }

            if (Editable is System.Boolean n22)
            {
                NodeStateManager.AddPropertyState(castedNode, "Editable", castedNode.Editable);
                castedNode.Editable = n22;
            }

            if (ContextMenuEnabled is System.Boolean n23)
            {
                NodeStateManager.AddPropertyState(castedNode, "ContextMenuEnabled", castedNode.ContextMenuEnabled);
                castedNode.ContextMenuEnabled = n23;
            }

            if (ShortcutKeysEnabled is System.Boolean n24)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutKeysEnabled", castedNode.ShortcutKeysEnabled);
                castedNode.ShortcutKeysEnabled = n24;
            }

            if (SelectingEnabled is System.Boolean n25)
            {
                NodeStateManager.AddPropertyState(castedNode, "SelectingEnabled", castedNode.SelectingEnabled);
                castedNode.SelectingEnabled = n25;
            }

            if (DeselectOnFocusLossEnabled is System.Boolean n26)
            {
                NodeStateManager.AddPropertyState(castedNode, "DeselectOnFocusLossEnabled", castedNode.DeselectOnFocusLossEnabled);
                castedNode.DeselectOnFocusLossEnabled = n26;
            }

            if (DragAndDropSelectionEnabled is System.Boolean n27)
            {
                NodeStateManager.AddPropertyState(castedNode, "DragAndDropSelectionEnabled", castedNode.DragAndDropSelectionEnabled);
                castedNode.DragAndDropSelectionEnabled = n27;
            }

            if (VirtualKeyboardEnabled is System.Boolean n28)
            {
                NodeStateManager.AddPropertyState(castedNode, "VirtualKeyboardEnabled", castedNode.VirtualKeyboardEnabled);
                castedNode.VirtualKeyboardEnabled = n28;
            }

            if (MiddleMousePasteEnabled is System.Boolean n29)
            {
                NodeStateManager.AddPropertyState(castedNode, "MiddleMousePasteEnabled", castedNode.MiddleMousePasteEnabled);
                castedNode.MiddleMousePasteEnabled = n29;
            }

            if (WrapMode is Godot.TextEdit.LineWrappingMode n30)
            {
                NodeStateManager.AddPropertyState(castedNode, "WrapMode", castedNode.WrapMode);
                castedNode.WrapMode = n30;
            }

            if (AutowrapMode is Godot.TextServer.AutowrapMode n31)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutowrapMode", castedNode.AutowrapMode);
                castedNode.AutowrapMode = n31;
            }

            if (IndentWrappedLines is System.Boolean n32)
            {
                NodeStateManager.AddPropertyState(castedNode, "IndentWrappedLines", castedNode.IndentWrappedLines);
                castedNode.IndentWrappedLines = n32;
            }

            if (ScrollSmooth is System.Boolean n33)
            {
                NodeStateManager.AddPropertyState(castedNode, "ScrollSmooth", castedNode.ScrollSmooth);
                castedNode.ScrollSmooth = n33;
            }

            if (ScrollVScrollSpeed is System.Single n34)
            {
                NodeStateManager.AddPropertyState(castedNode, "ScrollVScrollSpeed", castedNode.ScrollVScrollSpeed);
                castedNode.ScrollVScrollSpeed = n34;
            }

            if (ScrollPastEndOfFile is System.Boolean n35)
            {
                NodeStateManager.AddPropertyState(castedNode, "ScrollPastEndOfFile", castedNode.ScrollPastEndOfFile);
                castedNode.ScrollPastEndOfFile = n35;
            }

            if (ScrollVertical is System.Double n36)
            {
                NodeStateManager.AddPropertyState(castedNode, "ScrollVertical", castedNode.ScrollVertical);
                castedNode.ScrollVertical = n36;
            }

            if (ScrollHorizontal is System.Int32 n37)
            {
                NodeStateManager.AddPropertyState(castedNode, "ScrollHorizontal", castedNode.ScrollHorizontal);
                castedNode.ScrollHorizontal = n37;
            }

            if (ScrollFitContentHeight is System.Boolean n38)
            {
                NodeStateManager.AddPropertyState(castedNode, "ScrollFitContentHeight", castedNode.ScrollFitContentHeight);
                castedNode.ScrollFitContentHeight = n38;
            }

            if (MinimapDraw is System.Boolean n39)
            {
                NodeStateManager.AddPropertyState(castedNode, "MinimapDraw", castedNode.MinimapDraw);
                castedNode.MinimapDraw = n39;
            }

            if (MinimapWidth is System.Int32 n40)
            {
                NodeStateManager.AddPropertyState(castedNode, "MinimapWidth", castedNode.MinimapWidth);
                castedNode.MinimapWidth = n40;
            }

            if (CaretType is Godot.TextEdit.CaretTypeEnum n41)
            {
                NodeStateManager.AddPropertyState(castedNode, "CaretType", castedNode.CaretType);
                castedNode.CaretType = n41;
            }

            if (CaretBlink is System.Boolean n42)
            {
                NodeStateManager.AddPropertyState(castedNode, "CaretBlink", castedNode.CaretBlink);
                castedNode.CaretBlink = n42;
            }

            if (CaretBlinkInterval is System.Single n43)
            {
                NodeStateManager.AddPropertyState(castedNode, "CaretBlinkInterval", castedNode.CaretBlinkInterval);
                castedNode.CaretBlinkInterval = n43;
            }

            if (CaretDrawWhenEditableDisabled is System.Boolean n44)
            {
                NodeStateManager.AddPropertyState(castedNode, "CaretDrawWhenEditableDisabled", castedNode.CaretDrawWhenEditableDisabled);
                castedNode.CaretDrawWhenEditableDisabled = n44;
            }

            if (CaretMoveOnRightClick is System.Boolean n45)
            {
                NodeStateManager.AddPropertyState(castedNode, "CaretMoveOnRightClick", castedNode.CaretMoveOnRightClick);
                castedNode.CaretMoveOnRightClick = n45;
            }

            if (CaretMidGrapheme is System.Boolean n46)
            {
                NodeStateManager.AddPropertyState(castedNode, "CaretMidGrapheme", castedNode.CaretMidGrapheme);
                castedNode.CaretMidGrapheme = n46;
            }

            if (CaretMultiple is System.Boolean n47)
            {
                NodeStateManager.AddPropertyState(castedNode, "CaretMultiple", castedNode.CaretMultiple);
                castedNode.CaretMultiple = n47;
            }

            if (UseDefaultWordSeparators is System.Boolean n48)
            {
                NodeStateManager.AddPropertyState(castedNode, "UseDefaultWordSeparators", castedNode.UseDefaultWordSeparators);
                castedNode.UseDefaultWordSeparators = n48;
            }

            if (UseCustomWordSeparators is System.Boolean n49)
            {
                NodeStateManager.AddPropertyState(castedNode, "UseCustomWordSeparators", castedNode.UseCustomWordSeparators);
                castedNode.UseCustomWordSeparators = n49;
            }

            if (CustomWordSeparators is System.String n50)
            {
                NodeStateManager.AddPropertyState(castedNode, "CustomWordSeparators", castedNode.CustomWordSeparators);
                castedNode.CustomWordSeparators = n50;
            }

            if (SyntaxHighlighter is Godot.SyntaxHighlighter n51)
            {
                NodeStateManager.AddPropertyState(castedNode, "SyntaxHighlighter", castedNode.SyntaxHighlighter);
                castedNode.SyntaxHighlighter = n51;
            }

            if (HighlightAllOccurrences is System.Boolean n52)
            {
                NodeStateManager.AddPropertyState(castedNode, "HighlightAllOccurrences", castedNode.HighlightAllOccurrences);
                castedNode.HighlightAllOccurrences = n52;
            }

            if (HighlightCurrentLine is System.Boolean n53)
            {
                NodeStateManager.AddPropertyState(castedNode, "HighlightCurrentLine", castedNode.HighlightCurrentLine);
                castedNode.HighlightCurrentLine = n53;
            }

            if (DrawControlChars is System.Boolean n54)
            {
                NodeStateManager.AddPropertyState(castedNode, "DrawControlChars", castedNode.DrawControlChars);
                castedNode.DrawControlChars = n54;
            }

            if (DrawTabs is System.Boolean n55)
            {
                NodeStateManager.AddPropertyState(castedNode, "DrawTabs", castedNode.DrawTabs);
                castedNode.DrawTabs = n55;
            }

            if (DrawSpaces is System.Boolean n56)
            {
                NodeStateManager.AddPropertyState(castedNode, "DrawSpaces", castedNode.DrawSpaces);
                castedNode.DrawSpaces = n56;
            }

            if (TextDirection is Godot.Control.TextDirection n57)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextDirection", castedNode.TextDirection);
                castedNode.TextDirection = n57;
            }

            if (Language is System.String n58)
            {
                NodeStateManager.AddPropertyState(castedNode, "Language", castedNode.Language);
                castedNode.Language = n58;
            }

            if (StructuredTextBidiOverride is Godot.TextServer.StructuredTextParser n59)
            {
                NodeStateManager.AddPropertyState(castedNode, "StructuredTextBidiOverride", castedNode.StructuredTextBidiOverride);
                castedNode.StructuredTextBidiOverride = n59;
            }

            if (StructuredTextBidiOverrideOptions is Godot.Collections.Array n60)
            {
                NodeStateManager.AddPropertyState(castedNode, "StructuredTextBidiOverrideOptions", castedNode.StructuredTextBidiOverrideOptions);
                castedNode.StructuredTextBidiOverrideOptions = n60;
            }

            if (ClipContents is System.Boolean n61)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipContents", castedNode.ClipContents);
                castedNode.ClipContents = n61;
            }

            if (CustomMinimumSize is Godot.Vector2 n62)
            {
                NodeStateManager.AddPropertyState(castedNode, "CustomMinimumSize", castedNode.CustomMinimumSize);
                castedNode.CustomMinimumSize = n62;
            }

            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n63)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutDirection", castedNode.LayoutDirection);
                castedNode.LayoutDirection = n63;
            }

            if (LayoutMode is System.Int32 n64)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutMode", castedNode.LayoutMode);
                castedNode.LayoutMode = n64;
            }

            if (AnchorsPreset is System.Int32 n65)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorsPreset", castedNode.AnchorsPreset);
                castedNode.AnchorsPreset = n65;
            }

            if (AnchorLeft is System.Single n66)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorLeft", castedNode.AnchorLeft);
                castedNode.AnchorLeft = n66;
            }

            if (AnchorTop is System.Single n67)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorTop", castedNode.AnchorTop);
                castedNode.AnchorTop = n67;
            }

            if (AnchorRight is System.Single n68)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorRight", castedNode.AnchorRight);
                castedNode.AnchorRight = n68;
            }

            if (AnchorBottom is System.Single n69)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorBottom", castedNode.AnchorBottom);
                castedNode.AnchorBottom = n69;
            }

            if (OffsetLeft is System.Single n70)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetLeft", castedNode.OffsetLeft);
                castedNode.OffsetLeft = n70;
            }

            if (OffsetTop is System.Single n71)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetTop", castedNode.OffsetTop);
                castedNode.OffsetTop = n71;
            }

            if (OffsetRight is System.Single n72)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetRight", castedNode.OffsetRight);
                castedNode.OffsetRight = n72;
            }

            if (OffsetBottom is System.Single n73)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetBottom", castedNode.OffsetBottom);
                castedNode.OffsetBottom = n73;
            }

            if (GrowHorizontal is Godot.Control.GrowDirection n74)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowHorizontal", castedNode.GrowHorizontal);
                castedNode.GrowHorizontal = n74;
            }

            if (GrowVertical is Godot.Control.GrowDirection n75)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowVertical", castedNode.GrowVertical);
                castedNode.GrowVertical = n75;
            }

            if (Size is Godot.Vector2 n76)
            {
                NodeStateManager.AddPropertyState(castedNode, "Size", castedNode.Size);
                castedNode.Size = n76;
            }

            if (Position is Godot.Vector2 n77)
            {
                NodeStateManager.AddPropertyState(castedNode, "Position", castedNode.Position);
                castedNode.Position = n77;
            }

            if (GlobalPosition is Godot.Vector2 n78)
            {
                NodeStateManager.AddPropertyState(castedNode, "GlobalPosition", castedNode.GlobalPosition);
                castedNode.GlobalPosition = n78;
            }

            if (Rotation is System.Single n79)
            {
                NodeStateManager.AddPropertyState(castedNode, "Rotation", castedNode.Rotation);
                castedNode.Rotation = n79;
            }

            if (RotationDegrees is System.Single n80)
            {
                NodeStateManager.AddPropertyState(castedNode, "RotationDegrees", castedNode.RotationDegrees);
                castedNode.RotationDegrees = n80;
            }

            if (Scale is Godot.Vector2 n81)
            {
                NodeStateManager.AddPropertyState(castedNode, "Scale", castedNode.Scale);
                castedNode.Scale = n81;
            }

            if (PivotOffset is Godot.Vector2 n82)
            {
                NodeStateManager.AddPropertyState(castedNode, "PivotOffset", castedNode.PivotOffset);
                castedNode.PivotOffset = n82;
            }

            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n83)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsHorizontal", castedNode.SizeFlagsHorizontal);
                castedNode.SizeFlagsHorizontal = n83;
            }

            if (SizeFlagsVertical is Godot.Control.SizeFlags n84)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsVertical", castedNode.SizeFlagsVertical);
                castedNode.SizeFlagsVertical = n84;
            }

            if (SizeFlagsStretchRatio is System.Single n85)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsStretchRatio", castedNode.SizeFlagsStretchRatio);
                castedNode.SizeFlagsStretchRatio = n85;
            }

            if (LocalizeNumeralSystem is System.Boolean n86)
            {
                NodeStateManager.AddPropertyState(castedNode, "LocalizeNumeralSystem", castedNode.LocalizeNumeralSystem);
                castedNode.LocalizeNumeralSystem = n86;
            }

            if (AutoTranslate is System.Boolean n87)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslate", castedNode.AutoTranslate);
                castedNode.AutoTranslate = n87;
            }

            if (TooltipText is System.String n88)
            {
                NodeStateManager.AddPropertyState(castedNode, "TooltipText", castedNode.TooltipText);
                castedNode.TooltipText = n88;
            }

            if (FocusNeighborLeft is Godot.NodePath n89)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborLeft", castedNode.FocusNeighborLeft);
                castedNode.FocusNeighborLeft = n89;
            }

            if (FocusNeighborTop is Godot.NodePath n90)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborTop", castedNode.FocusNeighborTop);
                castedNode.FocusNeighborTop = n90;
            }

            if (FocusNeighborRight is Godot.NodePath n91)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborRight", castedNode.FocusNeighborRight);
                castedNode.FocusNeighborRight = n91;
            }

            if (FocusNeighborBottom is Godot.NodePath n92)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborBottom", castedNode.FocusNeighborBottom);
                castedNode.FocusNeighborBottom = n92;
            }

            if (FocusNext is Godot.NodePath n93)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNext", castedNode.FocusNext);
                castedNode.FocusNext = n93;
            }

            if (FocusPrevious is Godot.NodePath n94)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusPrevious", castedNode.FocusPrevious);
                castedNode.FocusPrevious = n94;
            }

            if (FocusMode is Godot.Control.FocusModeEnum n95)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusMode", castedNode.FocusMode);
                castedNode.FocusMode = n95;
            }

            if (MouseFilter is Godot.Control.MouseFilterEnum n96)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseFilter", castedNode.MouseFilter);
                castedNode.MouseFilter = n96;
            }

            if (MouseForcePassScrollEvents is System.Boolean n97)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseForcePassScrollEvents", castedNode.MouseForcePassScrollEvents);
                castedNode.MouseForcePassScrollEvents = n97;
            }

            if (MouseDefaultCursorShape is Godot.Control.CursorShape n98)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseDefaultCursorShape", castedNode.MouseDefaultCursorShape);
                castedNode.MouseDefaultCursorShape = n98;
            }

            if (ShortcutContext is Godot.Node n99)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutContext", castedNode.ShortcutContext);
                castedNode.ShortcutContext = n99;
            }

            if (Theme is Godot.Theme n100)
            {
                NodeStateManager.AddPropertyState(castedNode, "Theme", castedNode.Theme);
                castedNode.Theme = n100;
            }

            if (ThemeTypeVariation is Godot.StringName n101)
            {
                NodeStateManager.AddPropertyState(castedNode, "ThemeTypeVariation", castedNode.ThemeTypeVariation);
                castedNode.ThemeTypeVariation = n101;
            }

            if (Visible is System.Boolean n102)
            {
                NodeStateManager.AddPropertyState(castedNode, "Visible", castedNode.Visible);
                castedNode.Visible = n102;
            }

            if (Modulate is Godot.Color n103)
            {
                NodeStateManager.AddPropertyState(castedNode, "Modulate", castedNode.Modulate);
                castedNode.Modulate = n103;
            }

            if (SelfModulate is Godot.Color n104)
            {
                NodeStateManager.AddPropertyState(castedNode, "SelfModulate", castedNode.SelfModulate);
                castedNode.SelfModulate = n104;
            }

            if (ShowBehindParent is System.Boolean n105)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowBehindParent", castedNode.ShowBehindParent);
                castedNode.ShowBehindParent = n105;
            }

            if (TopLevel is System.Boolean n106)
            {
                NodeStateManager.AddPropertyState(castedNode, "TopLevel", castedNode.TopLevel);
                castedNode.TopLevel = n106;
            }

            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n107)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipChildren", castedNode.ClipChildren);
                castedNode.ClipChildren = n107;
            }

            if (LightMask is System.Int32 n108)
            {
                NodeStateManager.AddPropertyState(castedNode, "LightMask", castedNode.LightMask);
                castedNode.LightMask = n108;
            }

            if (VisibilityLayer is System.UInt32 n109)
            {
                NodeStateManager.AddPropertyState(castedNode, "VisibilityLayer", castedNode.VisibilityLayer);
                castedNode.VisibilityLayer = n109;
            }

            if (ZIndex is System.Int32 n110)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZIndex", castedNode.ZIndex);
                castedNode.ZIndex = n110;
            }

            if (ZAsRelative is System.Boolean n111)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZAsRelative", castedNode.ZAsRelative);
                castedNode.ZAsRelative = n111;
            }

            if (YSortEnabled is System.Boolean n112)
            {
                NodeStateManager.AddPropertyState(castedNode, "YSortEnabled", castedNode.YSortEnabled);
                castedNode.YSortEnabled = n112;
            }

            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n113)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureFilter", castedNode.TextureFilter);
                castedNode.TextureFilter = n113;
            }

            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n114)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureRepeat", castedNode.TextureRepeat);
                castedNode.TextureRepeat = n114;
            }

            if (Material is Godot.Material n115)
            {
                NodeStateManager.AddPropertyState(castedNode, "Material", castedNode.Material);
                castedNode.Material = n115;
            }

            if (UseParentMaterial is System.Boolean n116)
            {
                NodeStateManager.AddPropertyState(castedNode, "UseParentMaterial", castedNode.UseParentMaterial);
                castedNode.UseParentMaterial = n116;
            }

            if (Name is Godot.StringName n117)
            {
                NodeStateManager.AddPropertyState(castedNode, "Name", castedNode.Name);
                castedNode.Name = n117;
            }

            if (UniqueNameInOwner is System.Boolean n118)
            {
                NodeStateManager.AddPropertyState(castedNode, "UniqueNameInOwner", castedNode.UniqueNameInOwner);
                castedNode.UniqueNameInOwner = n118;
            }

            if (SceneFilePath is System.String n119)
            {
                NodeStateManager.AddPropertyState(castedNode, "SceneFilePath", castedNode.SceneFilePath);
                castedNode.SceneFilePath = n119;
            }

            if (Owner is Godot.Node n120)
            {
                NodeStateManager.AddPropertyState(castedNode, "Owner", castedNode.Owner);
                castedNode.Owner = n120;
            }

            if (ProcessMode is Godot.Node.ProcessModeEnum n121)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessMode", castedNode.ProcessMode);
                castedNode.ProcessMode = n121;
            }

            if (ProcessPriority is System.Int32 n122)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPriority", castedNode.ProcessPriority);
                castedNode.ProcessPriority = n122;
            }

            if (ProcessPhysicsPriority is System.Int32 n123)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPhysicsPriority", castedNode.ProcessPhysicsPriority);
                castedNode.ProcessPhysicsPriority = n123;
            }

            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n124)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroup", castedNode.ProcessThreadGroup);
                castedNode.ProcessThreadGroup = n124;
            }

            if (ProcessThreadGroupOrder is System.Int32 n125)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroupOrder", castedNode.ProcessThreadGroupOrder);
                castedNode.ProcessThreadGroupOrder = n125;
            }

            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n126)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadMessages", castedNode.ProcessThreadMessages);
                castedNode.ProcessThreadMessages = n126;
            }

            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n127)
            {
                NodeStateManager.AddPropertyState(castedNode, "PhysicsInterpolationMode", castedNode.PhysicsInterpolationMode);
                castedNode.PhysicsInterpolationMode = n127;
            }

            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n128)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslateMode", castedNode.AutoTranslateMode);
                castedNode.AutoTranslateMode = n128;
            }

            if (EditorDescription is System.String n129)
            {
                NodeStateManager.AddPropertyState(castedNode, "EditorDescription", castedNode.EditorDescription);
                castedNode.EditorDescription = n129;
            }

            if (BreakpointToggled is Godot.CodeEdit.BreakpointToggledEventHandler e0)
            {
                NodeStateManager.AddEventHandler(castedNode, "BreakpointToggled", e0);
                castedNode.BreakpointToggled += e0;
            }

            if (CodeCompletionRequested is System.Action e1)
            {
                NodeStateManager.AddEventHandler(castedNode, "CodeCompletionRequested", e1);
                castedNode.CodeCompletionRequested += e1;
            }

            if (SymbolLookup is Godot.CodeEdit.SymbolLookupEventHandler e2)
            {
                NodeStateManager.AddEventHandler(castedNode, "SymbolLookup", e2);
                castedNode.SymbolLookup += e2;
            }

            if (SymbolValidate is Godot.CodeEdit.SymbolValidateEventHandler e3)
            {
                NodeStateManager.AddEventHandler(castedNode, "SymbolValidate", e3);
                castedNode.SymbolValidate += e3;
            }

            if (TextSet is System.Action e4)
            {
                NodeStateManager.AddEventHandler(castedNode, "TextSet", e4);
                castedNode.TextSet += e4;
            }

            if (TextChanged is System.Action e5)
            {
                NodeStateManager.AddEventHandler(castedNode, "TextChanged", e5);
                castedNode.TextChanged += e5;
            }

            if (LinesEditedFrom is Godot.TextEdit.LinesEditedFromEventHandler e6)
            {
                NodeStateManager.AddEventHandler(castedNode, "LinesEditedFrom", e6);
                castedNode.LinesEditedFrom += e6;
            }

            if (CaretChanged is System.Action e7)
            {
                NodeStateManager.AddEventHandler(castedNode, "CaretChanged", e7);
                castedNode.CaretChanged += e7;
            }

            if (GutterClicked is Godot.TextEdit.GutterClickedEventHandler e8)
            {
                NodeStateManager.AddEventHandler(castedNode, "GutterClicked", e8);
                castedNode.GutterClicked += e8;
            }

            if (GutterAdded is System.Action e9)
            {
                NodeStateManager.AddEventHandler(castedNode, "GutterAdded", e9);
                castedNode.GutterAdded += e9;
            }

            if (GutterRemoved is System.Action e10)
            {
                NodeStateManager.AddEventHandler(castedNode, "GutterRemoved", e10);
                castedNode.GutterRemoved += e10;
            }

            if (Resized is System.Action e11)
            {
                NodeStateManager.AddEventHandler(castedNode, "Resized", e11);
                castedNode.Resized += e11;
            }

            if (GuiInput is Godot.Control.GuiInputEventHandler e12)
            {
                NodeStateManager.AddEventHandler(castedNode, "GuiInput", e12);
                castedNode.GuiInput += e12;
            }

            if (MouseEntered is System.Action e13)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseEntered", e13);
                castedNode.MouseEntered += e13;
            }

            if (MouseExited is System.Action e14)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseExited", e14);
                castedNode.MouseExited += e14;
            }

            if (FocusEntered is System.Action e15)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusEntered", e15);
                castedNode.FocusEntered += e15;
            }

            if (FocusExited is System.Action e16)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusExited", e16);
                castedNode.FocusExited += e16;
            }

            if (SizeFlagsChanged is System.Action e17)
            {
                NodeStateManager.AddEventHandler(castedNode, "SizeFlagsChanged", e17);
                castedNode.SizeFlagsChanged += e17;
            }

            if (MinimumSizeChanged is System.Action e18)
            {
                NodeStateManager.AddEventHandler(castedNode, "MinimumSizeChanged", e18);
                castedNode.MinimumSizeChanged += e18;
            }

            if (ThemeChanged is System.Action e19)
            {
                NodeStateManager.AddEventHandler(castedNode, "ThemeChanged", e19);
                castedNode.ThemeChanged += e19;
            }

            if (Draw is System.Action e20)
            {
                NodeStateManager.AddEventHandler(castedNode, "Draw", e20);
                castedNode.Draw += e20;
            }

            if (VisibilityChanged is System.Action e21)
            {
                NodeStateManager.AddEventHandler(castedNode, "VisibilityChanged", e21);
                castedNode.VisibilityChanged += e21;
            }

            if (Hidden is System.Action e22)
            {
                NodeStateManager.AddEventHandler(castedNode, "Hidden", e22);
                castedNode.Hidden += e22;
            }

            if (ItemRectChanged is System.Action e23)
            {
                NodeStateManager.AddEventHandler(castedNode, "ItemRectChanged", e23);
                castedNode.ItemRectChanged += e23;
            }

            if (Ready is System.Action e24)
            {
                NodeStateManager.AddEventHandler(castedNode, "Ready", e24);
                castedNode.Ready += e24;
            }

            if (Renamed is System.Action e25)
            {
                NodeStateManager.AddEventHandler(castedNode, "Renamed", e25);
                castedNode.Renamed += e25;
            }

            if (TreeEntered is System.Action e26)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeEntered", e26);
                castedNode.TreeEntered += e26;
            }

            if (TreeExiting is System.Action e27)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExiting", e27);
                castedNode.TreeExiting += e27;
            }

            if (TreeExited is System.Action e28)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExited", e28);
                castedNode.TreeExited += e28;
            }

            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e29)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildEnteredTree", e29);
                castedNode.ChildEnteredTree += e29;
            }

            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e30)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildExitingTree", e30);
                castedNode.ChildExitingTree += e30;
            }

            if (ChildOrderChanged is System.Action e31)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildOrderChanged", e31);
                castedNode.ChildOrderChanged += e31;
            }

            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e32)
            {
                NodeStateManager.AddEventHandler(castedNode, "ReplacingBy", e32);
                castedNode.ReplacingBy += e32;
            }

            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e33)
            {
                NodeStateManager.AddEventHandler(castedNode, "EditorDescriptionChanged", e33);
                castedNode.EditorDescriptionChanged += e33;
            }

            if (ScriptChanged is System.Action e34)
            {
                NodeStateManager.AddEventHandler(castedNode, "ScriptChanged", e34);
                castedNode.ScriptChanged += e34;
            }

            if (PropertyListChanged is System.Action e35)
            {
                NodeStateManager.AddEventHandler(castedNode, "PropertyListChanged", e35);
                castedNode.PropertyListChanged += e35;
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