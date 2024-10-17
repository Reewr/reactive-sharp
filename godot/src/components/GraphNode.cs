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
        public System.Action? ScriptChanged { protected get; init; }
        public System.Action? PropertyListChanged { protected get; init; }

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
                castedNode.Title = n0;
            if (IgnoreInvalidConnectionType is System.Boolean n1)
                castedNode.IgnoreInvalidConnectionType = n1;
            if (PositionOffset is Godot.Vector2 n2)
                castedNode.PositionOffset = n2;
            if (Resizable is System.Boolean n3)
                castedNode.Resizable = n3;
            if (Draggable is System.Boolean n4)
                castedNode.Draggable = n4;
            if (Selectable is System.Boolean n5)
                castedNode.Selectable = n5;
            if (Selected is System.Boolean n6)
                castedNode.Selected = n6;
            if (ClipContents is System.Boolean n7)
                castedNode.ClipContents = n7;
            if (CustomMinimumSize is Godot.Vector2 n8)
                castedNode.CustomMinimumSize = n8;
            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n9)
                castedNode.LayoutDirection = n9;
            if (LayoutMode is System.Int32 n10)
                castedNode.LayoutMode = n10;
            if (AnchorsPreset is System.Int32 n11)
                castedNode.AnchorsPreset = n11;
            if (AnchorLeft is System.Single n12)
                castedNode.AnchorLeft = n12;
            if (AnchorTop is System.Single n13)
                castedNode.AnchorTop = n13;
            if (AnchorRight is System.Single n14)
                castedNode.AnchorRight = n14;
            if (AnchorBottom is System.Single n15)
                castedNode.AnchorBottom = n15;
            if (OffsetLeft is System.Single n16)
                castedNode.OffsetLeft = n16;
            if (OffsetTop is System.Single n17)
                castedNode.OffsetTop = n17;
            if (OffsetRight is System.Single n18)
                castedNode.OffsetRight = n18;
            if (OffsetBottom is System.Single n19)
                castedNode.OffsetBottom = n19;
            if (GrowHorizontal is Godot.Control.GrowDirection n20)
                castedNode.GrowHorizontal = n20;
            if (GrowVertical is Godot.Control.GrowDirection n21)
                castedNode.GrowVertical = n21;
            if (Size is Godot.Vector2 n22)
                castedNode.Size = n22;
            if (Position is Godot.Vector2 n23)
                castedNode.Position = n23;
            if (GlobalPosition is Godot.Vector2 n24)
                castedNode.GlobalPosition = n24;
            if (Rotation is System.Single n25)
                castedNode.Rotation = n25;
            if (RotationDegrees is System.Single n26)
                castedNode.RotationDegrees = n26;
            if (Scale is Godot.Vector2 n27)
                castedNode.Scale = n27;
            if (PivotOffset is Godot.Vector2 n28)
                castedNode.PivotOffset = n28;
            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n29)
                castedNode.SizeFlagsHorizontal = n29;
            if (SizeFlagsVertical is Godot.Control.SizeFlags n30)
                castedNode.SizeFlagsVertical = n30;
            if (SizeFlagsStretchRatio is System.Single n31)
                castedNode.SizeFlagsStretchRatio = n31;
            if (LocalizeNumeralSystem is System.Boolean n32)
                castedNode.LocalizeNumeralSystem = n32;
            if (AutoTranslate is System.Boolean n33)
                castedNode.AutoTranslate = n33;
            if (TooltipText is System.String n34)
                castedNode.TooltipText = n34;
            if (FocusNeighborLeft is Godot.NodePath n35)
                castedNode.FocusNeighborLeft = n35;
            if (FocusNeighborTop is Godot.NodePath n36)
                castedNode.FocusNeighborTop = n36;
            if (FocusNeighborRight is Godot.NodePath n37)
                castedNode.FocusNeighborRight = n37;
            if (FocusNeighborBottom is Godot.NodePath n38)
                castedNode.FocusNeighborBottom = n38;
            if (FocusNext is Godot.NodePath n39)
                castedNode.FocusNext = n39;
            if (FocusPrevious is Godot.NodePath n40)
                castedNode.FocusPrevious = n40;
            if (FocusMode is Godot.Control.FocusModeEnum n41)
                castedNode.FocusMode = n41;
            if (MouseFilter is Godot.Control.MouseFilterEnum n42)
                castedNode.MouseFilter = n42;
            if (MouseForcePassScrollEvents is System.Boolean n43)
                castedNode.MouseForcePassScrollEvents = n43;
            if (MouseDefaultCursorShape is Godot.Control.CursorShape n44)
                castedNode.MouseDefaultCursorShape = n44;
            if (ShortcutContext is Godot.Node n45)
                castedNode.ShortcutContext = n45;
            if (Theme is Godot.Theme n46)
                castedNode.Theme = n46;
            if (ThemeTypeVariation is Godot.StringName n47)
                castedNode.ThemeTypeVariation = n47;
            if (Visible is System.Boolean n48)
                castedNode.Visible = n48;
            if (Modulate is Godot.Color n49)
                castedNode.Modulate = n49;
            if (SelfModulate is Godot.Color n50)
                castedNode.SelfModulate = n50;
            if (ShowBehindParent is System.Boolean n51)
                castedNode.ShowBehindParent = n51;
            if (TopLevel is System.Boolean n52)
                castedNode.TopLevel = n52;
            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n53)
                castedNode.ClipChildren = n53;
            if (LightMask is System.Int32 n54)
                castedNode.LightMask = n54;
            if (VisibilityLayer is System.UInt32 n55)
                castedNode.VisibilityLayer = n55;
            if (ZIndex is System.Int32 n56)
                castedNode.ZIndex = n56;
            if (ZAsRelative is System.Boolean n57)
                castedNode.ZAsRelative = n57;
            if (YSortEnabled is System.Boolean n58)
                castedNode.YSortEnabled = n58;
            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n59)
                castedNode.TextureFilter = n59;
            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n60)
                castedNode.TextureRepeat = n60;
            if (Material is Godot.Material n61)
                castedNode.Material = n61;
            if (UseParentMaterial is System.Boolean n62)
                castedNode.UseParentMaterial = n62;
            if (Name is Godot.StringName n63)
                castedNode.Name = n63;
            if (UniqueNameInOwner is System.Boolean n64)
                castedNode.UniqueNameInOwner = n64;
            if (SceneFilePath is System.String n65)
                castedNode.SceneFilePath = n65;
            if (Owner is Godot.Node n66)
                castedNode.Owner = n66;
            if (ProcessMode is Godot.Node.ProcessModeEnum n67)
                castedNode.ProcessMode = n67;
            if (ProcessPriority is System.Int32 n68)
                castedNode.ProcessPriority = n68;
            if (ProcessPhysicsPriority is System.Int32 n69)
                castedNode.ProcessPhysicsPriority = n69;
            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n70)
                castedNode.ProcessThreadGroup = n70;
            if (ProcessThreadGroupOrder is System.Int32 n71)
                castedNode.ProcessThreadGroupOrder = n71;
            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n72)
                castedNode.ProcessThreadMessages = n72;
            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n73)
                castedNode.PhysicsInterpolationMode = n73;
            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n74)
                castedNode.AutoTranslateMode = n74;
            if (EditorDescription is System.String n75)
                castedNode.EditorDescription = n75;
            if (CloseRequest is System.Action e0)
                castedNode.CloseRequest += e0;
            if (SlotUpdated is Godot.GraphNode.SlotUpdatedEventHandler e1)
                castedNode.SlotUpdated += e1;
            if (NodeSelected is System.Action e2)
                castedNode.NodeSelected += e2;
            if (NodeDeselected is System.Action e3)
                castedNode.NodeDeselected += e3;
            if (RaiseRequest is System.Action e4)
                castedNode.RaiseRequest += e4;
            if (DeleteRequest is System.Action e5)
                castedNode.DeleteRequest += e5;
            if (ResizeRequest is Godot.GraphElement.ResizeRequestEventHandler e6)
                castedNode.ResizeRequest += e6;
            if (ResizeEnd is Godot.GraphElement.ResizeEndEventHandler e7)
                castedNode.ResizeEnd += e7;
            if (Dragged is Godot.GraphElement.DraggedEventHandler e8)
                castedNode.Dragged += e8;
            if (PositionOffsetChanged is System.Action e9)
                castedNode.PositionOffsetChanged += e9;
            if (PreSortChildren is System.Action e10)
                castedNode.PreSortChildren += e10;
            if (SortChildren is System.Action e11)
                castedNode.SortChildren += e11;
            if (Resized is System.Action e12)
                castedNode.Resized += e12;
            if (GuiInput is Godot.Control.GuiInputEventHandler e13)
                castedNode.GuiInput += e13;
            if (MouseEntered is System.Action e14)
                castedNode.MouseEntered += e14;
            if (MouseExited is System.Action e15)
                castedNode.MouseExited += e15;
            if (FocusEntered is System.Action e16)
                castedNode.FocusEntered += e16;
            if (FocusExited is System.Action e17)
                castedNode.FocusExited += e17;
            if (SizeFlagsChanged is System.Action e18)
                castedNode.SizeFlagsChanged += e18;
            if (MinimumSizeChanged is System.Action e19)
                castedNode.MinimumSizeChanged += e19;
            if (ThemeChanged is System.Action e20)
                castedNode.ThemeChanged += e20;
            if (Draw is System.Action e21)
                castedNode.Draw += e21;
            if (VisibilityChanged is System.Action e22)
                castedNode.VisibilityChanged += e22;
            if (Hidden is System.Action e23)
                castedNode.Hidden += e23;
            if (ItemRectChanged is System.Action e24)
                castedNode.ItemRectChanged += e24;
            if (Ready is System.Action e25)
                castedNode.Ready += e25;
            if (Renamed is System.Action e26)
                castedNode.Renamed += e26;
            if (TreeEntered is System.Action e27)
                castedNode.TreeEntered += e27;
            if (TreeExiting is System.Action e28)
                castedNode.TreeExiting += e28;
            if (TreeExited is System.Action e29)
                castedNode.TreeExited += e29;
            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e30)
                castedNode.ChildEnteredTree += e30;
            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e31)
                castedNode.ChildExitingTree += e31;
            if (ChildOrderChanged is System.Action e32)
                castedNode.ChildOrderChanged += e32;
            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e33)
                castedNode.ReplacingBy += e33;
            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e34)
                castedNode.EditorDescriptionChanged += e34;
            if (ScriptChanged is System.Action e35)
                castedNode.ScriptChanged += e35;
            if (PropertyListChanged is System.Action e36)
                castedNode.PropertyListChanged += e36;
        }
    }
}