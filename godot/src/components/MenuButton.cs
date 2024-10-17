namespace ReactiveSharpGodot.Components
{
    public class MenuButton : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GMenuButton>
    {
        public System.Boolean? SwitchOnHover { protected get; init; }
        public System.Int32? ItemCount { protected get; init; }
        public System.String? Text { protected get; init; }
        public Godot.Texture2D? Icon { protected get; init; }
        public System.Boolean? Flat { protected get; init; }
        public Godot.HorizontalAlignment? Alignment { protected get; init; }
        public Godot.TextServer.OverrunBehavior? TextOverrunBehavior { protected get; init; }
        public Godot.TextServer.AutowrapMode? AutowrapMode { protected get; init; }
        public System.Boolean? ClipText { protected get; init; }
        public Godot.HorizontalAlignment? IconAlignment { protected get; init; }
        public Godot.VerticalAlignment? VerticalIconAlignment { protected get; init; }
        public System.Boolean? ExpandIcon { protected get; init; }
        public Godot.Control.TextDirection? TextDirection { protected get; init; }
        public System.String? Language { protected get; init; }
        public System.Boolean? Disabled { protected get; init; }
        public System.Boolean? ToggleMode { protected get; init; }
        public System.Boolean? ButtonPressed { protected get; init; }
        public Godot.BaseButton.ActionModeEnum? ActionMode { protected get; init; }
        public Godot.MouseButtonMask? ButtonMask { protected get; init; }
        public System.Boolean? KeepPressedOutside { protected get; init; }
        public Godot.ButtonGroup? ButtonGroup { protected get; init; }
        public Godot.Shortcut? Shortcut { protected get; init; }
        public System.Boolean? ShortcutFeedback { protected get; init; }
        public System.Boolean? ShortcutInTooltip { protected get; init; }
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
        public System.Action? AboutToPopup { protected get; init; }
        public System.Action? Pressed { protected get; init; }
        public System.Action? ButtonUp { protected get; init; }
        public System.Action? ButtonDown { protected get; init; }
        public Godot.BaseButton.ToggledEventHandler? Toggled { protected get; init; }
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

        public override ReactiveSharpGodot.Nodes.GMenuButton Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GMenuButton();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GMenuButton node)
        {
            var castedNode = (Godot.MenuButton)node.Node;
            if (SwitchOnHover is System.Boolean n0)
                castedNode.SwitchOnHover = n0;
            if (ItemCount is System.Int32 n1)
                castedNode.ItemCount = n1;
            if (Text is System.String n2)
                castedNode.Text = n2;
            if (Icon is Godot.Texture2D n3)
                castedNode.Icon = n3;
            if (Flat is System.Boolean n4)
                castedNode.Flat = n4;
            if (Alignment is Godot.HorizontalAlignment n5)
                castedNode.Alignment = n5;
            if (TextOverrunBehavior is Godot.TextServer.OverrunBehavior n6)
                castedNode.TextOverrunBehavior = n6;
            if (AutowrapMode is Godot.TextServer.AutowrapMode n7)
                castedNode.AutowrapMode = n7;
            if (ClipText is System.Boolean n8)
                castedNode.ClipText = n8;
            if (IconAlignment is Godot.HorizontalAlignment n9)
                castedNode.IconAlignment = n9;
            if (VerticalIconAlignment is Godot.VerticalAlignment n10)
                castedNode.VerticalIconAlignment = n10;
            if (ExpandIcon is System.Boolean n11)
                castedNode.ExpandIcon = n11;
            if (TextDirection is Godot.Control.TextDirection n12)
                castedNode.TextDirection = n12;
            if (Language is System.String n13)
                castedNode.Language = n13;
            if (Disabled is System.Boolean n14)
                castedNode.Disabled = n14;
            if (ToggleMode is System.Boolean n15)
                castedNode.ToggleMode = n15;
            if (ButtonPressed is System.Boolean n16)
                castedNode.ButtonPressed = n16;
            if (ActionMode is Godot.BaseButton.ActionModeEnum n17)
                castedNode.ActionMode = n17;
            if (ButtonMask is Godot.MouseButtonMask n18)
                castedNode.ButtonMask = n18;
            if (KeepPressedOutside is System.Boolean n19)
                castedNode.KeepPressedOutside = n19;
            if (ButtonGroup is Godot.ButtonGroup n20)
                castedNode.ButtonGroup = n20;
            if (Shortcut is Godot.Shortcut n21)
                castedNode.Shortcut = n21;
            if (ShortcutFeedback is System.Boolean n22)
                castedNode.ShortcutFeedback = n22;
            if (ShortcutInTooltip is System.Boolean n23)
                castedNode.ShortcutInTooltip = n23;
            if (ClipContents is System.Boolean n24)
                castedNode.ClipContents = n24;
            if (CustomMinimumSize is Godot.Vector2 n25)
                castedNode.CustomMinimumSize = n25;
            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n26)
                castedNode.LayoutDirection = n26;
            if (LayoutMode is System.Int32 n27)
                castedNode.LayoutMode = n27;
            if (AnchorsPreset is System.Int32 n28)
                castedNode.AnchorsPreset = n28;
            if (AnchorLeft is System.Single n29)
                castedNode.AnchorLeft = n29;
            if (AnchorTop is System.Single n30)
                castedNode.AnchorTop = n30;
            if (AnchorRight is System.Single n31)
                castedNode.AnchorRight = n31;
            if (AnchorBottom is System.Single n32)
                castedNode.AnchorBottom = n32;
            if (OffsetLeft is System.Single n33)
                castedNode.OffsetLeft = n33;
            if (OffsetTop is System.Single n34)
                castedNode.OffsetTop = n34;
            if (OffsetRight is System.Single n35)
                castedNode.OffsetRight = n35;
            if (OffsetBottom is System.Single n36)
                castedNode.OffsetBottom = n36;
            if (GrowHorizontal is Godot.Control.GrowDirection n37)
                castedNode.GrowHorizontal = n37;
            if (GrowVertical is Godot.Control.GrowDirection n38)
                castedNode.GrowVertical = n38;
            if (Size is Godot.Vector2 n39)
                castedNode.Size = n39;
            if (Position is Godot.Vector2 n40)
                castedNode.Position = n40;
            if (GlobalPosition is Godot.Vector2 n41)
                castedNode.GlobalPosition = n41;
            if (Rotation is System.Single n42)
                castedNode.Rotation = n42;
            if (RotationDegrees is System.Single n43)
                castedNode.RotationDegrees = n43;
            if (Scale is Godot.Vector2 n44)
                castedNode.Scale = n44;
            if (PivotOffset is Godot.Vector2 n45)
                castedNode.PivotOffset = n45;
            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n46)
                castedNode.SizeFlagsHorizontal = n46;
            if (SizeFlagsVertical is Godot.Control.SizeFlags n47)
                castedNode.SizeFlagsVertical = n47;
            if (SizeFlagsStretchRatio is System.Single n48)
                castedNode.SizeFlagsStretchRatio = n48;
            if (LocalizeNumeralSystem is System.Boolean n49)
                castedNode.LocalizeNumeralSystem = n49;
            if (AutoTranslate is System.Boolean n50)
                castedNode.AutoTranslate = n50;
            if (TooltipText is System.String n51)
                castedNode.TooltipText = n51;
            if (FocusNeighborLeft is Godot.NodePath n52)
                castedNode.FocusNeighborLeft = n52;
            if (FocusNeighborTop is Godot.NodePath n53)
                castedNode.FocusNeighborTop = n53;
            if (FocusNeighborRight is Godot.NodePath n54)
                castedNode.FocusNeighborRight = n54;
            if (FocusNeighborBottom is Godot.NodePath n55)
                castedNode.FocusNeighborBottom = n55;
            if (FocusNext is Godot.NodePath n56)
                castedNode.FocusNext = n56;
            if (FocusPrevious is Godot.NodePath n57)
                castedNode.FocusPrevious = n57;
            if (FocusMode is Godot.Control.FocusModeEnum n58)
                castedNode.FocusMode = n58;
            if (MouseFilter is Godot.Control.MouseFilterEnum n59)
                castedNode.MouseFilter = n59;
            if (MouseForcePassScrollEvents is System.Boolean n60)
                castedNode.MouseForcePassScrollEvents = n60;
            if (MouseDefaultCursorShape is Godot.Control.CursorShape n61)
                castedNode.MouseDefaultCursorShape = n61;
            if (ShortcutContext is Godot.Node n62)
                castedNode.ShortcutContext = n62;
            if (Theme is Godot.Theme n63)
                castedNode.Theme = n63;
            if (ThemeTypeVariation is Godot.StringName n64)
                castedNode.ThemeTypeVariation = n64;
            if (Visible is System.Boolean n65)
                castedNode.Visible = n65;
            if (Modulate is Godot.Color n66)
                castedNode.Modulate = n66;
            if (SelfModulate is Godot.Color n67)
                castedNode.SelfModulate = n67;
            if (ShowBehindParent is System.Boolean n68)
                castedNode.ShowBehindParent = n68;
            if (TopLevel is System.Boolean n69)
                castedNode.TopLevel = n69;
            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n70)
                castedNode.ClipChildren = n70;
            if (LightMask is System.Int32 n71)
                castedNode.LightMask = n71;
            if (VisibilityLayer is System.UInt32 n72)
                castedNode.VisibilityLayer = n72;
            if (ZIndex is System.Int32 n73)
                castedNode.ZIndex = n73;
            if (ZAsRelative is System.Boolean n74)
                castedNode.ZAsRelative = n74;
            if (YSortEnabled is System.Boolean n75)
                castedNode.YSortEnabled = n75;
            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n76)
                castedNode.TextureFilter = n76;
            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n77)
                castedNode.TextureRepeat = n77;
            if (Material is Godot.Material n78)
                castedNode.Material = n78;
            if (UseParentMaterial is System.Boolean n79)
                castedNode.UseParentMaterial = n79;
            if (Name is Godot.StringName n80)
                castedNode.Name = n80;
            if (UniqueNameInOwner is System.Boolean n81)
                castedNode.UniqueNameInOwner = n81;
            if (SceneFilePath is System.String n82)
                castedNode.SceneFilePath = n82;
            if (Owner is Godot.Node n83)
                castedNode.Owner = n83;
            if (ProcessMode is Godot.Node.ProcessModeEnum n84)
                castedNode.ProcessMode = n84;
            if (ProcessPriority is System.Int32 n85)
                castedNode.ProcessPriority = n85;
            if (ProcessPhysicsPriority is System.Int32 n86)
                castedNode.ProcessPhysicsPriority = n86;
            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n87)
                castedNode.ProcessThreadGroup = n87;
            if (ProcessThreadGroupOrder is System.Int32 n88)
                castedNode.ProcessThreadGroupOrder = n88;
            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n89)
                castedNode.ProcessThreadMessages = n89;
            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n90)
                castedNode.PhysicsInterpolationMode = n90;
            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n91)
                castedNode.AutoTranslateMode = n91;
            if (EditorDescription is System.String n92)
                castedNode.EditorDescription = n92;
            if (AboutToPopup is System.Action e0)
                castedNode.AboutToPopup += e0;
            if (Pressed is System.Action e1)
                castedNode.Pressed += e1;
            if (ButtonUp is System.Action e2)
                castedNode.ButtonUp += e2;
            if (ButtonDown is System.Action e3)
                castedNode.ButtonDown += e3;
            if (Toggled is Godot.BaseButton.ToggledEventHandler e4)
                castedNode.Toggled += e4;
            if (Resized is System.Action e5)
                castedNode.Resized += e5;
            if (GuiInput is Godot.Control.GuiInputEventHandler e6)
                castedNode.GuiInput += e6;
            if (MouseEntered is System.Action e7)
                castedNode.MouseEntered += e7;
            if (MouseExited is System.Action e8)
                castedNode.MouseExited += e8;
            if (FocusEntered is System.Action e9)
                castedNode.FocusEntered += e9;
            if (FocusExited is System.Action e10)
                castedNode.FocusExited += e10;
            if (SizeFlagsChanged is System.Action e11)
                castedNode.SizeFlagsChanged += e11;
            if (MinimumSizeChanged is System.Action e12)
                castedNode.MinimumSizeChanged += e12;
            if (ThemeChanged is System.Action e13)
                castedNode.ThemeChanged += e13;
            if (Draw is System.Action e14)
                castedNode.Draw += e14;
            if (VisibilityChanged is System.Action e15)
                castedNode.VisibilityChanged += e15;
            if (Hidden is System.Action e16)
                castedNode.Hidden += e16;
            if (ItemRectChanged is System.Action e17)
                castedNode.ItemRectChanged += e17;
            if (Ready is System.Action e18)
                castedNode.Ready += e18;
            if (Renamed is System.Action e19)
                castedNode.Renamed += e19;
            if (TreeEntered is System.Action e20)
                castedNode.TreeEntered += e20;
            if (TreeExiting is System.Action e21)
                castedNode.TreeExiting += e21;
            if (TreeExited is System.Action e22)
                castedNode.TreeExited += e22;
            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e23)
                castedNode.ChildEnteredTree += e23;
            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e24)
                castedNode.ChildExitingTree += e24;
            if (ChildOrderChanged is System.Action e25)
                castedNode.ChildOrderChanged += e25;
            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e26)
                castedNode.ReplacingBy += e26;
            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e27)
                castedNode.EditorDescriptionChanged += e27;
            if (ScriptChanged is System.Action e28)
                castedNode.ScriptChanged += e28;
            if (PropertyListChanged is System.Action e29)
                castedNode.PropertyListChanged += e29;
        }
    }
}