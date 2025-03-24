namespace ReactiveSharpGodot.Components
{
    public class TextureProgressBar : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GTextureProgressBar>
    {
        public System.Int32? FillMode { protected get; init; }
        public System.Single? RadialInitialAngle { protected get; init; }
        public System.Single? RadialFillDegrees { protected get; init; }
        public Godot.Vector2? RadialCenterOffset { protected get; init; }
        public System.Boolean? NinePatchStretch { protected get; init; }
        public System.Int32? StretchMarginLeft { protected get; init; }
        public System.Int32? StretchMarginTop { protected get; init; }
        public System.Int32? StretchMarginRight { protected get; init; }
        public System.Int32? StretchMarginBottom { protected get; init; }
        public Godot.Texture2D? TextureUnder { protected get; init; }
        public Godot.Texture2D? TextureOver { protected get; init; }
        public Godot.Texture2D? TextureProgress { protected get; init; }
        public Godot.Vector2? TextureProgressOffset { protected get; init; }
        public Godot.Color? TintUnder { protected get; init; }
        public Godot.Color? TintOver { protected get; init; }
        public Godot.Color? TintProgress { protected get; init; }
        public System.Double? MinValue { protected get; init; }
        public System.Double? MaxValue { protected get; init; }
        public System.Double? Step { protected get; init; }
        public System.Double? Page { protected get; init; }
        public System.Double? Value { protected get; init; }
        public System.Double? Ratio { protected get; init; }
        public System.Boolean? ExpEdit { protected get; init; }
        public System.Boolean? Rounded { protected get; init; }
        public System.Boolean? AllowGreater { protected get; init; }
        public System.Boolean? AllowLesser { protected get; init; }
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
        public Godot.Range.ValueChangedEventHandler? ValueChanged { protected get; init; }
        public System.Action? Changed { protected get; init; }
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
        public Action<ReactiveSharpGodot.Nodes.GTextureProgressBar>? CustomNodeHandling { protected get; init; }

        public override ReactiveSharpGodot.Nodes.GTextureProgressBar Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GTextureProgressBar();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GTextureProgressBar node)
        {
            var castedNode = (Godot.TextureProgressBar)node.Node;
            if (FillMode is System.Int32 n0)
            {
                NodeStateManager.AddPropertyState(castedNode, "FillMode", castedNode.FillMode);
                castedNode.FillMode = n0;
            }

            if (RadialInitialAngle is System.Single n1)
            {
                NodeStateManager.AddPropertyState(castedNode, "RadialInitialAngle", castedNode.RadialInitialAngle);
                castedNode.RadialInitialAngle = n1;
            }

            if (RadialFillDegrees is System.Single n2)
            {
                NodeStateManager.AddPropertyState(castedNode, "RadialFillDegrees", castedNode.RadialFillDegrees);
                castedNode.RadialFillDegrees = n2;
            }

            if (RadialCenterOffset is Godot.Vector2 n3)
            {
                NodeStateManager.AddPropertyState(castedNode, "RadialCenterOffset", castedNode.RadialCenterOffset);
                castedNode.RadialCenterOffset = n3;
            }

            if (NinePatchStretch is System.Boolean n4)
            {
                NodeStateManager.AddPropertyState(castedNode, "NinePatchStretch", castedNode.NinePatchStretch);
                castedNode.NinePatchStretch = n4;
            }

            if (StretchMarginLeft is System.Int32 n5)
            {
                NodeStateManager.AddPropertyState(castedNode, "StretchMarginLeft", castedNode.StretchMarginLeft);
                castedNode.StretchMarginLeft = n5;
            }

            if (StretchMarginTop is System.Int32 n6)
            {
                NodeStateManager.AddPropertyState(castedNode, "StretchMarginTop", castedNode.StretchMarginTop);
                castedNode.StretchMarginTop = n6;
            }

            if (StretchMarginRight is System.Int32 n7)
            {
                NodeStateManager.AddPropertyState(castedNode, "StretchMarginRight", castedNode.StretchMarginRight);
                castedNode.StretchMarginRight = n7;
            }

            if (StretchMarginBottom is System.Int32 n8)
            {
                NodeStateManager.AddPropertyState(castedNode, "StretchMarginBottom", castedNode.StretchMarginBottom);
                castedNode.StretchMarginBottom = n8;
            }

            if (TextureUnder is Godot.Texture2D n9)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureUnder", castedNode.TextureUnder);
                castedNode.TextureUnder = n9;
            }

            if (TextureOver is Godot.Texture2D n10)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureOver", castedNode.TextureOver);
                castedNode.TextureOver = n10;
            }

            if (TextureProgress is Godot.Texture2D n11)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureProgress", castedNode.TextureProgress);
                castedNode.TextureProgress = n11;
            }

            if (TextureProgressOffset is Godot.Vector2 n12)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureProgressOffset", castedNode.TextureProgressOffset);
                castedNode.TextureProgressOffset = n12;
            }

            if (TintUnder is Godot.Color n13)
            {
                NodeStateManager.AddPropertyState(castedNode, "TintUnder", castedNode.TintUnder);
                castedNode.TintUnder = n13;
            }

            if (TintOver is Godot.Color n14)
            {
                NodeStateManager.AddPropertyState(castedNode, "TintOver", castedNode.TintOver);
                castedNode.TintOver = n14;
            }

            if (TintProgress is Godot.Color n15)
            {
                NodeStateManager.AddPropertyState(castedNode, "TintProgress", castedNode.TintProgress);
                castedNode.TintProgress = n15;
            }

            if (MinValue is System.Double n16)
            {
                NodeStateManager.AddPropertyState(castedNode, "MinValue", castedNode.MinValue);
                castedNode.MinValue = n16;
            }

            if (MaxValue is System.Double n17)
            {
                NodeStateManager.AddPropertyState(castedNode, "MaxValue", castedNode.MaxValue);
                castedNode.MaxValue = n17;
            }

            if (Step is System.Double n18)
            {
                NodeStateManager.AddPropertyState(castedNode, "Step", castedNode.Step);
                castedNode.Step = n18;
            }

            if (Page is System.Double n19)
            {
                NodeStateManager.AddPropertyState(castedNode, "Page", castedNode.Page);
                castedNode.Page = n19;
            }

            if (Value is System.Double n20)
            {
                NodeStateManager.AddPropertyState(castedNode, "Value", castedNode.Value);
                castedNode.Value = n20;
            }

            if (Ratio is System.Double n21)
            {
                NodeStateManager.AddPropertyState(castedNode, "Ratio", castedNode.Ratio);
                castedNode.Ratio = n21;
            }

            if (ExpEdit is System.Boolean n22)
            {
                NodeStateManager.AddPropertyState(castedNode, "ExpEdit", castedNode.ExpEdit);
                castedNode.ExpEdit = n22;
            }

            if (Rounded is System.Boolean n23)
            {
                NodeStateManager.AddPropertyState(castedNode, "Rounded", castedNode.Rounded);
                castedNode.Rounded = n23;
            }

            if (AllowGreater is System.Boolean n24)
            {
                NodeStateManager.AddPropertyState(castedNode, "AllowGreater", castedNode.AllowGreater);
                castedNode.AllowGreater = n24;
            }

            if (AllowLesser is System.Boolean n25)
            {
                NodeStateManager.AddPropertyState(castedNode, "AllowLesser", castedNode.AllowLesser);
                castedNode.AllowLesser = n25;
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

            if (ValueChanged is Godot.Range.ValueChangedEventHandler e0)
            {
                NodeStateManager.AddEventHandler(castedNode, "ValueChanged", e0);
                castedNode.ValueChanged += e0;
            }

            if (Changed is System.Action e1)
            {
                NodeStateManager.AddEventHandler(castedNode, "Changed", e1);
                castedNode.Changed += e1;
            }

            if (Resized is System.Action e2)
            {
                NodeStateManager.AddEventHandler(castedNode, "Resized", e2);
                castedNode.Resized += e2;
            }

            if (GuiInput is Godot.Control.GuiInputEventHandler e3)
            {
                NodeStateManager.AddEventHandler(castedNode, "GuiInput", e3);
                castedNode.GuiInput += e3;
            }

            if (MouseEntered is System.Action e4)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseEntered", e4);
                castedNode.MouseEntered += e4;
            }

            if (MouseExited is System.Action e5)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseExited", e5);
                castedNode.MouseExited += e5;
            }

            if (FocusEntered is System.Action e6)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusEntered", e6);
                castedNode.FocusEntered += e6;
            }

            if (FocusExited is System.Action e7)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusExited", e7);
                castedNode.FocusExited += e7;
            }

            if (SizeFlagsChanged is System.Action e8)
            {
                NodeStateManager.AddEventHandler(castedNode, "SizeFlagsChanged", e8);
                castedNode.SizeFlagsChanged += e8;
            }

            if (MinimumSizeChanged is System.Action e9)
            {
                NodeStateManager.AddEventHandler(castedNode, "MinimumSizeChanged", e9);
                castedNode.MinimumSizeChanged += e9;
            }

            if (ThemeChanged is System.Action e10)
            {
                NodeStateManager.AddEventHandler(castedNode, "ThemeChanged", e10);
                castedNode.ThemeChanged += e10;
            }

            if (Draw is System.Action e11)
            {
                NodeStateManager.AddEventHandler(castedNode, "Draw", e11);
                castedNode.Draw += e11;
            }

            if (VisibilityChanged is System.Action e12)
            {
                NodeStateManager.AddEventHandler(castedNode, "VisibilityChanged", e12);
                castedNode.VisibilityChanged += e12;
            }

            if (Hidden is System.Action e13)
            {
                NodeStateManager.AddEventHandler(castedNode, "Hidden", e13);
                castedNode.Hidden += e13;
            }

            if (ItemRectChanged is System.Action e14)
            {
                NodeStateManager.AddEventHandler(castedNode, "ItemRectChanged", e14);
                castedNode.ItemRectChanged += e14;
            }

            if (Ready is System.Action e15)
            {
                NodeStateManager.AddEventHandler(castedNode, "Ready", e15);
                castedNode.Ready += e15;
            }

            if (Renamed is System.Action e16)
            {
                NodeStateManager.AddEventHandler(castedNode, "Renamed", e16);
                castedNode.Renamed += e16;
            }

            if (TreeEntered is System.Action e17)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeEntered", e17);
                castedNode.TreeEntered += e17;
            }

            if (TreeExiting is System.Action e18)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExiting", e18);
                castedNode.TreeExiting += e18;
            }

            if (TreeExited is System.Action e19)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExited", e19);
                castedNode.TreeExited += e19;
            }

            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e20)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildEnteredTree", e20);
                castedNode.ChildEnteredTree += e20;
            }

            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e21)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildExitingTree", e21);
                castedNode.ChildExitingTree += e21;
            }

            if (ChildOrderChanged is System.Action e22)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildOrderChanged", e22);
                castedNode.ChildOrderChanged += e22;
            }

            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e23)
            {
                NodeStateManager.AddEventHandler(castedNode, "ReplacingBy", e23);
                castedNode.ReplacingBy += e23;
            }

            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e24)
            {
                NodeStateManager.AddEventHandler(castedNode, "EditorDescriptionChanged", e24);
                castedNode.EditorDescriptionChanged += e24;
            }

            if (ScriptChanged is System.Action e25)
            {
                NodeStateManager.AddEventHandler(castedNode, "ScriptChanged", e25);
                castedNode.ScriptChanged += e25;
            }

            if (PropertyListChanged is System.Action e26)
            {
                NodeStateManager.AddEventHandler(castedNode, "PropertyListChanged", e26);
                castedNode.PropertyListChanged += e26;
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