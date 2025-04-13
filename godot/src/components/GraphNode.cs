// This file is auto-generated. Please do not edit
namespace ReactiveSharpGodot.Components
{
    public class GraphNode : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GGraphNode>
    {
        public System.String? Title { protected get; init; }
        public System.Boolean? IgnoreInvalidConnectionType { protected get; init; }
        public Godot.Vector2? PositionOffset { protected get; init; }
        public System.Boolean? Resizable { protected get; init; }
        public System.Boolean? Draggable { protected get; init; }
        public System.Boolean? Selectable { protected get; init; }
        public System.Boolean? Selected { protected get; init; }
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
        public System.Action? CloseRequest { protected get; init; }
        public Godot.GraphNode.SlotUpdatedEventHandler? SlotUpdated { protected get; init; }
        public System.Action? NodeSelected { protected get; init; }
        public System.Action? NodeDeselected { protected get; init; }
        public System.Action? RaiseRequest { protected get; init; }
        public System.Action? DeleteRequest { protected get; init; }
        public Godot.GraphElement.ResizeRequestEventHandler? ResizeRequest { protected get; init; }
        public Godot.GraphElement.ResizeEndEventHandler? ResizeEnd { protected get; init; }
        public Godot.GraphElement.DraggedEventHandler? Dragged { protected get; init; }
        public System.Action? PositionOffsetChanged { protected get; init; }
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
        public Action<ReactiveSharpGodot.Nodes.GGraphNode>? CustomNodeHandling { protected get; init; }

        public override ReactiveSharpGodot.Nodes.GGraphNode Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GGraphNode();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GGraphNode node)
        {
            var castedNode = (Godot.GraphNode)node.Node;
            if (Title is System.String n0)
            {
                NodeStateManager.AddPropertyState(castedNode, "Title", castedNode.Title);
                castedNode.Title = n0;
            }

            if (IgnoreInvalidConnectionType is System.Boolean n1)
            {
                NodeStateManager.AddPropertyState(castedNode, "IgnoreInvalidConnectionType", castedNode.IgnoreInvalidConnectionType);
                castedNode.IgnoreInvalidConnectionType = n1;
            }

            if (PositionOffset is Godot.Vector2 n2)
            {
                NodeStateManager.AddPropertyState(castedNode, "PositionOffset", castedNode.PositionOffset);
                castedNode.PositionOffset = n2;
            }

            if (Resizable is System.Boolean n3)
            {
                NodeStateManager.AddPropertyState(castedNode, "Resizable", castedNode.Resizable);
                castedNode.Resizable = n3;
            }

            if (Draggable is System.Boolean n4)
            {
                NodeStateManager.AddPropertyState(castedNode, "Draggable", castedNode.Draggable);
                castedNode.Draggable = n4;
            }

            if (Selectable is System.Boolean n5)
            {
                NodeStateManager.AddPropertyState(castedNode, "Selectable", castedNode.Selectable);
                castedNode.Selectable = n5;
            }

            if (Selected is System.Boolean n6)
            {
                NodeStateManager.AddPropertyState(castedNode, "Selected", castedNode.Selected);
                castedNode.Selected = n6;
            }

            if (ClipContents is System.Boolean n7)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipContents", castedNode.ClipContents);
                castedNode.ClipContents = n7;
            }

            if (CustomMinimumSize is Godot.Vector2 n8)
            {
                NodeStateManager.AddPropertyState(castedNode, "CustomMinimumSize", castedNode.CustomMinimumSize);
                castedNode.CustomMinimumSize = n8;
            }

            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n9)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutDirection", castedNode.LayoutDirection);
                castedNode.LayoutDirection = n9;
            }

            if (LayoutMode is System.Int32 n10)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutMode", castedNode.LayoutMode);
                castedNode.LayoutMode = n10;
            }

            if (AnchorsPreset is System.Int32 n11)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorsPreset", castedNode.AnchorsPreset);
                castedNode.AnchorsPreset = n11;
            }

            if (AnchorLeft is System.Single n12)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorLeft", castedNode.AnchorLeft);
                castedNode.AnchorLeft = n12;
            }

            if (AnchorTop is System.Single n13)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorTop", castedNode.AnchorTop);
                castedNode.AnchorTop = n13;
            }

            if (AnchorRight is System.Single n14)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorRight", castedNode.AnchorRight);
                castedNode.AnchorRight = n14;
            }

            if (AnchorBottom is System.Single n15)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorBottom", castedNode.AnchorBottom);
                castedNode.AnchorBottom = n15;
            }

            if (OffsetLeft is System.Single n16)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetLeft", castedNode.OffsetLeft);
                castedNode.OffsetLeft = n16;
            }

            if (OffsetTop is System.Single n17)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetTop", castedNode.OffsetTop);
                castedNode.OffsetTop = n17;
            }

            if (OffsetRight is System.Single n18)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetRight", castedNode.OffsetRight);
                castedNode.OffsetRight = n18;
            }

            if (OffsetBottom is System.Single n19)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetBottom", castedNode.OffsetBottom);
                castedNode.OffsetBottom = n19;
            }

            if (GrowHorizontal is Godot.Control.GrowDirection n20)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowHorizontal", castedNode.GrowHorizontal);
                castedNode.GrowHorizontal = n20;
            }

            if (GrowVertical is Godot.Control.GrowDirection n21)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowVertical", castedNode.GrowVertical);
                castedNode.GrowVertical = n21;
            }

            if (Size is Godot.Vector2 n22)
            {
                NodeStateManager.AddPropertyState(castedNode, "Size", castedNode.Size);
                castedNode.Size = n22;
            }

            if (Position is Godot.Vector2 n23)
            {
                NodeStateManager.AddPropertyState(castedNode, "Position", castedNode.Position);
                castedNode.Position = n23;
            }

            if (GlobalPosition is Godot.Vector2 n24)
            {
                NodeStateManager.AddPropertyState(castedNode, "GlobalPosition", castedNode.GlobalPosition);
                castedNode.GlobalPosition = n24;
            }

            if (Rotation is System.Single n25)
            {
                NodeStateManager.AddPropertyState(castedNode, "Rotation", castedNode.Rotation);
                castedNode.Rotation = n25;
            }

            if (RotationDegrees is System.Single n26)
            {
                NodeStateManager.AddPropertyState(castedNode, "RotationDegrees", castedNode.RotationDegrees);
                castedNode.RotationDegrees = n26;
            }

            if (Scale is Godot.Vector2 n27)
            {
                NodeStateManager.AddPropertyState(castedNode, "Scale", castedNode.Scale);
                castedNode.Scale = n27;
            }

            if (PivotOffset is Godot.Vector2 n28)
            {
                NodeStateManager.AddPropertyState(castedNode, "PivotOffset", castedNode.PivotOffset);
                castedNode.PivotOffset = n28;
            }

            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n29)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsHorizontal", castedNode.SizeFlagsHorizontal);
                castedNode.SizeFlagsHorizontal = n29;
            }

            if (SizeFlagsVertical is Godot.Control.SizeFlags n30)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsVertical", castedNode.SizeFlagsVertical);
                castedNode.SizeFlagsVertical = n30;
            }

            if (SizeFlagsStretchRatio is System.Single n31)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsStretchRatio", castedNode.SizeFlagsStretchRatio);
                castedNode.SizeFlagsStretchRatio = n31;
            }

            if (LocalizeNumeralSystem is System.Boolean n32)
            {
                NodeStateManager.AddPropertyState(castedNode, "LocalizeNumeralSystem", castedNode.LocalizeNumeralSystem);
                castedNode.LocalizeNumeralSystem = n32;
            }

            if (AutoTranslate is System.Boolean n33)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslate", castedNode.AutoTranslate);
                castedNode.AutoTranslate = n33;
            }

            if (TooltipText is System.String n34)
            {
                NodeStateManager.AddPropertyState(castedNode, "TooltipText", castedNode.TooltipText);
                castedNode.TooltipText = n34;
            }

            if (TooltipAutoTranslateMode is Godot.Node.AutoTranslateModeEnum n35)
            {
                NodeStateManager.AddPropertyState(castedNode, "TooltipAutoTranslateMode", castedNode.TooltipAutoTranslateMode);
                castedNode.TooltipAutoTranslateMode = n35;
            }

            if (FocusNeighborLeft is Godot.NodePath n36)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborLeft", castedNode.FocusNeighborLeft);
                castedNode.FocusNeighborLeft = n36;
            }

            if (FocusNeighborTop is Godot.NodePath n37)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborTop", castedNode.FocusNeighborTop);
                castedNode.FocusNeighborTop = n37;
            }

            if (FocusNeighborRight is Godot.NodePath n38)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborRight", castedNode.FocusNeighborRight);
                castedNode.FocusNeighborRight = n38;
            }

            if (FocusNeighborBottom is Godot.NodePath n39)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborBottom", castedNode.FocusNeighborBottom);
                castedNode.FocusNeighborBottom = n39;
            }

            if (FocusNext is Godot.NodePath n40)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNext", castedNode.FocusNext);
                castedNode.FocusNext = n40;
            }

            if (FocusPrevious is Godot.NodePath n41)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusPrevious", castedNode.FocusPrevious);
                castedNode.FocusPrevious = n41;
            }

            if (FocusMode is Godot.Control.FocusModeEnum n42)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusMode", castedNode.FocusMode);
                castedNode.FocusMode = n42;
            }

            if (MouseFilter is Godot.Control.MouseFilterEnum n43)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseFilter", castedNode.MouseFilter);
                castedNode.MouseFilter = n43;
            }

            if (MouseForcePassScrollEvents is System.Boolean n44)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseForcePassScrollEvents", castedNode.MouseForcePassScrollEvents);
                castedNode.MouseForcePassScrollEvents = n44;
            }

            if (MouseDefaultCursorShape is Godot.Control.CursorShape n45)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseDefaultCursorShape", castedNode.MouseDefaultCursorShape);
                castedNode.MouseDefaultCursorShape = n45;
            }

            if (ShortcutContext is Godot.Node n46)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutContext", castedNode.ShortcutContext);
                castedNode.ShortcutContext = n46;
            }

            if (Theme is Godot.Theme n47)
            {
                NodeStateManager.AddPropertyState(castedNode, "Theme", castedNode.Theme);
                castedNode.Theme = n47;
            }

            if (ThemeTypeVariation is Godot.StringName n48)
            {
                NodeStateManager.AddPropertyState(castedNode, "ThemeTypeVariation", castedNode.ThemeTypeVariation);
                castedNode.ThemeTypeVariation = n48;
            }

            if (Visible is System.Boolean n49)
            {
                NodeStateManager.AddPropertyState(castedNode, "Visible", castedNode.Visible);
                castedNode.Visible = n49;
            }

            if (Modulate is Godot.Color n50)
            {
                NodeStateManager.AddPropertyState(castedNode, "Modulate", castedNode.Modulate);
                castedNode.Modulate = n50;
            }

            if (SelfModulate is Godot.Color n51)
            {
                NodeStateManager.AddPropertyState(castedNode, "SelfModulate", castedNode.SelfModulate);
                castedNode.SelfModulate = n51;
            }

            if (ShowBehindParent is System.Boolean n52)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowBehindParent", castedNode.ShowBehindParent);
                castedNode.ShowBehindParent = n52;
            }

            if (TopLevel is System.Boolean n53)
            {
                NodeStateManager.AddPropertyState(castedNode, "TopLevel", castedNode.TopLevel);
                castedNode.TopLevel = n53;
            }

            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n54)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipChildren", castedNode.ClipChildren);
                castedNode.ClipChildren = n54;
            }

            if (LightMask is System.Int32 n55)
            {
                NodeStateManager.AddPropertyState(castedNode, "LightMask", castedNode.LightMask);
                castedNode.LightMask = n55;
            }

            if (VisibilityLayer is System.UInt32 n56)
            {
                NodeStateManager.AddPropertyState(castedNode, "VisibilityLayer", castedNode.VisibilityLayer);
                castedNode.VisibilityLayer = n56;
            }

            if (ZIndex is System.Int32 n57)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZIndex", castedNode.ZIndex);
                castedNode.ZIndex = n57;
            }

            if (ZAsRelative is System.Boolean n58)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZAsRelative", castedNode.ZAsRelative);
                castedNode.ZAsRelative = n58;
            }

            if (YSortEnabled is System.Boolean n59)
            {
                NodeStateManager.AddPropertyState(castedNode, "YSortEnabled", castedNode.YSortEnabled);
                castedNode.YSortEnabled = n59;
            }

            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n60)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureFilter", castedNode.TextureFilter);
                castedNode.TextureFilter = n60;
            }

            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n61)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureRepeat", castedNode.TextureRepeat);
                castedNode.TextureRepeat = n61;
            }

            if (Material is Godot.Material n62)
            {
                NodeStateManager.AddPropertyState(castedNode, "Material", castedNode.Material);
                castedNode.Material = n62;
            }

            if (UseParentMaterial is System.Boolean n63)
            {
                NodeStateManager.AddPropertyState(castedNode, "UseParentMaterial", castedNode.UseParentMaterial);
                castedNode.UseParentMaterial = n63;
            }

            if (Name is Godot.StringName n64)
            {
                NodeStateManager.AddPropertyState(castedNode, "Name", castedNode.Name);
                castedNode.Name = n64;
            }

            if (UniqueNameInOwner is System.Boolean n65)
            {
                NodeStateManager.AddPropertyState(castedNode, "UniqueNameInOwner", castedNode.UniqueNameInOwner);
                castedNode.UniqueNameInOwner = n65;
            }

            if (SceneFilePath is System.String n66)
            {
                NodeStateManager.AddPropertyState(castedNode, "SceneFilePath", castedNode.SceneFilePath);
                castedNode.SceneFilePath = n66;
            }

            if (Owner is Godot.Node n67)
            {
                NodeStateManager.AddPropertyState(castedNode, "Owner", castedNode.Owner);
                castedNode.Owner = n67;
            }

            if (ProcessMode is Godot.Node.ProcessModeEnum n68)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessMode", castedNode.ProcessMode);
                castedNode.ProcessMode = n68;
            }

            if (ProcessPriority is System.Int32 n69)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPriority", castedNode.ProcessPriority);
                castedNode.ProcessPriority = n69;
            }

            if (ProcessPhysicsPriority is System.Int32 n70)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPhysicsPriority", castedNode.ProcessPhysicsPriority);
                castedNode.ProcessPhysicsPriority = n70;
            }

            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n71)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroup", castedNode.ProcessThreadGroup);
                castedNode.ProcessThreadGroup = n71;
            }

            if (ProcessThreadGroupOrder is System.Int32 n72)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroupOrder", castedNode.ProcessThreadGroupOrder);
                castedNode.ProcessThreadGroupOrder = n72;
            }

            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n73)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadMessages", castedNode.ProcessThreadMessages);
                castedNode.ProcessThreadMessages = n73;
            }

            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n74)
            {
                NodeStateManager.AddPropertyState(castedNode, "PhysicsInterpolationMode", castedNode.PhysicsInterpolationMode);
                castedNode.PhysicsInterpolationMode = n74;
            }

            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n75)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslateMode", castedNode.AutoTranslateMode);
                castedNode.AutoTranslateMode = n75;
            }

            if (EditorDescription is System.String n76)
            {
                NodeStateManager.AddPropertyState(castedNode, "EditorDescription", castedNode.EditorDescription);
                castedNode.EditorDescription = n76;
            }

            if (CloseRequest is System.Action e0)
            {
                NodeStateManager.AddEventHandler(castedNode, "CloseRequest", e0);
                castedNode.CloseRequest += e0;
            }

            if (SlotUpdated is Godot.GraphNode.SlotUpdatedEventHandler e1)
            {
                NodeStateManager.AddEventHandler(castedNode, "SlotUpdated", e1);
                castedNode.SlotUpdated += e1;
            }

            if (NodeSelected is System.Action e2)
            {
                NodeStateManager.AddEventHandler(castedNode, "NodeSelected", e2);
                castedNode.NodeSelected += e2;
            }

            if (NodeDeselected is System.Action e3)
            {
                NodeStateManager.AddEventHandler(castedNode, "NodeDeselected", e3);
                castedNode.NodeDeselected += e3;
            }

            if (RaiseRequest is System.Action e4)
            {
                NodeStateManager.AddEventHandler(castedNode, "RaiseRequest", e4);
                castedNode.RaiseRequest += e4;
            }

            if (DeleteRequest is System.Action e5)
            {
                NodeStateManager.AddEventHandler(castedNode, "DeleteRequest", e5);
                castedNode.DeleteRequest += e5;
            }

            if (ResizeRequest is Godot.GraphElement.ResizeRequestEventHandler e6)
            {
                NodeStateManager.AddEventHandler(castedNode, "ResizeRequest", e6);
                castedNode.ResizeRequest += e6;
            }

            if (ResizeEnd is Godot.GraphElement.ResizeEndEventHandler e7)
            {
                NodeStateManager.AddEventHandler(castedNode, "ResizeEnd", e7);
                castedNode.ResizeEnd += e7;
            }

            if (Dragged is Godot.GraphElement.DraggedEventHandler e8)
            {
                NodeStateManager.AddEventHandler(castedNode, "Dragged", e8);
                castedNode.Dragged += e8;
            }

            if (PositionOffsetChanged is System.Action e9)
            {
                NodeStateManager.AddEventHandler(castedNode, "PositionOffsetChanged", e9);
                castedNode.PositionOffsetChanged += e9;
            }

            if (PreSortChildren is System.Action e10)
            {
                NodeStateManager.AddEventHandler(castedNode, "PreSortChildren", e10);
                castedNode.PreSortChildren += e10;
            }

            if (SortChildren is System.Action e11)
            {
                NodeStateManager.AddEventHandler(castedNode, "SortChildren", e11);
                castedNode.SortChildren += e11;
            }

            if (Resized is System.Action e12)
            {
                NodeStateManager.AddEventHandler(castedNode, "Resized", e12);
                castedNode.Resized += e12;
            }

            if (GuiInput is Godot.Control.GuiInputEventHandler e13)
            {
                NodeStateManager.AddEventHandler(castedNode, "GuiInput", e13);
                castedNode.GuiInput += e13;
            }

            if (MouseEntered is System.Action e14)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseEntered", e14);
                castedNode.MouseEntered += e14;
            }

            if (MouseExited is System.Action e15)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseExited", e15);
                castedNode.MouseExited += e15;
            }

            if (FocusEntered is System.Action e16)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusEntered", e16);
                castedNode.FocusEntered += e16;
            }

            if (FocusExited is System.Action e17)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusExited", e17);
                castedNode.FocusExited += e17;
            }

            if (SizeFlagsChanged is System.Action e18)
            {
                NodeStateManager.AddEventHandler(castedNode, "SizeFlagsChanged", e18);
                castedNode.SizeFlagsChanged += e18;
            }

            if (MinimumSizeChanged is System.Action e19)
            {
                NodeStateManager.AddEventHandler(castedNode, "MinimumSizeChanged", e19);
                castedNode.MinimumSizeChanged += e19;
            }

            if (ThemeChanged is System.Action e20)
            {
                NodeStateManager.AddEventHandler(castedNode, "ThemeChanged", e20);
                castedNode.ThemeChanged += e20;
            }

            if (Draw is System.Action e21)
            {
                NodeStateManager.AddEventHandler(castedNode, "Draw", e21);
                castedNode.Draw += e21;
            }

            if (VisibilityChanged is System.Action e22)
            {
                NodeStateManager.AddEventHandler(castedNode, "VisibilityChanged", e22);
                castedNode.VisibilityChanged += e22;
            }

            if (Hidden is System.Action e23)
            {
                NodeStateManager.AddEventHandler(castedNode, "Hidden", e23);
                castedNode.Hidden += e23;
            }

            if (ItemRectChanged is System.Action e24)
            {
                NodeStateManager.AddEventHandler(castedNode, "ItemRectChanged", e24);
                castedNode.ItemRectChanged += e24;
            }

            if (Ready is System.Action e25)
            {
                NodeStateManager.AddEventHandler(castedNode, "Ready", e25);
                castedNode.Ready += e25;
            }

            if (Renamed is System.Action e26)
            {
                NodeStateManager.AddEventHandler(castedNode, "Renamed", e26);
                castedNode.Renamed += e26;
            }

            if (TreeEntered is System.Action e27)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeEntered", e27);
                castedNode.TreeEntered += e27;
            }

            if (TreeExiting is System.Action e28)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExiting", e28);
                castedNode.TreeExiting += e28;
            }

            if (TreeExited is System.Action e29)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExited", e29);
                castedNode.TreeExited += e29;
            }

            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e30)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildEnteredTree", e30);
                castedNode.ChildEnteredTree += e30;
            }

            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e31)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildExitingTree", e31);
                castedNode.ChildExitingTree += e31;
            }

            if (ChildOrderChanged is System.Action e32)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildOrderChanged", e32);
                castedNode.ChildOrderChanged += e32;
            }

            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e33)
            {
                NodeStateManager.AddEventHandler(castedNode, "ReplacingBy", e33);
                castedNode.ReplacingBy += e33;
            }

            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e34)
            {
                NodeStateManager.AddEventHandler(castedNode, "EditorDescriptionChanged", e34);
                castedNode.EditorDescriptionChanged += e34;
            }

            if (EditorStateChanged is System.Action e35)
            {
                NodeStateManager.AddEventHandler(castedNode, "EditorStateChanged", e35);
                castedNode.EditorStateChanged += e35;
            }

            if (ScriptChanged is System.Action e36)
            {
                NodeStateManager.AddEventHandler(castedNode, "ScriptChanged", e36);
                castedNode.ScriptChanged += e36;
            }

            if (PropertyListChanged is System.Action e37)
            {
                NodeStateManager.AddEventHandler(castedNode, "PropertyListChanged", e37);
                castedNode.PropertyListChanged += e37;
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