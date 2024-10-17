namespace ReactiveSharpGodot.Components
{
    public class Button : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GButton>
    {
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

        public override ReactiveSharpGodot.Nodes.GButton Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GButton();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GButton node)
        {
            var castedNode = (Godot.Button)node.Node;
            if (Text is System.String n0)
                castedNode.Text = n0;
            if (Icon is Godot.Texture2D n1)
                castedNode.Icon = n1;
            if (Flat is System.Boolean n2)
                castedNode.Flat = n2;
            if (Alignment is Godot.HorizontalAlignment n3)
                castedNode.Alignment = n3;
            if (TextOverrunBehavior is Godot.TextServer.OverrunBehavior n4)
                castedNode.TextOverrunBehavior = n4;
            if (AutowrapMode is Godot.TextServer.AutowrapMode n5)
                castedNode.AutowrapMode = n5;
            if (ClipText is System.Boolean n6)
                castedNode.ClipText = n6;
            if (IconAlignment is Godot.HorizontalAlignment n7)
                castedNode.IconAlignment = n7;
            if (VerticalIconAlignment is Godot.VerticalAlignment n8)
                castedNode.VerticalIconAlignment = n8;
            if (ExpandIcon is System.Boolean n9)
                castedNode.ExpandIcon = n9;
            if (TextDirection is Godot.Control.TextDirection n10)
                castedNode.TextDirection = n10;
            if (Language is System.String n11)
                castedNode.Language = n11;
            if (Disabled is System.Boolean n12)
                castedNode.Disabled = n12;
            if (ToggleMode is System.Boolean n13)
                castedNode.ToggleMode = n13;
            if (ButtonPressed is System.Boolean n14)
                castedNode.ButtonPressed = n14;
            if (ActionMode is Godot.BaseButton.ActionModeEnum n15)
                castedNode.ActionMode = n15;
            if (ButtonMask is Godot.MouseButtonMask n16)
                castedNode.ButtonMask = n16;
            if (KeepPressedOutside is System.Boolean n17)
                castedNode.KeepPressedOutside = n17;
            if (ButtonGroup is Godot.ButtonGroup n18)
                castedNode.ButtonGroup = n18;
            if (Shortcut is Godot.Shortcut n19)
                castedNode.Shortcut = n19;
            if (ShortcutFeedback is System.Boolean n20)
                castedNode.ShortcutFeedback = n20;
            if (ShortcutInTooltip is System.Boolean n21)
                castedNode.ShortcutInTooltip = n21;
            if (ClipContents is System.Boolean n22)
                castedNode.ClipContents = n22;
            if (CustomMinimumSize is Godot.Vector2 n23)
                castedNode.CustomMinimumSize = n23;
            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n24)
                castedNode.LayoutDirection = n24;
            if (LayoutMode is System.Int32 n25)
                castedNode.LayoutMode = n25;
            if (AnchorsPreset is System.Int32 n26)
                castedNode.AnchorsPreset = n26;
            if (AnchorLeft is System.Single n27)
                castedNode.AnchorLeft = n27;
            if (AnchorTop is System.Single n28)
                castedNode.AnchorTop = n28;
            if (AnchorRight is System.Single n29)
                castedNode.AnchorRight = n29;
            if (AnchorBottom is System.Single n30)
                castedNode.AnchorBottom = n30;
            if (OffsetLeft is System.Single n31)
                castedNode.OffsetLeft = n31;
            if (OffsetTop is System.Single n32)
                castedNode.OffsetTop = n32;
            if (OffsetRight is System.Single n33)
                castedNode.OffsetRight = n33;
            if (OffsetBottom is System.Single n34)
                castedNode.OffsetBottom = n34;
            if (GrowHorizontal is Godot.Control.GrowDirection n35)
                castedNode.GrowHorizontal = n35;
            if (GrowVertical is Godot.Control.GrowDirection n36)
                castedNode.GrowVertical = n36;
            if (Size is Godot.Vector2 n37)
                castedNode.Size = n37;
            if (Position is Godot.Vector2 n38)
                castedNode.Position = n38;
            if (GlobalPosition is Godot.Vector2 n39)
                castedNode.GlobalPosition = n39;
            if (Rotation is System.Single n40)
                castedNode.Rotation = n40;
            if (RotationDegrees is System.Single n41)
                castedNode.RotationDegrees = n41;
            if (Scale is Godot.Vector2 n42)
                castedNode.Scale = n42;
            if (PivotOffset is Godot.Vector2 n43)
                castedNode.PivotOffset = n43;
            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n44)
                castedNode.SizeFlagsHorizontal = n44;
            if (SizeFlagsVertical is Godot.Control.SizeFlags n45)
                castedNode.SizeFlagsVertical = n45;
            if (SizeFlagsStretchRatio is System.Single n46)
                castedNode.SizeFlagsStretchRatio = n46;
            if (LocalizeNumeralSystem is System.Boolean n47)
                castedNode.LocalizeNumeralSystem = n47;
            if (AutoTranslate is System.Boolean n48)
                castedNode.AutoTranslate = n48;
            if (TooltipText is System.String n49)
                castedNode.TooltipText = n49;
            if (FocusNeighborLeft is Godot.NodePath n50)
                castedNode.FocusNeighborLeft = n50;
            if (FocusNeighborTop is Godot.NodePath n51)
                castedNode.FocusNeighborTop = n51;
            if (FocusNeighborRight is Godot.NodePath n52)
                castedNode.FocusNeighborRight = n52;
            if (FocusNeighborBottom is Godot.NodePath n53)
                castedNode.FocusNeighborBottom = n53;
            if (FocusNext is Godot.NodePath n54)
                castedNode.FocusNext = n54;
            if (FocusPrevious is Godot.NodePath n55)
                castedNode.FocusPrevious = n55;
            if (FocusMode is Godot.Control.FocusModeEnum n56)
                castedNode.FocusMode = n56;
            if (MouseFilter is Godot.Control.MouseFilterEnum n57)
                castedNode.MouseFilter = n57;
            if (MouseForcePassScrollEvents is System.Boolean n58)
                castedNode.MouseForcePassScrollEvents = n58;
            if (MouseDefaultCursorShape is Godot.Control.CursorShape n59)
                castedNode.MouseDefaultCursorShape = n59;
            if (ShortcutContext is Godot.Node n60)
                castedNode.ShortcutContext = n60;
            if (Theme is Godot.Theme n61)
                castedNode.Theme = n61;
            if (ThemeTypeVariation is Godot.StringName n62)
                castedNode.ThemeTypeVariation = n62;
            if (Visible is System.Boolean n63)
                castedNode.Visible = n63;
            if (Modulate is Godot.Color n64)
                castedNode.Modulate = n64;
            if (SelfModulate is Godot.Color n65)
                castedNode.SelfModulate = n65;
            if (ShowBehindParent is System.Boolean n66)
                castedNode.ShowBehindParent = n66;
            if (TopLevel is System.Boolean n67)
                castedNode.TopLevel = n67;
            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n68)
                castedNode.ClipChildren = n68;
            if (LightMask is System.Int32 n69)
                castedNode.LightMask = n69;
            if (VisibilityLayer is System.UInt32 n70)
                castedNode.VisibilityLayer = n70;
            if (ZIndex is System.Int32 n71)
                castedNode.ZIndex = n71;
            if (ZAsRelative is System.Boolean n72)
                castedNode.ZAsRelative = n72;
            if (YSortEnabled is System.Boolean n73)
                castedNode.YSortEnabled = n73;
            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n74)
                castedNode.TextureFilter = n74;
            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n75)
                castedNode.TextureRepeat = n75;
            if (Material is Godot.Material n76)
                castedNode.Material = n76;
            if (UseParentMaterial is System.Boolean n77)
                castedNode.UseParentMaterial = n77;
            if (Name is Godot.StringName n78)
                castedNode.Name = n78;
            if (UniqueNameInOwner is System.Boolean n79)
                castedNode.UniqueNameInOwner = n79;
            if (SceneFilePath is System.String n80)
                castedNode.SceneFilePath = n80;
            if (Owner is Godot.Node n81)
                castedNode.Owner = n81;
            if (ProcessMode is Godot.Node.ProcessModeEnum n82)
                castedNode.ProcessMode = n82;
            if (ProcessPriority is System.Int32 n83)
                castedNode.ProcessPriority = n83;
            if (ProcessPhysicsPriority is System.Int32 n84)
                castedNode.ProcessPhysicsPriority = n84;
            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n85)
                castedNode.ProcessThreadGroup = n85;
            if (ProcessThreadGroupOrder is System.Int32 n86)
                castedNode.ProcessThreadGroupOrder = n86;
            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n87)
                castedNode.ProcessThreadMessages = n87;
            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n88)
                castedNode.PhysicsInterpolationMode = n88;
            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n89)
                castedNode.AutoTranslateMode = n89;
            if (EditorDescription is System.String n90)
                castedNode.EditorDescription = n90;
            if (Pressed is System.Action e0)
                castedNode.Pressed += e0;
            if (ButtonUp is System.Action e1)
                castedNode.ButtonUp += e1;
            if (ButtonDown is System.Action e2)
                castedNode.ButtonDown += e2;
            if (Toggled is Godot.BaseButton.ToggledEventHandler e3)
                castedNode.Toggled += e3;
            if (Resized is System.Action e4)
                castedNode.Resized += e4;
            if (GuiInput is Godot.Control.GuiInputEventHandler e5)
                castedNode.GuiInput += e5;
            if (MouseEntered is System.Action e6)
                castedNode.MouseEntered += e6;
            if (MouseExited is System.Action e7)
                castedNode.MouseExited += e7;
            if (FocusEntered is System.Action e8)
                castedNode.FocusEntered += e8;
            if (FocusExited is System.Action e9)
                castedNode.FocusExited += e9;
            if (SizeFlagsChanged is System.Action e10)
                castedNode.SizeFlagsChanged += e10;
            if (MinimumSizeChanged is System.Action e11)
                castedNode.MinimumSizeChanged += e11;
            if (ThemeChanged is System.Action e12)
                castedNode.ThemeChanged += e12;
            if (Draw is System.Action e13)
                castedNode.Draw += e13;
            if (VisibilityChanged is System.Action e14)
                castedNode.VisibilityChanged += e14;
            if (Hidden is System.Action e15)
                castedNode.Hidden += e15;
            if (ItemRectChanged is System.Action e16)
                castedNode.ItemRectChanged += e16;
            if (Ready is System.Action e17)
                castedNode.Ready += e17;
            if (Renamed is System.Action e18)
                castedNode.Renamed += e18;
            if (TreeEntered is System.Action e19)
                castedNode.TreeEntered += e19;
            if (TreeExiting is System.Action e20)
                castedNode.TreeExiting += e20;
            if (TreeExited is System.Action e21)
                castedNode.TreeExited += e21;
            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e22)
                castedNode.ChildEnteredTree += e22;
            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e23)
                castedNode.ChildExitingTree += e23;
            if (ChildOrderChanged is System.Action e24)
                castedNode.ChildOrderChanged += e24;
            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e25)
                castedNode.ReplacingBy += e25;
            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e26)
                castedNode.EditorDescriptionChanged += e26;
            if (ScriptChanged is System.Action e27)
                castedNode.ScriptChanged += e27;
            if (PropertyListChanged is System.Action e28)
                castedNode.PropertyListChanged += e28;
        }
    }
}