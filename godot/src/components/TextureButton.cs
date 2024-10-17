namespace ReactiveSharpGodot.Components
{
    public class TextureButton : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GTextureButton>
    {
        public Godot.Texture2D? TextureNormal { protected get; init; }
        public Godot.Texture2D? TexturePressed { protected get; init; }
        public Godot.Texture2D? TextureHover { protected get; init; }
        public Godot.Texture2D? TextureDisabled { protected get; init; }
        public Godot.Texture2D? TextureFocused { protected get; init; }
        public Godot.Bitmap? TextureClickMask { protected get; init; }
        public System.Boolean? IgnoreTextureSize { protected get; init; }
        public Godot.TextureButton.StretchModeEnum? StretchMode { protected get; init; }
        public System.Boolean? FlipH { protected get; init; }
        public System.Boolean? FlipV { protected get; init; }
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

        public override ReactiveSharpGodot.Nodes.GTextureButton Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GTextureButton();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GTextureButton node)
        {
            var castedNode = (Godot.TextureButton)node.Node;
            if (TextureNormal is Godot.Texture2D n0)
                castedNode.TextureNormal = n0;
            if (TexturePressed is Godot.Texture2D n1)
                castedNode.TexturePressed = n1;
            if (TextureHover is Godot.Texture2D n2)
                castedNode.TextureHover = n2;
            if (TextureDisabled is Godot.Texture2D n3)
                castedNode.TextureDisabled = n3;
            if (TextureFocused is Godot.Texture2D n4)
                castedNode.TextureFocused = n4;
            if (TextureClickMask is Godot.Bitmap n5)
                castedNode.TextureClickMask = n5;
            if (IgnoreTextureSize is System.Boolean n6)
                castedNode.IgnoreTextureSize = n6;
            if (StretchMode is Godot.TextureButton.StretchModeEnum n7)
                castedNode.StretchMode = n7;
            if (FlipH is System.Boolean n8)
                castedNode.FlipH = n8;
            if (FlipV is System.Boolean n9)
                castedNode.FlipV = n9;
            if (Disabled is System.Boolean n10)
                castedNode.Disabled = n10;
            if (ToggleMode is System.Boolean n11)
                castedNode.ToggleMode = n11;
            if (ButtonPressed is System.Boolean n12)
                castedNode.ButtonPressed = n12;
            if (ActionMode is Godot.BaseButton.ActionModeEnum n13)
                castedNode.ActionMode = n13;
            if (ButtonMask is Godot.MouseButtonMask n14)
                castedNode.ButtonMask = n14;
            if (KeepPressedOutside is System.Boolean n15)
                castedNode.KeepPressedOutside = n15;
            if (ButtonGroup is Godot.ButtonGroup n16)
                castedNode.ButtonGroup = n16;
            if (Shortcut is Godot.Shortcut n17)
                castedNode.Shortcut = n17;
            if (ShortcutFeedback is System.Boolean n18)
                castedNode.ShortcutFeedback = n18;
            if (ShortcutInTooltip is System.Boolean n19)
                castedNode.ShortcutInTooltip = n19;
            if (ClipContents is System.Boolean n20)
                castedNode.ClipContents = n20;
            if (CustomMinimumSize is Godot.Vector2 n21)
                castedNode.CustomMinimumSize = n21;
            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n22)
                castedNode.LayoutDirection = n22;
            if (LayoutMode is System.Int32 n23)
                castedNode.LayoutMode = n23;
            if (AnchorsPreset is System.Int32 n24)
                castedNode.AnchorsPreset = n24;
            if (AnchorLeft is System.Single n25)
                castedNode.AnchorLeft = n25;
            if (AnchorTop is System.Single n26)
                castedNode.AnchorTop = n26;
            if (AnchorRight is System.Single n27)
                castedNode.AnchorRight = n27;
            if (AnchorBottom is System.Single n28)
                castedNode.AnchorBottom = n28;
            if (OffsetLeft is System.Single n29)
                castedNode.OffsetLeft = n29;
            if (OffsetTop is System.Single n30)
                castedNode.OffsetTop = n30;
            if (OffsetRight is System.Single n31)
                castedNode.OffsetRight = n31;
            if (OffsetBottom is System.Single n32)
                castedNode.OffsetBottom = n32;
            if (GrowHorizontal is Godot.Control.GrowDirection n33)
                castedNode.GrowHorizontal = n33;
            if (GrowVertical is Godot.Control.GrowDirection n34)
                castedNode.GrowVertical = n34;
            if (Size is Godot.Vector2 n35)
                castedNode.Size = n35;
            if (Position is Godot.Vector2 n36)
                castedNode.Position = n36;
            if (GlobalPosition is Godot.Vector2 n37)
                castedNode.GlobalPosition = n37;
            if (Rotation is System.Single n38)
                castedNode.Rotation = n38;
            if (RotationDegrees is System.Single n39)
                castedNode.RotationDegrees = n39;
            if (Scale is Godot.Vector2 n40)
                castedNode.Scale = n40;
            if (PivotOffset is Godot.Vector2 n41)
                castedNode.PivotOffset = n41;
            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n42)
                castedNode.SizeFlagsHorizontal = n42;
            if (SizeFlagsVertical is Godot.Control.SizeFlags n43)
                castedNode.SizeFlagsVertical = n43;
            if (SizeFlagsStretchRatio is System.Single n44)
                castedNode.SizeFlagsStretchRatio = n44;
            if (LocalizeNumeralSystem is System.Boolean n45)
                castedNode.LocalizeNumeralSystem = n45;
            if (AutoTranslate is System.Boolean n46)
                castedNode.AutoTranslate = n46;
            if (TooltipText is System.String n47)
                castedNode.TooltipText = n47;
            if (FocusNeighborLeft is Godot.NodePath n48)
                castedNode.FocusNeighborLeft = n48;
            if (FocusNeighborTop is Godot.NodePath n49)
                castedNode.FocusNeighborTop = n49;
            if (FocusNeighborRight is Godot.NodePath n50)
                castedNode.FocusNeighborRight = n50;
            if (FocusNeighborBottom is Godot.NodePath n51)
                castedNode.FocusNeighborBottom = n51;
            if (FocusNext is Godot.NodePath n52)
                castedNode.FocusNext = n52;
            if (FocusPrevious is Godot.NodePath n53)
                castedNode.FocusPrevious = n53;
            if (FocusMode is Godot.Control.FocusModeEnum n54)
                castedNode.FocusMode = n54;
            if (MouseFilter is Godot.Control.MouseFilterEnum n55)
                castedNode.MouseFilter = n55;
            if (MouseForcePassScrollEvents is System.Boolean n56)
                castedNode.MouseForcePassScrollEvents = n56;
            if (MouseDefaultCursorShape is Godot.Control.CursorShape n57)
                castedNode.MouseDefaultCursorShape = n57;
            if (ShortcutContext is Godot.Node n58)
                castedNode.ShortcutContext = n58;
            if (Theme is Godot.Theme n59)
                castedNode.Theme = n59;
            if (ThemeTypeVariation is Godot.StringName n60)
                castedNode.ThemeTypeVariation = n60;
            if (Visible is System.Boolean n61)
                castedNode.Visible = n61;
            if (Modulate is Godot.Color n62)
                castedNode.Modulate = n62;
            if (SelfModulate is Godot.Color n63)
                castedNode.SelfModulate = n63;
            if (ShowBehindParent is System.Boolean n64)
                castedNode.ShowBehindParent = n64;
            if (TopLevel is System.Boolean n65)
                castedNode.TopLevel = n65;
            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n66)
                castedNode.ClipChildren = n66;
            if (LightMask is System.Int32 n67)
                castedNode.LightMask = n67;
            if (VisibilityLayer is System.UInt32 n68)
                castedNode.VisibilityLayer = n68;
            if (ZIndex is System.Int32 n69)
                castedNode.ZIndex = n69;
            if (ZAsRelative is System.Boolean n70)
                castedNode.ZAsRelative = n70;
            if (YSortEnabled is System.Boolean n71)
                castedNode.YSortEnabled = n71;
            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n72)
                castedNode.TextureFilter = n72;
            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n73)
                castedNode.TextureRepeat = n73;
            if (Material is Godot.Material n74)
                castedNode.Material = n74;
            if (UseParentMaterial is System.Boolean n75)
                castedNode.UseParentMaterial = n75;
            if (Name is Godot.StringName n76)
                castedNode.Name = n76;
            if (UniqueNameInOwner is System.Boolean n77)
                castedNode.UniqueNameInOwner = n77;
            if (SceneFilePath is System.String n78)
                castedNode.SceneFilePath = n78;
            if (Owner is Godot.Node n79)
                castedNode.Owner = n79;
            if (ProcessMode is Godot.Node.ProcessModeEnum n80)
                castedNode.ProcessMode = n80;
            if (ProcessPriority is System.Int32 n81)
                castedNode.ProcessPriority = n81;
            if (ProcessPhysicsPriority is System.Int32 n82)
                castedNode.ProcessPhysicsPriority = n82;
            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n83)
                castedNode.ProcessThreadGroup = n83;
            if (ProcessThreadGroupOrder is System.Int32 n84)
                castedNode.ProcessThreadGroupOrder = n84;
            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n85)
                castedNode.ProcessThreadMessages = n85;
            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n86)
                castedNode.PhysicsInterpolationMode = n86;
            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n87)
                castedNode.AutoTranslateMode = n87;
            if (EditorDescription is System.String n88)
                castedNode.EditorDescription = n88;
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