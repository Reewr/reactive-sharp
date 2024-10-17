namespace ReactiveSharpGodot.Components
{
    public class GraphElement : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GGraphElement>
    {
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

        public override ReactiveSharpGodot.Nodes.GGraphElement Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GGraphElement();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GGraphElement node)
        {
            var castedNode = (Godot.GraphElement)node.Node;
            if (PositionOffset is Godot.Vector2 n0)
                castedNode.PositionOffset = n0;
            if (Resizable is System.Boolean n1)
                castedNode.Resizable = n1;
            if (Draggable is System.Boolean n2)
                castedNode.Draggable = n2;
            if (Selectable is System.Boolean n3)
                castedNode.Selectable = n3;
            if (Selected is System.Boolean n4)
                castedNode.Selected = n4;
            if (ClipContents is System.Boolean n5)
                castedNode.ClipContents = n5;
            if (CustomMinimumSize is Godot.Vector2 n6)
                castedNode.CustomMinimumSize = n6;
            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n7)
                castedNode.LayoutDirection = n7;
            if (LayoutMode is System.Int32 n8)
                castedNode.LayoutMode = n8;
            if (AnchorsPreset is System.Int32 n9)
                castedNode.AnchorsPreset = n9;
            if (AnchorLeft is System.Single n10)
                castedNode.AnchorLeft = n10;
            if (AnchorTop is System.Single n11)
                castedNode.AnchorTop = n11;
            if (AnchorRight is System.Single n12)
                castedNode.AnchorRight = n12;
            if (AnchorBottom is System.Single n13)
                castedNode.AnchorBottom = n13;
            if (OffsetLeft is System.Single n14)
                castedNode.OffsetLeft = n14;
            if (OffsetTop is System.Single n15)
                castedNode.OffsetTop = n15;
            if (OffsetRight is System.Single n16)
                castedNode.OffsetRight = n16;
            if (OffsetBottom is System.Single n17)
                castedNode.OffsetBottom = n17;
            if (GrowHorizontal is Godot.Control.GrowDirection n18)
                castedNode.GrowHorizontal = n18;
            if (GrowVertical is Godot.Control.GrowDirection n19)
                castedNode.GrowVertical = n19;
            if (Size is Godot.Vector2 n20)
                castedNode.Size = n20;
            if (Position is Godot.Vector2 n21)
                castedNode.Position = n21;
            if (GlobalPosition is Godot.Vector2 n22)
                castedNode.GlobalPosition = n22;
            if (Rotation is System.Single n23)
                castedNode.Rotation = n23;
            if (RotationDegrees is System.Single n24)
                castedNode.RotationDegrees = n24;
            if (Scale is Godot.Vector2 n25)
                castedNode.Scale = n25;
            if (PivotOffset is Godot.Vector2 n26)
                castedNode.PivotOffset = n26;
            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n27)
                castedNode.SizeFlagsHorizontal = n27;
            if (SizeFlagsVertical is Godot.Control.SizeFlags n28)
                castedNode.SizeFlagsVertical = n28;
            if (SizeFlagsStretchRatio is System.Single n29)
                castedNode.SizeFlagsStretchRatio = n29;
            if (LocalizeNumeralSystem is System.Boolean n30)
                castedNode.LocalizeNumeralSystem = n30;
            if (AutoTranslate is System.Boolean n31)
                castedNode.AutoTranslate = n31;
            if (TooltipText is System.String n32)
                castedNode.TooltipText = n32;
            if (FocusNeighborLeft is Godot.NodePath n33)
                castedNode.FocusNeighborLeft = n33;
            if (FocusNeighborTop is Godot.NodePath n34)
                castedNode.FocusNeighborTop = n34;
            if (FocusNeighborRight is Godot.NodePath n35)
                castedNode.FocusNeighborRight = n35;
            if (FocusNeighborBottom is Godot.NodePath n36)
                castedNode.FocusNeighborBottom = n36;
            if (FocusNext is Godot.NodePath n37)
                castedNode.FocusNext = n37;
            if (FocusPrevious is Godot.NodePath n38)
                castedNode.FocusPrevious = n38;
            if (FocusMode is Godot.Control.FocusModeEnum n39)
                castedNode.FocusMode = n39;
            if (MouseFilter is Godot.Control.MouseFilterEnum n40)
                castedNode.MouseFilter = n40;
            if (MouseForcePassScrollEvents is System.Boolean n41)
                castedNode.MouseForcePassScrollEvents = n41;
            if (MouseDefaultCursorShape is Godot.Control.CursorShape n42)
                castedNode.MouseDefaultCursorShape = n42;
            if (ShortcutContext is Godot.Node n43)
                castedNode.ShortcutContext = n43;
            if (Theme is Godot.Theme n44)
                castedNode.Theme = n44;
            if (ThemeTypeVariation is Godot.StringName n45)
                castedNode.ThemeTypeVariation = n45;
            if (Visible is System.Boolean n46)
                castedNode.Visible = n46;
            if (Modulate is Godot.Color n47)
                castedNode.Modulate = n47;
            if (SelfModulate is Godot.Color n48)
                castedNode.SelfModulate = n48;
            if (ShowBehindParent is System.Boolean n49)
                castedNode.ShowBehindParent = n49;
            if (TopLevel is System.Boolean n50)
                castedNode.TopLevel = n50;
            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n51)
                castedNode.ClipChildren = n51;
            if (LightMask is System.Int32 n52)
                castedNode.LightMask = n52;
            if (VisibilityLayer is System.UInt32 n53)
                castedNode.VisibilityLayer = n53;
            if (ZIndex is System.Int32 n54)
                castedNode.ZIndex = n54;
            if (ZAsRelative is System.Boolean n55)
                castedNode.ZAsRelative = n55;
            if (YSortEnabled is System.Boolean n56)
                castedNode.YSortEnabled = n56;
            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n57)
                castedNode.TextureFilter = n57;
            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n58)
                castedNode.TextureRepeat = n58;
            if (Material is Godot.Material n59)
                castedNode.Material = n59;
            if (UseParentMaterial is System.Boolean n60)
                castedNode.UseParentMaterial = n60;
            if (Name is Godot.StringName n61)
                castedNode.Name = n61;
            if (UniqueNameInOwner is System.Boolean n62)
                castedNode.UniqueNameInOwner = n62;
            if (SceneFilePath is System.String n63)
                castedNode.SceneFilePath = n63;
            if (Owner is Godot.Node n64)
                castedNode.Owner = n64;
            if (ProcessMode is Godot.Node.ProcessModeEnum n65)
                castedNode.ProcessMode = n65;
            if (ProcessPriority is System.Int32 n66)
                castedNode.ProcessPriority = n66;
            if (ProcessPhysicsPriority is System.Int32 n67)
                castedNode.ProcessPhysicsPriority = n67;
            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n68)
                castedNode.ProcessThreadGroup = n68;
            if (ProcessThreadGroupOrder is System.Int32 n69)
                castedNode.ProcessThreadGroupOrder = n69;
            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n70)
                castedNode.ProcessThreadMessages = n70;
            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n71)
                castedNode.PhysicsInterpolationMode = n71;
            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n72)
                castedNode.AutoTranslateMode = n72;
            if (EditorDescription is System.String n73)
                castedNode.EditorDescription = n73;
            if (NodeSelected is System.Action e0)
                castedNode.NodeSelected += e0;
            if (NodeDeselected is System.Action e1)
                castedNode.NodeDeselected += e1;
            if (RaiseRequest is System.Action e2)
                castedNode.RaiseRequest += e2;
            if (DeleteRequest is System.Action e3)
                castedNode.DeleteRequest += e3;
            if (ResizeRequest is Godot.GraphElement.ResizeRequestEventHandler e4)
                castedNode.ResizeRequest += e4;
            if (ResizeEnd is Godot.GraphElement.ResizeEndEventHandler e5)
                castedNode.ResizeEnd += e5;
            if (Dragged is Godot.GraphElement.DraggedEventHandler e6)
                castedNode.Dragged += e6;
            if (PositionOffsetChanged is System.Action e7)
                castedNode.PositionOffsetChanged += e7;
            if (PreSortChildren is System.Action e8)
                castedNode.PreSortChildren += e8;
            if (SortChildren is System.Action e9)
                castedNode.SortChildren += e9;
            if (Resized is System.Action e10)
                castedNode.Resized += e10;
            if (GuiInput is Godot.Control.GuiInputEventHandler e11)
                castedNode.GuiInput += e11;
            if (MouseEntered is System.Action e12)
                castedNode.MouseEntered += e12;
            if (MouseExited is System.Action e13)
                castedNode.MouseExited += e13;
            if (FocusEntered is System.Action e14)
                castedNode.FocusEntered += e14;
            if (FocusExited is System.Action e15)
                castedNode.FocusExited += e15;
            if (SizeFlagsChanged is System.Action e16)
                castedNode.SizeFlagsChanged += e16;
            if (MinimumSizeChanged is System.Action e17)
                castedNode.MinimumSizeChanged += e17;
            if (ThemeChanged is System.Action e18)
                castedNode.ThemeChanged += e18;
            if (Draw is System.Action e19)
                castedNode.Draw += e19;
            if (VisibilityChanged is System.Action e20)
                castedNode.VisibilityChanged += e20;
            if (Hidden is System.Action e21)
                castedNode.Hidden += e21;
            if (ItemRectChanged is System.Action e22)
                castedNode.ItemRectChanged += e22;
            if (Ready is System.Action e23)
                castedNode.Ready += e23;
            if (Renamed is System.Action e24)
                castedNode.Renamed += e24;
            if (TreeEntered is System.Action e25)
                castedNode.TreeEntered += e25;
            if (TreeExiting is System.Action e26)
                castedNode.TreeExiting += e26;
            if (TreeExited is System.Action e27)
                castedNode.TreeExited += e27;
            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e28)
                castedNode.ChildEnteredTree += e28;
            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e29)
                castedNode.ChildExitingTree += e29;
            if (ChildOrderChanged is System.Action e30)
                castedNode.ChildOrderChanged += e30;
            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e31)
                castedNode.ReplacingBy += e31;
            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e32)
                castedNode.EditorDescriptionChanged += e32;
            if (ScriptChanged is System.Action e33)
                castedNode.ScriptChanged += e33;
            if (PropertyListChanged is System.Action e34)
                castedNode.PropertyListChanged += e34;
        }
    }
}