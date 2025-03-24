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
        public Action<ReactiveSharpGodot.Nodes.GOptionButton>? CustomNodeHandling { protected get; init; }

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
            {
                NodeStateManager.AddPropertyState(castedNode, "Selected", castedNode.Selected);
                castedNode.Selected = n0;
            }

            if (FitToLongestItem is System.Boolean n1)
            {
                NodeStateManager.AddPropertyState(castedNode, "FitToLongestItem", castedNode.FitToLongestItem);
                castedNode.FitToLongestItem = n1;
            }

            if (AllowReselect is System.Boolean n2)
            {
                NodeStateManager.AddPropertyState(castedNode, "AllowReselect", castedNode.AllowReselect);
                castedNode.AllowReselect = n2;
            }

            if (ItemCount is System.Int32 n3)
            {
                NodeStateManager.AddPropertyState(castedNode, "ItemCount", castedNode.ItemCount);
                castedNode.ItemCount = n3;
            }

            if (Text is System.String n4)
            {
                NodeStateManager.AddPropertyState(castedNode, "Text", castedNode.Text);
                castedNode.Text = n4;
            }

            if (Icon is Godot.Texture2D n5)
            {
                NodeStateManager.AddPropertyState(castedNode, "Icon", castedNode.Icon);
                castedNode.Icon = n5;
            }

            if (Flat is System.Boolean n6)
            {
                NodeStateManager.AddPropertyState(castedNode, "Flat", castedNode.Flat);
                castedNode.Flat = n6;
            }

            if (Alignment is Godot.HorizontalAlignment n7)
            {
                NodeStateManager.AddPropertyState(castedNode, "Alignment", castedNode.Alignment);
                castedNode.Alignment = n7;
            }

            if (TextOverrunBehavior is Godot.TextServer.OverrunBehavior n8)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextOverrunBehavior", castedNode.TextOverrunBehavior);
                castedNode.TextOverrunBehavior = n8;
            }

            if (AutowrapMode is Godot.TextServer.AutowrapMode n9)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutowrapMode", castedNode.AutowrapMode);
                castedNode.AutowrapMode = n9;
            }

            if (ClipText is System.Boolean n10)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipText", castedNode.ClipText);
                castedNode.ClipText = n10;
            }

            if (IconAlignment is Godot.HorizontalAlignment n11)
            {
                NodeStateManager.AddPropertyState(castedNode, "IconAlignment", castedNode.IconAlignment);
                castedNode.IconAlignment = n11;
            }

            if (VerticalIconAlignment is Godot.VerticalAlignment n12)
            {
                NodeStateManager.AddPropertyState(castedNode, "VerticalIconAlignment", castedNode.VerticalIconAlignment);
                castedNode.VerticalIconAlignment = n12;
            }

            if (ExpandIcon is System.Boolean n13)
            {
                NodeStateManager.AddPropertyState(castedNode, "ExpandIcon", castedNode.ExpandIcon);
                castedNode.ExpandIcon = n13;
            }

            if (TextDirection is Godot.Control.TextDirection n14)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextDirection", castedNode.TextDirection);
                castedNode.TextDirection = n14;
            }

            if (Language is System.String n15)
            {
                NodeStateManager.AddPropertyState(castedNode, "Language", castedNode.Language);
                castedNode.Language = n15;
            }

            if (Disabled is System.Boolean n16)
            {
                NodeStateManager.AddPropertyState(castedNode, "Disabled", castedNode.Disabled);
                castedNode.Disabled = n16;
            }

            if (ToggleMode is System.Boolean n17)
            {
                NodeStateManager.AddPropertyState(castedNode, "ToggleMode", castedNode.ToggleMode);
                castedNode.ToggleMode = n17;
            }

            if (ButtonPressed is System.Boolean n18)
            {
                NodeStateManager.AddPropertyState(castedNode, "ButtonPressed", castedNode.ButtonPressed);
                castedNode.ButtonPressed = n18;
            }

            if (ActionMode is Godot.BaseButton.ActionModeEnum n19)
            {
                NodeStateManager.AddPropertyState(castedNode, "ActionMode", castedNode.ActionMode);
                castedNode.ActionMode = n19;
            }

            if (ButtonMask is Godot.MouseButtonMask n20)
            {
                NodeStateManager.AddPropertyState(castedNode, "ButtonMask", castedNode.ButtonMask);
                castedNode.ButtonMask = n20;
            }

            if (KeepPressedOutside is System.Boolean n21)
            {
                NodeStateManager.AddPropertyState(castedNode, "KeepPressedOutside", castedNode.KeepPressedOutside);
                castedNode.KeepPressedOutside = n21;
            }

            if (ButtonGroup is Godot.ButtonGroup n22)
            {
                NodeStateManager.AddPropertyState(castedNode, "ButtonGroup", castedNode.ButtonGroup);
                castedNode.ButtonGroup = n22;
            }

            if (Shortcut is Godot.Shortcut n23)
            {
                NodeStateManager.AddPropertyState(castedNode, "Shortcut", castedNode.Shortcut);
                castedNode.Shortcut = n23;
            }

            if (ShortcutFeedback is System.Boolean n24)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutFeedback", castedNode.ShortcutFeedback);
                castedNode.ShortcutFeedback = n24;
            }

            if (ShortcutInTooltip is System.Boolean n25)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutInTooltip", castedNode.ShortcutInTooltip);
                castedNode.ShortcutInTooltip = n25;
            }

            if (ClipContents is System.Boolean n26)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipContents", castedNode.ClipContents);
                castedNode.ClipContents = n26;
            }

            if (CustomMinimumSize is Godot.Vector2 n27)
            {
                NodeStateManager.AddPropertyState(castedNode, "CustomMinimumSize", castedNode.CustomMinimumSize);
                castedNode.CustomMinimumSize = n27;
            }

            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n28)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutDirection", castedNode.LayoutDirection);
                castedNode.LayoutDirection = n28;
            }

            if (LayoutMode is System.Int32 n29)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutMode", castedNode.LayoutMode);
                castedNode.LayoutMode = n29;
            }

            if (AnchorsPreset is System.Int32 n30)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorsPreset", castedNode.AnchorsPreset);
                castedNode.AnchorsPreset = n30;
            }

            if (AnchorLeft is System.Single n31)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorLeft", castedNode.AnchorLeft);
                castedNode.AnchorLeft = n31;
            }

            if (AnchorTop is System.Single n32)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorTop", castedNode.AnchorTop);
                castedNode.AnchorTop = n32;
            }

            if (AnchorRight is System.Single n33)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorRight", castedNode.AnchorRight);
                castedNode.AnchorRight = n33;
            }

            if (AnchorBottom is System.Single n34)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorBottom", castedNode.AnchorBottom);
                castedNode.AnchorBottom = n34;
            }

            if (OffsetLeft is System.Single n35)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetLeft", castedNode.OffsetLeft);
                castedNode.OffsetLeft = n35;
            }

            if (OffsetTop is System.Single n36)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetTop", castedNode.OffsetTop);
                castedNode.OffsetTop = n36;
            }

            if (OffsetRight is System.Single n37)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetRight", castedNode.OffsetRight);
                castedNode.OffsetRight = n37;
            }

            if (OffsetBottom is System.Single n38)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetBottom", castedNode.OffsetBottom);
                castedNode.OffsetBottom = n38;
            }

            if (GrowHorizontal is Godot.Control.GrowDirection n39)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowHorizontal", castedNode.GrowHorizontal);
                castedNode.GrowHorizontal = n39;
            }

            if (GrowVertical is Godot.Control.GrowDirection n40)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowVertical", castedNode.GrowVertical);
                castedNode.GrowVertical = n40;
            }

            if (Size is Godot.Vector2 n41)
            {
                NodeStateManager.AddPropertyState(castedNode, "Size", castedNode.Size);
                castedNode.Size = n41;
            }

            if (Position is Godot.Vector2 n42)
            {
                NodeStateManager.AddPropertyState(castedNode, "Position", castedNode.Position);
                castedNode.Position = n42;
            }

            if (GlobalPosition is Godot.Vector2 n43)
            {
                NodeStateManager.AddPropertyState(castedNode, "GlobalPosition", castedNode.GlobalPosition);
                castedNode.GlobalPosition = n43;
            }

            if (Rotation is System.Single n44)
            {
                NodeStateManager.AddPropertyState(castedNode, "Rotation", castedNode.Rotation);
                castedNode.Rotation = n44;
            }

            if (RotationDegrees is System.Single n45)
            {
                NodeStateManager.AddPropertyState(castedNode, "RotationDegrees", castedNode.RotationDegrees);
                castedNode.RotationDegrees = n45;
            }

            if (Scale is Godot.Vector2 n46)
            {
                NodeStateManager.AddPropertyState(castedNode, "Scale", castedNode.Scale);
                castedNode.Scale = n46;
            }

            if (PivotOffset is Godot.Vector2 n47)
            {
                NodeStateManager.AddPropertyState(castedNode, "PivotOffset", castedNode.PivotOffset);
                castedNode.PivotOffset = n47;
            }

            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n48)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsHorizontal", castedNode.SizeFlagsHorizontal);
                castedNode.SizeFlagsHorizontal = n48;
            }

            if (SizeFlagsVertical is Godot.Control.SizeFlags n49)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsVertical", castedNode.SizeFlagsVertical);
                castedNode.SizeFlagsVertical = n49;
            }

            if (SizeFlagsStretchRatio is System.Single n50)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsStretchRatio", castedNode.SizeFlagsStretchRatio);
                castedNode.SizeFlagsStretchRatio = n50;
            }

            if (LocalizeNumeralSystem is System.Boolean n51)
            {
                NodeStateManager.AddPropertyState(castedNode, "LocalizeNumeralSystem", castedNode.LocalizeNumeralSystem);
                castedNode.LocalizeNumeralSystem = n51;
            }

            if (AutoTranslate is System.Boolean n52)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslate", castedNode.AutoTranslate);
                castedNode.AutoTranslate = n52;
            }

            if (TooltipText is System.String n53)
            {
                NodeStateManager.AddPropertyState(castedNode, "TooltipText", castedNode.TooltipText);
                castedNode.TooltipText = n53;
            }

            if (FocusNeighborLeft is Godot.NodePath n54)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborLeft", castedNode.FocusNeighborLeft);
                castedNode.FocusNeighborLeft = n54;
            }

            if (FocusNeighborTop is Godot.NodePath n55)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborTop", castedNode.FocusNeighborTop);
                castedNode.FocusNeighborTop = n55;
            }

            if (FocusNeighborRight is Godot.NodePath n56)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborRight", castedNode.FocusNeighborRight);
                castedNode.FocusNeighborRight = n56;
            }

            if (FocusNeighborBottom is Godot.NodePath n57)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborBottom", castedNode.FocusNeighborBottom);
                castedNode.FocusNeighborBottom = n57;
            }

            if (FocusNext is Godot.NodePath n58)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNext", castedNode.FocusNext);
                castedNode.FocusNext = n58;
            }

            if (FocusPrevious is Godot.NodePath n59)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusPrevious", castedNode.FocusPrevious);
                castedNode.FocusPrevious = n59;
            }

            if (FocusMode is Godot.Control.FocusModeEnum n60)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusMode", castedNode.FocusMode);
                castedNode.FocusMode = n60;
            }

            if (MouseFilter is Godot.Control.MouseFilterEnum n61)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseFilter", castedNode.MouseFilter);
                castedNode.MouseFilter = n61;
            }

            if (MouseForcePassScrollEvents is System.Boolean n62)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseForcePassScrollEvents", castedNode.MouseForcePassScrollEvents);
                castedNode.MouseForcePassScrollEvents = n62;
            }

            if (MouseDefaultCursorShape is Godot.Control.CursorShape n63)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseDefaultCursorShape", castedNode.MouseDefaultCursorShape);
                castedNode.MouseDefaultCursorShape = n63;
            }

            if (ShortcutContext is Godot.Node n64)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutContext", castedNode.ShortcutContext);
                castedNode.ShortcutContext = n64;
            }

            if (Theme is Godot.Theme n65)
            {
                NodeStateManager.AddPropertyState(castedNode, "Theme", castedNode.Theme);
                castedNode.Theme = n65;
            }

            if (ThemeTypeVariation is Godot.StringName n66)
            {
                NodeStateManager.AddPropertyState(castedNode, "ThemeTypeVariation", castedNode.ThemeTypeVariation);
                castedNode.ThemeTypeVariation = n66;
            }

            if (Visible is System.Boolean n67)
            {
                NodeStateManager.AddPropertyState(castedNode, "Visible", castedNode.Visible);
                castedNode.Visible = n67;
            }

            if (Modulate is Godot.Color n68)
            {
                NodeStateManager.AddPropertyState(castedNode, "Modulate", castedNode.Modulate);
                castedNode.Modulate = n68;
            }

            if (SelfModulate is Godot.Color n69)
            {
                NodeStateManager.AddPropertyState(castedNode, "SelfModulate", castedNode.SelfModulate);
                castedNode.SelfModulate = n69;
            }

            if (ShowBehindParent is System.Boolean n70)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowBehindParent", castedNode.ShowBehindParent);
                castedNode.ShowBehindParent = n70;
            }

            if (TopLevel is System.Boolean n71)
            {
                NodeStateManager.AddPropertyState(castedNode, "TopLevel", castedNode.TopLevel);
                castedNode.TopLevel = n71;
            }

            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n72)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipChildren", castedNode.ClipChildren);
                castedNode.ClipChildren = n72;
            }

            if (LightMask is System.Int32 n73)
            {
                NodeStateManager.AddPropertyState(castedNode, "LightMask", castedNode.LightMask);
                castedNode.LightMask = n73;
            }

            if (VisibilityLayer is System.UInt32 n74)
            {
                NodeStateManager.AddPropertyState(castedNode, "VisibilityLayer", castedNode.VisibilityLayer);
                castedNode.VisibilityLayer = n74;
            }

            if (ZIndex is System.Int32 n75)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZIndex", castedNode.ZIndex);
                castedNode.ZIndex = n75;
            }

            if (ZAsRelative is System.Boolean n76)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZAsRelative", castedNode.ZAsRelative);
                castedNode.ZAsRelative = n76;
            }

            if (YSortEnabled is System.Boolean n77)
            {
                NodeStateManager.AddPropertyState(castedNode, "YSortEnabled", castedNode.YSortEnabled);
                castedNode.YSortEnabled = n77;
            }

            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n78)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureFilter", castedNode.TextureFilter);
                castedNode.TextureFilter = n78;
            }

            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n79)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureRepeat", castedNode.TextureRepeat);
                castedNode.TextureRepeat = n79;
            }

            if (Material is Godot.Material n80)
            {
                NodeStateManager.AddPropertyState(castedNode, "Material", castedNode.Material);
                castedNode.Material = n80;
            }

            if (UseParentMaterial is System.Boolean n81)
            {
                NodeStateManager.AddPropertyState(castedNode, "UseParentMaterial", castedNode.UseParentMaterial);
                castedNode.UseParentMaterial = n81;
            }

            if (Name is Godot.StringName n82)
            {
                NodeStateManager.AddPropertyState(castedNode, "Name", castedNode.Name);
                castedNode.Name = n82;
            }

            if (UniqueNameInOwner is System.Boolean n83)
            {
                NodeStateManager.AddPropertyState(castedNode, "UniqueNameInOwner", castedNode.UniqueNameInOwner);
                castedNode.UniqueNameInOwner = n83;
            }

            if (SceneFilePath is System.String n84)
            {
                NodeStateManager.AddPropertyState(castedNode, "SceneFilePath", castedNode.SceneFilePath);
                castedNode.SceneFilePath = n84;
            }

            if (Owner is Godot.Node n85)
            {
                NodeStateManager.AddPropertyState(castedNode, "Owner", castedNode.Owner);
                castedNode.Owner = n85;
            }

            if (ProcessMode is Godot.Node.ProcessModeEnum n86)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessMode", castedNode.ProcessMode);
                castedNode.ProcessMode = n86;
            }

            if (ProcessPriority is System.Int32 n87)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPriority", castedNode.ProcessPriority);
                castedNode.ProcessPriority = n87;
            }

            if (ProcessPhysicsPriority is System.Int32 n88)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPhysicsPriority", castedNode.ProcessPhysicsPriority);
                castedNode.ProcessPhysicsPriority = n88;
            }

            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n89)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroup", castedNode.ProcessThreadGroup);
                castedNode.ProcessThreadGroup = n89;
            }

            if (ProcessThreadGroupOrder is System.Int32 n90)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroupOrder", castedNode.ProcessThreadGroupOrder);
                castedNode.ProcessThreadGroupOrder = n90;
            }

            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n91)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadMessages", castedNode.ProcessThreadMessages);
                castedNode.ProcessThreadMessages = n91;
            }

            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n92)
            {
                NodeStateManager.AddPropertyState(castedNode, "PhysicsInterpolationMode", castedNode.PhysicsInterpolationMode);
                castedNode.PhysicsInterpolationMode = n92;
            }

            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n93)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslateMode", castedNode.AutoTranslateMode);
                castedNode.AutoTranslateMode = n93;
            }

            if (EditorDescription is System.String n94)
            {
                NodeStateManager.AddPropertyState(castedNode, "EditorDescription", castedNode.EditorDescription);
                castedNode.EditorDescription = n94;
            }

            if (ItemSelected is Godot.OptionButton.ItemSelectedEventHandler e0)
            {
                NodeStateManager.AddEventHandler(castedNode, "ItemSelected", e0);
                castedNode.ItemSelected += e0;
            }

            if (ItemFocused is Godot.OptionButton.ItemFocusedEventHandler e1)
            {
                NodeStateManager.AddEventHandler(castedNode, "ItemFocused", e1);
                castedNode.ItemFocused += e1;
            }

            if (Pressed is System.Action e2)
            {
                NodeStateManager.AddEventHandler(castedNode, "Pressed", e2);
                castedNode.Pressed += e2;
            }

            if (ButtonUp is System.Action e3)
            {
                NodeStateManager.AddEventHandler(castedNode, "ButtonUp", e3);
                castedNode.ButtonUp += e3;
            }

            if (ButtonDown is System.Action e4)
            {
                NodeStateManager.AddEventHandler(castedNode, "ButtonDown", e4);
                castedNode.ButtonDown += e4;
            }

            if (Toggled is Godot.BaseButton.ToggledEventHandler e5)
            {
                NodeStateManager.AddEventHandler(castedNode, "Toggled", e5);
                castedNode.Toggled += e5;
            }

            if (Resized is System.Action e6)
            {
                NodeStateManager.AddEventHandler(castedNode, "Resized", e6);
                castedNode.Resized += e6;
            }

            if (GuiInput is Godot.Control.GuiInputEventHandler e7)
            {
                NodeStateManager.AddEventHandler(castedNode, "GuiInput", e7);
                castedNode.GuiInput += e7;
            }

            if (MouseEntered is System.Action e8)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseEntered", e8);
                castedNode.MouseEntered += e8;
            }

            if (MouseExited is System.Action e9)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseExited", e9);
                castedNode.MouseExited += e9;
            }

            if (FocusEntered is System.Action e10)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusEntered", e10);
                castedNode.FocusEntered += e10;
            }

            if (FocusExited is System.Action e11)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusExited", e11);
                castedNode.FocusExited += e11;
            }

            if (SizeFlagsChanged is System.Action e12)
            {
                NodeStateManager.AddEventHandler(castedNode, "SizeFlagsChanged", e12);
                castedNode.SizeFlagsChanged += e12;
            }

            if (MinimumSizeChanged is System.Action e13)
            {
                NodeStateManager.AddEventHandler(castedNode, "MinimumSizeChanged", e13);
                castedNode.MinimumSizeChanged += e13;
            }

            if (ThemeChanged is System.Action e14)
            {
                NodeStateManager.AddEventHandler(castedNode, "ThemeChanged", e14);
                castedNode.ThemeChanged += e14;
            }

            if (Draw is System.Action e15)
            {
                NodeStateManager.AddEventHandler(castedNode, "Draw", e15);
                castedNode.Draw += e15;
            }

            if (VisibilityChanged is System.Action e16)
            {
                NodeStateManager.AddEventHandler(castedNode, "VisibilityChanged", e16);
                castedNode.VisibilityChanged += e16;
            }

            if (Hidden is System.Action e17)
            {
                NodeStateManager.AddEventHandler(castedNode, "Hidden", e17);
                castedNode.Hidden += e17;
            }

            if (ItemRectChanged is System.Action e18)
            {
                NodeStateManager.AddEventHandler(castedNode, "ItemRectChanged", e18);
                castedNode.ItemRectChanged += e18;
            }

            if (Ready is System.Action e19)
            {
                NodeStateManager.AddEventHandler(castedNode, "Ready", e19);
                castedNode.Ready += e19;
            }

            if (Renamed is System.Action e20)
            {
                NodeStateManager.AddEventHandler(castedNode, "Renamed", e20);
                castedNode.Renamed += e20;
            }

            if (TreeEntered is System.Action e21)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeEntered", e21);
                castedNode.TreeEntered += e21;
            }

            if (TreeExiting is System.Action e22)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExiting", e22);
                castedNode.TreeExiting += e22;
            }

            if (TreeExited is System.Action e23)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExited", e23);
                castedNode.TreeExited += e23;
            }

            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e24)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildEnteredTree", e24);
                castedNode.ChildEnteredTree += e24;
            }

            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e25)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildExitingTree", e25);
                castedNode.ChildExitingTree += e25;
            }

            if (ChildOrderChanged is System.Action e26)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildOrderChanged", e26);
                castedNode.ChildOrderChanged += e26;
            }

            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e27)
            {
                NodeStateManager.AddEventHandler(castedNode, "ReplacingBy", e27);
                castedNode.ReplacingBy += e27;
            }

            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e28)
            {
                NodeStateManager.AddEventHandler(castedNode, "EditorDescriptionChanged", e28);
                castedNode.EditorDescriptionChanged += e28;
            }

            if (ScriptChanged is System.Action e29)
            {
                NodeStateManager.AddEventHandler(castedNode, "ScriptChanged", e29);
                castedNode.ScriptChanged += e29;
            }

            if (PropertyListChanged is System.Action e30)
            {
                NodeStateManager.AddEventHandler(castedNode, "PropertyListChanged", e30);
                castedNode.PropertyListChanged += e30;
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