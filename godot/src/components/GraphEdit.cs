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
                castedNode.ArrangeNodesButtonHidden = n0;
            if (SnapDistance is System.Int32 n1)
                castedNode.SnapDistance = n1;
            if (UseSnap is System.Boolean n2)
                castedNode.UseSnap = n2;
            if (ScrollOffset is Godot.Vector2 n3)
                castedNode.ScrollOffset = n3;
            if (ShowGrid is System.Boolean n4)
                castedNode.ShowGrid = n4;
            if (GridPattern is Godot.GraphEdit.GridPatternEnum n5)
                castedNode.GridPattern = n5;
            if (SnappingEnabled is System.Boolean n6)
                castedNode.SnappingEnabled = n6;
            if (SnappingDistance is System.Int32 n7)
                castedNode.SnappingDistance = n7;
            if (PanningScheme is Godot.GraphEdit.PanningSchemeEnum n8)
                castedNode.PanningScheme = n8;
            if (RightDisconnects is System.Boolean n9)
                castedNode.RightDisconnects = n9;
            if (ConnectionLinesCurvature is System.Single n10)
                castedNode.ConnectionLinesCurvature = n10;
            if (ConnectionLinesThickness is System.Single n11)
                castedNode.ConnectionLinesThickness = n11;
            if (ConnectionLinesAntialiased is System.Boolean n12)
                castedNode.ConnectionLinesAntialiased = n12;
            if (Zoom is System.Single n13)
                castedNode.Zoom = n13;
            if (ZoomMin is System.Single n14)
                castedNode.ZoomMin = n14;
            if (ZoomMax is System.Single n15)
                castedNode.ZoomMax = n15;
            if (ZoomStep is System.Single n16)
                castedNode.ZoomStep = n16;
            if (MinimapEnabled is System.Boolean n17)
                castedNode.MinimapEnabled = n17;
            if (MinimapSize is Godot.Vector2 n18)
                castedNode.MinimapSize = n18;
            if (MinimapOpacity is System.Single n19)
                castedNode.MinimapOpacity = n19;
            if (ShowMenu is System.Boolean n20)
                castedNode.ShowMenu = n20;
            if (ShowZoomLabel is System.Boolean n21)
                castedNode.ShowZoomLabel = n21;
            if (ShowZoomButtons is System.Boolean n22)
                castedNode.ShowZoomButtons = n22;
            if (ShowGridButtons is System.Boolean n23)
                castedNode.ShowGridButtons = n23;
            if (ShowMinimapButton is System.Boolean n24)
                castedNode.ShowMinimapButton = n24;
            if (ShowArrangeButton is System.Boolean n25)
                castedNode.ShowArrangeButton = n25;
            if (ClipContents is System.Boolean n26)
                castedNode.ClipContents = n26;
            if (CustomMinimumSize is Godot.Vector2 n27)
                castedNode.CustomMinimumSize = n27;
            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n28)
                castedNode.LayoutDirection = n28;
            if (LayoutMode is System.Int32 n29)
                castedNode.LayoutMode = n29;
            if (AnchorsPreset is System.Int32 n30)
                castedNode.AnchorsPreset = n30;
            if (AnchorLeft is System.Single n31)
                castedNode.AnchorLeft = n31;
            if (AnchorTop is System.Single n32)
                castedNode.AnchorTop = n32;
            if (AnchorRight is System.Single n33)
                castedNode.AnchorRight = n33;
            if (AnchorBottom is System.Single n34)
                castedNode.AnchorBottom = n34;
            if (OffsetLeft is System.Single n35)
                castedNode.OffsetLeft = n35;
            if (OffsetTop is System.Single n36)
                castedNode.OffsetTop = n36;
            if (OffsetRight is System.Single n37)
                castedNode.OffsetRight = n37;
            if (OffsetBottom is System.Single n38)
                castedNode.OffsetBottom = n38;
            if (GrowHorizontal is Godot.Control.GrowDirection n39)
                castedNode.GrowHorizontal = n39;
            if (GrowVertical is Godot.Control.GrowDirection n40)
                castedNode.GrowVertical = n40;
            if (Size is Godot.Vector2 n41)
                castedNode.Size = n41;
            if (Position is Godot.Vector2 n42)
                castedNode.Position = n42;
            if (GlobalPosition is Godot.Vector2 n43)
                castedNode.GlobalPosition = n43;
            if (Rotation is System.Single n44)
                castedNode.Rotation = n44;
            if (RotationDegrees is System.Single n45)
                castedNode.RotationDegrees = n45;
            if (Scale is Godot.Vector2 n46)
                castedNode.Scale = n46;
            if (PivotOffset is Godot.Vector2 n47)
                castedNode.PivotOffset = n47;
            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n48)
                castedNode.SizeFlagsHorizontal = n48;
            if (SizeFlagsVertical is Godot.Control.SizeFlags n49)
                castedNode.SizeFlagsVertical = n49;
            if (SizeFlagsStretchRatio is System.Single n50)
                castedNode.SizeFlagsStretchRatio = n50;
            if (LocalizeNumeralSystem is System.Boolean n51)
                castedNode.LocalizeNumeralSystem = n51;
            if (AutoTranslate is System.Boolean n52)
                castedNode.AutoTranslate = n52;
            if (TooltipText is System.String n53)
                castedNode.TooltipText = n53;
            if (FocusNeighborLeft is Godot.NodePath n54)
                castedNode.FocusNeighborLeft = n54;
            if (FocusNeighborTop is Godot.NodePath n55)
                castedNode.FocusNeighborTop = n55;
            if (FocusNeighborRight is Godot.NodePath n56)
                castedNode.FocusNeighborRight = n56;
            if (FocusNeighborBottom is Godot.NodePath n57)
                castedNode.FocusNeighborBottom = n57;
            if (FocusNext is Godot.NodePath n58)
                castedNode.FocusNext = n58;
            if (FocusPrevious is Godot.NodePath n59)
                castedNode.FocusPrevious = n59;
            if (FocusMode is Godot.Control.FocusModeEnum n60)
                castedNode.FocusMode = n60;
            if (MouseFilter is Godot.Control.MouseFilterEnum n61)
                castedNode.MouseFilter = n61;
            if (MouseForcePassScrollEvents is System.Boolean n62)
                castedNode.MouseForcePassScrollEvents = n62;
            if (MouseDefaultCursorShape is Godot.Control.CursorShape n63)
                castedNode.MouseDefaultCursorShape = n63;
            if (ShortcutContext is Godot.Node n64)
                castedNode.ShortcutContext = n64;
            if (Theme is Godot.Theme n65)
                castedNode.Theme = n65;
            if (ThemeTypeVariation is Godot.StringName n66)
                castedNode.ThemeTypeVariation = n66;
            if (Visible is System.Boolean n67)
                castedNode.Visible = n67;
            if (Modulate is Godot.Color n68)
                castedNode.Modulate = n68;
            if (SelfModulate is Godot.Color n69)
                castedNode.SelfModulate = n69;
            if (ShowBehindParent is System.Boolean n70)
                castedNode.ShowBehindParent = n70;
            if (TopLevel is System.Boolean n71)
                castedNode.TopLevel = n71;
            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n72)
                castedNode.ClipChildren = n72;
            if (LightMask is System.Int32 n73)
                castedNode.LightMask = n73;
            if (VisibilityLayer is System.UInt32 n74)
                castedNode.VisibilityLayer = n74;
            if (ZIndex is System.Int32 n75)
                castedNode.ZIndex = n75;
            if (ZAsRelative is System.Boolean n76)
                castedNode.ZAsRelative = n76;
            if (YSortEnabled is System.Boolean n77)
                castedNode.YSortEnabled = n77;
            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n78)
                castedNode.TextureFilter = n78;
            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n79)
                castedNode.TextureRepeat = n79;
            if (Material is Godot.Material n80)
                castedNode.Material = n80;
            if (UseParentMaterial is System.Boolean n81)
                castedNode.UseParentMaterial = n81;
            if (Name is Godot.StringName n82)
                castedNode.Name = n82;
            if (UniqueNameInOwner is System.Boolean n83)
                castedNode.UniqueNameInOwner = n83;
            if (SceneFilePath is System.String n84)
                castedNode.SceneFilePath = n84;
            if (Owner is Godot.Node n85)
                castedNode.Owner = n85;
            if (ProcessMode is Godot.Node.ProcessModeEnum n86)
                castedNode.ProcessMode = n86;
            if (ProcessPriority is System.Int32 n87)
                castedNode.ProcessPriority = n87;
            if (ProcessPhysicsPriority is System.Int32 n88)
                castedNode.ProcessPhysicsPriority = n88;
            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n89)
                castedNode.ProcessThreadGroup = n89;
            if (ProcessThreadGroupOrder is System.Int32 n90)
                castedNode.ProcessThreadGroupOrder = n90;
            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n91)
                castedNode.ProcessThreadMessages = n91;
            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n92)
                castedNode.PhysicsInterpolationMode = n92;
            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n93)
                castedNode.AutoTranslateMode = n93;
            if (EditorDescription is System.String n94)
                castedNode.EditorDescription = n94;
            if (ConnectionRequest is Godot.GraphEdit.ConnectionRequestEventHandler e0)
                castedNode.ConnectionRequest += e0;
            if (DisconnectionRequest is Godot.GraphEdit.DisconnectionRequestEventHandler e1)
                castedNode.DisconnectionRequest += e1;
            if (ConnectionToEmpty is Godot.GraphEdit.ConnectionToEmptyEventHandler e2)
                castedNode.ConnectionToEmpty += e2;
            if (ConnectionFromEmpty is Godot.GraphEdit.ConnectionFromEmptyEventHandler e3)
                castedNode.ConnectionFromEmpty += e3;
            if (ConnectionDragStarted is Godot.GraphEdit.ConnectionDragStartedEventHandler e4)
                castedNode.ConnectionDragStarted += e4;
            if (ConnectionDragEnded is System.Action e5)
                castedNode.ConnectionDragEnded += e5;
            if (CopyNodesRequest is System.Action e6)
                castedNode.CopyNodesRequest += e6;
            if (PasteNodesRequest is System.Action e7)
                castedNode.PasteNodesRequest += e7;
            if (DuplicateNodesRequest is System.Action e8)
                castedNode.DuplicateNodesRequest += e8;
            if (DeleteNodesRequest is Godot.GraphEdit.DeleteNodesRequestEventHandler e9)
                castedNode.DeleteNodesRequest += e9;
            if (NodeSelected is Godot.GraphEdit.NodeSelectedEventHandler e10)
                castedNode.NodeSelected += e10;
            if (NodeDeselected is Godot.GraphEdit.NodeDeselectedEventHandler e11)
                castedNode.NodeDeselected += e11;
            if (FrameRectChanged is Godot.GraphEdit.FrameRectChangedEventHandler e12)
                castedNode.FrameRectChanged += e12;
            if (PopupRequest is Godot.GraphEdit.PopupRequestEventHandler e13)
                castedNode.PopupRequest += e13;
            if (BeginNodeMove is System.Action e14)
                castedNode.BeginNodeMove += e14;
            if (EndNodeMove is System.Action e15)
                castedNode.EndNodeMove += e15;
            if (GraphElementsLinkedToFrameRequest is Godot.GraphEdit.GraphElementsLinkedToFrameRequestEventHandler e16)
                castedNode.GraphElementsLinkedToFrameRequest += e16;
            if (ScrollOffsetChanged is Godot.GraphEdit.ScrollOffsetChangedEventHandler e17)
                castedNode.ScrollOffsetChanged += e17;
            if (Resized is System.Action e18)
                castedNode.Resized += e18;
            if (GuiInput is Godot.Control.GuiInputEventHandler e19)
                castedNode.GuiInput += e19;
            if (MouseEntered is System.Action e20)
                castedNode.MouseEntered += e20;
            if (MouseExited is System.Action e21)
                castedNode.MouseExited += e21;
            if (FocusEntered is System.Action e22)
                castedNode.FocusEntered += e22;
            if (FocusExited is System.Action e23)
                castedNode.FocusExited += e23;
            if (SizeFlagsChanged is System.Action e24)
                castedNode.SizeFlagsChanged += e24;
            if (MinimumSizeChanged is System.Action e25)
                castedNode.MinimumSizeChanged += e25;
            if (ThemeChanged is System.Action e26)
                castedNode.ThemeChanged += e26;
            if (Draw is System.Action e27)
                castedNode.Draw += e27;
            if (VisibilityChanged is System.Action e28)
                castedNode.VisibilityChanged += e28;
            if (Hidden is System.Action e29)
                castedNode.Hidden += e29;
            if (ItemRectChanged is System.Action e30)
                castedNode.ItemRectChanged += e30;
            if (Ready is System.Action e31)
                castedNode.Ready += e31;
            if (Renamed is System.Action e32)
                castedNode.Renamed += e32;
            if (TreeEntered is System.Action e33)
                castedNode.TreeEntered += e33;
            if (TreeExiting is System.Action e34)
                castedNode.TreeExiting += e34;
            if (TreeExited is System.Action e35)
                castedNode.TreeExited += e35;
            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e36)
                castedNode.ChildEnteredTree += e36;
            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e37)
                castedNode.ChildExitingTree += e37;
            if (ChildOrderChanged is System.Action e38)
                castedNode.ChildOrderChanged += e38;
            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e39)
                castedNode.ReplacingBy += e39;
            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e40)
                castedNode.EditorDescriptionChanged += e40;
            if (ScriptChanged is System.Action e41)
                castedNode.ScriptChanged += e41;
            if (PropertyListChanged is System.Action e42)
                castedNode.PropertyListChanged += e42;
        }
    }
}