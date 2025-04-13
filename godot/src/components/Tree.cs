// This file is auto-generated. Please do not edit
namespace ReactiveSharpGodot.Components
{
    public class Tree : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GTree>
    {
        public System.Int32? Columns { protected get; init; }
        public System.Boolean? ColumnTitlesVisible { protected get; init; }
        public System.Boolean? AllowReselect { protected get; init; }
        public System.Boolean? AllowRmbSelect { protected get; init; }
        public System.Boolean? AllowSearch { protected get; init; }
        public System.Boolean? HideFolding { protected get; init; }
        public System.Boolean? EnableRecursiveFolding { protected get; init; }
        public System.Boolean? HideRoot { protected get; init; }
        public System.Int32? DropModeFlags { protected get; init; }
        public Godot.Tree.SelectModeEnum? SelectMode { protected get; init; }
        public System.Boolean? ScrollHorizontalEnabled { protected get; init; }
        public System.Boolean? ScrollVerticalEnabled { protected get; init; }
        public System.Boolean? AutoTooltip { protected get; init; }
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
        public System.Action? ItemSelected { protected get; init; }
        public System.Action? CellSelected { protected get; init; }
        public Godot.Tree.MultiSelectedEventHandler? MultiSelected { protected get; init; }
        public Godot.Tree.ItemMouseSelectedEventHandler? ItemMouseSelected { protected get; init; }
        public Godot.Tree.EmptyClickedEventHandler? EmptyClicked { protected get; init; }
        public System.Action? ItemEdited { protected get; init; }
        public Godot.Tree.CustomItemClickedEventHandler? CustomItemClicked { protected get; init; }
        public System.Action? ItemIconDoubleClicked { protected get; init; }
        public Godot.Tree.ItemCollapsedEventHandler? ItemCollapsed { protected get; init; }
        public Godot.Tree.CheckPropagatedToItemEventHandler? CheckPropagatedToItem { protected get; init; }
        public Godot.Tree.ButtonClickedEventHandler? ButtonClicked { protected get; init; }
        public Godot.Tree.CustomPopupEditedEventHandler? CustomPopupEdited { protected get; init; }
        public System.Action? ItemActivated { protected get; init; }
        public Godot.Tree.ColumnTitleClickedEventHandler? ColumnTitleClicked { protected get; init; }
        public System.Action? NothingSelected { protected get; init; }
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
        public Action<ReactiveSharpGodot.Nodes.GTree>? CustomNodeHandling { protected get; init; }

        public override ReactiveSharpGodot.Nodes.GTree Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GTree();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GTree node)
        {
            var castedNode = (Godot.Tree)node.Node;
            if (Columns is System.Int32 n0)
            {
                NodeStateManager.AddPropertyState(castedNode, "Columns", castedNode.Columns);
                castedNode.Columns = n0;
            }

            if (ColumnTitlesVisible is System.Boolean n1)
            {
                NodeStateManager.AddPropertyState(castedNode, "ColumnTitlesVisible", castedNode.ColumnTitlesVisible);
                castedNode.ColumnTitlesVisible = n1;
            }

            if (AllowReselect is System.Boolean n2)
            {
                NodeStateManager.AddPropertyState(castedNode, "AllowReselect", castedNode.AllowReselect);
                castedNode.AllowReselect = n2;
            }

            if (AllowRmbSelect is System.Boolean n3)
            {
                NodeStateManager.AddPropertyState(castedNode, "AllowRmbSelect", castedNode.AllowRmbSelect);
                castedNode.AllowRmbSelect = n3;
            }

            if (AllowSearch is System.Boolean n4)
            {
                NodeStateManager.AddPropertyState(castedNode, "AllowSearch", castedNode.AllowSearch);
                castedNode.AllowSearch = n4;
            }

            if (HideFolding is System.Boolean n5)
            {
                NodeStateManager.AddPropertyState(castedNode, "HideFolding", castedNode.HideFolding);
                castedNode.HideFolding = n5;
            }

            if (EnableRecursiveFolding is System.Boolean n6)
            {
                NodeStateManager.AddPropertyState(castedNode, "EnableRecursiveFolding", castedNode.EnableRecursiveFolding);
                castedNode.EnableRecursiveFolding = n6;
            }

            if (HideRoot is System.Boolean n7)
            {
                NodeStateManager.AddPropertyState(castedNode, "HideRoot", castedNode.HideRoot);
                castedNode.HideRoot = n7;
            }

            if (DropModeFlags is System.Int32 n8)
            {
                NodeStateManager.AddPropertyState(castedNode, "DropModeFlags", castedNode.DropModeFlags);
                castedNode.DropModeFlags = n8;
            }

            if (SelectMode is Godot.Tree.SelectModeEnum n9)
            {
                NodeStateManager.AddPropertyState(castedNode, "SelectMode", castedNode.SelectMode);
                castedNode.SelectMode = n9;
            }

            if (ScrollHorizontalEnabled is System.Boolean n10)
            {
                NodeStateManager.AddPropertyState(castedNode, "ScrollHorizontalEnabled", castedNode.ScrollHorizontalEnabled);
                castedNode.ScrollHorizontalEnabled = n10;
            }

            if (ScrollVerticalEnabled is System.Boolean n11)
            {
                NodeStateManager.AddPropertyState(castedNode, "ScrollVerticalEnabled", castedNode.ScrollVerticalEnabled);
                castedNode.ScrollVerticalEnabled = n11;
            }

            if (AutoTooltip is System.Boolean n12)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTooltip", castedNode.AutoTooltip);
                castedNode.AutoTooltip = n12;
            }

            if (ClipContents is System.Boolean n13)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipContents", castedNode.ClipContents);
                castedNode.ClipContents = n13;
            }

            if (CustomMinimumSize is Godot.Vector2 n14)
            {
                NodeStateManager.AddPropertyState(castedNode, "CustomMinimumSize", castedNode.CustomMinimumSize);
                castedNode.CustomMinimumSize = n14;
            }

            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n15)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutDirection", castedNode.LayoutDirection);
                castedNode.LayoutDirection = n15;
            }

            if (LayoutMode is System.Int32 n16)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutMode", castedNode.LayoutMode);
                castedNode.LayoutMode = n16;
            }

            if (AnchorsPreset is System.Int32 n17)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorsPreset", castedNode.AnchorsPreset);
                castedNode.AnchorsPreset = n17;
            }

            if (AnchorLeft is System.Single n18)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorLeft", castedNode.AnchorLeft);
                castedNode.AnchorLeft = n18;
            }

            if (AnchorTop is System.Single n19)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorTop", castedNode.AnchorTop);
                castedNode.AnchorTop = n19;
            }

            if (AnchorRight is System.Single n20)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorRight", castedNode.AnchorRight);
                castedNode.AnchorRight = n20;
            }

            if (AnchorBottom is System.Single n21)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorBottom", castedNode.AnchorBottom);
                castedNode.AnchorBottom = n21;
            }

            if (OffsetLeft is System.Single n22)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetLeft", castedNode.OffsetLeft);
                castedNode.OffsetLeft = n22;
            }

            if (OffsetTop is System.Single n23)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetTop", castedNode.OffsetTop);
                castedNode.OffsetTop = n23;
            }

            if (OffsetRight is System.Single n24)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetRight", castedNode.OffsetRight);
                castedNode.OffsetRight = n24;
            }

            if (OffsetBottom is System.Single n25)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetBottom", castedNode.OffsetBottom);
                castedNode.OffsetBottom = n25;
            }

            if (GrowHorizontal is Godot.Control.GrowDirection n26)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowHorizontal", castedNode.GrowHorizontal);
                castedNode.GrowHorizontal = n26;
            }

            if (GrowVertical is Godot.Control.GrowDirection n27)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowVertical", castedNode.GrowVertical);
                castedNode.GrowVertical = n27;
            }

            if (Size is Godot.Vector2 n28)
            {
                NodeStateManager.AddPropertyState(castedNode, "Size", castedNode.Size);
                castedNode.Size = n28;
            }

            if (Position is Godot.Vector2 n29)
            {
                NodeStateManager.AddPropertyState(castedNode, "Position", castedNode.Position);
                castedNode.Position = n29;
            }

            if (GlobalPosition is Godot.Vector2 n30)
            {
                NodeStateManager.AddPropertyState(castedNode, "GlobalPosition", castedNode.GlobalPosition);
                castedNode.GlobalPosition = n30;
            }

            if (Rotation is System.Single n31)
            {
                NodeStateManager.AddPropertyState(castedNode, "Rotation", castedNode.Rotation);
                castedNode.Rotation = n31;
            }

            if (RotationDegrees is System.Single n32)
            {
                NodeStateManager.AddPropertyState(castedNode, "RotationDegrees", castedNode.RotationDegrees);
                castedNode.RotationDegrees = n32;
            }

            if (Scale is Godot.Vector2 n33)
            {
                NodeStateManager.AddPropertyState(castedNode, "Scale", castedNode.Scale);
                castedNode.Scale = n33;
            }

            if (PivotOffset is Godot.Vector2 n34)
            {
                NodeStateManager.AddPropertyState(castedNode, "PivotOffset", castedNode.PivotOffset);
                castedNode.PivotOffset = n34;
            }

            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n35)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsHorizontal", castedNode.SizeFlagsHorizontal);
                castedNode.SizeFlagsHorizontal = n35;
            }

            if (SizeFlagsVertical is Godot.Control.SizeFlags n36)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsVertical", castedNode.SizeFlagsVertical);
                castedNode.SizeFlagsVertical = n36;
            }

            if (SizeFlagsStretchRatio is System.Single n37)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsStretchRatio", castedNode.SizeFlagsStretchRatio);
                castedNode.SizeFlagsStretchRatio = n37;
            }

            if (LocalizeNumeralSystem is System.Boolean n38)
            {
                NodeStateManager.AddPropertyState(castedNode, "LocalizeNumeralSystem", castedNode.LocalizeNumeralSystem);
                castedNode.LocalizeNumeralSystem = n38;
            }

            if (AutoTranslate is System.Boolean n39)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslate", castedNode.AutoTranslate);
                castedNode.AutoTranslate = n39;
            }

            if (TooltipText is System.String n40)
            {
                NodeStateManager.AddPropertyState(castedNode, "TooltipText", castedNode.TooltipText);
                castedNode.TooltipText = n40;
            }

            if (TooltipAutoTranslateMode is Godot.Node.AutoTranslateModeEnum n41)
            {
                NodeStateManager.AddPropertyState(castedNode, "TooltipAutoTranslateMode", castedNode.TooltipAutoTranslateMode);
                castedNode.TooltipAutoTranslateMode = n41;
            }

            if (FocusNeighborLeft is Godot.NodePath n42)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborLeft", castedNode.FocusNeighborLeft);
                castedNode.FocusNeighborLeft = n42;
            }

            if (FocusNeighborTop is Godot.NodePath n43)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborTop", castedNode.FocusNeighborTop);
                castedNode.FocusNeighborTop = n43;
            }

            if (FocusNeighborRight is Godot.NodePath n44)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborRight", castedNode.FocusNeighborRight);
                castedNode.FocusNeighborRight = n44;
            }

            if (FocusNeighborBottom is Godot.NodePath n45)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborBottom", castedNode.FocusNeighborBottom);
                castedNode.FocusNeighborBottom = n45;
            }

            if (FocusNext is Godot.NodePath n46)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNext", castedNode.FocusNext);
                castedNode.FocusNext = n46;
            }

            if (FocusPrevious is Godot.NodePath n47)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusPrevious", castedNode.FocusPrevious);
                castedNode.FocusPrevious = n47;
            }

            if (FocusMode is Godot.Control.FocusModeEnum n48)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusMode", castedNode.FocusMode);
                castedNode.FocusMode = n48;
            }

            if (MouseFilter is Godot.Control.MouseFilterEnum n49)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseFilter", castedNode.MouseFilter);
                castedNode.MouseFilter = n49;
            }

            if (MouseForcePassScrollEvents is System.Boolean n50)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseForcePassScrollEvents", castedNode.MouseForcePassScrollEvents);
                castedNode.MouseForcePassScrollEvents = n50;
            }

            if (MouseDefaultCursorShape is Godot.Control.CursorShape n51)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseDefaultCursorShape", castedNode.MouseDefaultCursorShape);
                castedNode.MouseDefaultCursorShape = n51;
            }

            if (ShortcutContext is Godot.Node n52)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutContext", castedNode.ShortcutContext);
                castedNode.ShortcutContext = n52;
            }

            if (Theme is Godot.Theme n53)
            {
                NodeStateManager.AddPropertyState(castedNode, "Theme", castedNode.Theme);
                castedNode.Theme = n53;
            }

            if (ThemeTypeVariation is Godot.StringName n54)
            {
                NodeStateManager.AddPropertyState(castedNode, "ThemeTypeVariation", castedNode.ThemeTypeVariation);
                castedNode.ThemeTypeVariation = n54;
            }

            if (Visible is System.Boolean n55)
            {
                NodeStateManager.AddPropertyState(castedNode, "Visible", castedNode.Visible);
                castedNode.Visible = n55;
            }

            if (Modulate is Godot.Color n56)
            {
                NodeStateManager.AddPropertyState(castedNode, "Modulate", castedNode.Modulate);
                castedNode.Modulate = n56;
            }

            if (SelfModulate is Godot.Color n57)
            {
                NodeStateManager.AddPropertyState(castedNode, "SelfModulate", castedNode.SelfModulate);
                castedNode.SelfModulate = n57;
            }

            if (ShowBehindParent is System.Boolean n58)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowBehindParent", castedNode.ShowBehindParent);
                castedNode.ShowBehindParent = n58;
            }

            if (TopLevel is System.Boolean n59)
            {
                NodeStateManager.AddPropertyState(castedNode, "TopLevel", castedNode.TopLevel);
                castedNode.TopLevel = n59;
            }

            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n60)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipChildren", castedNode.ClipChildren);
                castedNode.ClipChildren = n60;
            }

            if (LightMask is System.Int32 n61)
            {
                NodeStateManager.AddPropertyState(castedNode, "LightMask", castedNode.LightMask);
                castedNode.LightMask = n61;
            }

            if (VisibilityLayer is System.UInt32 n62)
            {
                NodeStateManager.AddPropertyState(castedNode, "VisibilityLayer", castedNode.VisibilityLayer);
                castedNode.VisibilityLayer = n62;
            }

            if (ZIndex is System.Int32 n63)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZIndex", castedNode.ZIndex);
                castedNode.ZIndex = n63;
            }

            if (ZAsRelative is System.Boolean n64)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZAsRelative", castedNode.ZAsRelative);
                castedNode.ZAsRelative = n64;
            }

            if (YSortEnabled is System.Boolean n65)
            {
                NodeStateManager.AddPropertyState(castedNode, "YSortEnabled", castedNode.YSortEnabled);
                castedNode.YSortEnabled = n65;
            }

            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n66)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureFilter", castedNode.TextureFilter);
                castedNode.TextureFilter = n66;
            }

            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n67)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureRepeat", castedNode.TextureRepeat);
                castedNode.TextureRepeat = n67;
            }

            if (Material is Godot.Material n68)
            {
                NodeStateManager.AddPropertyState(castedNode, "Material", castedNode.Material);
                castedNode.Material = n68;
            }

            if (UseParentMaterial is System.Boolean n69)
            {
                NodeStateManager.AddPropertyState(castedNode, "UseParentMaterial", castedNode.UseParentMaterial);
                castedNode.UseParentMaterial = n69;
            }

            if (Name is Godot.StringName n70)
            {
                NodeStateManager.AddPropertyState(castedNode, "Name", castedNode.Name);
                castedNode.Name = n70;
            }

            if (UniqueNameInOwner is System.Boolean n71)
            {
                NodeStateManager.AddPropertyState(castedNode, "UniqueNameInOwner", castedNode.UniqueNameInOwner);
                castedNode.UniqueNameInOwner = n71;
            }

            if (SceneFilePath is System.String n72)
            {
                NodeStateManager.AddPropertyState(castedNode, "SceneFilePath", castedNode.SceneFilePath);
                castedNode.SceneFilePath = n72;
            }

            if (Owner is Godot.Node n73)
            {
                NodeStateManager.AddPropertyState(castedNode, "Owner", castedNode.Owner);
                castedNode.Owner = n73;
            }

            if (ProcessMode is Godot.Node.ProcessModeEnum n74)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessMode", castedNode.ProcessMode);
                castedNode.ProcessMode = n74;
            }

            if (ProcessPriority is System.Int32 n75)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPriority", castedNode.ProcessPriority);
                castedNode.ProcessPriority = n75;
            }

            if (ProcessPhysicsPriority is System.Int32 n76)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPhysicsPriority", castedNode.ProcessPhysicsPriority);
                castedNode.ProcessPhysicsPriority = n76;
            }

            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n77)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroup", castedNode.ProcessThreadGroup);
                castedNode.ProcessThreadGroup = n77;
            }

            if (ProcessThreadGroupOrder is System.Int32 n78)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroupOrder", castedNode.ProcessThreadGroupOrder);
                castedNode.ProcessThreadGroupOrder = n78;
            }

            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n79)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadMessages", castedNode.ProcessThreadMessages);
                castedNode.ProcessThreadMessages = n79;
            }

            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n80)
            {
                NodeStateManager.AddPropertyState(castedNode, "PhysicsInterpolationMode", castedNode.PhysicsInterpolationMode);
                castedNode.PhysicsInterpolationMode = n80;
            }

            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n81)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslateMode", castedNode.AutoTranslateMode);
                castedNode.AutoTranslateMode = n81;
            }

            if (EditorDescription is System.String n82)
            {
                NodeStateManager.AddPropertyState(castedNode, "EditorDescription", castedNode.EditorDescription);
                castedNode.EditorDescription = n82;
            }

            if (ItemSelected is System.Action e0)
            {
                NodeStateManager.AddEventHandler(castedNode, "ItemSelected", e0);
                castedNode.ItemSelected += e0;
            }

            if (CellSelected is System.Action e1)
            {
                NodeStateManager.AddEventHandler(castedNode, "CellSelected", e1);
                castedNode.CellSelected += e1;
            }

            if (MultiSelected is Godot.Tree.MultiSelectedEventHandler e2)
            {
                NodeStateManager.AddEventHandler(castedNode, "MultiSelected", e2);
                castedNode.MultiSelected += e2;
            }

            if (ItemMouseSelected is Godot.Tree.ItemMouseSelectedEventHandler e3)
            {
                NodeStateManager.AddEventHandler(castedNode, "ItemMouseSelected", e3);
                castedNode.ItemMouseSelected += e3;
            }

            if (EmptyClicked is Godot.Tree.EmptyClickedEventHandler e4)
            {
                NodeStateManager.AddEventHandler(castedNode, "EmptyClicked", e4);
                castedNode.EmptyClicked += e4;
            }

            if (ItemEdited is System.Action e5)
            {
                NodeStateManager.AddEventHandler(castedNode, "ItemEdited", e5);
                castedNode.ItemEdited += e5;
            }

            if (CustomItemClicked is Godot.Tree.CustomItemClickedEventHandler e6)
            {
                NodeStateManager.AddEventHandler(castedNode, "CustomItemClicked", e6);
                castedNode.CustomItemClicked += e6;
            }

            if (ItemIconDoubleClicked is System.Action e7)
            {
                NodeStateManager.AddEventHandler(castedNode, "ItemIconDoubleClicked", e7);
                castedNode.ItemIconDoubleClicked += e7;
            }

            if (ItemCollapsed is Godot.Tree.ItemCollapsedEventHandler e8)
            {
                NodeStateManager.AddEventHandler(castedNode, "ItemCollapsed", e8);
                castedNode.ItemCollapsed += e8;
            }

            if (CheckPropagatedToItem is Godot.Tree.CheckPropagatedToItemEventHandler e9)
            {
                NodeStateManager.AddEventHandler(castedNode, "CheckPropagatedToItem", e9);
                castedNode.CheckPropagatedToItem += e9;
            }

            if (ButtonClicked is Godot.Tree.ButtonClickedEventHandler e10)
            {
                NodeStateManager.AddEventHandler(castedNode, "ButtonClicked", e10);
                castedNode.ButtonClicked += e10;
            }

            if (CustomPopupEdited is Godot.Tree.CustomPopupEditedEventHandler e11)
            {
                NodeStateManager.AddEventHandler(castedNode, "CustomPopupEdited", e11);
                castedNode.CustomPopupEdited += e11;
            }

            if (ItemActivated is System.Action e12)
            {
                NodeStateManager.AddEventHandler(castedNode, "ItemActivated", e12);
                castedNode.ItemActivated += e12;
            }

            if (ColumnTitleClicked is Godot.Tree.ColumnTitleClickedEventHandler e13)
            {
                NodeStateManager.AddEventHandler(castedNode, "ColumnTitleClicked", e13);
                castedNode.ColumnTitleClicked += e13;
            }

            if (NothingSelected is System.Action e14)
            {
                NodeStateManager.AddEventHandler(castedNode, "NothingSelected", e14);
                castedNode.NothingSelected += e14;
            }

            if (Resized is System.Action e15)
            {
                NodeStateManager.AddEventHandler(castedNode, "Resized", e15);
                castedNode.Resized += e15;
            }

            if (GuiInput is Godot.Control.GuiInputEventHandler e16)
            {
                NodeStateManager.AddEventHandler(castedNode, "GuiInput", e16);
                castedNode.GuiInput += e16;
            }

            if (MouseEntered is System.Action e17)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseEntered", e17);
                castedNode.MouseEntered += e17;
            }

            if (MouseExited is System.Action e18)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseExited", e18);
                castedNode.MouseExited += e18;
            }

            if (FocusEntered is System.Action e19)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusEntered", e19);
                castedNode.FocusEntered += e19;
            }

            if (FocusExited is System.Action e20)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusExited", e20);
                castedNode.FocusExited += e20;
            }

            if (SizeFlagsChanged is System.Action e21)
            {
                NodeStateManager.AddEventHandler(castedNode, "SizeFlagsChanged", e21);
                castedNode.SizeFlagsChanged += e21;
            }

            if (MinimumSizeChanged is System.Action e22)
            {
                NodeStateManager.AddEventHandler(castedNode, "MinimumSizeChanged", e22);
                castedNode.MinimumSizeChanged += e22;
            }

            if (ThemeChanged is System.Action e23)
            {
                NodeStateManager.AddEventHandler(castedNode, "ThemeChanged", e23);
                castedNode.ThemeChanged += e23;
            }

            if (Draw is System.Action e24)
            {
                NodeStateManager.AddEventHandler(castedNode, "Draw", e24);
                castedNode.Draw += e24;
            }

            if (VisibilityChanged is System.Action e25)
            {
                NodeStateManager.AddEventHandler(castedNode, "VisibilityChanged", e25);
                castedNode.VisibilityChanged += e25;
            }

            if (Hidden is System.Action e26)
            {
                NodeStateManager.AddEventHandler(castedNode, "Hidden", e26);
                castedNode.Hidden += e26;
            }

            if (ItemRectChanged is System.Action e27)
            {
                NodeStateManager.AddEventHandler(castedNode, "ItemRectChanged", e27);
                castedNode.ItemRectChanged += e27;
            }

            if (Ready is System.Action e28)
            {
                NodeStateManager.AddEventHandler(castedNode, "Ready", e28);
                castedNode.Ready += e28;
            }

            if (Renamed is System.Action e29)
            {
                NodeStateManager.AddEventHandler(castedNode, "Renamed", e29);
                castedNode.Renamed += e29;
            }

            if (TreeEntered is System.Action e30)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeEntered", e30);
                castedNode.TreeEntered += e30;
            }

            if (TreeExiting is System.Action e31)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExiting", e31);
                castedNode.TreeExiting += e31;
            }

            if (TreeExited is System.Action e32)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExited", e32);
                castedNode.TreeExited += e32;
            }

            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e33)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildEnteredTree", e33);
                castedNode.ChildEnteredTree += e33;
            }

            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e34)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildExitingTree", e34);
                castedNode.ChildExitingTree += e34;
            }

            if (ChildOrderChanged is System.Action e35)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildOrderChanged", e35);
                castedNode.ChildOrderChanged += e35;
            }

            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e36)
            {
                NodeStateManager.AddEventHandler(castedNode, "ReplacingBy", e36);
                castedNode.ReplacingBy += e36;
            }

            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e37)
            {
                NodeStateManager.AddEventHandler(castedNode, "EditorDescriptionChanged", e37);
                castedNode.EditorDescriptionChanged += e37;
            }

            if (EditorStateChanged is System.Action e38)
            {
                NodeStateManager.AddEventHandler(castedNode, "EditorStateChanged", e38);
                castedNode.EditorStateChanged += e38;
            }

            if (ScriptChanged is System.Action e39)
            {
                NodeStateManager.AddEventHandler(castedNode, "ScriptChanged", e39);
                castedNode.ScriptChanged += e39;
            }

            if (PropertyListChanged is System.Action e40)
            {
                NodeStateManager.AddEventHandler(castedNode, "PropertyListChanged", e40);
                castedNode.PropertyListChanged += e40;
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