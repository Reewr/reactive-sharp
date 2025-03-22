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
        public Dictionary<string, int> ThemeConstantOverrides { protected get; init; } = [];
        public Dictionary<string, Godot.Color> ThemeColorOverrides { protected get; init; } = [];

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
            {
                NodeStateManager.AddPropertyState(castedNode, "Text", castedNode.Text);
                castedNode.Text = n0;
            }

            if (Icon is Godot.Texture2D n1)
            {
                NodeStateManager.AddPropertyState(castedNode, "Icon", castedNode.Icon);
                castedNode.Icon = n1;
            }

            if (Flat is System.Boolean n2)
            {
                NodeStateManager.AddPropertyState(castedNode, "Flat", castedNode.Flat);
                castedNode.Flat = n2;
            }

            if (Alignment is Godot.HorizontalAlignment n3)
            {
                NodeStateManager.AddPropertyState(castedNode, "Alignment", castedNode.Alignment);
                castedNode.Alignment = n3;
            }

            if (TextOverrunBehavior is Godot.TextServer.OverrunBehavior n4)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextOverrunBehavior", castedNode.TextOverrunBehavior);
                castedNode.TextOverrunBehavior = n4;
            }

            if (AutowrapMode is Godot.TextServer.AutowrapMode n5)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutowrapMode", castedNode.AutowrapMode);
                castedNode.AutowrapMode = n5;
            }

            if (ClipText is System.Boolean n6)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipText", castedNode.ClipText);
                castedNode.ClipText = n6;
            }

            if (IconAlignment is Godot.HorizontalAlignment n7)
            {
                NodeStateManager.AddPropertyState(castedNode, "IconAlignment", castedNode.IconAlignment);
                castedNode.IconAlignment = n7;
            }

            if (VerticalIconAlignment is Godot.VerticalAlignment n8)
            {
                NodeStateManager.AddPropertyState(castedNode, "VerticalIconAlignment", castedNode.VerticalIconAlignment);
                castedNode.VerticalIconAlignment = n8;
            }

            if (ExpandIcon is System.Boolean n9)
            {
                NodeStateManager.AddPropertyState(castedNode, "ExpandIcon", castedNode.ExpandIcon);
                castedNode.ExpandIcon = n9;
            }

            if (TextDirection is Godot.Control.TextDirection n10)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextDirection", castedNode.TextDirection);
                castedNode.TextDirection = n10;
            }

            if (Language is System.String n11)
            {
                NodeStateManager.AddPropertyState(castedNode, "Language", castedNode.Language);
                castedNode.Language = n11;
            }

            if (Disabled is System.Boolean n12)
            {
                NodeStateManager.AddPropertyState(castedNode, "Disabled", castedNode.Disabled);
                castedNode.Disabled = n12;
            }

            if (ToggleMode is System.Boolean n13)
            {
                NodeStateManager.AddPropertyState(castedNode, "ToggleMode", castedNode.ToggleMode);
                castedNode.ToggleMode = n13;
            }

            if (ButtonPressed is System.Boolean n14)
            {
                NodeStateManager.AddPropertyState(castedNode, "ButtonPressed", castedNode.ButtonPressed);
                castedNode.ButtonPressed = n14;
            }

            if (ActionMode is Godot.BaseButton.ActionModeEnum n15)
            {
                NodeStateManager.AddPropertyState(castedNode, "ActionMode", castedNode.ActionMode);
                castedNode.ActionMode = n15;
            }

            if (ButtonMask is Godot.MouseButtonMask n16)
            {
                NodeStateManager.AddPropertyState(castedNode, "ButtonMask", castedNode.ButtonMask);
                castedNode.ButtonMask = n16;
            }

            if (KeepPressedOutside is System.Boolean n17)
            {
                NodeStateManager.AddPropertyState(castedNode, "KeepPressedOutside", castedNode.KeepPressedOutside);
                castedNode.KeepPressedOutside = n17;
            }

            if (ButtonGroup is Godot.ButtonGroup n18)
            {
                NodeStateManager.AddPropertyState(castedNode, "ButtonGroup", castedNode.ButtonGroup);
                castedNode.ButtonGroup = n18;
            }

            if (Shortcut is Godot.Shortcut n19)
            {
                NodeStateManager.AddPropertyState(castedNode, "Shortcut", castedNode.Shortcut);
                castedNode.Shortcut = n19;
            }

            if (ShortcutFeedback is System.Boolean n20)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutFeedback", castedNode.ShortcutFeedback);
                castedNode.ShortcutFeedback = n20;
            }

            if (ShortcutInTooltip is System.Boolean n21)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutInTooltip", castedNode.ShortcutInTooltip);
                castedNode.ShortcutInTooltip = n21;
            }

            if (ClipContents is System.Boolean n22)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipContents", castedNode.ClipContents);
                castedNode.ClipContents = n22;
            }

            if (CustomMinimumSize is Godot.Vector2 n23)
            {
                NodeStateManager.AddPropertyState(castedNode, "CustomMinimumSize", castedNode.CustomMinimumSize);
                castedNode.CustomMinimumSize = n23;
            }

            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n24)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutDirection", castedNode.LayoutDirection);
                castedNode.LayoutDirection = n24;
            }

            if (LayoutMode is System.Int32 n25)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutMode", castedNode.LayoutMode);
                castedNode.LayoutMode = n25;
            }

            if (AnchorsPreset is System.Int32 n26)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorsPreset", castedNode.AnchorsPreset);
                castedNode.AnchorsPreset = n26;
            }

            if (AnchorLeft is System.Single n27)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorLeft", castedNode.AnchorLeft);
                castedNode.AnchorLeft = n27;
            }

            if (AnchorTop is System.Single n28)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorTop", castedNode.AnchorTop);
                castedNode.AnchorTop = n28;
            }

            if (AnchorRight is System.Single n29)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorRight", castedNode.AnchorRight);
                castedNode.AnchorRight = n29;
            }

            if (AnchorBottom is System.Single n30)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorBottom", castedNode.AnchorBottom);
                castedNode.AnchorBottom = n30;
            }

            if (OffsetLeft is System.Single n31)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetLeft", castedNode.OffsetLeft);
                castedNode.OffsetLeft = n31;
            }

            if (OffsetTop is System.Single n32)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetTop", castedNode.OffsetTop);
                castedNode.OffsetTop = n32;
            }

            if (OffsetRight is System.Single n33)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetRight", castedNode.OffsetRight);
                castedNode.OffsetRight = n33;
            }

            if (OffsetBottom is System.Single n34)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetBottom", castedNode.OffsetBottom);
                castedNode.OffsetBottom = n34;
            }

            if (GrowHorizontal is Godot.Control.GrowDirection n35)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowHorizontal", castedNode.GrowHorizontal);
                castedNode.GrowHorizontal = n35;
            }

            if (GrowVertical is Godot.Control.GrowDirection n36)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowVertical", castedNode.GrowVertical);
                castedNode.GrowVertical = n36;
            }

            if (Size is Godot.Vector2 n37)
            {
                NodeStateManager.AddPropertyState(castedNode, "Size", castedNode.Size);
                castedNode.Size = n37;
            }

            if (Position is Godot.Vector2 n38)
            {
                NodeStateManager.AddPropertyState(castedNode, "Position", castedNode.Position);
                castedNode.Position = n38;
            }

            if (GlobalPosition is Godot.Vector2 n39)
            {
                NodeStateManager.AddPropertyState(castedNode, "GlobalPosition", castedNode.GlobalPosition);
                castedNode.GlobalPosition = n39;
            }

            if (Rotation is System.Single n40)
            {
                NodeStateManager.AddPropertyState(castedNode, "Rotation", castedNode.Rotation);
                castedNode.Rotation = n40;
            }

            if (RotationDegrees is System.Single n41)
            {
                NodeStateManager.AddPropertyState(castedNode, "RotationDegrees", castedNode.RotationDegrees);
                castedNode.RotationDegrees = n41;
            }

            if (Scale is Godot.Vector2 n42)
            {
                NodeStateManager.AddPropertyState(castedNode, "Scale", castedNode.Scale);
                castedNode.Scale = n42;
            }

            if (PivotOffset is Godot.Vector2 n43)
            {
                NodeStateManager.AddPropertyState(castedNode, "PivotOffset", castedNode.PivotOffset);
                castedNode.PivotOffset = n43;
            }

            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n44)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsHorizontal", castedNode.SizeFlagsHorizontal);
                castedNode.SizeFlagsHorizontal = n44;
            }

            if (SizeFlagsVertical is Godot.Control.SizeFlags n45)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsVertical", castedNode.SizeFlagsVertical);
                castedNode.SizeFlagsVertical = n45;
            }

            if (SizeFlagsStretchRatio is System.Single n46)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsStretchRatio", castedNode.SizeFlagsStretchRatio);
                castedNode.SizeFlagsStretchRatio = n46;
            }

            if (LocalizeNumeralSystem is System.Boolean n47)
            {
                NodeStateManager.AddPropertyState(castedNode, "LocalizeNumeralSystem", castedNode.LocalizeNumeralSystem);
                castedNode.LocalizeNumeralSystem = n47;
            }

            if (AutoTranslate is System.Boolean n48)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslate", castedNode.AutoTranslate);
                castedNode.AutoTranslate = n48;
            }

            if (TooltipText is System.String n49)
            {
                NodeStateManager.AddPropertyState(castedNode, "TooltipText", castedNode.TooltipText);
                castedNode.TooltipText = n49;
            }

            if (FocusNeighborLeft is Godot.NodePath n50)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborLeft", castedNode.FocusNeighborLeft);
                castedNode.FocusNeighborLeft = n50;
            }

            if (FocusNeighborTop is Godot.NodePath n51)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborTop", castedNode.FocusNeighborTop);
                castedNode.FocusNeighborTop = n51;
            }

            if (FocusNeighborRight is Godot.NodePath n52)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborRight", castedNode.FocusNeighborRight);
                castedNode.FocusNeighborRight = n52;
            }

            if (FocusNeighborBottom is Godot.NodePath n53)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborBottom", castedNode.FocusNeighborBottom);
                castedNode.FocusNeighborBottom = n53;
            }

            if (FocusNext is Godot.NodePath n54)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNext", castedNode.FocusNext);
                castedNode.FocusNext = n54;
            }

            if (FocusPrevious is Godot.NodePath n55)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusPrevious", castedNode.FocusPrevious);
                castedNode.FocusPrevious = n55;
            }

            if (FocusMode is Godot.Control.FocusModeEnum n56)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusMode", castedNode.FocusMode);
                castedNode.FocusMode = n56;
            }

            if (MouseFilter is Godot.Control.MouseFilterEnum n57)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseFilter", castedNode.MouseFilter);
                castedNode.MouseFilter = n57;
            }

            if (MouseForcePassScrollEvents is System.Boolean n58)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseForcePassScrollEvents", castedNode.MouseForcePassScrollEvents);
                castedNode.MouseForcePassScrollEvents = n58;
            }

            if (MouseDefaultCursorShape is Godot.Control.CursorShape n59)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseDefaultCursorShape", castedNode.MouseDefaultCursorShape);
                castedNode.MouseDefaultCursorShape = n59;
            }

            if (ShortcutContext is Godot.Node n60)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutContext", castedNode.ShortcutContext);
                castedNode.ShortcutContext = n60;
            }

            if (Theme is Godot.Theme n61)
            {
                NodeStateManager.AddPropertyState(castedNode, "Theme", castedNode.Theme);
                castedNode.Theme = n61;
            }

            if (ThemeTypeVariation is Godot.StringName n62)
            {
                NodeStateManager.AddPropertyState(castedNode, "ThemeTypeVariation", castedNode.ThemeTypeVariation);
                castedNode.ThemeTypeVariation = n62;
            }

            if (Visible is System.Boolean n63)
            {
                NodeStateManager.AddPropertyState(castedNode, "Visible", castedNode.Visible);
                castedNode.Visible = n63;
            }

            if (Modulate is Godot.Color n64)
            {
                NodeStateManager.AddPropertyState(castedNode, "Modulate", castedNode.Modulate);
                castedNode.Modulate = n64;
            }

            if (SelfModulate is Godot.Color n65)
            {
                NodeStateManager.AddPropertyState(castedNode, "SelfModulate", castedNode.SelfModulate);
                castedNode.SelfModulate = n65;
            }

            if (ShowBehindParent is System.Boolean n66)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowBehindParent", castedNode.ShowBehindParent);
                castedNode.ShowBehindParent = n66;
            }

            if (TopLevel is System.Boolean n67)
            {
                NodeStateManager.AddPropertyState(castedNode, "TopLevel", castedNode.TopLevel);
                castedNode.TopLevel = n67;
            }

            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n68)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipChildren", castedNode.ClipChildren);
                castedNode.ClipChildren = n68;
            }

            if (LightMask is System.Int32 n69)
            {
                NodeStateManager.AddPropertyState(castedNode, "LightMask", castedNode.LightMask);
                castedNode.LightMask = n69;
            }

            if (VisibilityLayer is System.UInt32 n70)
            {
                NodeStateManager.AddPropertyState(castedNode, "VisibilityLayer", castedNode.VisibilityLayer);
                castedNode.VisibilityLayer = n70;
            }

            if (ZIndex is System.Int32 n71)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZIndex", castedNode.ZIndex);
                castedNode.ZIndex = n71;
            }

            if (ZAsRelative is System.Boolean n72)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZAsRelative", castedNode.ZAsRelative);
                castedNode.ZAsRelative = n72;
            }

            if (YSortEnabled is System.Boolean n73)
            {
                NodeStateManager.AddPropertyState(castedNode, "YSortEnabled", castedNode.YSortEnabled);
                castedNode.YSortEnabled = n73;
            }

            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n74)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureFilter", castedNode.TextureFilter);
                castedNode.TextureFilter = n74;
            }

            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n75)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureRepeat", castedNode.TextureRepeat);
                castedNode.TextureRepeat = n75;
            }

            if (Material is Godot.Material n76)
            {
                NodeStateManager.AddPropertyState(castedNode, "Material", castedNode.Material);
                castedNode.Material = n76;
            }

            if (UseParentMaterial is System.Boolean n77)
            {
                NodeStateManager.AddPropertyState(castedNode, "UseParentMaterial", castedNode.UseParentMaterial);
                castedNode.UseParentMaterial = n77;
            }

            if (Name is Godot.StringName n78)
            {
                NodeStateManager.AddPropertyState(castedNode, "Name", castedNode.Name);
                castedNode.Name = n78;
            }

            if (UniqueNameInOwner is System.Boolean n79)
            {
                NodeStateManager.AddPropertyState(castedNode, "UniqueNameInOwner", castedNode.UniqueNameInOwner);
                castedNode.UniqueNameInOwner = n79;
            }

            if (SceneFilePath is System.String n80)
            {
                NodeStateManager.AddPropertyState(castedNode, "SceneFilePath", castedNode.SceneFilePath);
                castedNode.SceneFilePath = n80;
            }

            if (Owner is Godot.Node n81)
            {
                NodeStateManager.AddPropertyState(castedNode, "Owner", castedNode.Owner);
                castedNode.Owner = n81;
            }

            if (ProcessMode is Godot.Node.ProcessModeEnum n82)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessMode", castedNode.ProcessMode);
                castedNode.ProcessMode = n82;
            }

            if (ProcessPriority is System.Int32 n83)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPriority", castedNode.ProcessPriority);
                castedNode.ProcessPriority = n83;
            }

            if (ProcessPhysicsPriority is System.Int32 n84)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPhysicsPriority", castedNode.ProcessPhysicsPriority);
                castedNode.ProcessPhysicsPriority = n84;
            }

            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n85)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroup", castedNode.ProcessThreadGroup);
                castedNode.ProcessThreadGroup = n85;
            }

            if (ProcessThreadGroupOrder is System.Int32 n86)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroupOrder", castedNode.ProcessThreadGroupOrder);
                castedNode.ProcessThreadGroupOrder = n86;
            }

            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n87)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadMessages", castedNode.ProcessThreadMessages);
                castedNode.ProcessThreadMessages = n87;
            }

            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n88)
            {
                NodeStateManager.AddPropertyState(castedNode, "PhysicsInterpolationMode", castedNode.PhysicsInterpolationMode);
                castedNode.PhysicsInterpolationMode = n88;
            }

            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n89)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslateMode", castedNode.AutoTranslateMode);
                castedNode.AutoTranslateMode = n89;
            }

            if (EditorDescription is System.String n90)
            {
                NodeStateManager.AddPropertyState(castedNode, "EditorDescription", castedNode.EditorDescription);
                castedNode.EditorDescription = n90;
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