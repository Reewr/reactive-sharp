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
                castedNode.SymbolLookupOnClick = n0;
            if (LineFolding is System.Boolean n1)
                castedNode.LineFolding = n1;
            if (LineLengthGuidelines is Godot.Collections.Array<System.Int32> n2)
                castedNode.LineLengthGuidelines = n2;
            if (GuttersDrawBreakpointsGutter is System.Boolean n3)
                castedNode.GuttersDrawBreakpointsGutter = n3;
            if (GuttersDrawBookmarks is System.Boolean n4)
                castedNode.GuttersDrawBookmarks = n4;
            if (GuttersDrawExecutingLines is System.Boolean n5)
                castedNode.GuttersDrawExecutingLines = n5;
            if (GuttersDrawLineNumbers is System.Boolean n6)
                castedNode.GuttersDrawLineNumbers = n6;
            if (GuttersZeroPadLineNumbers is System.Boolean n7)
                castedNode.GuttersZeroPadLineNumbers = n7;
            if (GuttersDrawFoldGutter is System.Boolean n8)
                castedNode.GuttersDrawFoldGutter = n8;
            if (DelimiterStrings is Godot.Collections.Array<System.String> n9)
                castedNode.DelimiterStrings = n9;
            if (DelimiterComments is Godot.Collections.Array<System.String> n10)
                castedNode.DelimiterComments = n10;
            if (CodeCompletionEnabled is System.Boolean n11)
                castedNode.CodeCompletionEnabled = n11;
            if (CodeCompletionPrefixes is Godot.Collections.Array<System.String> n12)
                castedNode.CodeCompletionPrefixes = n12;
            if (IndentSize is System.Int32 n13)
                castedNode.IndentSize = n13;
            if (IndentUseSpaces is System.Boolean n14)
                castedNode.IndentUseSpaces = n14;
            if (IndentAutomatic is System.Boolean n15)
                castedNode.IndentAutomatic = n15;
            if (IndentAutomaticPrefixes is Godot.Collections.Array<System.String> n16)
                castedNode.IndentAutomaticPrefixes = n16;
            if (AutoBraceCompletionEnabled is System.Boolean n17)
                castedNode.AutoBraceCompletionEnabled = n17;
            if (AutoBraceCompletionHighlightMatching is System.Boolean n18)
                castedNode.AutoBraceCompletionHighlightMatching = n18;
            if (AutoBraceCompletionPairs is Godot.Collections.Dictionary n19)
                castedNode.AutoBraceCompletionPairs = n19;
            if (Text is System.String n20)
                castedNode.Text = n20;
            if (PlaceholderText is System.String n21)
                castedNode.PlaceholderText = n21;
            if (Editable is System.Boolean n22)
                castedNode.Editable = n22;
            if (ContextMenuEnabled is System.Boolean n23)
                castedNode.ContextMenuEnabled = n23;
            if (ShortcutKeysEnabled is System.Boolean n24)
                castedNode.ShortcutKeysEnabled = n24;
            if (SelectingEnabled is System.Boolean n25)
                castedNode.SelectingEnabled = n25;
            if (DeselectOnFocusLossEnabled is System.Boolean n26)
                castedNode.DeselectOnFocusLossEnabled = n26;
            if (DragAndDropSelectionEnabled is System.Boolean n27)
                castedNode.DragAndDropSelectionEnabled = n27;
            if (VirtualKeyboardEnabled is System.Boolean n28)
                castedNode.VirtualKeyboardEnabled = n28;
            if (MiddleMousePasteEnabled is System.Boolean n29)
                castedNode.MiddleMousePasteEnabled = n29;
            if (WrapMode is Godot.TextEdit.LineWrappingMode n30)
                castedNode.WrapMode = n30;
            if (AutowrapMode is Godot.TextServer.AutowrapMode n31)
                castedNode.AutowrapMode = n31;
            if (IndentWrappedLines is System.Boolean n32)
                castedNode.IndentWrappedLines = n32;
            if (ScrollSmooth is System.Boolean n33)
                castedNode.ScrollSmooth = n33;
            if (ScrollVScrollSpeed is System.Single n34)
                castedNode.ScrollVScrollSpeed = n34;
            if (ScrollPastEndOfFile is System.Boolean n35)
                castedNode.ScrollPastEndOfFile = n35;
            if (ScrollVertical is System.Double n36)
                castedNode.ScrollVertical = n36;
            if (ScrollHorizontal is System.Int32 n37)
                castedNode.ScrollHorizontal = n37;
            if (ScrollFitContentHeight is System.Boolean n38)
                castedNode.ScrollFitContentHeight = n38;
            if (MinimapDraw is System.Boolean n39)
                castedNode.MinimapDraw = n39;
            if (MinimapWidth is System.Int32 n40)
                castedNode.MinimapWidth = n40;
            if (CaretType is Godot.TextEdit.CaretTypeEnum n41)
                castedNode.CaretType = n41;
            if (CaretBlink is System.Boolean n42)
                castedNode.CaretBlink = n42;
            if (CaretBlinkInterval is System.Single n43)
                castedNode.CaretBlinkInterval = n43;
            if (CaretDrawWhenEditableDisabled is System.Boolean n44)
                castedNode.CaretDrawWhenEditableDisabled = n44;
            if (CaretMoveOnRightClick is System.Boolean n45)
                castedNode.CaretMoveOnRightClick = n45;
            if (CaretMidGrapheme is System.Boolean n46)
                castedNode.CaretMidGrapheme = n46;
            if (CaretMultiple is System.Boolean n47)
                castedNode.CaretMultiple = n47;
            if (UseDefaultWordSeparators is System.Boolean n48)
                castedNode.UseDefaultWordSeparators = n48;
            if (UseCustomWordSeparators is System.Boolean n49)
                castedNode.UseCustomWordSeparators = n49;
            if (CustomWordSeparators is System.String n50)
                castedNode.CustomWordSeparators = n50;
            if (SyntaxHighlighter is Godot.SyntaxHighlighter n51)
                castedNode.SyntaxHighlighter = n51;
            if (HighlightAllOccurrences is System.Boolean n52)
                castedNode.HighlightAllOccurrences = n52;
            if (HighlightCurrentLine is System.Boolean n53)
                castedNode.HighlightCurrentLine = n53;
            if (DrawControlChars is System.Boolean n54)
                castedNode.DrawControlChars = n54;
            if (DrawTabs is System.Boolean n55)
                castedNode.DrawTabs = n55;
            if (DrawSpaces is System.Boolean n56)
                castedNode.DrawSpaces = n56;
            if (TextDirection is Godot.Control.TextDirection n57)
                castedNode.TextDirection = n57;
            if (Language is System.String n58)
                castedNode.Language = n58;
            if (StructuredTextBidiOverride is Godot.TextServer.StructuredTextParser n59)
                castedNode.StructuredTextBidiOverride = n59;
            if (StructuredTextBidiOverrideOptions is Godot.Collections.Array n60)
                castedNode.StructuredTextBidiOverrideOptions = n60;
            if (ClipContents is System.Boolean n61)
                castedNode.ClipContents = n61;
            if (CustomMinimumSize is Godot.Vector2 n62)
                castedNode.CustomMinimumSize = n62;
            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n63)
                castedNode.LayoutDirection = n63;
            if (LayoutMode is System.Int32 n64)
                castedNode.LayoutMode = n64;
            if (AnchorsPreset is System.Int32 n65)
                castedNode.AnchorsPreset = n65;
            if (AnchorLeft is System.Single n66)
                castedNode.AnchorLeft = n66;
            if (AnchorTop is System.Single n67)
                castedNode.AnchorTop = n67;
            if (AnchorRight is System.Single n68)
                castedNode.AnchorRight = n68;
            if (AnchorBottom is System.Single n69)
                castedNode.AnchorBottom = n69;
            if (OffsetLeft is System.Single n70)
                castedNode.OffsetLeft = n70;
            if (OffsetTop is System.Single n71)
                castedNode.OffsetTop = n71;
            if (OffsetRight is System.Single n72)
                castedNode.OffsetRight = n72;
            if (OffsetBottom is System.Single n73)
                castedNode.OffsetBottom = n73;
            if (GrowHorizontal is Godot.Control.GrowDirection n74)
                castedNode.GrowHorizontal = n74;
            if (GrowVertical is Godot.Control.GrowDirection n75)
                castedNode.GrowVertical = n75;
            if (Size is Godot.Vector2 n76)
                castedNode.Size = n76;
            if (Position is Godot.Vector2 n77)
                castedNode.Position = n77;
            if (GlobalPosition is Godot.Vector2 n78)
                castedNode.GlobalPosition = n78;
            if (Rotation is System.Single n79)
                castedNode.Rotation = n79;
            if (RotationDegrees is System.Single n80)
                castedNode.RotationDegrees = n80;
            if (Scale is Godot.Vector2 n81)
                castedNode.Scale = n81;
            if (PivotOffset is Godot.Vector2 n82)
                castedNode.PivotOffset = n82;
            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n83)
                castedNode.SizeFlagsHorizontal = n83;
            if (SizeFlagsVertical is Godot.Control.SizeFlags n84)
                castedNode.SizeFlagsVertical = n84;
            if (SizeFlagsStretchRatio is System.Single n85)
                castedNode.SizeFlagsStretchRatio = n85;
            if (LocalizeNumeralSystem is System.Boolean n86)
                castedNode.LocalizeNumeralSystem = n86;
            if (AutoTranslate is System.Boolean n87)
                castedNode.AutoTranslate = n87;
            if (TooltipText is System.String n88)
                castedNode.TooltipText = n88;
            if (FocusNeighborLeft is Godot.NodePath n89)
                castedNode.FocusNeighborLeft = n89;
            if (FocusNeighborTop is Godot.NodePath n90)
                castedNode.FocusNeighborTop = n90;
            if (FocusNeighborRight is Godot.NodePath n91)
                castedNode.FocusNeighborRight = n91;
            if (FocusNeighborBottom is Godot.NodePath n92)
                castedNode.FocusNeighborBottom = n92;
            if (FocusNext is Godot.NodePath n93)
                castedNode.FocusNext = n93;
            if (FocusPrevious is Godot.NodePath n94)
                castedNode.FocusPrevious = n94;
            if (FocusMode is Godot.Control.FocusModeEnum n95)
                castedNode.FocusMode = n95;
            if (MouseFilter is Godot.Control.MouseFilterEnum n96)
                castedNode.MouseFilter = n96;
            if (MouseForcePassScrollEvents is System.Boolean n97)
                castedNode.MouseForcePassScrollEvents = n97;
            if (MouseDefaultCursorShape is Godot.Control.CursorShape n98)
                castedNode.MouseDefaultCursorShape = n98;
            if (ShortcutContext is Godot.Node n99)
                castedNode.ShortcutContext = n99;
            if (Theme is Godot.Theme n100)
                castedNode.Theme = n100;
            if (ThemeTypeVariation is Godot.StringName n101)
                castedNode.ThemeTypeVariation = n101;
            if (Visible is System.Boolean n102)
                castedNode.Visible = n102;
            if (Modulate is Godot.Color n103)
                castedNode.Modulate = n103;
            if (SelfModulate is Godot.Color n104)
                castedNode.SelfModulate = n104;
            if (ShowBehindParent is System.Boolean n105)
                castedNode.ShowBehindParent = n105;
            if (TopLevel is System.Boolean n106)
                castedNode.TopLevel = n106;
            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n107)
                castedNode.ClipChildren = n107;
            if (LightMask is System.Int32 n108)
                castedNode.LightMask = n108;
            if (VisibilityLayer is System.UInt32 n109)
                castedNode.VisibilityLayer = n109;
            if (ZIndex is System.Int32 n110)
                castedNode.ZIndex = n110;
            if (ZAsRelative is System.Boolean n111)
                castedNode.ZAsRelative = n111;
            if (YSortEnabled is System.Boolean n112)
                castedNode.YSortEnabled = n112;
            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n113)
                castedNode.TextureFilter = n113;
            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n114)
                castedNode.TextureRepeat = n114;
            if (Material is Godot.Material n115)
                castedNode.Material = n115;
            if (UseParentMaterial is System.Boolean n116)
                castedNode.UseParentMaterial = n116;
            if (Name is Godot.StringName n117)
                castedNode.Name = n117;
            if (UniqueNameInOwner is System.Boolean n118)
                castedNode.UniqueNameInOwner = n118;
            if (SceneFilePath is System.String n119)
                castedNode.SceneFilePath = n119;
            if (Owner is Godot.Node n120)
                castedNode.Owner = n120;
            if (ProcessMode is Godot.Node.ProcessModeEnum n121)
                castedNode.ProcessMode = n121;
            if (ProcessPriority is System.Int32 n122)
                castedNode.ProcessPriority = n122;
            if (ProcessPhysicsPriority is System.Int32 n123)
                castedNode.ProcessPhysicsPriority = n123;
            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n124)
                castedNode.ProcessThreadGroup = n124;
            if (ProcessThreadGroupOrder is System.Int32 n125)
                castedNode.ProcessThreadGroupOrder = n125;
            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n126)
                castedNode.ProcessThreadMessages = n126;
            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n127)
                castedNode.PhysicsInterpolationMode = n127;
            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n128)
                castedNode.AutoTranslateMode = n128;
            if (EditorDescription is System.String n129)
                castedNode.EditorDescription = n129;
            if (BreakpointToggled is Godot.CodeEdit.BreakpointToggledEventHandler e0)
                castedNode.BreakpointToggled += e0;
            if (CodeCompletionRequested is System.Action e1)
                castedNode.CodeCompletionRequested += e1;
            if (SymbolLookup is Godot.CodeEdit.SymbolLookupEventHandler e2)
                castedNode.SymbolLookup += e2;
            if (SymbolValidate is Godot.CodeEdit.SymbolValidateEventHandler e3)
                castedNode.SymbolValidate += e3;
            if (TextSet is System.Action e4)
                castedNode.TextSet += e4;
            if (TextChanged is System.Action e5)
                castedNode.TextChanged += e5;
            if (LinesEditedFrom is Godot.TextEdit.LinesEditedFromEventHandler e6)
                castedNode.LinesEditedFrom += e6;
            if (CaretChanged is System.Action e7)
                castedNode.CaretChanged += e7;
            if (GutterClicked is Godot.TextEdit.GutterClickedEventHandler e8)
                castedNode.GutterClicked += e8;
            if (GutterAdded is System.Action e9)
                castedNode.GutterAdded += e9;
            if (GutterRemoved is System.Action e10)
                castedNode.GutterRemoved += e10;
            if (Resized is System.Action e11)
                castedNode.Resized += e11;
            if (GuiInput is Godot.Control.GuiInputEventHandler e12)
                castedNode.GuiInput += e12;
            if (MouseEntered is System.Action e13)
                castedNode.MouseEntered += e13;
            if (MouseExited is System.Action e14)
                castedNode.MouseExited += e14;
            if (FocusEntered is System.Action e15)
                castedNode.FocusEntered += e15;
            if (FocusExited is System.Action e16)
                castedNode.FocusExited += e16;
            if (SizeFlagsChanged is System.Action e17)
                castedNode.SizeFlagsChanged += e17;
            if (MinimumSizeChanged is System.Action e18)
                castedNode.MinimumSizeChanged += e18;
            if (ThemeChanged is System.Action e19)
                castedNode.ThemeChanged += e19;
            if (Draw is System.Action e20)
                castedNode.Draw += e20;
            if (VisibilityChanged is System.Action e21)
                castedNode.VisibilityChanged += e21;
            if (Hidden is System.Action e22)
                castedNode.Hidden += e22;
            if (ItemRectChanged is System.Action e23)
                castedNode.ItemRectChanged += e23;
            if (Ready is System.Action e24)
                castedNode.Ready += e24;
            if (Renamed is System.Action e25)
                castedNode.Renamed += e25;
            if (TreeEntered is System.Action e26)
                castedNode.TreeEntered += e26;
            if (TreeExiting is System.Action e27)
                castedNode.TreeExiting += e27;
            if (TreeExited is System.Action e28)
                castedNode.TreeExited += e28;
            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e29)
                castedNode.ChildEnteredTree += e29;
            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e30)
                castedNode.ChildExitingTree += e30;
            if (ChildOrderChanged is System.Action e31)
                castedNode.ChildOrderChanged += e31;
            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e32)
                castedNode.ReplacingBy += e32;
            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e33)
                castedNode.EditorDescriptionChanged += e33;
            if (ScriptChanged is System.Action e34)
                castedNode.ScriptChanged += e34;
            if (PropertyListChanged is System.Action e35)
                castedNode.PropertyListChanged += e35;
        }
    }
}