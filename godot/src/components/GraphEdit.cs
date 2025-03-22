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
        public System.Action? ScriptChanged { protected get; init; }
        public System.Action? PropertyListChanged { protected get; init; }
        public Dictionary<string, int> ThemeConstantOverrides { protected get; init; } = [];
        public Dictionary<string, Godot.Color> ThemeColorOverrides { protected get; init; } = [];

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

            if (Zoom is System.Single n13)
            {
                NodeStateManager.AddPropertyState(castedNode, "Zoom", castedNode.Zoom);
                castedNode.Zoom = n13;
            }

            if (ZoomMin is System.Single n14)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZoomMin", castedNode.ZoomMin);
                castedNode.ZoomMin = n14;
            }

            if (ZoomMax is System.Single n15)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZoomMax", castedNode.ZoomMax);
                castedNode.ZoomMax = n15;
            }

            if (ZoomStep is System.Single n16)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZoomStep", castedNode.ZoomStep);
                castedNode.ZoomStep = n16;
            }

            if (MinimapEnabled is System.Boolean n17)
            {
                NodeStateManager.AddPropertyState(castedNode, "MinimapEnabled", castedNode.MinimapEnabled);
                castedNode.MinimapEnabled = n17;
            }

            if (MinimapSize is Godot.Vector2 n18)
            {
                NodeStateManager.AddPropertyState(castedNode, "MinimapSize", castedNode.MinimapSize);
                castedNode.MinimapSize = n18;
            }

            if (MinimapOpacity is System.Single n19)
            {
                NodeStateManager.AddPropertyState(castedNode, "MinimapOpacity", castedNode.MinimapOpacity);
                castedNode.MinimapOpacity = n19;
            }

            if (ShowMenu is System.Boolean n20)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowMenu", castedNode.ShowMenu);
                castedNode.ShowMenu = n20;
            }

            if (ShowZoomLabel is System.Boolean n21)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowZoomLabel", castedNode.ShowZoomLabel);
                castedNode.ShowZoomLabel = n21;
            }

            if (ShowZoomButtons is System.Boolean n22)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowZoomButtons", castedNode.ShowZoomButtons);
                castedNode.ShowZoomButtons = n22;
            }

            if (ShowGridButtons is System.Boolean n23)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowGridButtons", castedNode.ShowGridButtons);
                castedNode.ShowGridButtons = n23;
            }

            if (ShowMinimapButton is System.Boolean n24)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowMinimapButton", castedNode.ShowMinimapButton);
                castedNode.ShowMinimapButton = n24;
            }

            if (ShowArrangeButton is System.Boolean n25)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowArrangeButton", castedNode.ShowArrangeButton);
                castedNode.ShowArrangeButton = n25;
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

            if (PasteNodesRequest is System.Action e7)
            {
                NodeStateManager.AddEventHandler(castedNode, "PasteNodesRequest", e7);
                castedNode.PasteNodesRequest += e7;
            }

            if (DuplicateNodesRequest is System.Action e8)
            {
                NodeStateManager.AddEventHandler(castedNode, "DuplicateNodesRequest", e8);
                castedNode.DuplicateNodesRequest += e8;
            }

            if (DeleteNodesRequest is Godot.GraphEdit.DeleteNodesRequestEventHandler e9)
            {
                NodeStateManager.AddEventHandler(castedNode, "DeleteNodesRequest", e9);
                castedNode.DeleteNodesRequest += e9;
            }

            if (NodeSelected is Godot.GraphEdit.NodeSelectedEventHandler e10)
            {
                NodeStateManager.AddEventHandler(castedNode, "NodeSelected", e10);
                castedNode.NodeSelected += e10;
            }

            if (NodeDeselected is Godot.GraphEdit.NodeDeselectedEventHandler e11)
            {
                NodeStateManager.AddEventHandler(castedNode, "NodeDeselected", e11);
                castedNode.NodeDeselected += e11;
            }

            if (FrameRectChanged is Godot.GraphEdit.FrameRectChangedEventHandler e12)
            {
                NodeStateManager.AddEventHandler(castedNode, "FrameRectChanged", e12);
                castedNode.FrameRectChanged += e12;
            }

            if (PopupRequest is Godot.GraphEdit.PopupRequestEventHandler e13)
            {
                NodeStateManager.AddEventHandler(castedNode, "PopupRequest", e13);
                castedNode.PopupRequest += e13;
            }

            if (BeginNodeMove is System.Action e14)
            {
                NodeStateManager.AddEventHandler(castedNode, "BeginNodeMove", e14);
                castedNode.BeginNodeMove += e14;
            }

            if (EndNodeMove is System.Action e15)
            {
                NodeStateManager.AddEventHandler(castedNode, "EndNodeMove", e15);
                castedNode.EndNodeMove += e15;
            }

            if (GraphElementsLinkedToFrameRequest is Godot.GraphEdit.GraphElementsLinkedToFrameRequestEventHandler e16)
            {
                NodeStateManager.AddEventHandler(castedNode, "GraphElementsLinkedToFrameRequest", e16);
                castedNode.GraphElementsLinkedToFrameRequest += e16;
            }

            if (ScrollOffsetChanged is Godot.GraphEdit.ScrollOffsetChangedEventHandler e17)
            {
                NodeStateManager.AddEventHandler(castedNode, "ScrollOffsetChanged", e17);
                castedNode.ScrollOffsetChanged += e17;
            }

            if (Resized is System.Action e18)
            {
                NodeStateManager.AddEventHandler(castedNode, "Resized", e18);
                castedNode.Resized += e18;
            }

            if (GuiInput is Godot.Control.GuiInputEventHandler e19)
            {
                NodeStateManager.AddEventHandler(castedNode, "GuiInput", e19);
                castedNode.GuiInput += e19;
            }

            if (MouseEntered is System.Action e20)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseEntered", e20);
                castedNode.MouseEntered += e20;
            }

            if (MouseExited is System.Action e21)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseExited", e21);
                castedNode.MouseExited += e21;
            }

            if (FocusEntered is System.Action e22)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusEntered", e22);
                castedNode.FocusEntered += e22;
            }

            if (FocusExited is System.Action e23)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusExited", e23);
                castedNode.FocusExited += e23;
            }

            if (SizeFlagsChanged is System.Action e24)
            {
                NodeStateManager.AddEventHandler(castedNode, "SizeFlagsChanged", e24);
                castedNode.SizeFlagsChanged += e24;
            }

            if (MinimumSizeChanged is System.Action e25)
            {
                NodeStateManager.AddEventHandler(castedNode, "MinimumSizeChanged", e25);
                castedNode.MinimumSizeChanged += e25;
            }

            if (ThemeChanged is System.Action e26)
            {
                NodeStateManager.AddEventHandler(castedNode, "ThemeChanged", e26);
                castedNode.ThemeChanged += e26;
            }

            if (Draw is System.Action e27)
            {
                NodeStateManager.AddEventHandler(castedNode, "Draw", e27);
                castedNode.Draw += e27;
            }

            if (VisibilityChanged is System.Action e28)
            {
                NodeStateManager.AddEventHandler(castedNode, "VisibilityChanged", e28);
                castedNode.VisibilityChanged += e28;
            }

            if (Hidden is System.Action e29)
            {
                NodeStateManager.AddEventHandler(castedNode, "Hidden", e29);
                castedNode.Hidden += e29;
            }

            if (ItemRectChanged is System.Action e30)
            {
                NodeStateManager.AddEventHandler(castedNode, "ItemRectChanged", e30);
                castedNode.ItemRectChanged += e30;
            }

            if (Ready is System.Action e31)
            {
                NodeStateManager.AddEventHandler(castedNode, "Ready", e31);
                castedNode.Ready += e31;
            }

            if (Renamed is System.Action e32)
            {
                NodeStateManager.AddEventHandler(castedNode, "Renamed", e32);
                castedNode.Renamed += e32;
            }

            if (TreeEntered is System.Action e33)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeEntered", e33);
                castedNode.TreeEntered += e33;
            }

            if (TreeExiting is System.Action e34)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExiting", e34);
                castedNode.TreeExiting += e34;
            }

            if (TreeExited is System.Action e35)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExited", e35);
                castedNode.TreeExited += e35;
            }

            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e36)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildEnteredTree", e36);
                castedNode.ChildEnteredTree += e36;
            }

            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e37)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildExitingTree", e37);
                castedNode.ChildExitingTree += e37;
            }

            if (ChildOrderChanged is System.Action e38)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildOrderChanged", e38);
                castedNode.ChildOrderChanged += e38;
            }

            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e39)
            {
                NodeStateManager.AddEventHandler(castedNode, "ReplacingBy", e39);
                castedNode.ReplacingBy += e39;
            }

            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e40)
            {
                NodeStateManager.AddEventHandler(castedNode, "EditorDescriptionChanged", e40);
                castedNode.EditorDescriptionChanged += e40;
            }

            if (ScriptChanged is System.Action e41)
            {
                NodeStateManager.AddEventHandler(castedNode, "ScriptChanged", e41);
                castedNode.ScriptChanged += e41;
            }

            if (PropertyListChanged is System.Action e42)
            {
                NodeStateManager.AddEventHandler(castedNode, "PropertyListChanged", e42);
                castedNode.PropertyListChanged += e42;
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