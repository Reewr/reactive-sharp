// This file is auto-generated. Please do not edit
namespace ReactiveSharpGodot.Components
{
    public class ColorPicker : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GColorPicker>
    {
        public Godot.Color? Color { protected get; init; }
        public System.Boolean? EditAlpha { protected get; init; }
        public Godot.ColorPicker.ColorModeType? ColorMode { protected get; init; }
        public System.Boolean? DeferredMode { protected get; init; }
        public Godot.ColorPicker.PickerShapeType? PickerShape { protected get; init; }
        public System.Boolean? CanAddSwatches { protected get; init; }
        public System.Boolean? SamplerVisible { protected get; init; }
        public System.Boolean? ColorModesVisible { protected get; init; }
        public System.Boolean? SlidersVisible { protected get; init; }
        public System.Boolean? HexVisible { protected get; init; }
        public System.Boolean? PresetsVisible { protected get; init; }
        public Godot.BoxContainer.AlignmentMode? Alignment { protected get; init; }
        public System.Boolean? Vertical { protected get; init; }
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
        public Godot.ColorPicker.ColorChangedEventHandler? ColorChanged { protected get; init; }
        public Godot.ColorPicker.PresetAddedEventHandler? PresetAdded { protected get; init; }
        public Godot.ColorPicker.PresetRemovedEventHandler? PresetRemoved { protected get; init; }
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
        public Action<ReactiveSharpGodot.Nodes.GColorPicker>? CustomNodeHandling { protected get; init; }

        public override ReactiveSharpGodot.Nodes.GColorPicker Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GColorPicker();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GColorPicker node)
        {
            var castedNode = (Godot.ColorPicker)node.Node;
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

            if (ColorMode is Godot.ColorPicker.ColorModeType n2)
            {
                NodeStateManager.AddPropertyState(castedNode, "ColorMode", castedNode.ColorMode);
                castedNode.ColorMode = n2;
            }

            if (DeferredMode is System.Boolean n3)
            {
                NodeStateManager.AddPropertyState(castedNode, "DeferredMode", castedNode.DeferredMode);
                castedNode.DeferredMode = n3;
            }

            if (PickerShape is Godot.ColorPicker.PickerShapeType n4)
            {
                NodeStateManager.AddPropertyState(castedNode, "PickerShape", castedNode.PickerShape);
                castedNode.PickerShape = n4;
            }

            if (CanAddSwatches is System.Boolean n5)
            {
                NodeStateManager.AddPropertyState(castedNode, "CanAddSwatches", castedNode.CanAddSwatches);
                castedNode.CanAddSwatches = n5;
            }

            if (SamplerVisible is System.Boolean n6)
            {
                NodeStateManager.AddPropertyState(castedNode, "SamplerVisible", castedNode.SamplerVisible);
                castedNode.SamplerVisible = n6;
            }

            if (ColorModesVisible is System.Boolean n7)
            {
                NodeStateManager.AddPropertyState(castedNode, "ColorModesVisible", castedNode.ColorModesVisible);
                castedNode.ColorModesVisible = n7;
            }

            if (SlidersVisible is System.Boolean n8)
            {
                NodeStateManager.AddPropertyState(castedNode, "SlidersVisible", castedNode.SlidersVisible);
                castedNode.SlidersVisible = n8;
            }

            if (HexVisible is System.Boolean n9)
            {
                NodeStateManager.AddPropertyState(castedNode, "HexVisible", castedNode.HexVisible);
                castedNode.HexVisible = n9;
            }

            if (PresetsVisible is System.Boolean n10)
            {
                NodeStateManager.AddPropertyState(castedNode, "PresetsVisible", castedNode.PresetsVisible);
                castedNode.PresetsVisible = n10;
            }

            if (Alignment is Godot.BoxContainer.AlignmentMode n11)
            {
                NodeStateManager.AddPropertyState(castedNode, "Alignment", castedNode.Alignment);
                castedNode.Alignment = n11;
            }

            if (Vertical is System.Boolean n12)
            {
                NodeStateManager.AddPropertyState(castedNode, "Vertical", castedNode.Vertical);
                castedNode.Vertical = n12;
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

            if (FocusNeighborLeft is Godot.NodePath n41)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborLeft", castedNode.FocusNeighborLeft);
                castedNode.FocusNeighborLeft = n41;
            }

            if (FocusNeighborTop is Godot.NodePath n42)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborTop", castedNode.FocusNeighborTop);
                castedNode.FocusNeighborTop = n42;
            }

            if (FocusNeighborRight is Godot.NodePath n43)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborRight", castedNode.FocusNeighborRight);
                castedNode.FocusNeighborRight = n43;
            }

            if (FocusNeighborBottom is Godot.NodePath n44)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborBottom", castedNode.FocusNeighborBottom);
                castedNode.FocusNeighborBottom = n44;
            }

            if (FocusNext is Godot.NodePath n45)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNext", castedNode.FocusNext);
                castedNode.FocusNext = n45;
            }

            if (FocusPrevious is Godot.NodePath n46)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusPrevious", castedNode.FocusPrevious);
                castedNode.FocusPrevious = n46;
            }

            if (FocusMode is Godot.Control.FocusModeEnum n47)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusMode", castedNode.FocusMode);
                castedNode.FocusMode = n47;
            }

            if (MouseFilter is Godot.Control.MouseFilterEnum n48)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseFilter", castedNode.MouseFilter);
                castedNode.MouseFilter = n48;
            }

            if (MouseForcePassScrollEvents is System.Boolean n49)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseForcePassScrollEvents", castedNode.MouseForcePassScrollEvents);
                castedNode.MouseForcePassScrollEvents = n49;
            }

            if (MouseDefaultCursorShape is Godot.Control.CursorShape n50)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseDefaultCursorShape", castedNode.MouseDefaultCursorShape);
                castedNode.MouseDefaultCursorShape = n50;
            }

            if (ShortcutContext is Godot.Node n51)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutContext", castedNode.ShortcutContext);
                castedNode.ShortcutContext = n51;
            }

            if (Theme is Godot.Theme n52)
            {
                NodeStateManager.AddPropertyState(castedNode, "Theme", castedNode.Theme);
                castedNode.Theme = n52;
            }

            if (ThemeTypeVariation is Godot.StringName n53)
            {
                NodeStateManager.AddPropertyState(castedNode, "ThemeTypeVariation", castedNode.ThemeTypeVariation);
                castedNode.ThemeTypeVariation = n53;
            }

            if (Visible is System.Boolean n54)
            {
                NodeStateManager.AddPropertyState(castedNode, "Visible", castedNode.Visible);
                castedNode.Visible = n54;
            }

            if (Modulate is Godot.Color n55)
            {
                NodeStateManager.AddPropertyState(castedNode, "Modulate", castedNode.Modulate);
                castedNode.Modulate = n55;
            }

            if (SelfModulate is Godot.Color n56)
            {
                NodeStateManager.AddPropertyState(castedNode, "SelfModulate", castedNode.SelfModulate);
                castedNode.SelfModulate = n56;
            }

            if (ShowBehindParent is System.Boolean n57)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowBehindParent", castedNode.ShowBehindParent);
                castedNode.ShowBehindParent = n57;
            }

            if (TopLevel is System.Boolean n58)
            {
                NodeStateManager.AddPropertyState(castedNode, "TopLevel", castedNode.TopLevel);
                castedNode.TopLevel = n58;
            }

            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n59)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipChildren", castedNode.ClipChildren);
                castedNode.ClipChildren = n59;
            }

            if (LightMask is System.Int32 n60)
            {
                NodeStateManager.AddPropertyState(castedNode, "LightMask", castedNode.LightMask);
                castedNode.LightMask = n60;
            }

            if (VisibilityLayer is System.UInt32 n61)
            {
                NodeStateManager.AddPropertyState(castedNode, "VisibilityLayer", castedNode.VisibilityLayer);
                castedNode.VisibilityLayer = n61;
            }

            if (ZIndex is System.Int32 n62)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZIndex", castedNode.ZIndex);
                castedNode.ZIndex = n62;
            }

            if (ZAsRelative is System.Boolean n63)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZAsRelative", castedNode.ZAsRelative);
                castedNode.ZAsRelative = n63;
            }

            if (YSortEnabled is System.Boolean n64)
            {
                NodeStateManager.AddPropertyState(castedNode, "YSortEnabled", castedNode.YSortEnabled);
                castedNode.YSortEnabled = n64;
            }

            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n65)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureFilter", castedNode.TextureFilter);
                castedNode.TextureFilter = n65;
            }

            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n66)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureRepeat", castedNode.TextureRepeat);
                castedNode.TextureRepeat = n66;
            }

            if (Material is Godot.Material n67)
            {
                NodeStateManager.AddPropertyState(castedNode, "Material", castedNode.Material);
                castedNode.Material = n67;
            }

            if (UseParentMaterial is System.Boolean n68)
            {
                NodeStateManager.AddPropertyState(castedNode, "UseParentMaterial", castedNode.UseParentMaterial);
                castedNode.UseParentMaterial = n68;
            }

            if (Name is Godot.StringName n69)
            {
                NodeStateManager.AddPropertyState(castedNode, "Name", castedNode.Name);
                castedNode.Name = n69;
            }

            if (UniqueNameInOwner is System.Boolean n70)
            {
                NodeStateManager.AddPropertyState(castedNode, "UniqueNameInOwner", castedNode.UniqueNameInOwner);
                castedNode.UniqueNameInOwner = n70;
            }

            if (SceneFilePath is System.String n71)
            {
                NodeStateManager.AddPropertyState(castedNode, "SceneFilePath", castedNode.SceneFilePath);
                castedNode.SceneFilePath = n71;
            }

            if (Owner is Godot.Node n72)
            {
                NodeStateManager.AddPropertyState(castedNode, "Owner", castedNode.Owner);
                castedNode.Owner = n72;
            }

            if (ProcessMode is Godot.Node.ProcessModeEnum n73)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessMode", castedNode.ProcessMode);
                castedNode.ProcessMode = n73;
            }

            if (ProcessPriority is System.Int32 n74)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPriority", castedNode.ProcessPriority);
                castedNode.ProcessPriority = n74;
            }

            if (ProcessPhysicsPriority is System.Int32 n75)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPhysicsPriority", castedNode.ProcessPhysicsPriority);
                castedNode.ProcessPhysicsPriority = n75;
            }

            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n76)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroup", castedNode.ProcessThreadGroup);
                castedNode.ProcessThreadGroup = n76;
            }

            if (ProcessThreadGroupOrder is System.Int32 n77)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroupOrder", castedNode.ProcessThreadGroupOrder);
                castedNode.ProcessThreadGroupOrder = n77;
            }

            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n78)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadMessages", castedNode.ProcessThreadMessages);
                castedNode.ProcessThreadMessages = n78;
            }

            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n79)
            {
                NodeStateManager.AddPropertyState(castedNode, "PhysicsInterpolationMode", castedNode.PhysicsInterpolationMode);
                castedNode.PhysicsInterpolationMode = n79;
            }

            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n80)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslateMode", castedNode.AutoTranslateMode);
                castedNode.AutoTranslateMode = n80;
            }

            if (EditorDescription is System.String n81)
            {
                NodeStateManager.AddPropertyState(castedNode, "EditorDescription", castedNode.EditorDescription);
                castedNode.EditorDescription = n81;
            }

            if (ColorChanged is Godot.ColorPicker.ColorChangedEventHandler e0)
            {
                NodeStateManager.AddEventHandler(castedNode, "ColorChanged", e0);
                castedNode.ColorChanged += e0;
            }

            if (PresetAdded is Godot.ColorPicker.PresetAddedEventHandler e1)
            {
                NodeStateManager.AddEventHandler(castedNode, "PresetAdded", e1);
                castedNode.PresetAdded += e1;
            }

            if (PresetRemoved is Godot.ColorPicker.PresetRemovedEventHandler e2)
            {
                NodeStateManager.AddEventHandler(castedNode, "PresetRemoved", e2);
                castedNode.PresetRemoved += e2;
            }

            if (PreSortChildren is System.Action e3)
            {
                NodeStateManager.AddEventHandler(castedNode, "PreSortChildren", e3);
                castedNode.PreSortChildren += e3;
            }

            if (SortChildren is System.Action e4)
            {
                NodeStateManager.AddEventHandler(castedNode, "SortChildren", e4);
                castedNode.SortChildren += e4;
            }

            if (Resized is System.Action e5)
            {
                NodeStateManager.AddEventHandler(castedNode, "Resized", e5);
                castedNode.Resized += e5;
            }

            if (GuiInput is Godot.Control.GuiInputEventHandler e6)
            {
                NodeStateManager.AddEventHandler(castedNode, "GuiInput", e6);
                castedNode.GuiInput += e6;
            }

            if (MouseEntered is System.Action e7)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseEntered", e7);
                castedNode.MouseEntered += e7;
            }

            if (MouseExited is System.Action e8)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseExited", e8);
                castedNode.MouseExited += e8;
            }

            if (FocusEntered is System.Action e9)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusEntered", e9);
                castedNode.FocusEntered += e9;
            }

            if (FocusExited is System.Action e10)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusExited", e10);
                castedNode.FocusExited += e10;
            }

            if (SizeFlagsChanged is System.Action e11)
            {
                NodeStateManager.AddEventHandler(castedNode, "SizeFlagsChanged", e11);
                castedNode.SizeFlagsChanged += e11;
            }

            if (MinimumSizeChanged is System.Action e12)
            {
                NodeStateManager.AddEventHandler(castedNode, "MinimumSizeChanged", e12);
                castedNode.MinimumSizeChanged += e12;
            }

            if (ThemeChanged is System.Action e13)
            {
                NodeStateManager.AddEventHandler(castedNode, "ThemeChanged", e13);
                castedNode.ThemeChanged += e13;
            }

            if (Draw is System.Action e14)
            {
                NodeStateManager.AddEventHandler(castedNode, "Draw", e14);
                castedNode.Draw += e14;
            }

            if (VisibilityChanged is System.Action e15)
            {
                NodeStateManager.AddEventHandler(castedNode, "VisibilityChanged", e15);
                castedNode.VisibilityChanged += e15;
            }

            if (Hidden is System.Action e16)
            {
                NodeStateManager.AddEventHandler(castedNode, "Hidden", e16);
                castedNode.Hidden += e16;
            }

            if (ItemRectChanged is System.Action e17)
            {
                NodeStateManager.AddEventHandler(castedNode, "ItemRectChanged", e17);
                castedNode.ItemRectChanged += e17;
            }

            if (Ready is System.Action e18)
            {
                NodeStateManager.AddEventHandler(castedNode, "Ready", e18);
                castedNode.Ready += e18;
            }

            if (Renamed is System.Action e19)
            {
                NodeStateManager.AddEventHandler(castedNode, "Renamed", e19);
                castedNode.Renamed += e19;
            }

            if (TreeEntered is System.Action e20)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeEntered", e20);
                castedNode.TreeEntered += e20;
            }

            if (TreeExiting is System.Action e21)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExiting", e21);
                castedNode.TreeExiting += e21;
            }

            if (TreeExited is System.Action e22)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExited", e22);
                castedNode.TreeExited += e22;
            }

            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e23)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildEnteredTree", e23);
                castedNode.ChildEnteredTree += e23;
            }

            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e24)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildExitingTree", e24);
                castedNode.ChildExitingTree += e24;
            }

            if (ChildOrderChanged is System.Action e25)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildOrderChanged", e25);
                castedNode.ChildOrderChanged += e25;
            }

            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e26)
            {
                NodeStateManager.AddEventHandler(castedNode, "ReplacingBy", e26);
                castedNode.ReplacingBy += e26;
            }

            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e27)
            {
                NodeStateManager.AddEventHandler(castedNode, "EditorDescriptionChanged", e27);
                castedNode.EditorDescriptionChanged += e27;
            }

            if (ScriptChanged is System.Action e28)
            {
                NodeStateManager.AddEventHandler(castedNode, "ScriptChanged", e28);
                castedNode.ScriptChanged += e28;
            }

            if (PropertyListChanged is System.Action e29)
            {
                NodeStateManager.AddEventHandler(castedNode, "PropertyListChanged", e29);
                castedNode.PropertyListChanged += e29;
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