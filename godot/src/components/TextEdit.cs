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
            if (ClipContents is System.Boolean n41)
                castedNode.ClipContents = n41;
            if (CustomMinimumSize is Godot.Vector2 n42)
                castedNode.CustomMinimumSize = n42;
            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n43)
                castedNode.LayoutDirection = n43;
            if (LayoutMode is System.Int32 n44)
                castedNode.LayoutMode = n44;
            if (AnchorsPreset is System.Int32 n45)
                castedNode.AnchorsPreset = n45;
            if (AnchorLeft is System.Single n46)
                castedNode.AnchorLeft = n46;
            if (AnchorTop is System.Single n47)
                castedNode.AnchorTop = n47;
            if (AnchorRight is System.Single n48)
                castedNode.AnchorRight = n48;
            if (AnchorBottom is System.Single n49)
                castedNode.AnchorBottom = n49;
            if (OffsetLeft is System.Single n50)
                castedNode.OffsetLeft = n50;
            if (OffsetTop is System.Single n51)
                castedNode.OffsetTop = n51;
            if (OffsetRight is System.Single n52)
                castedNode.OffsetRight = n52;
            if (OffsetBottom is System.Single n53)
                castedNode.OffsetBottom = n53;
            if (GrowHorizontal is Godot.Control.GrowDirection n54)
                castedNode.GrowHorizontal = n54;
            if (GrowVertical is Godot.Control.GrowDirection n55)
                castedNode.GrowVertical = n55;
            if (Size is Godot.Vector2 n56)
                castedNode.Size = n56;
            if (Position is Godot.Vector2 n57)
                castedNode.Position = n57;
            if (GlobalPosition is Godot.Vector2 n58)
                castedNode.GlobalPosition = n58;
            if (Rotation is System.Single n59)
                castedNode.Rotation = n59;
            if (RotationDegrees is System.Single n60)
                castedNode.RotationDegrees = n60;
            if (Scale is Godot.Vector2 n61)
                castedNode.Scale = n61;
            if (PivotOffset is Godot.Vector2 n62)
                castedNode.PivotOffset = n62;
            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n63)
                castedNode.SizeFlagsHorizontal = n63;
            if (SizeFlagsVertical is Godot.Control.SizeFlags n64)
                castedNode.SizeFlagsVertical = n64;
            if (SizeFlagsStretchRatio is System.Single n65)
                castedNode.SizeFlagsStretchRatio = n65;
            if (LocalizeNumeralSystem is System.Boolean n66)
                castedNode.LocalizeNumeralSystem = n66;
            if (AutoTranslate is System.Boolean n67)
                castedNode.AutoTranslate = n67;
            if (TooltipText is System.String n68)
                castedNode.TooltipText = n68;
            if (FocusNeighborLeft is Godot.NodePath n69)
                castedNode.FocusNeighborLeft = n69;
            if (FocusNeighborTop is Godot.NodePath n70)
                castedNode.FocusNeighborTop = n70;
            if (FocusNeighborRight is Godot.NodePath n71)
                castedNode.FocusNeighborRight = n71;
            if (FocusNeighborBottom is Godot.NodePath n72)
                castedNode.FocusNeighborBottom = n72;
            if (FocusNext is Godot.NodePath n73)
                castedNode.FocusNext = n73;
            if (FocusPrevious is Godot.NodePath n74)
                castedNode.FocusPrevious = n74;
            if (FocusMode is Godot.Control.FocusModeEnum n75)
                castedNode.FocusMode = n75;
            if (MouseFilter is Godot.Control.MouseFilterEnum n76)
                castedNode.MouseFilter = n76;
            if (MouseForcePassScrollEvents is System.Boolean n77)
                castedNode.MouseForcePassScrollEvents = n77;
            if (MouseDefaultCursorShape is Godot.Control.CursorShape n78)
                castedNode.MouseDefaultCursorShape = n78;
            if (ShortcutContext is Godot.Node n79)
                castedNode.ShortcutContext = n79;
            if (Theme is Godot.Theme n80)
                castedNode.Theme = n80;
            if (ThemeTypeVariation is Godot.StringName n81)
                castedNode.ThemeTypeVariation = n81;
            if (Visible is System.Boolean n82)
                castedNode.Visible = n82;
            if (Modulate is Godot.Color n83)
                castedNode.Modulate = n83;
            if (SelfModulate is Godot.Color n84)
                castedNode.SelfModulate = n84;
            if (ShowBehindParent is System.Boolean n85)
                castedNode.ShowBehindParent = n85;
            if (TopLevel is System.Boolean n86)
                castedNode.TopLevel = n86;
            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n87)
                castedNode.ClipChildren = n87;
            if (LightMask is System.Int32 n88)
                castedNode.LightMask = n88;
            if (VisibilityLayer is System.UInt32 n89)
                castedNode.VisibilityLayer = n89;
            if (ZIndex is System.Int32 n90)
                castedNode.ZIndex = n90;
            if (ZAsRelative is System.Boolean n91)
                castedNode.ZAsRelative = n91;
            if (YSortEnabled is System.Boolean n92)
                castedNode.YSortEnabled = n92;
            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n93)
                castedNode.TextureFilter = n93;
            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n94)
                castedNode.TextureRepeat = n94;
            if (Material is Godot.Material n95)
                castedNode.Material = n95;
            if (UseParentMaterial is System.Boolean n96)
                castedNode.UseParentMaterial = n96;
            if (Name is Godot.StringName n97)
                castedNode.Name = n97;
            if (UniqueNameInOwner is System.Boolean n98)
                castedNode.UniqueNameInOwner = n98;
            if (SceneFilePath is System.String n99)
                castedNode.SceneFilePath = n99;
            if (Owner is Godot.Node n100)
                castedNode.Owner = n100;
            if (ProcessMode is Godot.Node.ProcessModeEnum n101)
                castedNode.ProcessMode = n101;
            if (ProcessPriority is System.Int32 n102)
                castedNode.ProcessPriority = n102;
            if (ProcessPhysicsPriority is System.Int32 n103)
                castedNode.ProcessPhysicsPriority = n103;
            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n104)
                castedNode.ProcessThreadGroup = n104;
            if (ProcessThreadGroupOrder is System.Int32 n105)
                castedNode.ProcessThreadGroupOrder = n105;
            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n106)
                castedNode.ProcessThreadMessages = n106;
            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n107)
                castedNode.PhysicsInterpolationMode = n107;
            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n108)
                castedNode.AutoTranslateMode = n108;
            if (EditorDescription is System.String n109)
                castedNode.EditorDescription = n109;
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
            if (Resized is System.Action e7)
                castedNode.Resized += e7;
            if (GuiInput is Godot.Control.GuiInputEventHandler e8)
                castedNode.GuiInput += e8;
            if (MouseEntered is System.Action e9)
                castedNode.MouseEntered += e9;
            if (MouseExited is System.Action e10)
                castedNode.MouseExited += e10;
            if (FocusEntered is System.Action e11)
                castedNode.FocusEntered += e11;
            if (FocusExited is System.Action e12)
                castedNode.FocusExited += e12;
            if (SizeFlagsChanged is System.Action e13)
                castedNode.SizeFlagsChanged += e13;
            if (MinimumSizeChanged is System.Action e14)
                castedNode.MinimumSizeChanged += e14;
            if (ThemeChanged is System.Action e15)
                castedNode.ThemeChanged += e15;
            if (Draw is System.Action e16)
                castedNode.Draw += e16;
            if (VisibilityChanged is System.Action e17)
                castedNode.VisibilityChanged += e17;
            if (Hidden is System.Action e18)
                castedNode.Hidden += e18;
            if (ItemRectChanged is System.Action e19)
                castedNode.ItemRectChanged += e19;
            if (Ready is System.Action e20)
                castedNode.Ready += e20;
            if (Renamed is System.Action e21)
                castedNode.Renamed += e21;
            if (TreeEntered is System.Action e22)
                castedNode.TreeEntered += e22;
            if (TreeExiting is System.Action e23)
                castedNode.TreeExiting += e23;
            if (TreeExited is System.Action e24)
                castedNode.TreeExited += e24;
            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e25)
                castedNode.ChildEnteredTree += e25;
            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e26)
                castedNode.ChildExitingTree += e26;
            if (ChildOrderChanged is System.Action e27)
                castedNode.ChildOrderChanged += e27;
            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e28)
                castedNode.ReplacingBy += e28;
            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e29)
                castedNode.EditorDescriptionChanged += e29;
            if (ScriptChanged is System.Action e30)
                castedNode.ScriptChanged += e30;
            if (PropertyListChanged is System.Action e31)
                castedNode.PropertyListChanged += e31;
        }
    }
}