namespace ReactiveSharpGodot.Components
{
    public class Label : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GLabel>
    {
        public System.String? Text { protected get; init; }
        public Godot.LabelSettings? LabelSettings { protected get; init; }
        public Godot.HorizontalAlignment? HorizontalAlignment { protected get; init; }
        public Godot.VerticalAlignment? VerticalAlignment { protected get; init; }
        public Godot.TextServer.AutowrapMode? AutowrapMode { protected get; init; }
        public Godot.TextServer.JustificationFlag? JustificationFlags { protected get; init; }
        public System.Boolean? ClipText { protected get; init; }
        public Godot.TextServer.OverrunBehavior? TextOverrunBehavior { protected get; init; }
        public System.String? EllipsisChar { protected get; init; }
        public System.Boolean? Uppercase { protected get; init; }
        public System.Single[]? TabStops { protected get; init; }
        public System.Int32? LinesSkipped { protected get; init; }
        public System.Int32? MaxLinesVisible { protected get; init; }
        public System.Int32? VisibleCharacters { protected get; init; }
        public Godot.TextServer.VisibleCharactersBehavior? VisibleCharactersBehavior { protected get; init; }
        public System.Single? VisibleRatio { protected get; init; }
        public Godot.Control.TextDirection? TextDirection { protected get; init; }
        public System.String? Language { protected get; init; }
        public Godot.TextServer.StructuredTextParser? StructuredTextBidiOverride { protected get; init; }
        public Godot.Collections.Array? StructuredTextBidiOverrideOptions { protected get; init; }
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
        public Action<ReactiveSharpGodot.Nodes.GLabel>? CustomNodeHandling { protected get; init; }

        public override ReactiveSharpGodot.Nodes.GLabel Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GLabel();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GLabel node)
        {
            var castedNode = (Godot.Label)node.Node;
            if (Text is System.String n0)
            {
                NodeStateManager.AddPropertyState(castedNode, "Text", castedNode.Text);
                castedNode.Text = n0;
            }

            if (LabelSettings is Godot.LabelSettings n1)
            {
                NodeStateManager.AddPropertyState(castedNode, "LabelSettings", castedNode.LabelSettings);
                castedNode.LabelSettings = n1;
            }

            if (HorizontalAlignment is Godot.HorizontalAlignment n2)
            {
                NodeStateManager.AddPropertyState(castedNode, "HorizontalAlignment", castedNode.HorizontalAlignment);
                castedNode.HorizontalAlignment = n2;
            }

            if (VerticalAlignment is Godot.VerticalAlignment n3)
            {
                NodeStateManager.AddPropertyState(castedNode, "VerticalAlignment", castedNode.VerticalAlignment);
                castedNode.VerticalAlignment = n3;
            }

            if (AutowrapMode is Godot.TextServer.AutowrapMode n4)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutowrapMode", castedNode.AutowrapMode);
                castedNode.AutowrapMode = n4;
            }

            if (JustificationFlags is Godot.TextServer.JustificationFlag n5)
            {
                NodeStateManager.AddPropertyState(castedNode, "JustificationFlags", castedNode.JustificationFlags);
                castedNode.JustificationFlags = n5;
            }

            if (ClipText is System.Boolean n6)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipText", castedNode.ClipText);
                castedNode.ClipText = n6;
            }

            if (TextOverrunBehavior is Godot.TextServer.OverrunBehavior n7)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextOverrunBehavior", castedNode.TextOverrunBehavior);
                castedNode.TextOverrunBehavior = n7;
            }

            if (EllipsisChar is System.String n8)
            {
                NodeStateManager.AddPropertyState(castedNode, "EllipsisChar", castedNode.EllipsisChar);
                castedNode.EllipsisChar = n8;
            }

            if (Uppercase is System.Boolean n9)
            {
                NodeStateManager.AddPropertyState(castedNode, "Uppercase", castedNode.Uppercase);
                castedNode.Uppercase = n9;
            }

            if (TabStops is System.Single[] n10)
            {
                NodeStateManager.AddPropertyState(castedNode, "TabStops", castedNode.TabStops);
                castedNode.TabStops = n10;
            }

            if (LinesSkipped is System.Int32 n11)
            {
                NodeStateManager.AddPropertyState(castedNode, "LinesSkipped", castedNode.LinesSkipped);
                castedNode.LinesSkipped = n11;
            }

            if (MaxLinesVisible is System.Int32 n12)
            {
                NodeStateManager.AddPropertyState(castedNode, "MaxLinesVisible", castedNode.MaxLinesVisible);
                castedNode.MaxLinesVisible = n12;
            }

            if (VisibleCharacters is System.Int32 n13)
            {
                NodeStateManager.AddPropertyState(castedNode, "VisibleCharacters", castedNode.VisibleCharacters);
                castedNode.VisibleCharacters = n13;
            }

            if (VisibleCharactersBehavior is Godot.TextServer.VisibleCharactersBehavior n14)
            {
                NodeStateManager.AddPropertyState(castedNode, "VisibleCharactersBehavior", castedNode.VisibleCharactersBehavior);
                castedNode.VisibleCharactersBehavior = n14;
            }

            if (VisibleRatio is System.Single n15)
            {
                NodeStateManager.AddPropertyState(castedNode, "VisibleRatio", castedNode.VisibleRatio);
                castedNode.VisibleRatio = n15;
            }

            if (TextDirection is Godot.Control.TextDirection n16)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextDirection", castedNode.TextDirection);
                castedNode.TextDirection = n16;
            }

            if (Language is System.String n17)
            {
                NodeStateManager.AddPropertyState(castedNode, "Language", castedNode.Language);
                castedNode.Language = n17;
            }

            if (StructuredTextBidiOverride is Godot.TextServer.StructuredTextParser n18)
            {
                NodeStateManager.AddPropertyState(castedNode, "StructuredTextBidiOverride", castedNode.StructuredTextBidiOverride);
                castedNode.StructuredTextBidiOverride = n18;
            }

            if (StructuredTextBidiOverrideOptions is Godot.Collections.Array n19)
            {
                NodeStateManager.AddPropertyState(castedNode, "StructuredTextBidiOverrideOptions", castedNode.StructuredTextBidiOverrideOptions);
                castedNode.StructuredTextBidiOverrideOptions = n19;
            }

            if (ClipContents is System.Boolean n20)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipContents", castedNode.ClipContents);
                castedNode.ClipContents = n20;
            }

            if (CustomMinimumSize is Godot.Vector2 n21)
            {
                NodeStateManager.AddPropertyState(castedNode, "CustomMinimumSize", castedNode.CustomMinimumSize);
                castedNode.CustomMinimumSize = n21;
            }

            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n22)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutDirection", castedNode.LayoutDirection);
                castedNode.LayoutDirection = n22;
            }

            if (LayoutMode is System.Int32 n23)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutMode", castedNode.LayoutMode);
                castedNode.LayoutMode = n23;
            }

            if (AnchorsPreset is System.Int32 n24)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorsPreset", castedNode.AnchorsPreset);
                castedNode.AnchorsPreset = n24;
            }

            if (AnchorLeft is System.Single n25)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorLeft", castedNode.AnchorLeft);
                castedNode.AnchorLeft = n25;
            }

            if (AnchorTop is System.Single n26)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorTop", castedNode.AnchorTop);
                castedNode.AnchorTop = n26;
            }

            if (AnchorRight is System.Single n27)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorRight", castedNode.AnchorRight);
                castedNode.AnchorRight = n27;
            }

            if (AnchorBottom is System.Single n28)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorBottom", castedNode.AnchorBottom);
                castedNode.AnchorBottom = n28;
            }

            if (OffsetLeft is System.Single n29)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetLeft", castedNode.OffsetLeft);
                castedNode.OffsetLeft = n29;
            }

            if (OffsetTop is System.Single n30)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetTop", castedNode.OffsetTop);
                castedNode.OffsetTop = n30;
            }

            if (OffsetRight is System.Single n31)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetRight", castedNode.OffsetRight);
                castedNode.OffsetRight = n31;
            }

            if (OffsetBottom is System.Single n32)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetBottom", castedNode.OffsetBottom);
                castedNode.OffsetBottom = n32;
            }

            if (GrowHorizontal is Godot.Control.GrowDirection n33)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowHorizontal", castedNode.GrowHorizontal);
                castedNode.GrowHorizontal = n33;
            }

            if (GrowVertical is Godot.Control.GrowDirection n34)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowVertical", castedNode.GrowVertical);
                castedNode.GrowVertical = n34;
            }

            if (Size is Godot.Vector2 n35)
            {
                NodeStateManager.AddPropertyState(castedNode, "Size", castedNode.Size);
                castedNode.Size = n35;
            }

            if (Position is Godot.Vector2 n36)
            {
                NodeStateManager.AddPropertyState(castedNode, "Position", castedNode.Position);
                castedNode.Position = n36;
            }

            if (GlobalPosition is Godot.Vector2 n37)
            {
                NodeStateManager.AddPropertyState(castedNode, "GlobalPosition", castedNode.GlobalPosition);
                castedNode.GlobalPosition = n37;
            }

            if (Rotation is System.Single n38)
            {
                NodeStateManager.AddPropertyState(castedNode, "Rotation", castedNode.Rotation);
                castedNode.Rotation = n38;
            }

            if (RotationDegrees is System.Single n39)
            {
                NodeStateManager.AddPropertyState(castedNode, "RotationDegrees", castedNode.RotationDegrees);
                castedNode.RotationDegrees = n39;
            }

            if (Scale is Godot.Vector2 n40)
            {
                NodeStateManager.AddPropertyState(castedNode, "Scale", castedNode.Scale);
                castedNode.Scale = n40;
            }

            if (PivotOffset is Godot.Vector2 n41)
            {
                NodeStateManager.AddPropertyState(castedNode, "PivotOffset", castedNode.PivotOffset);
                castedNode.PivotOffset = n41;
            }

            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n42)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsHorizontal", castedNode.SizeFlagsHorizontal);
                castedNode.SizeFlagsHorizontal = n42;
            }

            if (SizeFlagsVertical is Godot.Control.SizeFlags n43)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsVertical", castedNode.SizeFlagsVertical);
                castedNode.SizeFlagsVertical = n43;
            }

            if (SizeFlagsStretchRatio is System.Single n44)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsStretchRatio", castedNode.SizeFlagsStretchRatio);
                castedNode.SizeFlagsStretchRatio = n44;
            }

            if (LocalizeNumeralSystem is System.Boolean n45)
            {
                NodeStateManager.AddPropertyState(castedNode, "LocalizeNumeralSystem", castedNode.LocalizeNumeralSystem);
                castedNode.LocalizeNumeralSystem = n45;
            }

            if (AutoTranslate is System.Boolean n46)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslate", castedNode.AutoTranslate);
                castedNode.AutoTranslate = n46;
            }

            if (TooltipText is System.String n47)
            {
                NodeStateManager.AddPropertyState(castedNode, "TooltipText", castedNode.TooltipText);
                castedNode.TooltipText = n47;
            }

            if (FocusNeighborLeft is Godot.NodePath n48)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborLeft", castedNode.FocusNeighborLeft);
                castedNode.FocusNeighborLeft = n48;
            }

            if (FocusNeighborTop is Godot.NodePath n49)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborTop", castedNode.FocusNeighborTop);
                castedNode.FocusNeighborTop = n49;
            }

            if (FocusNeighborRight is Godot.NodePath n50)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborRight", castedNode.FocusNeighborRight);
                castedNode.FocusNeighborRight = n50;
            }

            if (FocusNeighborBottom is Godot.NodePath n51)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborBottom", castedNode.FocusNeighborBottom);
                castedNode.FocusNeighborBottom = n51;
            }

            if (FocusNext is Godot.NodePath n52)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNext", castedNode.FocusNext);
                castedNode.FocusNext = n52;
            }

            if (FocusPrevious is Godot.NodePath n53)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusPrevious", castedNode.FocusPrevious);
                castedNode.FocusPrevious = n53;
            }

            if (FocusMode is Godot.Control.FocusModeEnum n54)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusMode", castedNode.FocusMode);
                castedNode.FocusMode = n54;
            }

            if (MouseFilter is Godot.Control.MouseFilterEnum n55)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseFilter", castedNode.MouseFilter);
                castedNode.MouseFilter = n55;
            }

            if (MouseForcePassScrollEvents is System.Boolean n56)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseForcePassScrollEvents", castedNode.MouseForcePassScrollEvents);
                castedNode.MouseForcePassScrollEvents = n56;
            }

            if (MouseDefaultCursorShape is Godot.Control.CursorShape n57)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseDefaultCursorShape", castedNode.MouseDefaultCursorShape);
                castedNode.MouseDefaultCursorShape = n57;
            }

            if (ShortcutContext is Godot.Node n58)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutContext", castedNode.ShortcutContext);
                castedNode.ShortcutContext = n58;
            }

            if (Theme is Godot.Theme n59)
            {
                NodeStateManager.AddPropertyState(castedNode, "Theme", castedNode.Theme);
                castedNode.Theme = n59;
            }

            if (ThemeTypeVariation is Godot.StringName n60)
            {
                NodeStateManager.AddPropertyState(castedNode, "ThemeTypeVariation", castedNode.ThemeTypeVariation);
                castedNode.ThemeTypeVariation = n60;
            }

            if (Visible is System.Boolean n61)
            {
                NodeStateManager.AddPropertyState(castedNode, "Visible", castedNode.Visible);
                castedNode.Visible = n61;
            }

            if (Modulate is Godot.Color n62)
            {
                NodeStateManager.AddPropertyState(castedNode, "Modulate", castedNode.Modulate);
                castedNode.Modulate = n62;
            }

            if (SelfModulate is Godot.Color n63)
            {
                NodeStateManager.AddPropertyState(castedNode, "SelfModulate", castedNode.SelfModulate);
                castedNode.SelfModulate = n63;
            }

            if (ShowBehindParent is System.Boolean n64)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowBehindParent", castedNode.ShowBehindParent);
                castedNode.ShowBehindParent = n64;
            }

            if (TopLevel is System.Boolean n65)
            {
                NodeStateManager.AddPropertyState(castedNode, "TopLevel", castedNode.TopLevel);
                castedNode.TopLevel = n65;
            }

            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n66)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipChildren", castedNode.ClipChildren);
                castedNode.ClipChildren = n66;
            }

            if (LightMask is System.Int32 n67)
            {
                NodeStateManager.AddPropertyState(castedNode, "LightMask", castedNode.LightMask);
                castedNode.LightMask = n67;
            }

            if (VisibilityLayer is System.UInt32 n68)
            {
                NodeStateManager.AddPropertyState(castedNode, "VisibilityLayer", castedNode.VisibilityLayer);
                castedNode.VisibilityLayer = n68;
            }

            if (ZIndex is System.Int32 n69)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZIndex", castedNode.ZIndex);
                castedNode.ZIndex = n69;
            }

            if (ZAsRelative is System.Boolean n70)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZAsRelative", castedNode.ZAsRelative);
                castedNode.ZAsRelative = n70;
            }

            if (YSortEnabled is System.Boolean n71)
            {
                NodeStateManager.AddPropertyState(castedNode, "YSortEnabled", castedNode.YSortEnabled);
                castedNode.YSortEnabled = n71;
            }

            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n72)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureFilter", castedNode.TextureFilter);
                castedNode.TextureFilter = n72;
            }

            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n73)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureRepeat", castedNode.TextureRepeat);
                castedNode.TextureRepeat = n73;
            }

            if (Material is Godot.Material n74)
            {
                NodeStateManager.AddPropertyState(castedNode, "Material", castedNode.Material);
                castedNode.Material = n74;
            }

            if (UseParentMaterial is System.Boolean n75)
            {
                NodeStateManager.AddPropertyState(castedNode, "UseParentMaterial", castedNode.UseParentMaterial);
                castedNode.UseParentMaterial = n75;
            }

            if (Name is Godot.StringName n76)
            {
                NodeStateManager.AddPropertyState(castedNode, "Name", castedNode.Name);
                castedNode.Name = n76;
            }

            if (UniqueNameInOwner is System.Boolean n77)
            {
                NodeStateManager.AddPropertyState(castedNode, "UniqueNameInOwner", castedNode.UniqueNameInOwner);
                castedNode.UniqueNameInOwner = n77;
            }

            if (SceneFilePath is System.String n78)
            {
                NodeStateManager.AddPropertyState(castedNode, "SceneFilePath", castedNode.SceneFilePath);
                castedNode.SceneFilePath = n78;
            }

            if (Owner is Godot.Node n79)
            {
                NodeStateManager.AddPropertyState(castedNode, "Owner", castedNode.Owner);
                castedNode.Owner = n79;
            }

            if (ProcessMode is Godot.Node.ProcessModeEnum n80)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessMode", castedNode.ProcessMode);
                castedNode.ProcessMode = n80;
            }

            if (ProcessPriority is System.Int32 n81)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPriority", castedNode.ProcessPriority);
                castedNode.ProcessPriority = n81;
            }

            if (ProcessPhysicsPriority is System.Int32 n82)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPhysicsPriority", castedNode.ProcessPhysicsPriority);
                castedNode.ProcessPhysicsPriority = n82;
            }

            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n83)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroup", castedNode.ProcessThreadGroup);
                castedNode.ProcessThreadGroup = n83;
            }

            if (ProcessThreadGroupOrder is System.Int32 n84)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroupOrder", castedNode.ProcessThreadGroupOrder);
                castedNode.ProcessThreadGroupOrder = n84;
            }

            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n85)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadMessages", castedNode.ProcessThreadMessages);
                castedNode.ProcessThreadMessages = n85;
            }

            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n86)
            {
                NodeStateManager.AddPropertyState(castedNode, "PhysicsInterpolationMode", castedNode.PhysicsInterpolationMode);
                castedNode.PhysicsInterpolationMode = n86;
            }

            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n87)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslateMode", castedNode.AutoTranslateMode);
                castedNode.AutoTranslateMode = n87;
            }

            if (EditorDescription is System.String n88)
            {
                NodeStateManager.AddPropertyState(castedNode, "EditorDescription", castedNode.EditorDescription);
                castedNode.EditorDescription = n88;
            }

            if (Resized is System.Action e0)
            {
                NodeStateManager.AddEventHandler(castedNode, "Resized", e0);
                castedNode.Resized += e0;
            }

            if (GuiInput is Godot.Control.GuiInputEventHandler e1)
            {
                NodeStateManager.AddEventHandler(castedNode, "GuiInput", e1);
                castedNode.GuiInput += e1;
            }

            if (MouseEntered is System.Action e2)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseEntered", e2);
                castedNode.MouseEntered += e2;
            }

            if (MouseExited is System.Action e3)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseExited", e3);
                castedNode.MouseExited += e3;
            }

            if (FocusEntered is System.Action e4)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusEntered", e4);
                castedNode.FocusEntered += e4;
            }

            if (FocusExited is System.Action e5)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusExited", e5);
                castedNode.FocusExited += e5;
            }

            if (SizeFlagsChanged is System.Action e6)
            {
                NodeStateManager.AddEventHandler(castedNode, "SizeFlagsChanged", e6);
                castedNode.SizeFlagsChanged += e6;
            }

            if (MinimumSizeChanged is System.Action e7)
            {
                NodeStateManager.AddEventHandler(castedNode, "MinimumSizeChanged", e7);
                castedNode.MinimumSizeChanged += e7;
            }

            if (ThemeChanged is System.Action e8)
            {
                NodeStateManager.AddEventHandler(castedNode, "ThemeChanged", e8);
                castedNode.ThemeChanged += e8;
            }

            if (Draw is System.Action e9)
            {
                NodeStateManager.AddEventHandler(castedNode, "Draw", e9);
                castedNode.Draw += e9;
            }

            if (VisibilityChanged is System.Action e10)
            {
                NodeStateManager.AddEventHandler(castedNode, "VisibilityChanged", e10);
                castedNode.VisibilityChanged += e10;
            }

            if (Hidden is System.Action e11)
            {
                NodeStateManager.AddEventHandler(castedNode, "Hidden", e11);
                castedNode.Hidden += e11;
            }

            if (ItemRectChanged is System.Action e12)
            {
                NodeStateManager.AddEventHandler(castedNode, "ItemRectChanged", e12);
                castedNode.ItemRectChanged += e12;
            }

            if (Ready is System.Action e13)
            {
                NodeStateManager.AddEventHandler(castedNode, "Ready", e13);
                castedNode.Ready += e13;
            }

            if (Renamed is System.Action e14)
            {
                NodeStateManager.AddEventHandler(castedNode, "Renamed", e14);
                castedNode.Renamed += e14;
            }

            if (TreeEntered is System.Action e15)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeEntered", e15);
                castedNode.TreeEntered += e15;
            }

            if (TreeExiting is System.Action e16)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExiting", e16);
                castedNode.TreeExiting += e16;
            }

            if (TreeExited is System.Action e17)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExited", e17);
                castedNode.TreeExited += e17;
            }

            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e18)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildEnteredTree", e18);
                castedNode.ChildEnteredTree += e18;
            }

            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e19)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildExitingTree", e19);
                castedNode.ChildExitingTree += e19;
            }

            if (ChildOrderChanged is System.Action e20)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildOrderChanged", e20);
                castedNode.ChildOrderChanged += e20;
            }

            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e21)
            {
                NodeStateManager.AddEventHandler(castedNode, "ReplacingBy", e21);
                castedNode.ReplacingBy += e21;
            }

            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e22)
            {
                NodeStateManager.AddEventHandler(castedNode, "EditorDescriptionChanged", e22);
                castedNode.EditorDescriptionChanged += e22;
            }

            if (ScriptChanged is System.Action e23)
            {
                NodeStateManager.AddEventHandler(castedNode, "ScriptChanged", e23);
                castedNode.ScriptChanged += e23;
            }

            if (PropertyListChanged is System.Action e24)
            {
                NodeStateManager.AddEventHandler(castedNode, "PropertyListChanged", e24);
                castedNode.PropertyListChanged += e24;
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