// This file is auto-generated. Please do not edit
namespace ReactiveSharpGodot.Components
{
    public class GraphEdit : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GGraphEdit>
    {
        public System.Boolean? ArrangeNodesButtonHidden { protected get; init; }
        public System.Int32? SnapDistance { protected get; init; }
        public System.Boolean? UseSnap { protected get; init; }
        public Godot.Vector2? ScrollOffset { protected get; init; }
        public System.Boolean? ShowGrid { protected get; init; }
        public Godot.GraphEdit.GridPatternEnum? GridPattern { protected get; init; }
        public System.Boolean? SnappingEnabled { protected get; init; }
        public System.Int32? SnappingDistance { protected get; init; }
        public Godot.GraphEdit.PanningSchemeEnum? PanningScheme { protected get; init; }
        public System.Boolean? RightDisconnects { protected get; init; }
        public System.Single? ConnectionLinesCurvature { protected get; init; }
        public System.Single? ConnectionLinesThickness { protected get; init; }
        public System.Boolean? ConnectionLinesAntialiased { protected get; init; }
        public Godot.Collections.Array<Godot.Collections.Dictionary>? Connections { protected get; init; }
        public System.Single? Zoom { protected get; init; }
        public System.Single? ZoomMin { protected get; init; }
        public System.Single? ZoomMax { protected get; init; }
        public System.Single? ZoomStep { protected get; init; }
        public System.Boolean? MinimapEnabled { protected get; init; }
        public Godot.Vector2? MinimapSize { protected get; init; }
        public System.Single? MinimapOpacity { protected get; init; }
        public System.Boolean? ShowMenu { protected get; init; }
        public System.Boolean? ShowZoomLabel { protected get; init; }
        public System.Boolean? ShowZoomButtons { protected get; init; }
        public System.Boolean? ShowGridButtons { protected get; init; }
        public System.Boolean? ShowMinimapButton { protected get; init; }
        public System.Boolean? ShowArrangeButton { protected get; init; }
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
        public Godot.GraphEdit.ConnectionRequestEventHandler? ConnectionRequest { protected get; init; }
        public Godot.GraphEdit.DisconnectionRequestEventHandler? DisconnectionRequest { protected get; init; }
        public Godot.GraphEdit.ConnectionToEmptyEventHandler? ConnectionToEmpty { protected get; init; }
        public Godot.GraphEdit.ConnectionFromEmptyEventHandler? ConnectionFromEmpty { protected get; init; }
        public Godot.GraphEdit.ConnectionDragStartedEventHandler? ConnectionDragStarted { protected get; init; }
        public System.Action? ConnectionDragEnded { protected get; init; }
        public System.Action? CopyNodesRequest { protected get; init; }
        public System.Action? CutNodesRequest { protected get; init; }
        public System.Action? PasteNodesRequest { protected get; init; }
        public System.Action? DuplicateNodesRequest { protected get; init; }
        public Godot.GraphEdit.DeleteNodesRequestEventHandler? DeleteNodesRequest { protected get; init; }
        public Godot.GraphEdit.NodeSelectedEventHandler? NodeSelected { protected get; init; }
        public Godot.GraphEdit.NodeDeselectedEventHandler? NodeDeselected { protected get; init; }
        public Godot.GraphEdit.FrameRectChangedEventHandler? FrameRectChanged { protected get; init; }
        public Godot.GraphEdit.PopupRequestEventHandler? PopupRequest { protected get; init; }
        public System.Action? BeginNodeMove { protected get; init; }
        public System.Action? EndNodeMove { protected get; init; }
        public Godot.GraphEdit.GraphElementsLinkedToFrameRequestEventHandler? GraphElementsLinkedToFrameRequest { protected get; init; }
        public Godot.GraphEdit.ScrollOffsetChangedEventHandler? ScrollOffsetChanged { protected get; init; }
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
        public Action<ReactiveSharpGodot.Nodes.GGraphEdit>? CustomNodeHandling { protected get; init; }

        public override ReactiveSharpGodot.Nodes.GGraphEdit Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GGraphEdit();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GGraphEdit node)
        {
            var castedNode = (Godot.GraphEdit)node.Node;
            if (ArrangeNodesButtonHidden is System.Boolean n0)
            {
                NodeStateManager.AddPropertyState(castedNode, "ArrangeNodesButtonHidden", castedNode.ArrangeNodesButtonHidden);
                castedNode.ArrangeNodesButtonHidden = n0;
            }

            if (SnapDistance is System.Int32 n1)
            {
                NodeStateManager.AddPropertyState(castedNode, "SnapDistance", castedNode.SnapDistance);
                castedNode.SnapDistance = n1;
            }

            if (UseSnap is System.Boolean n2)
            {
                NodeStateManager.AddPropertyState(castedNode, "UseSnap", castedNode.UseSnap);
                castedNode.UseSnap = n2;
            }

            if (ScrollOffset is Godot.Vector2 n3)
            {
                NodeStateManager.AddPropertyState(castedNode, "ScrollOffset", castedNode.ScrollOffset);
                castedNode.ScrollOffset = n3;
            }

            if (ShowGrid is System.Boolean n4)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowGrid", castedNode.ShowGrid);
                castedNode.ShowGrid = n4;
            }

            if (GridPattern is Godot.GraphEdit.GridPatternEnum n5)
            {
                NodeStateManager.AddPropertyState(castedNode, "GridPattern", castedNode.GridPattern);
                castedNode.GridPattern = n5;
            }

            if (SnappingEnabled is System.Boolean n6)
            {
                NodeStateManager.AddPropertyState(castedNode, "SnappingEnabled", castedNode.SnappingEnabled);
                castedNode.SnappingEnabled = n6;
            }

            if (SnappingDistance is System.Int32 n7)
            {
                NodeStateManager.AddPropertyState(castedNode, "SnappingDistance", castedNode.SnappingDistance);
                castedNode.SnappingDistance = n7;
            }

            if (PanningScheme is Godot.GraphEdit.PanningSchemeEnum n8)
            {
                NodeStateManager.AddPropertyState(castedNode, "PanningScheme", castedNode.PanningScheme);
                castedNode.PanningScheme = n8;
            }

            if (RightDisconnects is System.Boolean n9)
            {
                NodeStateManager.AddPropertyState(castedNode, "RightDisconnects", castedNode.RightDisconnects);
                castedNode.RightDisconnects = n9;
            }

            if (ConnectionLinesCurvature is System.Single n10)
            {
                NodeStateManager.AddPropertyState(castedNode, "ConnectionLinesCurvature", castedNode.ConnectionLinesCurvature);
                castedNode.ConnectionLinesCurvature = n10;
            }

            if (ConnectionLinesThickness is System.Single n11)
            {
                NodeStateManager.AddPropertyState(castedNode, "ConnectionLinesThickness", castedNode.ConnectionLinesThickness);
                castedNode.ConnectionLinesThickness = n11;
            }

            if (ConnectionLinesAntialiased is System.Boolean n12)
            {
                NodeStateManager.AddPropertyState(castedNode, "ConnectionLinesAntialiased", castedNode.ConnectionLinesAntialiased);
                castedNode.ConnectionLinesAntialiased = n12;
            }

            if (Connections is Godot.Collections.Array<Godot.Collections.Dictionary> n13)
            {
                NodeStateManager.AddPropertyState(castedNode, "Connections", castedNode.Connections);
                castedNode.Connections = n13;
            }

            if (Zoom is System.Single n14)
            {
                NodeStateManager.AddPropertyState(castedNode, "Zoom", castedNode.Zoom);
                castedNode.Zoom = n14;
            }

            if (ZoomMin is System.Single n15)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZoomMin", castedNode.ZoomMin);
                castedNode.ZoomMin = n15;
            }

            if (ZoomMax is System.Single n16)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZoomMax", castedNode.ZoomMax);
                castedNode.ZoomMax = n16;
            }

            if (ZoomStep is System.Single n17)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZoomStep", castedNode.ZoomStep);
                castedNode.ZoomStep = n17;
            }

            if (MinimapEnabled is System.Boolean n18)
            {
                NodeStateManager.AddPropertyState(castedNode, "MinimapEnabled", castedNode.MinimapEnabled);
                castedNode.MinimapEnabled = n18;
            }

            if (MinimapSize is Godot.Vector2 n19)
            {
                NodeStateManager.AddPropertyState(castedNode, "MinimapSize", castedNode.MinimapSize);
                castedNode.MinimapSize = n19;
            }

            if (MinimapOpacity is System.Single n20)
            {
                NodeStateManager.AddPropertyState(castedNode, "MinimapOpacity", castedNode.MinimapOpacity);
                castedNode.MinimapOpacity = n20;
            }

            if (ShowMenu is System.Boolean n21)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowMenu", castedNode.ShowMenu);
                castedNode.ShowMenu = n21;
            }

            if (ShowZoomLabel is System.Boolean n22)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowZoomLabel", castedNode.ShowZoomLabel);
                castedNode.ShowZoomLabel = n22;
            }

            if (ShowZoomButtons is System.Boolean n23)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowZoomButtons", castedNode.ShowZoomButtons);
                castedNode.ShowZoomButtons = n23;
            }

            if (ShowGridButtons is System.Boolean n24)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowGridButtons", castedNode.ShowGridButtons);
                castedNode.ShowGridButtons = n24;
            }

            if (ShowMinimapButton is System.Boolean n25)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowMinimapButton", castedNode.ShowMinimapButton);
                castedNode.ShowMinimapButton = n25;
            }

            if (ShowArrangeButton is System.Boolean n26)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowArrangeButton", castedNode.ShowArrangeButton);
                castedNode.ShowArrangeButton = n26;
            }

            if (ClipContents is System.Boolean n27)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipContents", castedNode.ClipContents);
                castedNode.ClipContents = n27;
            }

            if (CustomMinimumSize is Godot.Vector2 n28)
            {
                NodeStateManager.AddPropertyState(castedNode, "CustomMinimumSize", castedNode.CustomMinimumSize);
                castedNode.CustomMinimumSize = n28;
            }

            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n29)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutDirection", castedNode.LayoutDirection);
                castedNode.LayoutDirection = n29;
            }

            if (LayoutMode is System.Int32 n30)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutMode", castedNode.LayoutMode);
                castedNode.LayoutMode = n30;
            }

            if (AnchorsPreset is System.Int32 n31)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorsPreset", castedNode.AnchorsPreset);
                castedNode.AnchorsPreset = n31;
            }

            if (AnchorLeft is System.Single n32)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorLeft", castedNode.AnchorLeft);
                castedNode.AnchorLeft = n32;
            }

            if (AnchorTop is System.Single n33)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorTop", castedNode.AnchorTop);
                castedNode.AnchorTop = n33;
            }

            if (AnchorRight is System.Single n34)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorRight", castedNode.AnchorRight);
                castedNode.AnchorRight = n34;
            }

            if (AnchorBottom is System.Single n35)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorBottom", castedNode.AnchorBottom);
                castedNode.AnchorBottom = n35;
            }

            if (OffsetLeft is System.Single n36)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetLeft", castedNode.OffsetLeft);
                castedNode.OffsetLeft = n36;
            }

            if (OffsetTop is System.Single n37)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetTop", castedNode.OffsetTop);
                castedNode.OffsetTop = n37;
            }

            if (OffsetRight is System.Single n38)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetRight", castedNode.OffsetRight);
                castedNode.OffsetRight = n38;
            }

            if (OffsetBottom is System.Single n39)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetBottom", castedNode.OffsetBottom);
                castedNode.OffsetBottom = n39;
            }

            if (GrowHorizontal is Godot.Control.GrowDirection n40)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowHorizontal", castedNode.GrowHorizontal);
                castedNode.GrowHorizontal = n40;
            }

            if (GrowVertical is Godot.Control.GrowDirection n41)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowVertical", castedNode.GrowVertical);
                castedNode.GrowVertical = n41;
            }

            if (Size is Godot.Vector2 n42)
            {
                NodeStateManager.AddPropertyState(castedNode, "Size", castedNode.Size);
                castedNode.Size = n42;
            }

            if (Position is Godot.Vector2 n43)
            {
                NodeStateManager.AddPropertyState(castedNode, "Position", castedNode.Position);
                castedNode.Position = n43;
            }

            if (GlobalPosition is Godot.Vector2 n44)
            {
                NodeStateManager.AddPropertyState(castedNode, "GlobalPosition", castedNode.GlobalPosition);
                castedNode.GlobalPosition = n44;
            }

            if (Rotation is System.Single n45)
            {
                NodeStateManager.AddPropertyState(castedNode, "Rotation", castedNode.Rotation);
                castedNode.Rotation = n45;
            }

            if (RotationDegrees is System.Single n46)
            {
                NodeStateManager.AddPropertyState(castedNode, "RotationDegrees", castedNode.RotationDegrees);
                castedNode.RotationDegrees = n46;
            }

            if (Scale is Godot.Vector2 n47)
            {
                NodeStateManager.AddPropertyState(castedNode, "Scale", castedNode.Scale);
                castedNode.Scale = n47;
            }

            if (PivotOffset is Godot.Vector2 n48)
            {
                NodeStateManager.AddPropertyState(castedNode, "PivotOffset", castedNode.PivotOffset);
                castedNode.PivotOffset = n48;
            }

            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n49)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsHorizontal", castedNode.SizeFlagsHorizontal);
                castedNode.SizeFlagsHorizontal = n49;
            }

            if (SizeFlagsVertical is Godot.Control.SizeFlags n50)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsVertical", castedNode.SizeFlagsVertical);
                castedNode.SizeFlagsVertical = n50;
            }

            if (SizeFlagsStretchRatio is System.Single n51)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsStretchRatio", castedNode.SizeFlagsStretchRatio);
                castedNode.SizeFlagsStretchRatio = n51;
            }

            if (LocalizeNumeralSystem is System.Boolean n52)
            {
                NodeStateManager.AddPropertyState(castedNode, "LocalizeNumeralSystem", castedNode.LocalizeNumeralSystem);
                castedNode.LocalizeNumeralSystem = n52;
            }

            if (AutoTranslate is System.Boolean n53)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslate", castedNode.AutoTranslate);
                castedNode.AutoTranslate = n53;
            }

            if (TooltipText is System.String n54)
            {
                NodeStateManager.AddPropertyState(castedNode, "TooltipText", castedNode.TooltipText);
                castedNode.TooltipText = n54;
            }

            if (TooltipAutoTranslateMode is Godot.Node.AutoTranslateModeEnum n55)
            {
                NodeStateManager.AddPropertyState(castedNode, "TooltipAutoTranslateMode", castedNode.TooltipAutoTranslateMode);
                castedNode.TooltipAutoTranslateMode = n55;
            }

            if (FocusNeighborLeft is Godot.NodePath n56)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborLeft", castedNode.FocusNeighborLeft);
                castedNode.FocusNeighborLeft = n56;
            }

            if (FocusNeighborTop is Godot.NodePath n57)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborTop", castedNode.FocusNeighborTop);
                castedNode.FocusNeighborTop = n57;
            }

            if (FocusNeighborRight is Godot.NodePath n58)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborRight", castedNode.FocusNeighborRight);
                castedNode.FocusNeighborRight = n58;
            }

            if (FocusNeighborBottom is Godot.NodePath n59)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborBottom", castedNode.FocusNeighborBottom);
                castedNode.FocusNeighborBottom = n59;
            }

            if (FocusNext is Godot.NodePath n60)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNext", castedNode.FocusNext);
                castedNode.FocusNext = n60;
            }

            if (FocusPrevious is Godot.NodePath n61)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusPrevious", castedNode.FocusPrevious);
                castedNode.FocusPrevious = n61;
            }

            if (FocusMode is Godot.Control.FocusModeEnum n62)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusMode", castedNode.FocusMode);
                castedNode.FocusMode = n62;
            }

            if (MouseFilter is Godot.Control.MouseFilterEnum n63)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseFilter", castedNode.MouseFilter);
                castedNode.MouseFilter = n63;
            }

            if (MouseForcePassScrollEvents is System.Boolean n64)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseForcePassScrollEvents", castedNode.MouseForcePassScrollEvents);
                castedNode.MouseForcePassScrollEvents = n64;
            }

            if (MouseDefaultCursorShape is Godot.Control.CursorShape n65)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseDefaultCursorShape", castedNode.MouseDefaultCursorShape);
                castedNode.MouseDefaultCursorShape = n65;
            }

            if (ShortcutContext is Godot.Node n66)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutContext", castedNode.ShortcutContext);
                castedNode.ShortcutContext = n66;
            }

            if (Theme is Godot.Theme n67)
            {
                NodeStateManager.AddPropertyState(castedNode, "Theme", castedNode.Theme);
                castedNode.Theme = n67;
            }

            if (ThemeTypeVariation is Godot.StringName n68)
            {
                NodeStateManager.AddPropertyState(castedNode, "ThemeTypeVariation", castedNode.ThemeTypeVariation);
                castedNode.ThemeTypeVariation = n68;
            }

            if (Visible is System.Boolean n69)
            {
                NodeStateManager.AddPropertyState(castedNode, "Visible", castedNode.Visible);
                castedNode.Visible = n69;
            }

            if (Modulate is Godot.Color n70)
            {
                NodeStateManager.AddPropertyState(castedNode, "Modulate", castedNode.Modulate);
                castedNode.Modulate = n70;
            }

            if (SelfModulate is Godot.Color n71)
            {
                NodeStateManager.AddPropertyState(castedNode, "SelfModulate", castedNode.SelfModulate);
                castedNode.SelfModulate = n71;
            }

            if (ShowBehindParent is System.Boolean n72)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowBehindParent", castedNode.ShowBehindParent);
                castedNode.ShowBehindParent = n72;
            }

            if (TopLevel is System.Boolean n73)
            {
                NodeStateManager.AddPropertyState(castedNode, "TopLevel", castedNode.TopLevel);
                castedNode.TopLevel = n73;
            }

            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n74)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipChildren", castedNode.ClipChildren);
                castedNode.ClipChildren = n74;
            }

            if (LightMask is System.Int32 n75)
            {
                NodeStateManager.AddPropertyState(castedNode, "LightMask", castedNode.LightMask);
                castedNode.LightMask = n75;
            }

            if (VisibilityLayer is System.UInt32 n76)
            {
                NodeStateManager.AddPropertyState(castedNode, "VisibilityLayer", castedNode.VisibilityLayer);
                castedNode.VisibilityLayer = n76;
            }

            if (ZIndex is System.Int32 n77)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZIndex", castedNode.ZIndex);
                castedNode.ZIndex = n77;
            }

            if (ZAsRelative is System.Boolean n78)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZAsRelative", castedNode.ZAsRelative);
                castedNode.ZAsRelative = n78;
            }

            if (YSortEnabled is System.Boolean n79)
            {
                NodeStateManager.AddPropertyState(castedNode, "YSortEnabled", castedNode.YSortEnabled);
                castedNode.YSortEnabled = n79;
            }

            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n80)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureFilter", castedNode.TextureFilter);
                castedNode.TextureFilter = n80;
            }

            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n81)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureRepeat", castedNode.TextureRepeat);
                castedNode.TextureRepeat = n81;
            }

            if (Material is Godot.Material n82)
            {
                NodeStateManager.AddPropertyState(castedNode, "Material", castedNode.Material);
                castedNode.Material = n82;
            }

            if (UseParentMaterial is System.Boolean n83)
            {
                NodeStateManager.AddPropertyState(castedNode, "UseParentMaterial", castedNode.UseParentMaterial);
                castedNode.UseParentMaterial = n83;
            }

            if (Name is Godot.StringName n84)
            {
                NodeStateManager.AddPropertyState(castedNode, "Name", castedNode.Name);
                castedNode.Name = n84;
            }

            if (UniqueNameInOwner is System.Boolean n85)
            {
                NodeStateManager.AddPropertyState(castedNode, "UniqueNameInOwner", castedNode.UniqueNameInOwner);
                castedNode.UniqueNameInOwner = n85;
            }

            if (SceneFilePath is System.String n86)
            {
                NodeStateManager.AddPropertyState(castedNode, "SceneFilePath", castedNode.SceneFilePath);
                castedNode.SceneFilePath = n86;
            }

            if (Owner is Godot.Node n87)
            {
                NodeStateManager.AddPropertyState(castedNode, "Owner", castedNode.Owner);
                castedNode.Owner = n87;
            }

            if (ProcessMode is Godot.Node.ProcessModeEnum n88)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessMode", castedNode.ProcessMode);
                castedNode.ProcessMode = n88;
            }

            if (ProcessPriority is System.Int32 n89)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPriority", castedNode.ProcessPriority);
                castedNode.ProcessPriority = n89;
            }

            if (ProcessPhysicsPriority is System.Int32 n90)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPhysicsPriority", castedNode.ProcessPhysicsPriority);
                castedNode.ProcessPhysicsPriority = n90;
            }

            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n91)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroup", castedNode.ProcessThreadGroup);
                castedNode.ProcessThreadGroup = n91;
            }

            if (ProcessThreadGroupOrder is System.Int32 n92)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroupOrder", castedNode.ProcessThreadGroupOrder);
                castedNode.ProcessThreadGroupOrder = n92;
            }

            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n93)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadMessages", castedNode.ProcessThreadMessages);
                castedNode.ProcessThreadMessages = n93;
            }

            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n94)
            {
                NodeStateManager.AddPropertyState(castedNode, "PhysicsInterpolationMode", castedNode.PhysicsInterpolationMode);
                castedNode.PhysicsInterpolationMode = n94;
            }

            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n95)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslateMode", castedNode.AutoTranslateMode);
                castedNode.AutoTranslateMode = n95;
            }

            if (EditorDescription is System.String n96)
            {
                NodeStateManager.AddPropertyState(castedNode, "EditorDescription", castedNode.EditorDescription);
                castedNode.EditorDescription = n96;
            }

            if (ConnectionRequest is Godot.GraphEdit.ConnectionRequestEventHandler e0)
            {
                NodeStateManager.AddEventHandler(castedNode, "ConnectionRequest", e0);
                castedNode.ConnectionRequest += e0;
            }

            if (DisconnectionRequest is Godot.GraphEdit.DisconnectionRequestEventHandler e1)
            {
                NodeStateManager.AddEventHandler(castedNode, "DisconnectionRequest", e1);
                castedNode.DisconnectionRequest += e1;
            }

            if (ConnectionToEmpty is Godot.GraphEdit.ConnectionToEmptyEventHandler e2)
            {
                NodeStateManager.AddEventHandler(castedNode, "ConnectionToEmpty", e2);
                castedNode.ConnectionToEmpty += e2;
            }

            if (ConnectionFromEmpty is Godot.GraphEdit.ConnectionFromEmptyEventHandler e3)
            {
                NodeStateManager.AddEventHandler(castedNode, "ConnectionFromEmpty", e3);
                castedNode.ConnectionFromEmpty += e3;
            }

            if (ConnectionDragStarted is Godot.GraphEdit.ConnectionDragStartedEventHandler e4)
            {
                NodeStateManager.AddEventHandler(castedNode, "ConnectionDragStarted", e4);
                castedNode.ConnectionDragStarted += e4;
            }

            if (ConnectionDragEnded is System.Action e5)
            {
                NodeStateManager.AddEventHandler(castedNode, "ConnectionDragEnded", e5);
                castedNode.ConnectionDragEnded += e5;
            }

            if (CopyNodesRequest is System.Action e6)
            {
                NodeStateManager.AddEventHandler(castedNode, "CopyNodesRequest", e6);
                castedNode.CopyNodesRequest += e6;
            }

            if (CutNodesRequest is System.Action e7)
            {
                NodeStateManager.AddEventHandler(castedNode, "CutNodesRequest", e7);
                castedNode.CutNodesRequest += e7;
            }

            if (PasteNodesRequest is System.Action e8)
            {
                NodeStateManager.AddEventHandler(castedNode, "PasteNodesRequest", e8);
                castedNode.PasteNodesRequest += e8;
            }

            if (DuplicateNodesRequest is System.Action e9)
            {
                NodeStateManager.AddEventHandler(castedNode, "DuplicateNodesRequest", e9);
                castedNode.DuplicateNodesRequest += e9;
            }

            if (DeleteNodesRequest is Godot.GraphEdit.DeleteNodesRequestEventHandler e10)
            {
                NodeStateManager.AddEventHandler(castedNode, "DeleteNodesRequest", e10);
                castedNode.DeleteNodesRequest += e10;
            }

            if (NodeSelected is Godot.GraphEdit.NodeSelectedEventHandler e11)
            {
                NodeStateManager.AddEventHandler(castedNode, "NodeSelected", e11);
                castedNode.NodeSelected += e11;
            }

            if (NodeDeselected is Godot.GraphEdit.NodeDeselectedEventHandler e12)
            {
                NodeStateManager.AddEventHandler(castedNode, "NodeDeselected", e12);
                castedNode.NodeDeselected += e12;
            }

            if (FrameRectChanged is Godot.GraphEdit.FrameRectChangedEventHandler e13)
            {
                NodeStateManager.AddEventHandler(castedNode, "FrameRectChanged", e13);
                castedNode.FrameRectChanged += e13;
            }

            if (PopupRequest is Godot.GraphEdit.PopupRequestEventHandler e14)
            {
                NodeStateManager.AddEventHandler(castedNode, "PopupRequest", e14);
                castedNode.PopupRequest += e14;
            }

            if (BeginNodeMove is System.Action e15)
            {
                NodeStateManager.AddEventHandler(castedNode, "BeginNodeMove", e15);
                castedNode.BeginNodeMove += e15;
            }

            if (EndNodeMove is System.Action e16)
            {
                NodeStateManager.AddEventHandler(castedNode, "EndNodeMove", e16);
                castedNode.EndNodeMove += e16;
            }

            if (GraphElementsLinkedToFrameRequest is Godot.GraphEdit.GraphElementsLinkedToFrameRequestEventHandler e17)
            {
                NodeStateManager.AddEventHandler(castedNode, "GraphElementsLinkedToFrameRequest", e17);
                castedNode.GraphElementsLinkedToFrameRequest += e17;
            }

            if (ScrollOffsetChanged is Godot.GraphEdit.ScrollOffsetChangedEventHandler e18)
            {
                NodeStateManager.AddEventHandler(castedNode, "ScrollOffsetChanged", e18);
                castedNode.ScrollOffsetChanged += e18;
            }

            if (Resized is System.Action e19)
            {
                NodeStateManager.AddEventHandler(castedNode, "Resized", e19);
                castedNode.Resized += e19;
            }

            if (GuiInput is Godot.Control.GuiInputEventHandler e20)
            {
                NodeStateManager.AddEventHandler(castedNode, "GuiInput", e20);
                castedNode.GuiInput += e20;
            }

            if (MouseEntered is System.Action e21)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseEntered", e21);
                castedNode.MouseEntered += e21;
            }

            if (MouseExited is System.Action e22)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseExited", e22);
                castedNode.MouseExited += e22;
            }

            if (FocusEntered is System.Action e23)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusEntered", e23);
                castedNode.FocusEntered += e23;
            }

            if (FocusExited is System.Action e24)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusExited", e24);
                castedNode.FocusExited += e24;
            }

            if (SizeFlagsChanged is System.Action e25)
            {
                NodeStateManager.AddEventHandler(castedNode, "SizeFlagsChanged", e25);
                castedNode.SizeFlagsChanged += e25;
            }

            if (MinimumSizeChanged is System.Action e26)
            {
                NodeStateManager.AddEventHandler(castedNode, "MinimumSizeChanged", e26);
                castedNode.MinimumSizeChanged += e26;
            }

            if (ThemeChanged is System.Action e27)
            {
                NodeStateManager.AddEventHandler(castedNode, "ThemeChanged", e27);
                castedNode.ThemeChanged += e27;
            }

            if (Draw is System.Action e28)
            {
                NodeStateManager.AddEventHandler(castedNode, "Draw", e28);
                castedNode.Draw += e28;
            }

            if (VisibilityChanged is System.Action e29)
            {
                NodeStateManager.AddEventHandler(castedNode, "VisibilityChanged", e29);
                castedNode.VisibilityChanged += e29;
            }

            if (Hidden is System.Action e30)
            {
                NodeStateManager.AddEventHandler(castedNode, "Hidden", e30);
                castedNode.Hidden += e30;
            }

            if (ItemRectChanged is System.Action e31)
            {
                NodeStateManager.AddEventHandler(castedNode, "ItemRectChanged", e31);
                castedNode.ItemRectChanged += e31;
            }

            if (Ready is System.Action e32)
            {
                NodeStateManager.AddEventHandler(castedNode, "Ready", e32);
                castedNode.Ready += e32;
            }

            if (Renamed is System.Action e33)
            {
                NodeStateManager.AddEventHandler(castedNode, "Renamed", e33);
                castedNode.Renamed += e33;
            }

            if (TreeEntered is System.Action e34)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeEntered", e34);
                castedNode.TreeEntered += e34;
            }

            if (TreeExiting is System.Action e35)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExiting", e35);
                castedNode.TreeExiting += e35;
            }

            if (TreeExited is System.Action e36)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExited", e36);
                castedNode.TreeExited += e36;
            }

            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e37)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildEnteredTree", e37);
                castedNode.ChildEnteredTree += e37;
            }

            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e38)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildExitingTree", e38);
                castedNode.ChildExitingTree += e38;
            }

            if (ChildOrderChanged is System.Action e39)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildOrderChanged", e39);
                castedNode.ChildOrderChanged += e39;
            }

            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e40)
            {
                NodeStateManager.AddEventHandler(castedNode, "ReplacingBy", e40);
                castedNode.ReplacingBy += e40;
            }

            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e41)
            {
                NodeStateManager.AddEventHandler(castedNode, "EditorDescriptionChanged", e41);
                castedNode.EditorDescriptionChanged += e41;
            }

            if (EditorStateChanged is System.Action e42)
            {
                NodeStateManager.AddEventHandler(castedNode, "EditorStateChanged", e42);
                castedNode.EditorStateChanged += e42;
            }

            if (ScriptChanged is System.Action e43)
            {
                NodeStateManager.AddEventHandler(castedNode, "ScriptChanged", e43);
                castedNode.ScriptChanged += e43;
            }

            if (PropertyListChanged is System.Action e44)
            {
                NodeStateManager.AddEventHandler(castedNode, "PropertyListChanged", e44);
                castedNode.PropertyListChanged += e44;
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