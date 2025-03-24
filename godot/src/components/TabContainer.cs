// This file is auto-generated. Please do not edit
namespace ReactiveSharpGodot.Components
{
    public class TabContainer : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GTabContainer>
    {
        public Godot.TabBar.AlignmentMode? TabAlignment { protected get; init; }
        public System.Int32? CurrentTab { protected get; init; }
        public Godot.TabContainer.TabPosition? TabsPosition { protected get; init; }
        public System.Boolean? ClipTabs { protected get; init; }
        public System.Boolean? TabsVisible { protected get; init; }
        public System.Boolean? AllTabsInFront { protected get; init; }
        public System.Boolean? DragToRearrangeEnabled { protected get; init; }
        public System.Int32? TabsRearrangeGroup { protected get; init; }
        public System.Boolean? UseHiddenTabsForMinSize { protected get; init; }
        public Godot.Control.FocusModeEnum? TabFocusMode { protected get; init; }
        public System.Boolean? DeselectEnabled { protected get; init; }
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
        public Godot.TabContainer.ActiveTabRearrangedEventHandler? ActiveTabRearranged { protected get; init; }
        public Godot.TabContainer.TabChangedEventHandler? TabChanged { protected get; init; }
        public Godot.TabContainer.TabClickedEventHandler? TabClicked { protected get; init; }
        public Godot.TabContainer.TabHoveredEventHandler? TabHovered { protected get; init; }
        public Godot.TabContainer.TabSelectedEventHandler? TabSelected { protected get; init; }
        public Godot.TabContainer.TabButtonPressedEventHandler? TabButtonPressed { protected get; init; }
        public System.Action? PrePopupPressed { protected get; init; }
        public System.Action? PreSortChildren { protected get; init; }
        public System.Action? SortChildren { protected get; init; }
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
        public Action<ReactiveSharpGodot.Nodes.GTabContainer>? CustomNodeHandling { protected get; init; }

        public override ReactiveSharpGodot.Nodes.GTabContainer Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GTabContainer();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GTabContainer node)
        {
            var castedNode = (Godot.TabContainer)node.Node;
            if (TabAlignment is Godot.TabBar.AlignmentMode n0)
            {
                NodeStateManager.AddPropertyState(castedNode, "TabAlignment", castedNode.TabAlignment);
                castedNode.TabAlignment = n0;
            }

            if (CurrentTab is System.Int32 n1)
            {
                NodeStateManager.AddPropertyState(castedNode, "CurrentTab", castedNode.CurrentTab);
                castedNode.CurrentTab = n1;
            }

            if (TabsPosition is Godot.TabContainer.TabPosition n2)
            {
                NodeStateManager.AddPropertyState(castedNode, "TabsPosition", castedNode.TabsPosition);
                castedNode.TabsPosition = n2;
            }

            if (ClipTabs is System.Boolean n3)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipTabs", castedNode.ClipTabs);
                castedNode.ClipTabs = n3;
            }

            if (TabsVisible is System.Boolean n4)
            {
                NodeStateManager.AddPropertyState(castedNode, "TabsVisible", castedNode.TabsVisible);
                castedNode.TabsVisible = n4;
            }

            if (AllTabsInFront is System.Boolean n5)
            {
                NodeStateManager.AddPropertyState(castedNode, "AllTabsInFront", castedNode.AllTabsInFront);
                castedNode.AllTabsInFront = n5;
            }

            if (DragToRearrangeEnabled is System.Boolean n6)
            {
                NodeStateManager.AddPropertyState(castedNode, "DragToRearrangeEnabled", castedNode.DragToRearrangeEnabled);
                castedNode.DragToRearrangeEnabled = n6;
            }

            if (TabsRearrangeGroup is System.Int32 n7)
            {
                NodeStateManager.AddPropertyState(castedNode, "TabsRearrangeGroup", castedNode.TabsRearrangeGroup);
                castedNode.TabsRearrangeGroup = n7;
            }

            if (UseHiddenTabsForMinSize is System.Boolean n8)
            {
                NodeStateManager.AddPropertyState(castedNode, "UseHiddenTabsForMinSize", castedNode.UseHiddenTabsForMinSize);
                castedNode.UseHiddenTabsForMinSize = n8;
            }

            if (TabFocusMode is Godot.Control.FocusModeEnum n9)
            {
                NodeStateManager.AddPropertyState(castedNode, "TabFocusMode", castedNode.TabFocusMode);
                castedNode.TabFocusMode = n9;
            }

            if (DeselectEnabled is System.Boolean n10)
            {
                NodeStateManager.AddPropertyState(castedNode, "DeselectEnabled", castedNode.DeselectEnabled);
                castedNode.DeselectEnabled = n10;
            }

            if (ClipContents is System.Boolean n11)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipContents", castedNode.ClipContents);
                castedNode.ClipContents = n11;
            }

            if (CustomMinimumSize is Godot.Vector2 n12)
            {
                NodeStateManager.AddPropertyState(castedNode, "CustomMinimumSize", castedNode.CustomMinimumSize);
                castedNode.CustomMinimumSize = n12;
            }

            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n13)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutDirection", castedNode.LayoutDirection);
                castedNode.LayoutDirection = n13;
            }

            if (LayoutMode is System.Int32 n14)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutMode", castedNode.LayoutMode);
                castedNode.LayoutMode = n14;
            }

            if (AnchorsPreset is System.Int32 n15)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorsPreset", castedNode.AnchorsPreset);
                castedNode.AnchorsPreset = n15;
            }

            if (AnchorLeft is System.Single n16)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorLeft", castedNode.AnchorLeft);
                castedNode.AnchorLeft = n16;
            }

            if (AnchorTop is System.Single n17)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorTop", castedNode.AnchorTop);
                castedNode.AnchorTop = n17;
            }

            if (AnchorRight is System.Single n18)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorRight", castedNode.AnchorRight);
                castedNode.AnchorRight = n18;
            }

            if (AnchorBottom is System.Single n19)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorBottom", castedNode.AnchorBottom);
                castedNode.AnchorBottom = n19;
            }

            if (OffsetLeft is System.Single n20)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetLeft", castedNode.OffsetLeft);
                castedNode.OffsetLeft = n20;
            }

            if (OffsetTop is System.Single n21)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetTop", castedNode.OffsetTop);
                castedNode.OffsetTop = n21;
            }

            if (OffsetRight is System.Single n22)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetRight", castedNode.OffsetRight);
                castedNode.OffsetRight = n22;
            }

            if (OffsetBottom is System.Single n23)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetBottom", castedNode.OffsetBottom);
                castedNode.OffsetBottom = n23;
            }

            if (GrowHorizontal is Godot.Control.GrowDirection n24)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowHorizontal", castedNode.GrowHorizontal);
                castedNode.GrowHorizontal = n24;
            }

            if (GrowVertical is Godot.Control.GrowDirection n25)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowVertical", castedNode.GrowVertical);
                castedNode.GrowVertical = n25;
            }

            if (Size is Godot.Vector2 n26)
            {
                NodeStateManager.AddPropertyState(castedNode, "Size", castedNode.Size);
                castedNode.Size = n26;
            }

            if (Position is Godot.Vector2 n27)
            {
                NodeStateManager.AddPropertyState(castedNode, "Position", castedNode.Position);
                castedNode.Position = n27;
            }

            if (GlobalPosition is Godot.Vector2 n28)
            {
                NodeStateManager.AddPropertyState(castedNode, "GlobalPosition", castedNode.GlobalPosition);
                castedNode.GlobalPosition = n28;
            }

            if (Rotation is System.Single n29)
            {
                NodeStateManager.AddPropertyState(castedNode, "Rotation", castedNode.Rotation);
                castedNode.Rotation = n29;
            }

            if (RotationDegrees is System.Single n30)
            {
                NodeStateManager.AddPropertyState(castedNode, "RotationDegrees", castedNode.RotationDegrees);
                castedNode.RotationDegrees = n30;
            }

            if (Scale is Godot.Vector2 n31)
            {
                NodeStateManager.AddPropertyState(castedNode, "Scale", castedNode.Scale);
                castedNode.Scale = n31;
            }

            if (PivotOffset is Godot.Vector2 n32)
            {
                NodeStateManager.AddPropertyState(castedNode, "PivotOffset", castedNode.PivotOffset);
                castedNode.PivotOffset = n32;
            }

            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n33)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsHorizontal", castedNode.SizeFlagsHorizontal);
                castedNode.SizeFlagsHorizontal = n33;
            }

            if (SizeFlagsVertical is Godot.Control.SizeFlags n34)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsVertical", castedNode.SizeFlagsVertical);
                castedNode.SizeFlagsVertical = n34;
            }

            if (SizeFlagsStretchRatio is System.Single n35)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsStretchRatio", castedNode.SizeFlagsStretchRatio);
                castedNode.SizeFlagsStretchRatio = n35;
            }

            if (LocalizeNumeralSystem is System.Boolean n36)
            {
                NodeStateManager.AddPropertyState(castedNode, "LocalizeNumeralSystem", castedNode.LocalizeNumeralSystem);
                castedNode.LocalizeNumeralSystem = n36;
            }

            if (AutoTranslate is System.Boolean n37)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslate", castedNode.AutoTranslate);
                castedNode.AutoTranslate = n37;
            }

            if (TooltipText is System.String n38)
            {
                NodeStateManager.AddPropertyState(castedNode, "TooltipText", castedNode.TooltipText);
                castedNode.TooltipText = n38;
            }

            if (FocusNeighborLeft is Godot.NodePath n39)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborLeft", castedNode.FocusNeighborLeft);
                castedNode.FocusNeighborLeft = n39;
            }

            if (FocusNeighborTop is Godot.NodePath n40)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborTop", castedNode.FocusNeighborTop);
                castedNode.FocusNeighborTop = n40;
            }

            if (FocusNeighborRight is Godot.NodePath n41)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborRight", castedNode.FocusNeighborRight);
                castedNode.FocusNeighborRight = n41;
            }

            if (FocusNeighborBottom is Godot.NodePath n42)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborBottom", castedNode.FocusNeighborBottom);
                castedNode.FocusNeighborBottom = n42;
            }

            if (FocusNext is Godot.NodePath n43)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNext", castedNode.FocusNext);
                castedNode.FocusNext = n43;
            }

            if (FocusPrevious is Godot.NodePath n44)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusPrevious", castedNode.FocusPrevious);
                castedNode.FocusPrevious = n44;
            }

            if (FocusMode is Godot.Control.FocusModeEnum n45)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusMode", castedNode.FocusMode);
                castedNode.FocusMode = n45;
            }

            if (MouseFilter is Godot.Control.MouseFilterEnum n46)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseFilter", castedNode.MouseFilter);
                castedNode.MouseFilter = n46;
            }

            if (MouseForcePassScrollEvents is System.Boolean n47)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseForcePassScrollEvents", castedNode.MouseForcePassScrollEvents);
                castedNode.MouseForcePassScrollEvents = n47;
            }

            if (MouseDefaultCursorShape is Godot.Control.CursorShape n48)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseDefaultCursorShape", castedNode.MouseDefaultCursorShape);
                castedNode.MouseDefaultCursorShape = n48;
            }

            if (ShortcutContext is Godot.Node n49)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutContext", castedNode.ShortcutContext);
                castedNode.ShortcutContext = n49;
            }

            if (Theme is Godot.Theme n50)
            {
                NodeStateManager.AddPropertyState(castedNode, "Theme", castedNode.Theme);
                castedNode.Theme = n50;
            }

            if (ThemeTypeVariation is Godot.StringName n51)
            {
                NodeStateManager.AddPropertyState(castedNode, "ThemeTypeVariation", castedNode.ThemeTypeVariation);
                castedNode.ThemeTypeVariation = n51;
            }

            if (Visible is System.Boolean n52)
            {
                NodeStateManager.AddPropertyState(castedNode, "Visible", castedNode.Visible);
                castedNode.Visible = n52;
            }

            if (Modulate is Godot.Color n53)
            {
                NodeStateManager.AddPropertyState(castedNode, "Modulate", castedNode.Modulate);
                castedNode.Modulate = n53;
            }

            if (SelfModulate is Godot.Color n54)
            {
                NodeStateManager.AddPropertyState(castedNode, "SelfModulate", castedNode.SelfModulate);
                castedNode.SelfModulate = n54;
            }

            if (ShowBehindParent is System.Boolean n55)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowBehindParent", castedNode.ShowBehindParent);
                castedNode.ShowBehindParent = n55;
            }

            if (TopLevel is System.Boolean n56)
            {
                NodeStateManager.AddPropertyState(castedNode, "TopLevel", castedNode.TopLevel);
                castedNode.TopLevel = n56;
            }

            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n57)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipChildren", castedNode.ClipChildren);
                castedNode.ClipChildren = n57;
            }

            if (LightMask is System.Int32 n58)
            {
                NodeStateManager.AddPropertyState(castedNode, "LightMask", castedNode.LightMask);
                castedNode.LightMask = n58;
            }

            if (VisibilityLayer is System.UInt32 n59)
            {
                NodeStateManager.AddPropertyState(castedNode, "VisibilityLayer", castedNode.VisibilityLayer);
                castedNode.VisibilityLayer = n59;
            }

            if (ZIndex is System.Int32 n60)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZIndex", castedNode.ZIndex);
                castedNode.ZIndex = n60;
            }

            if (ZAsRelative is System.Boolean n61)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZAsRelative", castedNode.ZAsRelative);
                castedNode.ZAsRelative = n61;
            }

            if (YSortEnabled is System.Boolean n62)
            {
                NodeStateManager.AddPropertyState(castedNode, "YSortEnabled", castedNode.YSortEnabled);
                castedNode.YSortEnabled = n62;
            }

            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n63)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureFilter", castedNode.TextureFilter);
                castedNode.TextureFilter = n63;
            }

            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n64)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureRepeat", castedNode.TextureRepeat);
                castedNode.TextureRepeat = n64;
            }

            if (Material is Godot.Material n65)
            {
                NodeStateManager.AddPropertyState(castedNode, "Material", castedNode.Material);
                castedNode.Material = n65;
            }

            if (UseParentMaterial is System.Boolean n66)
            {
                NodeStateManager.AddPropertyState(castedNode, "UseParentMaterial", castedNode.UseParentMaterial);
                castedNode.UseParentMaterial = n66;
            }

            if (Name is Godot.StringName n67)
            {
                NodeStateManager.AddPropertyState(castedNode, "Name", castedNode.Name);
                castedNode.Name = n67;
            }

            if (UniqueNameInOwner is System.Boolean n68)
            {
                NodeStateManager.AddPropertyState(castedNode, "UniqueNameInOwner", castedNode.UniqueNameInOwner);
                castedNode.UniqueNameInOwner = n68;
            }

            if (SceneFilePath is System.String n69)
            {
                NodeStateManager.AddPropertyState(castedNode, "SceneFilePath", castedNode.SceneFilePath);
                castedNode.SceneFilePath = n69;
            }

            if (Owner is Godot.Node n70)
            {
                NodeStateManager.AddPropertyState(castedNode, "Owner", castedNode.Owner);
                castedNode.Owner = n70;
            }

            if (ProcessMode is Godot.Node.ProcessModeEnum n71)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessMode", castedNode.ProcessMode);
                castedNode.ProcessMode = n71;
            }

            if (ProcessPriority is System.Int32 n72)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPriority", castedNode.ProcessPriority);
                castedNode.ProcessPriority = n72;
            }

            if (ProcessPhysicsPriority is System.Int32 n73)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPhysicsPriority", castedNode.ProcessPhysicsPriority);
                castedNode.ProcessPhysicsPriority = n73;
            }

            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n74)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroup", castedNode.ProcessThreadGroup);
                castedNode.ProcessThreadGroup = n74;
            }

            if (ProcessThreadGroupOrder is System.Int32 n75)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroupOrder", castedNode.ProcessThreadGroupOrder);
                castedNode.ProcessThreadGroupOrder = n75;
            }

            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n76)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadMessages", castedNode.ProcessThreadMessages);
                castedNode.ProcessThreadMessages = n76;
            }

            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n77)
            {
                NodeStateManager.AddPropertyState(castedNode, "PhysicsInterpolationMode", castedNode.PhysicsInterpolationMode);
                castedNode.PhysicsInterpolationMode = n77;
            }

            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n78)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslateMode", castedNode.AutoTranslateMode);
                castedNode.AutoTranslateMode = n78;
            }

            if (EditorDescription is System.String n79)
            {
                NodeStateManager.AddPropertyState(castedNode, "EditorDescription", castedNode.EditorDescription);
                castedNode.EditorDescription = n79;
            }

            if (ActiveTabRearranged is Godot.TabContainer.ActiveTabRearrangedEventHandler e0)
            {
                NodeStateManager.AddEventHandler(castedNode, "ActiveTabRearranged", e0);
                castedNode.ActiveTabRearranged += e0;
            }

            if (TabChanged is Godot.TabContainer.TabChangedEventHandler e1)
            {
                NodeStateManager.AddEventHandler(castedNode, "TabChanged", e1);
                castedNode.TabChanged += e1;
            }

            if (TabClicked is Godot.TabContainer.TabClickedEventHandler e2)
            {
                NodeStateManager.AddEventHandler(castedNode, "TabClicked", e2);
                castedNode.TabClicked += e2;
            }

            if (TabHovered is Godot.TabContainer.TabHoveredEventHandler e3)
            {
                NodeStateManager.AddEventHandler(castedNode, "TabHovered", e3);
                castedNode.TabHovered += e3;
            }

            if (TabSelected is Godot.TabContainer.TabSelectedEventHandler e4)
            {
                NodeStateManager.AddEventHandler(castedNode, "TabSelected", e4);
                castedNode.TabSelected += e4;
            }

            if (TabButtonPressed is Godot.TabContainer.TabButtonPressedEventHandler e5)
            {
                NodeStateManager.AddEventHandler(castedNode, "TabButtonPressed", e5);
                castedNode.TabButtonPressed += e5;
            }

            if (PrePopupPressed is System.Action e6)
            {
                NodeStateManager.AddEventHandler(castedNode, "PrePopupPressed", e6);
                castedNode.PrePopupPressed += e6;
            }

            if (PreSortChildren is System.Action e7)
            {
                NodeStateManager.AddEventHandler(castedNode, "PreSortChildren", e7);
                castedNode.PreSortChildren += e7;
            }

            if (SortChildren is System.Action e8)
            {
                NodeStateManager.AddEventHandler(castedNode, "SortChildren", e8);
                castedNode.SortChildren += e8;
            }

            if (Resized is System.Action e9)
            {
                NodeStateManager.AddEventHandler(castedNode, "Resized", e9);
                castedNode.Resized += e9;
            }

            if (GuiInput is Godot.Control.GuiInputEventHandler e10)
            {
                NodeStateManager.AddEventHandler(castedNode, "GuiInput", e10);
                castedNode.GuiInput += e10;
            }

            if (MouseEntered is System.Action e11)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseEntered", e11);
                castedNode.MouseEntered += e11;
            }

            if (MouseExited is System.Action e12)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseExited", e12);
                castedNode.MouseExited += e12;
            }

            if (FocusEntered is System.Action e13)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusEntered", e13);
                castedNode.FocusEntered += e13;
            }

            if (FocusExited is System.Action e14)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusExited", e14);
                castedNode.FocusExited += e14;
            }

            if (SizeFlagsChanged is System.Action e15)
            {
                NodeStateManager.AddEventHandler(castedNode, "SizeFlagsChanged", e15);
                castedNode.SizeFlagsChanged += e15;
            }

            if (MinimumSizeChanged is System.Action e16)
            {
                NodeStateManager.AddEventHandler(castedNode, "MinimumSizeChanged", e16);
                castedNode.MinimumSizeChanged += e16;
            }

            if (ThemeChanged is System.Action e17)
            {
                NodeStateManager.AddEventHandler(castedNode, "ThemeChanged", e17);
                castedNode.ThemeChanged += e17;
            }

            if (Draw is System.Action e18)
            {
                NodeStateManager.AddEventHandler(castedNode, "Draw", e18);
                castedNode.Draw += e18;
            }

            if (VisibilityChanged is System.Action e19)
            {
                NodeStateManager.AddEventHandler(castedNode, "VisibilityChanged", e19);
                castedNode.VisibilityChanged += e19;
            }

            if (Hidden is System.Action e20)
            {
                NodeStateManager.AddEventHandler(castedNode, "Hidden", e20);
                castedNode.Hidden += e20;
            }

            if (ItemRectChanged is System.Action e21)
            {
                NodeStateManager.AddEventHandler(castedNode, "ItemRectChanged", e21);
                castedNode.ItemRectChanged += e21;
            }

            if (Ready is System.Action e22)
            {
                NodeStateManager.AddEventHandler(castedNode, "Ready", e22);
                castedNode.Ready += e22;
            }

            if (Renamed is System.Action e23)
            {
                NodeStateManager.AddEventHandler(castedNode, "Renamed", e23);
                castedNode.Renamed += e23;
            }

            if (TreeEntered is System.Action e24)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeEntered", e24);
                castedNode.TreeEntered += e24;
            }

            if (TreeExiting is System.Action e25)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExiting", e25);
                castedNode.TreeExiting += e25;
            }

            if (TreeExited is System.Action e26)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExited", e26);
                castedNode.TreeExited += e26;
            }

            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e27)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildEnteredTree", e27);
                castedNode.ChildEnteredTree += e27;
            }

            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e28)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildExitingTree", e28);
                castedNode.ChildExitingTree += e28;
            }

            if (ChildOrderChanged is System.Action e29)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildOrderChanged", e29);
                castedNode.ChildOrderChanged += e29;
            }

            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e30)
            {
                NodeStateManager.AddEventHandler(castedNode, "ReplacingBy", e30);
                castedNode.ReplacingBy += e30;
            }

            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e31)
            {
                NodeStateManager.AddEventHandler(castedNode, "EditorDescriptionChanged", e31);
                castedNode.EditorDescriptionChanged += e31;
            }

            if (ScriptChanged is System.Action e32)
            {
                NodeStateManager.AddEventHandler(castedNode, "ScriptChanged", e32);
                castedNode.ScriptChanged += e32;
            }

            if (PropertyListChanged is System.Action e33)
            {
                NodeStateManager.AddEventHandler(castedNode, "PropertyListChanged", e33);
                castedNode.PropertyListChanged += e33;
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