namespace ReactiveSharpGodot.Components
{
    public class OptionButton : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GOptionButton>
    {
        public System.Int32? Selected { protected get; init; }
        public System.Boolean? FitToLongestItem { protected get; init; }
        public System.Boolean? AllowReselect { protected get; init; }
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
        public Godot.OptionButton.ItemSelectedEventHandler? ItemSelected { protected get; init; }
        public Godot.OptionButton.ItemFocusedEventHandler? ItemFocused { protected get; init; }
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

        public override ReactiveSharpGodot.Nodes.GOptionButton Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GOptionButton();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GOptionButton node)
        {
            var castedNode = (Godot.OptionButton)node.Node;
            if (Selected is System.Int32 n0)
                castedNode.Selected = n0;
            if (FitToLongestItem is System.Boolean n1)
                castedNode.FitToLongestItem = n1;
            if (AllowReselect is System.Boolean n2)
                castedNode.AllowReselect = n2;
            if (ItemCount is System.Int32 n3)
                castedNode.ItemCount = n3;
            if (Text is System.String n4)
                castedNode.Text = n4;
            if (Icon is Godot.Texture2D n5)
                castedNode.Icon = n5;
            if (Flat is System.Boolean n6)
                castedNode.Flat = n6;
            if (Alignment is Godot.HorizontalAlignment n7)
                castedNode.Alignment = n7;
            if (TextOverrunBehavior is Godot.TextServer.OverrunBehavior n8)
                castedNode.TextOverrunBehavior = n8;
            if (AutowrapMode is Godot.TextServer.AutowrapMode n9)
                castedNode.AutowrapMode = n9;
            if (ClipText is System.Boolean n10)
                castedNode.ClipText = n10;
            if (IconAlignment is Godot.HorizontalAlignment n11)
                castedNode.IconAlignment = n11;
            if (VerticalIconAlignment is Godot.VerticalAlignment n12)
                castedNode.VerticalIconAlignment = n12;
            if (ExpandIcon is System.Boolean n13)
                castedNode.ExpandIcon = n13;
            if (TextDirection is Godot.Control.TextDirection n14)
                castedNode.TextDirection = n14;
            if (Language is System.String n15)
                castedNode.Language = n15;
            if (Disabled is System.Boolean n16)
                castedNode.Disabled = n16;
            if (ToggleMode is System.Boolean n17)
                castedNode.ToggleMode = n17;
            if (ButtonPressed is System.Boolean n18)
                castedNode.ButtonPressed = n18;
            if (ActionMode is Godot.BaseButton.ActionModeEnum n19)
                castedNode.ActionMode = n19;
            if (ButtonMask is Godot.MouseButtonMask n20)
                castedNode.ButtonMask = n20;
            if (KeepPressedOutside is System.Boolean n21)
                castedNode.KeepPressedOutside = n21;
            if (ButtonGroup is Godot.ButtonGroup n22)
                castedNode.ButtonGroup = n22;
            if (Shortcut is Godot.Shortcut n23)
                castedNode.Shortcut = n23;
            if (ShortcutFeedback is System.Boolean n24)
                castedNode.ShortcutFeedback = n24;
            if (ShortcutInTooltip is System.Boolean n25)
                castedNode.ShortcutInTooltip = n25;
            if (ClipContents is System.Boolean n26)
                castedNode.ClipContents = n26;
            if (CustomMinimumSize is Godot.Vector2 n27)
                castedNode.CustomMinimumSize = n27;
            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n28)
                castedNode.LayoutDirection = n28;
            if (LayoutMode is System.Int32 n29)
                castedNode.LayoutMode = n29;
            if (AnchorsPreset is System.Int32 n30)
                castedNode.AnchorsPreset = n30;
            if (AnchorLeft is System.Single n31)
                castedNode.AnchorLeft = n31;
            if (AnchorTop is System.Single n32)
                castedNode.AnchorTop = n32;
            if (AnchorRight is System.Single n33)
                castedNode.AnchorRight = n33;
            if (AnchorBottom is System.Single n34)
                castedNode.AnchorBottom = n34;
            if (OffsetLeft is System.Single n35)
                castedNode.OffsetLeft = n35;
            if (OffsetTop is System.Single n36)
                castedNode.OffsetTop = n36;
            if (OffsetRight is System.Single n37)
                castedNode.OffsetRight = n37;
            if (OffsetBottom is System.Single n38)
                castedNode.OffsetBottom = n38;
            if (GrowHorizontal is Godot.Control.GrowDirection n39)
                castedNode.GrowHorizontal = n39;
            if (GrowVertical is Godot.Control.GrowDirection n40)
                castedNode.GrowVertical = n40;
            if (Size is Godot.Vector2 n41)
                castedNode.Size = n41;
            if (Position is Godot.Vector2 n42)
                castedNode.Position = n42;
            if (GlobalPosition is Godot.Vector2 n43)
                castedNode.GlobalPosition = n43;
            if (Rotation is System.Single n44)
                castedNode.Rotation = n44;
            if (RotationDegrees is System.Single n45)
                castedNode.RotationDegrees = n45;
            if (Scale is Godot.Vector2 n46)
                castedNode.Scale = n46;
            if (PivotOffset is Godot.Vector2 n47)
                castedNode.PivotOffset = n47;
            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n48)
                castedNode.SizeFlagsHorizontal = n48;
            if (SizeFlagsVertical is Godot.Control.SizeFlags n49)
                castedNode.SizeFlagsVertical = n49;
            if (SizeFlagsStretchRatio is System.Single n50)
                castedNode.SizeFlagsStretchRatio = n50;
            if (LocalizeNumeralSystem is System.Boolean n51)
                castedNode.LocalizeNumeralSystem = n51;
            if (AutoTranslate is System.Boolean n52)
                castedNode.AutoTranslate = n52;
            if (TooltipText is System.String n53)
                castedNode.TooltipText = n53;
            if (FocusNeighborLeft is Godot.NodePath n54)
                castedNode.FocusNeighborLeft = n54;
            if (FocusNeighborTop is Godot.NodePath n55)
                castedNode.FocusNeighborTop = n55;
            if (FocusNeighborRight is Godot.NodePath n56)
                castedNode.FocusNeighborRight = n56;
            if (FocusNeighborBottom is Godot.NodePath n57)
                castedNode.FocusNeighborBottom = n57;
            if (FocusNext is Godot.NodePath n58)
                castedNode.FocusNext = n58;
            if (FocusPrevious is Godot.NodePath n59)
                castedNode.FocusPrevious = n59;
            if (FocusMode is Godot.Control.FocusModeEnum n60)
                castedNode.FocusMode = n60;
            if (MouseFilter is Godot.Control.MouseFilterEnum n61)
                castedNode.MouseFilter = n61;
            if (MouseForcePassScrollEvents is System.Boolean n62)
                castedNode.MouseForcePassScrollEvents = n62;
            if (MouseDefaultCursorShape is Godot.Control.CursorShape n63)
                castedNode.MouseDefaultCursorShape = n63;
            if (ShortcutContext is Godot.Node n64)
                castedNode.ShortcutContext = n64;
            if (Theme is Godot.Theme n65)
                castedNode.Theme = n65;
            if (ThemeTypeVariation is Godot.StringName n66)
                castedNode.ThemeTypeVariation = n66;
            if (Visible is System.Boolean n67)
                castedNode.Visible = n67;
            if (Modulate is Godot.Color n68)
                castedNode.Modulate = n68;
            if (SelfModulate is Godot.Color n69)
                castedNode.SelfModulate = n69;
            if (ShowBehindParent is System.Boolean n70)
                castedNode.ShowBehindParent = n70;
            if (TopLevel is System.Boolean n71)
                castedNode.TopLevel = n71;
            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n72)
                castedNode.ClipChildren = n72;
            if (LightMask is System.Int32 n73)
                castedNode.LightMask = n73;
            if (VisibilityLayer is System.UInt32 n74)
                castedNode.VisibilityLayer = n74;
            if (ZIndex is System.Int32 n75)
                castedNode.ZIndex = n75;
            if (ZAsRelative is System.Boolean n76)
                castedNode.ZAsRelative = n76;
            if (YSortEnabled is System.Boolean n77)
                castedNode.YSortEnabled = n77;
            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n78)
                castedNode.TextureFilter = n78;
            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n79)
                castedNode.TextureRepeat = n79;
            if (Material is Godot.Material n80)
                castedNode.Material = n80;
            if (UseParentMaterial is System.Boolean n81)
                castedNode.UseParentMaterial = n81;
            if (Name is Godot.StringName n82)
                castedNode.Name = n82;
            if (UniqueNameInOwner is System.Boolean n83)
                castedNode.UniqueNameInOwner = n83;
            if (SceneFilePath is System.String n84)
                castedNode.SceneFilePath = n84;
            if (Owner is Godot.Node n85)
                castedNode.Owner = n85;
            if (ProcessMode is Godot.Node.ProcessModeEnum n86)
                castedNode.ProcessMode = n86;
            if (ProcessPriority is System.Int32 n87)
                castedNode.ProcessPriority = n87;
            if (ProcessPhysicsPriority is System.Int32 n88)
                castedNode.ProcessPhysicsPriority = n88;
            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n89)
                castedNode.ProcessThreadGroup = n89;
            if (ProcessThreadGroupOrder is System.Int32 n90)
                castedNode.ProcessThreadGroupOrder = n90;
            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n91)
                castedNode.ProcessThreadMessages = n91;
            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n92)
                castedNode.PhysicsInterpolationMode = n92;
            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n93)
                castedNode.AutoTranslateMode = n93;
            if (EditorDescription is System.String n94)
                castedNode.EditorDescription = n94;
            if (ItemSelected is Godot.OptionButton.ItemSelectedEventHandler e0)
                castedNode.ItemSelected += e0;
            if (ItemFocused is Godot.OptionButton.ItemFocusedEventHandler e1)
                castedNode.ItemFocused += e1;
            if (Pressed is System.Action e2)
                castedNode.Pressed += e2;
            if (ButtonUp is System.Action e3)
                castedNode.ButtonUp += e3;
            if (ButtonDown is System.Action e4)
                castedNode.ButtonDown += e4;
            if (Toggled is Godot.BaseButton.ToggledEventHandler e5)
                castedNode.Toggled += e5;
            if (Resized is System.Action e6)
                castedNode.Resized += e6;
            if (GuiInput is Godot.Control.GuiInputEventHandler e7)
                castedNode.GuiInput += e7;
            if (MouseEntered is System.Action e8)
                castedNode.MouseEntered += e8;
            if (MouseExited is System.Action e9)
                castedNode.MouseExited += e9;
            if (FocusEntered is System.Action e10)
                castedNode.FocusEntered += e10;
            if (FocusExited is System.Action e11)
                castedNode.FocusExited += e11;
            if (SizeFlagsChanged is System.Action e12)
                castedNode.SizeFlagsChanged += e12;
            if (MinimumSizeChanged is System.Action e13)
                castedNode.MinimumSizeChanged += e13;
            if (ThemeChanged is System.Action e14)
                castedNode.ThemeChanged += e14;
            if (Draw is System.Action e15)
                castedNode.Draw += e15;
            if (VisibilityChanged is System.Action e16)
                castedNode.VisibilityChanged += e16;
            if (Hidden is System.Action e17)
                castedNode.Hidden += e17;
            if (ItemRectChanged is System.Action e18)
                castedNode.ItemRectChanged += e18;
            if (Ready is System.Action e19)
                castedNode.Ready += e19;
            if (Renamed is System.Action e20)
                castedNode.Renamed += e20;
            if (TreeEntered is System.Action e21)
                castedNode.TreeEntered += e21;
            if (TreeExiting is System.Action e22)
                castedNode.TreeExiting += e22;
            if (TreeExited is System.Action e23)
                castedNode.TreeExited += e23;
            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e24)
                castedNode.ChildEnteredTree += e24;
            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e25)
                castedNode.ChildExitingTree += e25;
            if (ChildOrderChanged is System.Action e26)
                castedNode.ChildOrderChanged += e26;
            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e27)
                castedNode.ReplacingBy += e27;
            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e28)
                castedNode.EditorDescriptionChanged += e28;
            if (ScriptChanged is System.Action e29)
                castedNode.ScriptChanged += e29;
            if (PropertyListChanged is System.Action e30)
                castedNode.PropertyListChanged += e30;
        }
    }
}