// This file is auto-generated. Please do not edit
namespace ReactiveSharpGodot.Components
{
    public class ColorPickerButton : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GColorPickerButton>
    {
        public Godot.Color? Color { protected get; init; }
        public System.Boolean? EditAlpha { protected get; init; }
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
        public Godot.Node.AutoTranslateModeEnum? TooltipAutoTranslateMode { protected get; init; }
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
        public Godot.ColorPickerButton.ColorChangedEventHandler? ColorChanged { protected get; init; }
        public System.Action? PopupClosed { protected get; init; }
        public System.Action? PickerCreated { protected get; init; }
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
        public System.Action? EditorStateChanged { protected get; init; }
        public System.Action? ScriptChanged { protected get; init; }
        public System.Action? PropertyListChanged { protected get; init; }
        public Dictionary<string, int> ThemeConstantOverrides { protected get; init; } = [];
        public Dictionary<string, Godot.Color> ThemeColorOverrides { protected get; init; } = [];
        /// <summary>
        /// This property allows you to define an action that will be called right after the node
        /// it represents is updated within Godot. As godot has many functions that can be useful
        /// making bindings for all of them, even generated ones, is a huge task.
        ///
        /// This function allows you to use all the functionality of the godot node.
        ///
        /// <b>NOTE</b>: State changes done through this function are NOT reset on re-render.
        /// Therefore, you need to keep track of the state yourself and set it on every render
        /// <example>
        /// In the below example, the component uses a button. The button has a SetPressedNoSignal function
        /// that can be used to set the toggle state on the button without triggering an event
        /// Since this is a function and not a property, it is not exposed through the Button component itself
        /// and therefore we need to use the CustomNodeHandling to set this property.
        /// <code>
        /// class MyComponent : Component {
        /// 	Component Render() {
        /// 		var isToggled = UseState(false);
        /// 		return new Button()
        /// 		{
        /// 			ToggleMode = true,
        ///			CustomNodeHandling = (Button button) =>
        /// 			{
        /// 				button.SetPressedNoSignal(isToggled.Value);
        /// 			}
        /// 		};
        /// 	}
        /// }
        /// </code>
        /// </example>
        /// </summary>
        public Action<ReactiveSharpGodot.Nodes.GColorPickerButton>? CustomNodeHandling { protected get; init; }

        public override ReactiveSharpGodot.Nodes.GColorPickerButton Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GColorPickerButton();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GColorPickerButton node)
        {
            var castedNode = (Godot.ColorPickerButton)node.Node;
            if (Color is Godot.Color n0)
            {
                NodeStateManager.AddPropertyState(castedNode, "Color", castedNode.Color);
                castedNode.Color = n0;
            }

            if (EditAlpha is System.Boolean n1)
            {
                NodeStateManager.AddPropertyState(castedNode, "EditAlpha", castedNode.EditAlpha);
                castedNode.EditAlpha = n1;
            }

            if (Text is System.String n2)
            {
                NodeStateManager.AddPropertyState(castedNode, "Text", castedNode.Text);
                castedNode.Text = n2;
            }

            if (Icon is Godot.Texture2D n3)
            {
                NodeStateManager.AddPropertyState(castedNode, "Icon", castedNode.Icon);
                castedNode.Icon = n3;
            }

            if (Flat is System.Boolean n4)
            {
                NodeStateManager.AddPropertyState(castedNode, "Flat", castedNode.Flat);
                castedNode.Flat = n4;
            }

            if (Alignment is Godot.HorizontalAlignment n5)
            {
                NodeStateManager.AddPropertyState(castedNode, "Alignment", castedNode.Alignment);
                castedNode.Alignment = n5;
            }

            if (TextOverrunBehavior is Godot.TextServer.OverrunBehavior n6)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextOverrunBehavior", castedNode.TextOverrunBehavior);
                castedNode.TextOverrunBehavior = n6;
            }

            if (AutowrapMode is Godot.TextServer.AutowrapMode n7)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutowrapMode", castedNode.AutowrapMode);
                castedNode.AutowrapMode = n7;
            }

            if (ClipText is System.Boolean n8)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipText", castedNode.ClipText);
                castedNode.ClipText = n8;
            }

            if (IconAlignment is Godot.HorizontalAlignment n9)
            {
                NodeStateManager.AddPropertyState(castedNode, "IconAlignment", castedNode.IconAlignment);
                castedNode.IconAlignment = n9;
            }

            if (VerticalIconAlignment is Godot.VerticalAlignment n10)
            {
                NodeStateManager.AddPropertyState(castedNode, "VerticalIconAlignment", castedNode.VerticalIconAlignment);
                castedNode.VerticalIconAlignment = n10;
            }

            if (ExpandIcon is System.Boolean n11)
            {
                NodeStateManager.AddPropertyState(castedNode, "ExpandIcon", castedNode.ExpandIcon);
                castedNode.ExpandIcon = n11;
            }

            if (TextDirection is Godot.Control.TextDirection n12)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextDirection", castedNode.TextDirection);
                castedNode.TextDirection = n12;
            }

            if (Language is System.String n13)
            {
                NodeStateManager.AddPropertyState(castedNode, "Language", castedNode.Language);
                castedNode.Language = n13;
            }

            if (Disabled is System.Boolean n14)
            {
                NodeStateManager.AddPropertyState(castedNode, "Disabled", castedNode.Disabled);
                castedNode.Disabled = n14;
            }

            if (ToggleMode is System.Boolean n15)
            {
                NodeStateManager.AddPropertyState(castedNode, "ToggleMode", castedNode.ToggleMode);
                castedNode.ToggleMode = n15;
            }

            if (ButtonPressed is System.Boolean n16)
            {
                NodeStateManager.AddPropertyState(castedNode, "ButtonPressed", castedNode.ButtonPressed);
                castedNode.ButtonPressed = n16;
            }

            if (ActionMode is Godot.BaseButton.ActionModeEnum n17)
            {
                NodeStateManager.AddPropertyState(castedNode, "ActionMode", castedNode.ActionMode);
                castedNode.ActionMode = n17;
            }

            if (ButtonMask is Godot.MouseButtonMask n18)
            {
                NodeStateManager.AddPropertyState(castedNode, "ButtonMask", castedNode.ButtonMask);
                castedNode.ButtonMask = n18;
            }

            if (KeepPressedOutside is System.Boolean n19)
            {
                NodeStateManager.AddPropertyState(castedNode, "KeepPressedOutside", castedNode.KeepPressedOutside);
                castedNode.KeepPressedOutside = n19;
            }

            if (ButtonGroup is Godot.ButtonGroup n20)
            {
                NodeStateManager.AddPropertyState(castedNode, "ButtonGroup", castedNode.ButtonGroup);
                castedNode.ButtonGroup = n20;
            }

            if (Shortcut is Godot.Shortcut n21)
            {
                NodeStateManager.AddPropertyState(castedNode, "Shortcut", castedNode.Shortcut);
                castedNode.Shortcut = n21;
            }

            if (ShortcutFeedback is System.Boolean n22)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutFeedback", castedNode.ShortcutFeedback);
                castedNode.ShortcutFeedback = n22;
            }

            if (ShortcutInTooltip is System.Boolean n23)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutInTooltip", castedNode.ShortcutInTooltip);
                castedNode.ShortcutInTooltip = n23;
            }

            if (ClipContents is System.Boolean n24)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipContents", castedNode.ClipContents);
                castedNode.ClipContents = n24;
            }

            if (CustomMinimumSize is Godot.Vector2 n25)
            {
                NodeStateManager.AddPropertyState(castedNode, "CustomMinimumSize", castedNode.CustomMinimumSize);
                castedNode.CustomMinimumSize = n25;
            }

            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n26)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutDirection", castedNode.LayoutDirection);
                castedNode.LayoutDirection = n26;
            }

            if (LayoutMode is System.Int32 n27)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutMode", castedNode.LayoutMode);
                castedNode.LayoutMode = n27;
            }

            if (AnchorsPreset is System.Int32 n28)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorsPreset", castedNode.AnchorsPreset);
                castedNode.AnchorsPreset = n28;
            }

            if (AnchorLeft is System.Single n29)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorLeft", castedNode.AnchorLeft);
                castedNode.AnchorLeft = n29;
            }

            if (AnchorTop is System.Single n30)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorTop", castedNode.AnchorTop);
                castedNode.AnchorTop = n30;
            }

            if (AnchorRight is System.Single n31)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorRight", castedNode.AnchorRight);
                castedNode.AnchorRight = n31;
            }

            if (AnchorBottom is System.Single n32)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorBottom", castedNode.AnchorBottom);
                castedNode.AnchorBottom = n32;
            }

            if (OffsetLeft is System.Single n33)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetLeft", castedNode.OffsetLeft);
                castedNode.OffsetLeft = n33;
            }

            if (OffsetTop is System.Single n34)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetTop", castedNode.OffsetTop);
                castedNode.OffsetTop = n34;
            }

            if (OffsetRight is System.Single n35)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetRight", castedNode.OffsetRight);
                castedNode.OffsetRight = n35;
            }

            if (OffsetBottom is System.Single n36)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetBottom", castedNode.OffsetBottom);
                castedNode.OffsetBottom = n36;
            }

            if (GrowHorizontal is Godot.Control.GrowDirection n37)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowHorizontal", castedNode.GrowHorizontal);
                castedNode.GrowHorizontal = n37;
            }

            if (GrowVertical is Godot.Control.GrowDirection n38)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowVertical", castedNode.GrowVertical);
                castedNode.GrowVertical = n38;
            }

            if (Size is Godot.Vector2 n39)
            {
                NodeStateManager.AddPropertyState(castedNode, "Size", castedNode.Size);
                castedNode.Size = n39;
            }

            if (Position is Godot.Vector2 n40)
            {
                NodeStateManager.AddPropertyState(castedNode, "Position", castedNode.Position);
                castedNode.Position = n40;
            }

            if (GlobalPosition is Godot.Vector2 n41)
            {
                NodeStateManager.AddPropertyState(castedNode, "GlobalPosition", castedNode.GlobalPosition);
                castedNode.GlobalPosition = n41;
            }

            if (Rotation is System.Single n42)
            {
                NodeStateManager.AddPropertyState(castedNode, "Rotation", castedNode.Rotation);
                castedNode.Rotation = n42;
            }

            if (RotationDegrees is System.Single n43)
            {
                NodeStateManager.AddPropertyState(castedNode, "RotationDegrees", castedNode.RotationDegrees);
                castedNode.RotationDegrees = n43;
            }

            if (Scale is Godot.Vector2 n44)
            {
                NodeStateManager.AddPropertyState(castedNode, "Scale", castedNode.Scale);
                castedNode.Scale = n44;
            }

            if (PivotOffset is Godot.Vector2 n45)
            {
                NodeStateManager.AddPropertyState(castedNode, "PivotOffset", castedNode.PivotOffset);
                castedNode.PivotOffset = n45;
            }

            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n46)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsHorizontal", castedNode.SizeFlagsHorizontal);
                castedNode.SizeFlagsHorizontal = n46;
            }

            if (SizeFlagsVertical is Godot.Control.SizeFlags n47)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsVertical", castedNode.SizeFlagsVertical);
                castedNode.SizeFlagsVertical = n47;
            }

            if (SizeFlagsStretchRatio is System.Single n48)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsStretchRatio", castedNode.SizeFlagsStretchRatio);
                castedNode.SizeFlagsStretchRatio = n48;
            }

            if (LocalizeNumeralSystem is System.Boolean n49)
            {
                NodeStateManager.AddPropertyState(castedNode, "LocalizeNumeralSystem", castedNode.LocalizeNumeralSystem);
                castedNode.LocalizeNumeralSystem = n49;
            }

            if (AutoTranslate is System.Boolean n50)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslate", castedNode.AutoTranslate);
                castedNode.AutoTranslate = n50;
            }

            if (TooltipText is System.String n51)
            {
                NodeStateManager.AddPropertyState(castedNode, "TooltipText", castedNode.TooltipText);
                castedNode.TooltipText = n51;
            }

            if (TooltipAutoTranslateMode is Godot.Node.AutoTranslateModeEnum n52)
            {
                NodeStateManager.AddPropertyState(castedNode, "TooltipAutoTranslateMode", castedNode.TooltipAutoTranslateMode);
                castedNode.TooltipAutoTranslateMode = n52;
            }

            if (FocusNeighborLeft is Godot.NodePath n53)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborLeft", castedNode.FocusNeighborLeft);
                castedNode.FocusNeighborLeft = n53;
            }

            if (FocusNeighborTop is Godot.NodePath n54)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborTop", castedNode.FocusNeighborTop);
                castedNode.FocusNeighborTop = n54;
            }

            if (FocusNeighborRight is Godot.NodePath n55)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborRight", castedNode.FocusNeighborRight);
                castedNode.FocusNeighborRight = n55;
            }

            if (FocusNeighborBottom is Godot.NodePath n56)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborBottom", castedNode.FocusNeighborBottom);
                castedNode.FocusNeighborBottom = n56;
            }

            if (FocusNext is Godot.NodePath n57)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNext", castedNode.FocusNext);
                castedNode.FocusNext = n57;
            }

            if (FocusPrevious is Godot.NodePath n58)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusPrevious", castedNode.FocusPrevious);
                castedNode.FocusPrevious = n58;
            }

            if (FocusMode is Godot.Control.FocusModeEnum n59)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusMode", castedNode.FocusMode);
                castedNode.FocusMode = n59;
            }

            if (MouseFilter is Godot.Control.MouseFilterEnum n60)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseFilter", castedNode.MouseFilter);
                castedNode.MouseFilter = n60;
            }

            if (MouseForcePassScrollEvents is System.Boolean n61)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseForcePassScrollEvents", castedNode.MouseForcePassScrollEvents);
                castedNode.MouseForcePassScrollEvents = n61;
            }

            if (MouseDefaultCursorShape is Godot.Control.CursorShape n62)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseDefaultCursorShape", castedNode.MouseDefaultCursorShape);
                castedNode.MouseDefaultCursorShape = n62;
            }

            if (ShortcutContext is Godot.Node n63)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutContext", castedNode.ShortcutContext);
                castedNode.ShortcutContext = n63;
            }

            if (Theme is Godot.Theme n64)
            {
                NodeStateManager.AddPropertyState(castedNode, "Theme", castedNode.Theme);
                castedNode.Theme = n64;
            }

            if (ThemeTypeVariation is Godot.StringName n65)
            {
                NodeStateManager.AddPropertyState(castedNode, "ThemeTypeVariation", castedNode.ThemeTypeVariation);
                castedNode.ThemeTypeVariation = n65;
            }

            if (Visible is System.Boolean n66)
            {
                NodeStateManager.AddPropertyState(castedNode, "Visible", castedNode.Visible);
                castedNode.Visible = n66;
            }

            if (Modulate is Godot.Color n67)
            {
                NodeStateManager.AddPropertyState(castedNode, "Modulate", castedNode.Modulate);
                castedNode.Modulate = n67;
            }

            if (SelfModulate is Godot.Color n68)
            {
                NodeStateManager.AddPropertyState(castedNode, "SelfModulate", castedNode.SelfModulate);
                castedNode.SelfModulate = n68;
            }

            if (ShowBehindParent is System.Boolean n69)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowBehindParent", castedNode.ShowBehindParent);
                castedNode.ShowBehindParent = n69;
            }

            if (TopLevel is System.Boolean n70)
            {
                NodeStateManager.AddPropertyState(castedNode, "TopLevel", castedNode.TopLevel);
                castedNode.TopLevel = n70;
            }

            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n71)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipChildren", castedNode.ClipChildren);
                castedNode.ClipChildren = n71;
            }

            if (LightMask is System.Int32 n72)
            {
                NodeStateManager.AddPropertyState(castedNode, "LightMask", castedNode.LightMask);
                castedNode.LightMask = n72;
            }

            if (VisibilityLayer is System.UInt32 n73)
            {
                NodeStateManager.AddPropertyState(castedNode, "VisibilityLayer", castedNode.VisibilityLayer);
                castedNode.VisibilityLayer = n73;
            }

            if (ZIndex is System.Int32 n74)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZIndex", castedNode.ZIndex);
                castedNode.ZIndex = n74;
            }

            if (ZAsRelative is System.Boolean n75)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZAsRelative", castedNode.ZAsRelative);
                castedNode.ZAsRelative = n75;
            }

            if (YSortEnabled is System.Boolean n76)
            {
                NodeStateManager.AddPropertyState(castedNode, "YSortEnabled", castedNode.YSortEnabled);
                castedNode.YSortEnabled = n76;
            }

            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n77)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureFilter", castedNode.TextureFilter);
                castedNode.TextureFilter = n77;
            }

            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n78)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureRepeat", castedNode.TextureRepeat);
                castedNode.TextureRepeat = n78;
            }

            if (Material is Godot.Material n79)
            {
                NodeStateManager.AddPropertyState(castedNode, "Material", castedNode.Material);
                castedNode.Material = n79;
            }

            if (UseParentMaterial is System.Boolean n80)
            {
                NodeStateManager.AddPropertyState(castedNode, "UseParentMaterial", castedNode.UseParentMaterial);
                castedNode.UseParentMaterial = n80;
            }

            if (Name is Godot.StringName n81)
            {
                NodeStateManager.AddPropertyState(castedNode, "Name", castedNode.Name);
                castedNode.Name = n81;
            }

            if (UniqueNameInOwner is System.Boolean n82)
            {
                NodeStateManager.AddPropertyState(castedNode, "UniqueNameInOwner", castedNode.UniqueNameInOwner);
                castedNode.UniqueNameInOwner = n82;
            }

            if (SceneFilePath is System.String n83)
            {
                NodeStateManager.AddPropertyState(castedNode, "SceneFilePath", castedNode.SceneFilePath);
                castedNode.SceneFilePath = n83;
            }

            if (Owner is Godot.Node n84)
            {
                NodeStateManager.AddPropertyState(castedNode, "Owner", castedNode.Owner);
                castedNode.Owner = n84;
            }

            if (ProcessMode is Godot.Node.ProcessModeEnum n85)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessMode", castedNode.ProcessMode);
                castedNode.ProcessMode = n85;
            }

            if (ProcessPriority is System.Int32 n86)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPriority", castedNode.ProcessPriority);
                castedNode.ProcessPriority = n86;
            }

            if (ProcessPhysicsPriority is System.Int32 n87)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPhysicsPriority", castedNode.ProcessPhysicsPriority);
                castedNode.ProcessPhysicsPriority = n87;
            }

            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n88)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroup", castedNode.ProcessThreadGroup);
                castedNode.ProcessThreadGroup = n88;
            }

            if (ProcessThreadGroupOrder is System.Int32 n89)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroupOrder", castedNode.ProcessThreadGroupOrder);
                castedNode.ProcessThreadGroupOrder = n89;
            }

            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n90)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadMessages", castedNode.ProcessThreadMessages);
                castedNode.ProcessThreadMessages = n90;
            }

            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n91)
            {
                NodeStateManager.AddPropertyState(castedNode, "PhysicsInterpolationMode", castedNode.PhysicsInterpolationMode);
                castedNode.PhysicsInterpolationMode = n91;
            }

            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n92)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslateMode", castedNode.AutoTranslateMode);
                castedNode.AutoTranslateMode = n92;
            }

            if (EditorDescription is System.String n93)
            {
                NodeStateManager.AddPropertyState(castedNode, "EditorDescription", castedNode.EditorDescription);
                castedNode.EditorDescription = n93;
            }

            if (ColorChanged is Godot.ColorPickerButton.ColorChangedEventHandler e0)
            {
                NodeStateManager.AddEventHandler(castedNode, "ColorChanged", e0);
                castedNode.ColorChanged += e0;
            }

            if (PopupClosed is System.Action e1)
            {
                NodeStateManager.AddEventHandler(castedNode, "PopupClosed", e1);
                castedNode.PopupClosed += e1;
            }

            if (PickerCreated is System.Action e2)
            {
                NodeStateManager.AddEventHandler(castedNode, "PickerCreated", e2);
                castedNode.PickerCreated += e2;
            }

            if (Pressed is System.Action e3)
            {
                NodeStateManager.AddEventHandler(castedNode, "Pressed", e3);
                castedNode.Pressed += e3;
            }

            if (ButtonUp is System.Action e4)
            {
                NodeStateManager.AddEventHandler(castedNode, "ButtonUp", e4);
                castedNode.ButtonUp += e4;
            }

            if (ButtonDown is System.Action e5)
            {
                NodeStateManager.AddEventHandler(castedNode, "ButtonDown", e5);
                castedNode.ButtonDown += e5;
            }

            if (Toggled is Godot.BaseButton.ToggledEventHandler e6)
            {
                NodeStateManager.AddEventHandler(castedNode, "Toggled", e6);
                castedNode.Toggled += e6;
            }

            if (Resized is System.Action e7)
            {
                NodeStateManager.AddEventHandler(castedNode, "Resized", e7);
                castedNode.Resized += e7;
            }

            if (GuiInput is Godot.Control.GuiInputEventHandler e8)
            {
                NodeStateManager.AddEventHandler(castedNode, "GuiInput", e8);
                castedNode.GuiInput += e8;
            }

            if (MouseEntered is System.Action e9)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseEntered", e9);
                castedNode.MouseEntered += e9;
            }

            if (MouseExited is System.Action e10)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseExited", e10);
                castedNode.MouseExited += e10;
            }

            if (FocusEntered is System.Action e11)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusEntered", e11);
                castedNode.FocusEntered += e11;
            }

            if (FocusExited is System.Action e12)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusExited", e12);
                castedNode.FocusExited += e12;
            }

            if (SizeFlagsChanged is System.Action e13)
            {
                NodeStateManager.AddEventHandler(castedNode, "SizeFlagsChanged", e13);
                castedNode.SizeFlagsChanged += e13;
            }

            if (MinimumSizeChanged is System.Action e14)
            {
                NodeStateManager.AddEventHandler(castedNode, "MinimumSizeChanged", e14);
                castedNode.MinimumSizeChanged += e14;
            }

            if (ThemeChanged is System.Action e15)
            {
                NodeStateManager.AddEventHandler(castedNode, "ThemeChanged", e15);
                castedNode.ThemeChanged += e15;
            }

            if (Draw is System.Action e16)
            {
                NodeStateManager.AddEventHandler(castedNode, "Draw", e16);
                castedNode.Draw += e16;
            }

            if (VisibilityChanged is System.Action e17)
            {
                NodeStateManager.AddEventHandler(castedNode, "VisibilityChanged", e17);
                castedNode.VisibilityChanged += e17;
            }

            if (Hidden is System.Action e18)
            {
                NodeStateManager.AddEventHandler(castedNode, "Hidden", e18);
                castedNode.Hidden += e18;
            }

            if (ItemRectChanged is System.Action e19)
            {
                NodeStateManager.AddEventHandler(castedNode, "ItemRectChanged", e19);
                castedNode.ItemRectChanged += e19;
            }

            if (Ready is System.Action e20)
            {
                NodeStateManager.AddEventHandler(castedNode, "Ready", e20);
                castedNode.Ready += e20;
            }

            if (Renamed is System.Action e21)
            {
                NodeStateManager.AddEventHandler(castedNode, "Renamed", e21);
                castedNode.Renamed += e21;
            }

            if (TreeEntered is System.Action e22)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeEntered", e22);
                castedNode.TreeEntered += e22;
            }

            if (TreeExiting is System.Action e23)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExiting", e23);
                castedNode.TreeExiting += e23;
            }

            if (TreeExited is System.Action e24)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExited", e24);
                castedNode.TreeExited += e24;
            }

            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e25)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildEnteredTree", e25);
                castedNode.ChildEnteredTree += e25;
            }

            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e26)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildExitingTree", e26);
                castedNode.ChildExitingTree += e26;
            }

            if (ChildOrderChanged is System.Action e27)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildOrderChanged", e27);
                castedNode.ChildOrderChanged += e27;
            }

            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e28)
            {
                NodeStateManager.AddEventHandler(castedNode, "ReplacingBy", e28);
                castedNode.ReplacingBy += e28;
            }

            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e29)
            {
                NodeStateManager.AddEventHandler(castedNode, "EditorDescriptionChanged", e29);
                castedNode.EditorDescriptionChanged += e29;
            }

            if (EditorStateChanged is System.Action e30)
            {
                NodeStateManager.AddEventHandler(castedNode, "EditorStateChanged", e30);
                castedNode.EditorStateChanged += e30;
            }

            if (ScriptChanged is System.Action e31)
            {
                NodeStateManager.AddEventHandler(castedNode, "ScriptChanged", e31);
                castedNode.ScriptChanged += e31;
            }

            if (PropertyListChanged is System.Action e32)
            {
                NodeStateManager.AddEventHandler(castedNode, "PropertyListChanged", e32);
                castedNode.PropertyListChanged += e32;
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
            CustomNodeHandling?.Invoke(node);
        }
    }
}