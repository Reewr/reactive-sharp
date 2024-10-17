namespace ReactiveSharpGodot.Components
{
    public class CenterContainer : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GCenterContainer>
    {
        public System.Boolean? UseTopLeft { protected get; init; }
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

        public override ReactiveSharpGodot.Nodes.GCenterContainer Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GCenterContainer();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GCenterContainer node)
        {
            var castedNode = (Godot.CenterContainer)node.Node;
            if (UseTopLeft is System.Boolean n0)
                castedNode.UseTopLeft = n0;
            if (ClipContents is System.Boolean n1)
                castedNode.ClipContents = n1;
            if (CustomMinimumSize is Godot.Vector2 n2)
                castedNode.CustomMinimumSize = n2;
            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n3)
                castedNode.LayoutDirection = n3;
            if (LayoutMode is System.Int32 n4)
                castedNode.LayoutMode = n4;
            if (AnchorsPreset is System.Int32 n5)
                castedNode.AnchorsPreset = n5;
            if (AnchorLeft is System.Single n6)
                castedNode.AnchorLeft = n6;
            if (AnchorTop is System.Single n7)
                castedNode.AnchorTop = n7;
            if (AnchorRight is System.Single n8)
                castedNode.AnchorRight = n8;
            if (AnchorBottom is System.Single n9)
                castedNode.AnchorBottom = n9;
            if (OffsetLeft is System.Single n10)
                castedNode.OffsetLeft = n10;
            if (OffsetTop is System.Single n11)
                castedNode.OffsetTop = n11;
            if (OffsetRight is System.Single n12)
                castedNode.OffsetRight = n12;
            if (OffsetBottom is System.Single n13)
                castedNode.OffsetBottom = n13;
            if (GrowHorizontal is Godot.Control.GrowDirection n14)
                castedNode.GrowHorizontal = n14;
            if (GrowVertical is Godot.Control.GrowDirection n15)
                castedNode.GrowVertical = n15;
            if (Size is Godot.Vector2 n16)
                castedNode.Size = n16;
            if (Position is Godot.Vector2 n17)
                castedNode.Position = n17;
            if (GlobalPosition is Godot.Vector2 n18)
                castedNode.GlobalPosition = n18;
            if (Rotation is System.Single n19)
                castedNode.Rotation = n19;
            if (RotationDegrees is System.Single n20)
                castedNode.RotationDegrees = n20;
            if (Scale is Godot.Vector2 n21)
                castedNode.Scale = n21;
            if (PivotOffset is Godot.Vector2 n22)
                castedNode.PivotOffset = n22;
            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n23)
                castedNode.SizeFlagsHorizontal = n23;
            if (SizeFlagsVertical is Godot.Control.SizeFlags n24)
                castedNode.SizeFlagsVertical = n24;
            if (SizeFlagsStretchRatio is System.Single n25)
                castedNode.SizeFlagsStretchRatio = n25;
            if (LocalizeNumeralSystem is System.Boolean n26)
                castedNode.LocalizeNumeralSystem = n26;
            if (AutoTranslate is System.Boolean n27)
                castedNode.AutoTranslate = n27;
            if (TooltipText is System.String n28)
                castedNode.TooltipText = n28;
            if (FocusNeighborLeft is Godot.NodePath n29)
                castedNode.FocusNeighborLeft = n29;
            if (FocusNeighborTop is Godot.NodePath n30)
                castedNode.FocusNeighborTop = n30;
            if (FocusNeighborRight is Godot.NodePath n31)
                castedNode.FocusNeighborRight = n31;
            if (FocusNeighborBottom is Godot.NodePath n32)
                castedNode.FocusNeighborBottom = n32;
            if (FocusNext is Godot.NodePath n33)
                castedNode.FocusNext = n33;
            if (FocusPrevious is Godot.NodePath n34)
                castedNode.FocusPrevious = n34;
            if (FocusMode is Godot.Control.FocusModeEnum n35)
                castedNode.FocusMode = n35;
            if (MouseFilter is Godot.Control.MouseFilterEnum n36)
                castedNode.MouseFilter = n36;
            if (MouseForcePassScrollEvents is System.Boolean n37)
                castedNode.MouseForcePassScrollEvents = n37;
            if (MouseDefaultCursorShape is Godot.Control.CursorShape n38)
                castedNode.MouseDefaultCursorShape = n38;
            if (ShortcutContext is Godot.Node n39)
                castedNode.ShortcutContext = n39;
            if (Theme is Godot.Theme n40)
                castedNode.Theme = n40;
            if (ThemeTypeVariation is Godot.StringName n41)
                castedNode.ThemeTypeVariation = n41;
            if (Visible is System.Boolean n42)
                castedNode.Visible = n42;
            if (Modulate is Godot.Color n43)
                castedNode.Modulate = n43;
            if (SelfModulate is Godot.Color n44)
                castedNode.SelfModulate = n44;
            if (ShowBehindParent is System.Boolean n45)
                castedNode.ShowBehindParent = n45;
            if (TopLevel is System.Boolean n46)
                castedNode.TopLevel = n46;
            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n47)
                castedNode.ClipChildren = n47;
            if (LightMask is System.Int32 n48)
                castedNode.LightMask = n48;
            if (VisibilityLayer is System.UInt32 n49)
                castedNode.VisibilityLayer = n49;
            if (ZIndex is System.Int32 n50)
                castedNode.ZIndex = n50;
            if (ZAsRelative is System.Boolean n51)
                castedNode.ZAsRelative = n51;
            if (YSortEnabled is System.Boolean n52)
                castedNode.YSortEnabled = n52;
            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n53)
                castedNode.TextureFilter = n53;
            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n54)
                castedNode.TextureRepeat = n54;
            if (Material is Godot.Material n55)
                castedNode.Material = n55;
            if (UseParentMaterial is System.Boolean n56)
                castedNode.UseParentMaterial = n56;
            if (Name is Godot.StringName n57)
                castedNode.Name = n57;
            if (UniqueNameInOwner is System.Boolean n58)
                castedNode.UniqueNameInOwner = n58;
            if (SceneFilePath is System.String n59)
                castedNode.SceneFilePath = n59;
            if (Owner is Godot.Node n60)
                castedNode.Owner = n60;
            if (ProcessMode is Godot.Node.ProcessModeEnum n61)
                castedNode.ProcessMode = n61;
            if (ProcessPriority is System.Int32 n62)
                castedNode.ProcessPriority = n62;
            if (ProcessPhysicsPriority is System.Int32 n63)
                castedNode.ProcessPhysicsPriority = n63;
            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n64)
                castedNode.ProcessThreadGroup = n64;
            if (ProcessThreadGroupOrder is System.Int32 n65)
                castedNode.ProcessThreadGroupOrder = n65;
            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n66)
                castedNode.ProcessThreadMessages = n66;
            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n67)
                castedNode.PhysicsInterpolationMode = n67;
            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n68)
                castedNode.AutoTranslateMode = n68;
            if (EditorDescription is System.String n69)
                castedNode.EditorDescription = n69;
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