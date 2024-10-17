namespace ReactiveSharpGodot.Components
{
    public class LinkButton : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GLinkButton>
    {
        public System.String? Text { protected get; init; }
        public Godot.LinkButton.UnderlineMode? Underline { protected get; init; }
        public System.String? Uri { protected get; init; }
        public Godot.Control.TextDirection? TextDirection { protected get; init; }
        public System.String? Language { protected get; init; }
        public Godot.TextServer.StructuredTextParser? StructuredTextBidiOverride { protected get; init; }
        public Godot.Collections.Array? StructuredTextBidiOverrideOptions { protected get; init; }
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

        public override ReactiveSharpGodot.Nodes.GLinkButton Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GLinkButton();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GLinkButton node)
        {
            var castedNode = (Godot.LinkButton)node.Node;
            if (Text is System.String n0)
                castedNode.Text = n0;
            if (Underline is Godot.LinkButton.UnderlineMode n1)
                castedNode.Underline = n1;
            if (Uri is System.String n2)
                castedNode.Uri = n2;
            if (TextDirection is Godot.Control.TextDirection n3)
                castedNode.TextDirection = n3;
            if (Language is System.String n4)
                castedNode.Language = n4;
            if (StructuredTextBidiOverride is Godot.TextServer.StructuredTextParser n5)
                castedNode.StructuredTextBidiOverride = n5;
            if (StructuredTextBidiOverrideOptions is Godot.Collections.Array n6)
                castedNode.StructuredTextBidiOverrideOptions = n6;
            if (Disabled is System.Boolean n7)
                castedNode.Disabled = n7;
            if (ToggleMode is System.Boolean n8)
                castedNode.ToggleMode = n8;
            if (ButtonPressed is System.Boolean n9)
                castedNode.ButtonPressed = n9;
            if (ActionMode is Godot.BaseButton.ActionModeEnum n10)
                castedNode.ActionMode = n10;
            if (ButtonMask is Godot.MouseButtonMask n11)
                castedNode.ButtonMask = n11;
            if (KeepPressedOutside is System.Boolean n12)
                castedNode.KeepPressedOutside = n12;
            if (ButtonGroup is Godot.ButtonGroup n13)
                castedNode.ButtonGroup = n13;
            if (Shortcut is Godot.Shortcut n14)
                castedNode.Shortcut = n14;
            if (ShortcutFeedback is System.Boolean n15)
                castedNode.ShortcutFeedback = n15;
            if (ShortcutInTooltip is System.Boolean n16)
                castedNode.ShortcutInTooltip = n16;
            if (ClipContents is System.Boolean n17)
                castedNode.ClipContents = n17;
            if (CustomMinimumSize is Godot.Vector2 n18)
                castedNode.CustomMinimumSize = n18;
            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n19)
                castedNode.LayoutDirection = n19;
            if (LayoutMode is System.Int32 n20)
                castedNode.LayoutMode = n20;
            if (AnchorsPreset is System.Int32 n21)
                castedNode.AnchorsPreset = n21;
            if (AnchorLeft is System.Single n22)
                castedNode.AnchorLeft = n22;
            if (AnchorTop is System.Single n23)
                castedNode.AnchorTop = n23;
            if (AnchorRight is System.Single n24)
                castedNode.AnchorRight = n24;
            if (AnchorBottom is System.Single n25)
                castedNode.AnchorBottom = n25;
            if (OffsetLeft is System.Single n26)
                castedNode.OffsetLeft = n26;
            if (OffsetTop is System.Single n27)
                castedNode.OffsetTop = n27;
            if (OffsetRight is System.Single n28)
                castedNode.OffsetRight = n28;
            if (OffsetBottom is System.Single n29)
                castedNode.OffsetBottom = n29;
            if (GrowHorizontal is Godot.Control.GrowDirection n30)
                castedNode.GrowHorizontal = n30;
            if (GrowVertical is Godot.Control.GrowDirection n31)
                castedNode.GrowVertical = n31;
            if (Size is Godot.Vector2 n32)
                castedNode.Size = n32;
            if (Position is Godot.Vector2 n33)
                castedNode.Position = n33;
            if (GlobalPosition is Godot.Vector2 n34)
                castedNode.GlobalPosition = n34;
            if (Rotation is System.Single n35)
                castedNode.Rotation = n35;
            if (RotationDegrees is System.Single n36)
                castedNode.RotationDegrees = n36;
            if (Scale is Godot.Vector2 n37)
                castedNode.Scale = n37;
            if (PivotOffset is Godot.Vector2 n38)
                castedNode.PivotOffset = n38;
            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n39)
                castedNode.SizeFlagsHorizontal = n39;
            if (SizeFlagsVertical is Godot.Control.SizeFlags n40)
                castedNode.SizeFlagsVertical = n40;
            if (SizeFlagsStretchRatio is System.Single n41)
                castedNode.SizeFlagsStretchRatio = n41;
            if (LocalizeNumeralSystem is System.Boolean n42)
                castedNode.LocalizeNumeralSystem = n42;
            if (AutoTranslate is System.Boolean n43)
                castedNode.AutoTranslate = n43;
            if (TooltipText is System.String n44)
                castedNode.TooltipText = n44;
            if (FocusNeighborLeft is Godot.NodePath n45)
                castedNode.FocusNeighborLeft = n45;
            if (FocusNeighborTop is Godot.NodePath n46)
                castedNode.FocusNeighborTop = n46;
            if (FocusNeighborRight is Godot.NodePath n47)
                castedNode.FocusNeighborRight = n47;
            if (FocusNeighborBottom is Godot.NodePath n48)
                castedNode.FocusNeighborBottom = n48;
            if (FocusNext is Godot.NodePath n49)
                castedNode.FocusNext = n49;
            if (FocusPrevious is Godot.NodePath n50)
                castedNode.FocusPrevious = n50;
            if (FocusMode is Godot.Control.FocusModeEnum n51)
                castedNode.FocusMode = n51;
            if (MouseFilter is Godot.Control.MouseFilterEnum n52)
                castedNode.MouseFilter = n52;
            if (MouseForcePassScrollEvents is System.Boolean n53)
                castedNode.MouseForcePassScrollEvents = n53;
            if (MouseDefaultCursorShape is Godot.Control.CursorShape n54)
                castedNode.MouseDefaultCursorShape = n54;
            if (ShortcutContext is Godot.Node n55)
                castedNode.ShortcutContext = n55;
            if (Theme is Godot.Theme n56)
                castedNode.Theme = n56;
            if (ThemeTypeVariation is Godot.StringName n57)
                castedNode.ThemeTypeVariation = n57;
            if (Visible is System.Boolean n58)
                castedNode.Visible = n58;
            if (Modulate is Godot.Color n59)
                castedNode.Modulate = n59;
            if (SelfModulate is Godot.Color n60)
                castedNode.SelfModulate = n60;
            if (ShowBehindParent is System.Boolean n61)
                castedNode.ShowBehindParent = n61;
            if (TopLevel is System.Boolean n62)
                castedNode.TopLevel = n62;
            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n63)
                castedNode.ClipChildren = n63;
            if (LightMask is System.Int32 n64)
                castedNode.LightMask = n64;
            if (VisibilityLayer is System.UInt32 n65)
                castedNode.VisibilityLayer = n65;
            if (ZIndex is System.Int32 n66)
                castedNode.ZIndex = n66;
            if (ZAsRelative is System.Boolean n67)
                castedNode.ZAsRelative = n67;
            if (YSortEnabled is System.Boolean n68)
                castedNode.YSortEnabled = n68;
            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n69)
                castedNode.TextureFilter = n69;
            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n70)
                castedNode.TextureRepeat = n70;
            if (Material is Godot.Material n71)
                castedNode.Material = n71;
            if (UseParentMaterial is System.Boolean n72)
                castedNode.UseParentMaterial = n72;
            if (Name is Godot.StringName n73)
                castedNode.Name = n73;
            if (UniqueNameInOwner is System.Boolean n74)
                castedNode.UniqueNameInOwner = n74;
            if (SceneFilePath is System.String n75)
                castedNode.SceneFilePath = n75;
            if (Owner is Godot.Node n76)
                castedNode.Owner = n76;
            if (ProcessMode is Godot.Node.ProcessModeEnum n77)
                castedNode.ProcessMode = n77;
            if (ProcessPriority is System.Int32 n78)
                castedNode.ProcessPriority = n78;
            if (ProcessPhysicsPriority is System.Int32 n79)
                castedNode.ProcessPhysicsPriority = n79;
            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n80)
                castedNode.ProcessThreadGroup = n80;
            if (ProcessThreadGroupOrder is System.Int32 n81)
                castedNode.ProcessThreadGroupOrder = n81;
            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n82)
                castedNode.ProcessThreadMessages = n82;
            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n83)
                castedNode.PhysicsInterpolationMode = n83;
            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n84)
                castedNode.AutoTranslateMode = n84;
            if (EditorDescription is System.String n85)
                castedNode.EditorDescription = n85;
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