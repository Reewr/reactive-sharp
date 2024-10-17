namespace ReactiveSharpGodot.Components
{
    public class LineEdit : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GLineEdit>
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
        public Godot.LineEdit.TextChangedEventHandler? TextChanged { protected get; init; }
        public Godot.LineEdit.TextChangeRejectedEventHandler? TextChangeRejected { protected get; init; }
        public Godot.LineEdit.TextSubmittedEventHandler? TextSubmitted { protected get; init; }
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

        public override ReactiveSharpGodot.Nodes.GLineEdit Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GLineEdit();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GLineEdit node)
        {
            var castedNode = (Godot.LineEdit)node.Node;
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
            if (ClipContents is System.Boolean n30)
                castedNode.ClipContents = n30;
            if (CustomMinimumSize is Godot.Vector2 n31)
                castedNode.CustomMinimumSize = n31;
            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n32)
                castedNode.LayoutDirection = n32;
            if (LayoutMode is System.Int32 n33)
                castedNode.LayoutMode = n33;
            if (AnchorsPreset is System.Int32 n34)
                castedNode.AnchorsPreset = n34;
            if (AnchorLeft is System.Single n35)
                castedNode.AnchorLeft = n35;
            if (AnchorTop is System.Single n36)
                castedNode.AnchorTop = n36;
            if (AnchorRight is System.Single n37)
                castedNode.AnchorRight = n37;
            if (AnchorBottom is System.Single n38)
                castedNode.AnchorBottom = n38;
            if (OffsetLeft is System.Single n39)
                castedNode.OffsetLeft = n39;
            if (OffsetTop is System.Single n40)
                castedNode.OffsetTop = n40;
            if (OffsetRight is System.Single n41)
                castedNode.OffsetRight = n41;
            if (OffsetBottom is System.Single n42)
                castedNode.OffsetBottom = n42;
            if (GrowHorizontal is Godot.Control.GrowDirection n43)
                castedNode.GrowHorizontal = n43;
            if (GrowVertical is Godot.Control.GrowDirection n44)
                castedNode.GrowVertical = n44;
            if (Size is Godot.Vector2 n45)
                castedNode.Size = n45;
            if (Position is Godot.Vector2 n46)
                castedNode.Position = n46;
            if (GlobalPosition is Godot.Vector2 n47)
                castedNode.GlobalPosition = n47;
            if (Rotation is System.Single n48)
                castedNode.Rotation = n48;
            if (RotationDegrees is System.Single n49)
                castedNode.RotationDegrees = n49;
            if (Scale is Godot.Vector2 n50)
                castedNode.Scale = n50;
            if (PivotOffset is Godot.Vector2 n51)
                castedNode.PivotOffset = n51;
            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n52)
                castedNode.SizeFlagsHorizontal = n52;
            if (SizeFlagsVertical is Godot.Control.SizeFlags n53)
                castedNode.SizeFlagsVertical = n53;
            if (SizeFlagsStretchRatio is System.Single n54)
                castedNode.SizeFlagsStretchRatio = n54;
            if (LocalizeNumeralSystem is System.Boolean n55)
                castedNode.LocalizeNumeralSystem = n55;
            if (AutoTranslate is System.Boolean n56)
                castedNode.AutoTranslate = n56;
            if (TooltipText is System.String n57)
                castedNode.TooltipText = n57;
            if (FocusNeighborLeft is Godot.NodePath n58)
                castedNode.FocusNeighborLeft = n58;
            if (FocusNeighborTop is Godot.NodePath n59)
                castedNode.FocusNeighborTop = n59;
            if (FocusNeighborRight is Godot.NodePath n60)
                castedNode.FocusNeighborRight = n60;
            if (FocusNeighborBottom is Godot.NodePath n61)
                castedNode.FocusNeighborBottom = n61;
            if (FocusNext is Godot.NodePath n62)
                castedNode.FocusNext = n62;
            if (FocusPrevious is Godot.NodePath n63)
                castedNode.FocusPrevious = n63;
            if (FocusMode is Godot.Control.FocusModeEnum n64)
                castedNode.FocusMode = n64;
            if (MouseFilter is Godot.Control.MouseFilterEnum n65)
                castedNode.MouseFilter = n65;
            if (MouseForcePassScrollEvents is System.Boolean n66)
                castedNode.MouseForcePassScrollEvents = n66;
            if (MouseDefaultCursorShape is Godot.Control.CursorShape n67)
                castedNode.MouseDefaultCursorShape = n67;
            if (ShortcutContext is Godot.Node n68)
                castedNode.ShortcutContext = n68;
            if (Theme is Godot.Theme n69)
                castedNode.Theme = n69;
            if (ThemeTypeVariation is Godot.StringName n70)
                castedNode.ThemeTypeVariation = n70;
            if (Visible is System.Boolean n71)
                castedNode.Visible = n71;
            if (Modulate is Godot.Color n72)
                castedNode.Modulate = n72;
            if (SelfModulate is Godot.Color n73)
                castedNode.SelfModulate = n73;
            if (ShowBehindParent is System.Boolean n74)
                castedNode.ShowBehindParent = n74;
            if (TopLevel is System.Boolean n75)
                castedNode.TopLevel = n75;
            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n76)
                castedNode.ClipChildren = n76;
            if (LightMask is System.Int32 n77)
                castedNode.LightMask = n77;
            if (VisibilityLayer is System.UInt32 n78)
                castedNode.VisibilityLayer = n78;
            if (ZIndex is System.Int32 n79)
                castedNode.ZIndex = n79;
            if (ZAsRelative is System.Boolean n80)
                castedNode.ZAsRelative = n80;
            if (YSortEnabled is System.Boolean n81)
                castedNode.YSortEnabled = n81;
            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n82)
                castedNode.TextureFilter = n82;
            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n83)
                castedNode.TextureRepeat = n83;
            if (Material is Godot.Material n84)
                castedNode.Material = n84;
            if (UseParentMaterial is System.Boolean n85)
                castedNode.UseParentMaterial = n85;
            if (Name is Godot.StringName n86)
                castedNode.Name = n86;
            if (UniqueNameInOwner is System.Boolean n87)
                castedNode.UniqueNameInOwner = n87;
            if (SceneFilePath is System.String n88)
                castedNode.SceneFilePath = n88;
            if (Owner is Godot.Node n89)
                castedNode.Owner = n89;
            if (ProcessMode is Godot.Node.ProcessModeEnum n90)
                castedNode.ProcessMode = n90;
            if (ProcessPriority is System.Int32 n91)
                castedNode.ProcessPriority = n91;
            if (ProcessPhysicsPriority is System.Int32 n92)
                castedNode.ProcessPhysicsPriority = n92;
            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n93)
                castedNode.ProcessThreadGroup = n93;
            if (ProcessThreadGroupOrder is System.Int32 n94)
                castedNode.ProcessThreadGroupOrder = n94;
            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n95)
                castedNode.ProcessThreadMessages = n95;
            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n96)
                castedNode.PhysicsInterpolationMode = n96;
            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n97)
                castedNode.AutoTranslateMode = n97;
            if (EditorDescription is System.String n98)
                castedNode.EditorDescription = n98;
            if (TextChanged is Godot.LineEdit.TextChangedEventHandler e0)
                castedNode.TextChanged += e0;
            if (TextChangeRejected is Godot.LineEdit.TextChangeRejectedEventHandler e1)
                castedNode.TextChangeRejected += e1;
            if (TextSubmitted is Godot.LineEdit.TextSubmittedEventHandler e2)
                castedNode.TextSubmitted += e2;
            if (Resized is System.Action e3)
                castedNode.Resized += e3;
            if (GuiInput is Godot.Control.GuiInputEventHandler e4)
                castedNode.GuiInput += e4;
            if (MouseEntered is System.Action e5)
                castedNode.MouseEntered += e5;
            if (MouseExited is System.Action e6)
                castedNode.MouseExited += e6;
            if (FocusEntered is System.Action e7)
                castedNode.FocusEntered += e7;
            if (FocusExited is System.Action e8)
                castedNode.FocusExited += e8;
            if (SizeFlagsChanged is System.Action e9)
                castedNode.SizeFlagsChanged += e9;
            if (MinimumSizeChanged is System.Action e10)
                castedNode.MinimumSizeChanged += e10;
            if (ThemeChanged is System.Action e11)
                castedNode.ThemeChanged += e11;
            if (Draw is System.Action e12)
                castedNode.Draw += e12;
            if (VisibilityChanged is System.Action e13)
                castedNode.VisibilityChanged += e13;
            if (Hidden is System.Action e14)
                castedNode.Hidden += e14;
            if (ItemRectChanged is System.Action e15)
                castedNode.ItemRectChanged += e15;
            if (Ready is System.Action e16)
                castedNode.Ready += e16;
            if (Renamed is System.Action e17)
                castedNode.Renamed += e17;
            if (TreeEntered is System.Action e18)
                castedNode.TreeEntered += e18;
            if (TreeExiting is System.Action e19)
                castedNode.TreeExiting += e19;
            if (TreeExited is System.Action e20)
                castedNode.TreeExited += e20;
            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e21)
                castedNode.ChildEnteredTree += e21;
            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e22)
                castedNode.ChildExitingTree += e22;
            if (ChildOrderChanged is System.Action e23)
                castedNode.ChildOrderChanged += e23;
            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e24)
                castedNode.ReplacingBy += e24;
            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e25)
                castedNode.EditorDescriptionChanged += e25;
            if (ScriptChanged is System.Action e26)
                castedNode.ScriptChanged += e26;
            if (PropertyListChanged is System.Action e27)
                castedNode.PropertyListChanged += e27;
        }
    }
}