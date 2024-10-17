namespace ReactiveSharpGodot.Components
{
    public class HBoxContainer : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GHBoxContainer>
    {
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

        public override ReactiveSharpGodot.Nodes.GHBoxContainer Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GHBoxContainer();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GHBoxContainer node)
        {
            var castedNode = (Godot.HBoxContainer)node.Node;
            if (Alignment is Godot.BoxContainer.AlignmentMode n0)
                castedNode.Alignment = n0;
            if (Vertical is System.Boolean n1)
                castedNode.Vertical = n1;
            if (ClipContents is System.Boolean n2)
                castedNode.ClipContents = n2;
            if (CustomMinimumSize is Godot.Vector2 n3)
                castedNode.CustomMinimumSize = n3;
            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n4)
                castedNode.LayoutDirection = n4;
            if (LayoutMode is System.Int32 n5)
                castedNode.LayoutMode = n5;
            if (AnchorsPreset is System.Int32 n6)
                castedNode.AnchorsPreset = n6;
            if (AnchorLeft is System.Single n7)
                castedNode.AnchorLeft = n7;
            if (AnchorTop is System.Single n8)
                castedNode.AnchorTop = n8;
            if (AnchorRight is System.Single n9)
                castedNode.AnchorRight = n9;
            if (AnchorBottom is System.Single n10)
                castedNode.AnchorBottom = n10;
            if (OffsetLeft is System.Single n11)
                castedNode.OffsetLeft = n11;
            if (OffsetTop is System.Single n12)
                castedNode.OffsetTop = n12;
            if (OffsetRight is System.Single n13)
                castedNode.OffsetRight = n13;
            if (OffsetBottom is System.Single n14)
                castedNode.OffsetBottom = n14;
            if (GrowHorizontal is Godot.Control.GrowDirection n15)
                castedNode.GrowHorizontal = n15;
            if (GrowVertical is Godot.Control.GrowDirection n16)
                castedNode.GrowVertical = n16;
            if (Size is Godot.Vector2 n17)
                castedNode.Size = n17;
            if (Position is Godot.Vector2 n18)
                castedNode.Position = n18;
            if (GlobalPosition is Godot.Vector2 n19)
                castedNode.GlobalPosition = n19;
            if (Rotation is System.Single n20)
                castedNode.Rotation = n20;
            if (RotationDegrees is System.Single n21)
                castedNode.RotationDegrees = n21;
            if (Scale is Godot.Vector2 n22)
                castedNode.Scale = n22;
            if (PivotOffset is Godot.Vector2 n23)
                castedNode.PivotOffset = n23;
            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n24)
                castedNode.SizeFlagsHorizontal = n24;
            if (SizeFlagsVertical is Godot.Control.SizeFlags n25)
                castedNode.SizeFlagsVertical = n25;
            if (SizeFlagsStretchRatio is System.Single n26)
                castedNode.SizeFlagsStretchRatio = n26;
            if (LocalizeNumeralSystem is System.Boolean n27)
                castedNode.LocalizeNumeralSystem = n27;
            if (AutoTranslate is System.Boolean n28)
                castedNode.AutoTranslate = n28;
            if (TooltipText is System.String n29)
                castedNode.TooltipText = n29;
            if (FocusNeighborLeft is Godot.NodePath n30)
                castedNode.FocusNeighborLeft = n30;
            if (FocusNeighborTop is Godot.NodePath n31)
                castedNode.FocusNeighborTop = n31;
            if (FocusNeighborRight is Godot.NodePath n32)
                castedNode.FocusNeighborRight = n32;
            if (FocusNeighborBottom is Godot.NodePath n33)
                castedNode.FocusNeighborBottom = n33;
            if (FocusNext is Godot.NodePath n34)
                castedNode.FocusNext = n34;
            if (FocusPrevious is Godot.NodePath n35)
                castedNode.FocusPrevious = n35;
            if (FocusMode is Godot.Control.FocusModeEnum n36)
                castedNode.FocusMode = n36;
            if (MouseFilter is Godot.Control.MouseFilterEnum n37)
                castedNode.MouseFilter = n37;
            if (MouseForcePassScrollEvents is System.Boolean n38)
                castedNode.MouseForcePassScrollEvents = n38;
            if (MouseDefaultCursorShape is Godot.Control.CursorShape n39)
                castedNode.MouseDefaultCursorShape = n39;
            if (ShortcutContext is Godot.Node n40)
                castedNode.ShortcutContext = n40;
            if (Theme is Godot.Theme n41)
                castedNode.Theme = n41;
            if (ThemeTypeVariation is Godot.StringName n42)
                castedNode.ThemeTypeVariation = n42;
            if (Visible is System.Boolean n43)
                castedNode.Visible = n43;
            if (Modulate is Godot.Color n44)
                castedNode.Modulate = n44;
            if (SelfModulate is Godot.Color n45)
                castedNode.SelfModulate = n45;
            if (ShowBehindParent is System.Boolean n46)
                castedNode.ShowBehindParent = n46;
            if (TopLevel is System.Boolean n47)
                castedNode.TopLevel = n47;
            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n48)
                castedNode.ClipChildren = n48;
            if (LightMask is System.Int32 n49)
                castedNode.LightMask = n49;
            if (VisibilityLayer is System.UInt32 n50)
                castedNode.VisibilityLayer = n50;
            if (ZIndex is System.Int32 n51)
                castedNode.ZIndex = n51;
            if (ZAsRelative is System.Boolean n52)
                castedNode.ZAsRelative = n52;
            if (YSortEnabled is System.Boolean n53)
                castedNode.YSortEnabled = n53;
            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n54)
                castedNode.TextureFilter = n54;
            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n55)
                castedNode.TextureRepeat = n55;
            if (Material is Godot.Material n56)
                castedNode.Material = n56;
            if (UseParentMaterial is System.Boolean n57)
                castedNode.UseParentMaterial = n57;
            if (Name is Godot.StringName n58)
                castedNode.Name = n58;
            if (UniqueNameInOwner is System.Boolean n59)
                castedNode.UniqueNameInOwner = n59;
            if (SceneFilePath is System.String n60)
                castedNode.SceneFilePath = n60;
            if (Owner is Godot.Node n61)
                castedNode.Owner = n61;
            if (ProcessMode is Godot.Node.ProcessModeEnum n62)
                castedNode.ProcessMode = n62;
            if (ProcessPriority is System.Int32 n63)
                castedNode.ProcessPriority = n63;
            if (ProcessPhysicsPriority is System.Int32 n64)
                castedNode.ProcessPhysicsPriority = n64;
            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n65)
                castedNode.ProcessThreadGroup = n65;
            if (ProcessThreadGroupOrder is System.Int32 n66)
                castedNode.ProcessThreadGroupOrder = n66;
            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n67)
                castedNode.ProcessThreadMessages = n67;
            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n68)
                castedNode.PhysicsInterpolationMode = n68;
            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n69)
                castedNode.AutoTranslateMode = n69;
            if (EditorDescription is System.String n70)
                castedNode.EditorDescription = n70;
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