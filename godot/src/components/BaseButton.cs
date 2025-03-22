namespace ReactiveSharpGodot.Components
{
    public class BaseButton : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GBaseButton>
    {
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
        public Dictionary<string, int> ThemeConstantOverrides { protected get; init; } = [];
        public Dictionary<string, Godot.Color> ThemeColorOverrides { protected get; init; } = [];

        public override ReactiveSharpGodot.Nodes.GBaseButton Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GBaseButton();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GBaseButton node)
        {
            var castedNode = (Godot.BaseButton)node.Node;
            if (Disabled is System.Boolean n0)
            {
                NodeStateManager.AddPropertyState(castedNode, "Disabled", castedNode.Disabled);
                castedNode.Disabled = n0;
            }

            if (ToggleMode is System.Boolean n1)
            {
                NodeStateManager.AddPropertyState(castedNode, "ToggleMode", castedNode.ToggleMode);
                castedNode.ToggleMode = n1;
            }

            if (ButtonPressed is System.Boolean n2)
            {
                NodeStateManager.AddPropertyState(castedNode, "ButtonPressed", castedNode.ButtonPressed);
                castedNode.ButtonPressed = n2;
            }

            if (ActionMode is Godot.BaseButton.ActionModeEnum n3)
            {
                NodeStateManager.AddPropertyState(castedNode, "ActionMode", castedNode.ActionMode);
                castedNode.ActionMode = n3;
            }

            if (ButtonMask is Godot.MouseButtonMask n4)
            {
                NodeStateManager.AddPropertyState(castedNode, "ButtonMask", castedNode.ButtonMask);
                castedNode.ButtonMask = n4;
            }

            if (KeepPressedOutside is System.Boolean n5)
            {
                NodeStateManager.AddPropertyState(castedNode, "KeepPressedOutside", castedNode.KeepPressedOutside);
                castedNode.KeepPressedOutside = n5;
            }

            if (ButtonGroup is Godot.ButtonGroup n6)
            {
                NodeStateManager.AddPropertyState(castedNode, "ButtonGroup", castedNode.ButtonGroup);
                castedNode.ButtonGroup = n6;
            }

            if (Shortcut is Godot.Shortcut n7)
            {
                NodeStateManager.AddPropertyState(castedNode, "Shortcut", castedNode.Shortcut);
                castedNode.Shortcut = n7;
            }

            if (ShortcutFeedback is System.Boolean n8)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutFeedback", castedNode.ShortcutFeedback);
                castedNode.ShortcutFeedback = n8;
            }

            if (ShortcutInTooltip is System.Boolean n9)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutInTooltip", castedNode.ShortcutInTooltip);
                castedNode.ShortcutInTooltip = n9;
            }

            if (ClipContents is System.Boolean n10)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipContents", castedNode.ClipContents);
                castedNode.ClipContents = n10;
            }

            if (CustomMinimumSize is Godot.Vector2 n11)
            {
                NodeStateManager.AddPropertyState(castedNode, "CustomMinimumSize", castedNode.CustomMinimumSize);
                castedNode.CustomMinimumSize = n11;
            }

            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n12)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutDirection", castedNode.LayoutDirection);
                castedNode.LayoutDirection = n12;
            }

            if (LayoutMode is System.Int32 n13)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutMode", castedNode.LayoutMode);
                castedNode.LayoutMode = n13;
            }

            if (AnchorsPreset is System.Int32 n14)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorsPreset", castedNode.AnchorsPreset);
                castedNode.AnchorsPreset = n14;
            }

            if (AnchorLeft is System.Single n15)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorLeft", castedNode.AnchorLeft);
                castedNode.AnchorLeft = n15;
            }

            if (AnchorTop is System.Single n16)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorTop", castedNode.AnchorTop);
                castedNode.AnchorTop = n16;
            }

            if (AnchorRight is System.Single n17)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorRight", castedNode.AnchorRight);
                castedNode.AnchorRight = n17;
            }

            if (AnchorBottom is System.Single n18)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorBottom", castedNode.AnchorBottom);
                castedNode.AnchorBottom = n18;
            }

            if (OffsetLeft is System.Single n19)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetLeft", castedNode.OffsetLeft);
                castedNode.OffsetLeft = n19;
            }

            if (OffsetTop is System.Single n20)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetTop", castedNode.OffsetTop);
                castedNode.OffsetTop = n20;
            }

            if (OffsetRight is System.Single n21)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetRight", castedNode.OffsetRight);
                castedNode.OffsetRight = n21;
            }

            if (OffsetBottom is System.Single n22)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetBottom", castedNode.OffsetBottom);
                castedNode.OffsetBottom = n22;
            }

            if (GrowHorizontal is Godot.Control.GrowDirection n23)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowHorizontal", castedNode.GrowHorizontal);
                castedNode.GrowHorizontal = n23;
            }

            if (GrowVertical is Godot.Control.GrowDirection n24)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowVertical", castedNode.GrowVertical);
                castedNode.GrowVertical = n24;
            }

            if (Size is Godot.Vector2 n25)
            {
                NodeStateManager.AddPropertyState(castedNode, "Size", castedNode.Size);
                castedNode.Size = n25;
            }

            if (Position is Godot.Vector2 n26)
            {
                NodeStateManager.AddPropertyState(castedNode, "Position", castedNode.Position);
                castedNode.Position = n26;
            }

            if (GlobalPosition is Godot.Vector2 n27)
            {
                NodeStateManager.AddPropertyState(castedNode, "GlobalPosition", castedNode.GlobalPosition);
                castedNode.GlobalPosition = n27;
            }

            if (Rotation is System.Single n28)
            {
                NodeStateManager.AddPropertyState(castedNode, "Rotation", castedNode.Rotation);
                castedNode.Rotation = n28;
            }

            if (RotationDegrees is System.Single n29)
            {
                NodeStateManager.AddPropertyState(castedNode, "RotationDegrees", castedNode.RotationDegrees);
                castedNode.RotationDegrees = n29;
            }

            if (Scale is Godot.Vector2 n30)
            {
                NodeStateManager.AddPropertyState(castedNode, "Scale", castedNode.Scale);
                castedNode.Scale = n30;
            }

            if (PivotOffset is Godot.Vector2 n31)
            {
                NodeStateManager.AddPropertyState(castedNode, "PivotOffset", castedNode.PivotOffset);
                castedNode.PivotOffset = n31;
            }

            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n32)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsHorizontal", castedNode.SizeFlagsHorizontal);
                castedNode.SizeFlagsHorizontal = n32;
            }

            if (SizeFlagsVertical is Godot.Control.SizeFlags n33)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsVertical", castedNode.SizeFlagsVertical);
                castedNode.SizeFlagsVertical = n33;
            }

            if (SizeFlagsStretchRatio is System.Single n34)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsStretchRatio", castedNode.SizeFlagsStretchRatio);
                castedNode.SizeFlagsStretchRatio = n34;
            }

            if (LocalizeNumeralSystem is System.Boolean n35)
            {
                NodeStateManager.AddPropertyState(castedNode, "LocalizeNumeralSystem", castedNode.LocalizeNumeralSystem);
                castedNode.LocalizeNumeralSystem = n35;
            }

            if (AutoTranslate is System.Boolean n36)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslate", castedNode.AutoTranslate);
                castedNode.AutoTranslate = n36;
            }

            if (TooltipText is System.String n37)
            {
                NodeStateManager.AddPropertyState(castedNode, "TooltipText", castedNode.TooltipText);
                castedNode.TooltipText = n37;
            }

            if (FocusNeighborLeft is Godot.NodePath n38)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborLeft", castedNode.FocusNeighborLeft);
                castedNode.FocusNeighborLeft = n38;
            }

            if (FocusNeighborTop is Godot.NodePath n39)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborTop", castedNode.FocusNeighborTop);
                castedNode.FocusNeighborTop = n39;
            }

            if (FocusNeighborRight is Godot.NodePath n40)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborRight", castedNode.FocusNeighborRight);
                castedNode.FocusNeighborRight = n40;
            }

            if (FocusNeighborBottom is Godot.NodePath n41)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborBottom", castedNode.FocusNeighborBottom);
                castedNode.FocusNeighborBottom = n41;
            }

            if (FocusNext is Godot.NodePath n42)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNext", castedNode.FocusNext);
                castedNode.FocusNext = n42;
            }

            if (FocusPrevious is Godot.NodePath n43)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusPrevious", castedNode.FocusPrevious);
                castedNode.FocusPrevious = n43;
            }

            if (FocusMode is Godot.Control.FocusModeEnum n44)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusMode", castedNode.FocusMode);
                castedNode.FocusMode = n44;
            }

            if (MouseFilter is Godot.Control.MouseFilterEnum n45)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseFilter", castedNode.MouseFilter);
                castedNode.MouseFilter = n45;
            }

            if (MouseForcePassScrollEvents is System.Boolean n46)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseForcePassScrollEvents", castedNode.MouseForcePassScrollEvents);
                castedNode.MouseForcePassScrollEvents = n46;
            }

            if (MouseDefaultCursorShape is Godot.Control.CursorShape n47)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseDefaultCursorShape", castedNode.MouseDefaultCursorShape);
                castedNode.MouseDefaultCursorShape = n47;
            }

            if (ShortcutContext is Godot.Node n48)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutContext", castedNode.ShortcutContext);
                castedNode.ShortcutContext = n48;
            }

            if (Theme is Godot.Theme n49)
            {
                NodeStateManager.AddPropertyState(castedNode, "Theme", castedNode.Theme);
                castedNode.Theme = n49;
            }

            if (ThemeTypeVariation is Godot.StringName n50)
            {
                NodeStateManager.AddPropertyState(castedNode, "ThemeTypeVariation", castedNode.ThemeTypeVariation);
                castedNode.ThemeTypeVariation = n50;
            }

            if (Visible is System.Boolean n51)
            {
                NodeStateManager.AddPropertyState(castedNode, "Visible", castedNode.Visible);
                castedNode.Visible = n51;
            }

            if (Modulate is Godot.Color n52)
            {
                NodeStateManager.AddPropertyState(castedNode, "Modulate", castedNode.Modulate);
                castedNode.Modulate = n52;
            }

            if (SelfModulate is Godot.Color n53)
            {
                NodeStateManager.AddPropertyState(castedNode, "SelfModulate", castedNode.SelfModulate);
                castedNode.SelfModulate = n53;
            }

            if (ShowBehindParent is System.Boolean n54)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowBehindParent", castedNode.ShowBehindParent);
                castedNode.ShowBehindParent = n54;
            }

            if (TopLevel is System.Boolean n55)
            {
                NodeStateManager.AddPropertyState(castedNode, "TopLevel", castedNode.TopLevel);
                castedNode.TopLevel = n55;
            }

            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n56)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipChildren", castedNode.ClipChildren);
                castedNode.ClipChildren = n56;
            }

            if (LightMask is System.Int32 n57)
            {
                NodeStateManager.AddPropertyState(castedNode, "LightMask", castedNode.LightMask);
                castedNode.LightMask = n57;
            }

            if (VisibilityLayer is System.UInt32 n58)
            {
                NodeStateManager.AddPropertyState(castedNode, "VisibilityLayer", castedNode.VisibilityLayer);
                castedNode.VisibilityLayer = n58;
            }

            if (ZIndex is System.Int32 n59)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZIndex", castedNode.ZIndex);
                castedNode.ZIndex = n59;
            }

            if (ZAsRelative is System.Boolean n60)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZAsRelative", castedNode.ZAsRelative);
                castedNode.ZAsRelative = n60;
            }

            if (YSortEnabled is System.Boolean n61)
            {
                NodeStateManager.AddPropertyState(castedNode, "YSortEnabled", castedNode.YSortEnabled);
                castedNode.YSortEnabled = n61;
            }

            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n62)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureFilter", castedNode.TextureFilter);
                castedNode.TextureFilter = n62;
            }

            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n63)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureRepeat", castedNode.TextureRepeat);
                castedNode.TextureRepeat = n63;
            }

            if (Material is Godot.Material n64)
            {
                NodeStateManager.AddPropertyState(castedNode, "Material", castedNode.Material);
                castedNode.Material = n64;
            }

            if (UseParentMaterial is System.Boolean n65)
            {
                NodeStateManager.AddPropertyState(castedNode, "UseParentMaterial", castedNode.UseParentMaterial);
                castedNode.UseParentMaterial = n65;
            }

            if (Name is Godot.StringName n66)
            {
                NodeStateManager.AddPropertyState(castedNode, "Name", castedNode.Name);
                castedNode.Name = n66;
            }

            if (UniqueNameInOwner is System.Boolean n67)
            {
                NodeStateManager.AddPropertyState(castedNode, "UniqueNameInOwner", castedNode.UniqueNameInOwner);
                castedNode.UniqueNameInOwner = n67;
            }

            if (SceneFilePath is System.String n68)
            {
                NodeStateManager.AddPropertyState(castedNode, "SceneFilePath", castedNode.SceneFilePath);
                castedNode.SceneFilePath = n68;
            }

            if (Owner is Godot.Node n69)
            {
                NodeStateManager.AddPropertyState(castedNode, "Owner", castedNode.Owner);
                castedNode.Owner = n69;
            }

            if (ProcessMode is Godot.Node.ProcessModeEnum n70)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessMode", castedNode.ProcessMode);
                castedNode.ProcessMode = n70;
            }

            if (ProcessPriority is System.Int32 n71)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPriority", castedNode.ProcessPriority);
                castedNode.ProcessPriority = n71;
            }

            if (ProcessPhysicsPriority is System.Int32 n72)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPhysicsPriority", castedNode.ProcessPhysicsPriority);
                castedNode.ProcessPhysicsPriority = n72;
            }

            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n73)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroup", castedNode.ProcessThreadGroup);
                castedNode.ProcessThreadGroup = n73;
            }

            if (ProcessThreadGroupOrder is System.Int32 n74)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroupOrder", castedNode.ProcessThreadGroupOrder);
                castedNode.ProcessThreadGroupOrder = n74;
            }

            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n75)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadMessages", castedNode.ProcessThreadMessages);
                castedNode.ProcessThreadMessages = n75;
            }

            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n76)
            {
                NodeStateManager.AddPropertyState(castedNode, "PhysicsInterpolationMode", castedNode.PhysicsInterpolationMode);
                castedNode.PhysicsInterpolationMode = n76;
            }

            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n77)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslateMode", castedNode.AutoTranslateMode);
                castedNode.AutoTranslateMode = n77;
            }

            if (EditorDescription is System.String n78)
            {
                NodeStateManager.AddPropertyState(castedNode, "EditorDescription", castedNode.EditorDescription);
                castedNode.EditorDescription = n78;
            }

            if (Pressed is System.Action e0)
            {
                NodeStateManager.AddEventHandler(castedNode, "Pressed", e0);
                castedNode.Pressed += e0;
            }

            if (ButtonUp is System.Action e1)
            {
                NodeStateManager.AddEventHandler(castedNode, "ButtonUp", e1);
                castedNode.ButtonUp += e1;
            }

            if (ButtonDown is System.Action e2)
            {
                NodeStateManager.AddEventHandler(castedNode, "ButtonDown", e2);
                castedNode.ButtonDown += e2;
            }

            if (Toggled is Godot.BaseButton.ToggledEventHandler e3)
            {
                NodeStateManager.AddEventHandler(castedNode, "Toggled", e3);
                castedNode.Toggled += e3;
            }

            if (Resized is System.Action e4)
            {
                NodeStateManager.AddEventHandler(castedNode, "Resized", e4);
                castedNode.Resized += e4;
            }

            if (GuiInput is Godot.Control.GuiInputEventHandler e5)
            {
                NodeStateManager.AddEventHandler(castedNode, "GuiInput", e5);
                castedNode.GuiInput += e5;
            }

            if (MouseEntered is System.Action e6)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseEntered", e6);
                castedNode.MouseEntered += e6;
            }

            if (MouseExited is System.Action e7)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseExited", e7);
                castedNode.MouseExited += e7;
            }

            if (FocusEntered is System.Action e8)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusEntered", e8);
                castedNode.FocusEntered += e8;
            }

            if (FocusExited is System.Action e9)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusExited", e9);
                castedNode.FocusExited += e9;
            }

            if (SizeFlagsChanged is System.Action e10)
            {
                NodeStateManager.AddEventHandler(castedNode, "SizeFlagsChanged", e10);
                castedNode.SizeFlagsChanged += e10;
            }

            if (MinimumSizeChanged is System.Action e11)
            {
                NodeStateManager.AddEventHandler(castedNode, "MinimumSizeChanged", e11);
                castedNode.MinimumSizeChanged += e11;
            }

            if (ThemeChanged is System.Action e12)
            {
                NodeStateManager.AddEventHandler(castedNode, "ThemeChanged", e12);
                castedNode.ThemeChanged += e12;
            }

            if (Draw is System.Action e13)
            {
                NodeStateManager.AddEventHandler(castedNode, "Draw", e13);
                castedNode.Draw += e13;
            }

            if (VisibilityChanged is System.Action e14)
            {
                NodeStateManager.AddEventHandler(castedNode, "VisibilityChanged", e14);
                castedNode.VisibilityChanged += e14;
            }

            if (Hidden is System.Action e15)
            {
                NodeStateManager.AddEventHandler(castedNode, "Hidden", e15);
                castedNode.Hidden += e15;
            }

            if (ItemRectChanged is System.Action e16)
            {
                NodeStateManager.AddEventHandler(castedNode, "ItemRectChanged", e16);
                castedNode.ItemRectChanged += e16;
            }

            if (Ready is System.Action e17)
            {
                NodeStateManager.AddEventHandler(castedNode, "Ready", e17);
                castedNode.Ready += e17;
            }

            if (Renamed is System.Action e18)
            {
                NodeStateManager.AddEventHandler(castedNode, "Renamed", e18);
                castedNode.Renamed += e18;
            }

            if (TreeEntered is System.Action e19)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeEntered", e19);
                castedNode.TreeEntered += e19;
            }

            if (TreeExiting is System.Action e20)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExiting", e20);
                castedNode.TreeExiting += e20;
            }

            if (TreeExited is System.Action e21)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExited", e21);
                castedNode.TreeExited += e21;
            }

            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e22)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildEnteredTree", e22);
                castedNode.ChildEnteredTree += e22;
            }

            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e23)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildExitingTree", e23);
                castedNode.ChildExitingTree += e23;
            }

            if (ChildOrderChanged is System.Action e24)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildOrderChanged", e24);
                castedNode.ChildOrderChanged += e24;
            }

            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e25)
            {
                NodeStateManager.AddEventHandler(castedNode, "ReplacingBy", e25);
                castedNode.ReplacingBy += e25;
            }

            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e26)
            {
                NodeStateManager.AddEventHandler(castedNode, "EditorDescriptionChanged", e26);
                castedNode.EditorDescriptionChanged += e26;
            }

            if (ScriptChanged is System.Action e27)
            {
                NodeStateManager.AddEventHandler(castedNode, "ScriptChanged", e27);
                castedNode.ScriptChanged += e27;
            }

            if (PropertyListChanged is System.Action e28)
            {
                NodeStateManager.AddEventHandler(castedNode, "PropertyListChanged", e28);
                castedNode.PropertyListChanged += e28;
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
        }
    }
}