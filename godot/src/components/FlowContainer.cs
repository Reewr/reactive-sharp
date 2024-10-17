namespace ReactiveSharpGodot.Components
{
    public class FlowContainer : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GFlowContainer>
    {
        public Godot.FlowContainer.AlignmentMode? Alignment { protected get; init; }
        public Godot.FlowContainer.LastWrapAlignmentMode? LastWrapAlignment { protected get; init; }
        public System.Boolean? Vertical { protected get; init; }
        public System.Boolean? ReverseFill { protected get; init; }
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

        public override ReactiveSharpGodot.Nodes.GFlowContainer Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GFlowContainer();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GFlowContainer node)
        {
            var castedNode = (Godot.FlowContainer)node.Node;
            if (Alignment is Godot.FlowContainer.AlignmentMode n0)
                castedNode.Alignment = n0;
            if (LastWrapAlignment is Godot.FlowContainer.LastWrapAlignmentMode n1)
                castedNode.LastWrapAlignment = n1;
            if (Vertical is System.Boolean n2)
                castedNode.Vertical = n2;
            if (ReverseFill is System.Boolean n3)
                castedNode.ReverseFill = n3;
            if (ClipContents is System.Boolean n4)
                castedNode.ClipContents = n4;
            if (CustomMinimumSize is Godot.Vector2 n5)
                castedNode.CustomMinimumSize = n5;
            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n6)
                castedNode.LayoutDirection = n6;
            if (LayoutMode is System.Int32 n7)
                castedNode.LayoutMode = n7;
            if (AnchorsPreset is System.Int32 n8)
                castedNode.AnchorsPreset = n8;
            if (AnchorLeft is System.Single n9)
                castedNode.AnchorLeft = n9;
            if (AnchorTop is System.Single n10)
                castedNode.AnchorTop = n10;
            if (AnchorRight is System.Single n11)
                castedNode.AnchorRight = n11;
            if (AnchorBottom is System.Single n12)
                castedNode.AnchorBottom = n12;
            if (OffsetLeft is System.Single n13)
                castedNode.OffsetLeft = n13;
            if (OffsetTop is System.Single n14)
                castedNode.OffsetTop = n14;
            if (OffsetRight is System.Single n15)
                castedNode.OffsetRight = n15;
            if (OffsetBottom is System.Single n16)
                castedNode.OffsetBottom = n16;
            if (GrowHorizontal is Godot.Control.GrowDirection n17)
                castedNode.GrowHorizontal = n17;
            if (GrowVertical is Godot.Control.GrowDirection n18)
                castedNode.GrowVertical = n18;
            if (Size is Godot.Vector2 n19)
                castedNode.Size = n19;
            if (Position is Godot.Vector2 n20)
                castedNode.Position = n20;
            if (GlobalPosition is Godot.Vector2 n21)
                castedNode.GlobalPosition = n21;
            if (Rotation is System.Single n22)
                castedNode.Rotation = n22;
            if (RotationDegrees is System.Single n23)
                castedNode.RotationDegrees = n23;
            if (Scale is Godot.Vector2 n24)
                castedNode.Scale = n24;
            if (PivotOffset is Godot.Vector2 n25)
                castedNode.PivotOffset = n25;
            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n26)
                castedNode.SizeFlagsHorizontal = n26;
            if (SizeFlagsVertical is Godot.Control.SizeFlags n27)
                castedNode.SizeFlagsVertical = n27;
            if (SizeFlagsStretchRatio is System.Single n28)
                castedNode.SizeFlagsStretchRatio = n28;
            if (LocalizeNumeralSystem is System.Boolean n29)
                castedNode.LocalizeNumeralSystem = n29;
            if (AutoTranslate is System.Boolean n30)
                castedNode.AutoTranslate = n30;
            if (TooltipText is System.String n31)
                castedNode.TooltipText = n31;
            if (FocusNeighborLeft is Godot.NodePath n32)
                castedNode.FocusNeighborLeft = n32;
            if (FocusNeighborTop is Godot.NodePath n33)
                castedNode.FocusNeighborTop = n33;
            if (FocusNeighborRight is Godot.NodePath n34)
                castedNode.FocusNeighborRight = n34;
            if (FocusNeighborBottom is Godot.NodePath n35)
                castedNode.FocusNeighborBottom = n35;
            if (FocusNext is Godot.NodePath n36)
                castedNode.FocusNext = n36;
            if (FocusPrevious is Godot.NodePath n37)
                castedNode.FocusPrevious = n37;
            if (FocusMode is Godot.Control.FocusModeEnum n38)
                castedNode.FocusMode = n38;
            if (MouseFilter is Godot.Control.MouseFilterEnum n39)
                castedNode.MouseFilter = n39;
            if (MouseForcePassScrollEvents is System.Boolean n40)
                castedNode.MouseForcePassScrollEvents = n40;
            if (MouseDefaultCursorShape is Godot.Control.CursorShape n41)
                castedNode.MouseDefaultCursorShape = n41;
            if (ShortcutContext is Godot.Node n42)
                castedNode.ShortcutContext = n42;
            if (Theme is Godot.Theme n43)
                castedNode.Theme = n43;
            if (ThemeTypeVariation is Godot.StringName n44)
                castedNode.ThemeTypeVariation = n44;
            if (Visible is System.Boolean n45)
                castedNode.Visible = n45;
            if (Modulate is Godot.Color n46)
                castedNode.Modulate = n46;
            if (SelfModulate is Godot.Color n47)
                castedNode.SelfModulate = n47;
            if (ShowBehindParent is System.Boolean n48)
                castedNode.ShowBehindParent = n48;
            if (TopLevel is System.Boolean n49)
                castedNode.TopLevel = n49;
            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n50)
                castedNode.ClipChildren = n50;
            if (LightMask is System.Int32 n51)
                castedNode.LightMask = n51;
            if (VisibilityLayer is System.UInt32 n52)
                castedNode.VisibilityLayer = n52;
            if (ZIndex is System.Int32 n53)
                castedNode.ZIndex = n53;
            if (ZAsRelative is System.Boolean n54)
                castedNode.ZAsRelative = n54;
            if (YSortEnabled is System.Boolean n55)
                castedNode.YSortEnabled = n55;
            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n56)
                castedNode.TextureFilter = n56;
            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n57)
                castedNode.TextureRepeat = n57;
            if (Material is Godot.Material n58)
                castedNode.Material = n58;
            if (UseParentMaterial is System.Boolean n59)
                castedNode.UseParentMaterial = n59;
            if (Name is Godot.StringName n60)
                castedNode.Name = n60;
            if (UniqueNameInOwner is System.Boolean n61)
                castedNode.UniqueNameInOwner = n61;
            if (SceneFilePath is System.String n62)
                castedNode.SceneFilePath = n62;
            if (Owner is Godot.Node n63)
                castedNode.Owner = n63;
            if (ProcessMode is Godot.Node.ProcessModeEnum n64)
                castedNode.ProcessMode = n64;
            if (ProcessPriority is System.Int32 n65)
                castedNode.ProcessPriority = n65;
            if (ProcessPhysicsPriority is System.Int32 n66)
                castedNode.ProcessPhysicsPriority = n66;
            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n67)
                castedNode.ProcessThreadGroup = n67;
            if (ProcessThreadGroupOrder is System.Int32 n68)
                castedNode.ProcessThreadGroupOrder = n68;
            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n69)
                castedNode.ProcessThreadMessages = n69;
            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n70)
                castedNode.PhysicsInterpolationMode = n70;
            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n71)
                castedNode.AutoTranslateMode = n71;
            if (EditorDescription is System.String n72)
                castedNode.EditorDescription = n72;
            if (PreSortChildren is System.Action e0)
                castedNode.PreSortChildren += e0;
            if (SortChildren is System.Action e1)
                castedNode.SortChildren += e1;
            if (Resized is System.Action e2)
                castedNode.Resized += e2;
            if (GuiInput is Godot.Control.GuiInputEventHandler e3)
                castedNode.GuiInput += e3;
            if (MouseEntered is System.Action e4)
                castedNode.MouseEntered += e4;
            if (MouseExited is System.Action e5)
                castedNode.MouseExited += e5;
            if (FocusEntered is System.Action e6)
                castedNode.FocusEntered += e6;
            if (FocusExited is System.Action e7)
                castedNode.FocusExited += e7;
            if (SizeFlagsChanged is System.Action e8)
                castedNode.SizeFlagsChanged += e8;
            if (MinimumSizeChanged is System.Action e9)
                castedNode.MinimumSizeChanged += e9;
            if (ThemeChanged is System.Action e10)
                castedNode.ThemeChanged += e10;
            if (Draw is System.Action e11)
                castedNode.Draw += e11;
            if (VisibilityChanged is System.Action e12)
                castedNode.VisibilityChanged += e12;
            if (Hidden is System.Action e13)
                castedNode.Hidden += e13;
            if (ItemRectChanged is System.Action e14)
                castedNode.ItemRectChanged += e14;
            if (Ready is System.Action e15)
                castedNode.Ready += e15;
            if (Renamed is System.Action e16)
                castedNode.Renamed += e16;
            if (TreeEntered is System.Action e17)
                castedNode.TreeEntered += e17;
            if (TreeExiting is System.Action e18)
                castedNode.TreeExiting += e18;
            if (TreeExited is System.Action e19)
                castedNode.TreeExited += e19;
            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e20)
                castedNode.ChildEnteredTree += e20;
            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e21)
                castedNode.ChildExitingTree += e21;
            if (ChildOrderChanged is System.Action e22)
                castedNode.ChildOrderChanged += e22;
            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e23)
                castedNode.ReplacingBy += e23;
            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e24)
                castedNode.EditorDescriptionChanged += e24;
            if (ScriptChanged is System.Action e25)
                castedNode.ScriptChanged += e25;
            if (PropertyListChanged is System.Action e26)
                castedNode.PropertyListChanged += e26;
        }
    }
}