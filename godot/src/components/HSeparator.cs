namespace ReactiveSharpGodot.Components
{
    public class HSeparator : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GHSeparator>
    {
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

        public override ReactiveSharpGodot.Nodes.GHSeparator Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GHSeparator();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GHSeparator node)
        {
            var castedNode = (Godot.HSeparator)node.Node;
            if (ClipContents is System.Boolean n0)
                castedNode.ClipContents = n0;
            if (CustomMinimumSize is Godot.Vector2 n1)
                castedNode.CustomMinimumSize = n1;
            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n2)
                castedNode.LayoutDirection = n2;
            if (LayoutMode is System.Int32 n3)
                castedNode.LayoutMode = n3;
            if (AnchorsPreset is System.Int32 n4)
                castedNode.AnchorsPreset = n4;
            if (AnchorLeft is System.Single n5)
                castedNode.AnchorLeft = n5;
            if (AnchorTop is System.Single n6)
                castedNode.AnchorTop = n6;
            if (AnchorRight is System.Single n7)
                castedNode.AnchorRight = n7;
            if (AnchorBottom is System.Single n8)
                castedNode.AnchorBottom = n8;
            if (OffsetLeft is System.Single n9)
                castedNode.OffsetLeft = n9;
            if (OffsetTop is System.Single n10)
                castedNode.OffsetTop = n10;
            if (OffsetRight is System.Single n11)
                castedNode.OffsetRight = n11;
            if (OffsetBottom is System.Single n12)
                castedNode.OffsetBottom = n12;
            if (GrowHorizontal is Godot.Control.GrowDirection n13)
                castedNode.GrowHorizontal = n13;
            if (GrowVertical is Godot.Control.GrowDirection n14)
                castedNode.GrowVertical = n14;
            if (Size is Godot.Vector2 n15)
                castedNode.Size = n15;
            if (Position is Godot.Vector2 n16)
                castedNode.Position = n16;
            if (GlobalPosition is Godot.Vector2 n17)
                castedNode.GlobalPosition = n17;
            if (Rotation is System.Single n18)
                castedNode.Rotation = n18;
            if (RotationDegrees is System.Single n19)
                castedNode.RotationDegrees = n19;
            if (Scale is Godot.Vector2 n20)
                castedNode.Scale = n20;
            if (PivotOffset is Godot.Vector2 n21)
                castedNode.PivotOffset = n21;
            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n22)
                castedNode.SizeFlagsHorizontal = n22;
            if (SizeFlagsVertical is Godot.Control.SizeFlags n23)
                castedNode.SizeFlagsVertical = n23;
            if (SizeFlagsStretchRatio is System.Single n24)
                castedNode.SizeFlagsStretchRatio = n24;
            if (LocalizeNumeralSystem is System.Boolean n25)
                castedNode.LocalizeNumeralSystem = n25;
            if (AutoTranslate is System.Boolean n26)
                castedNode.AutoTranslate = n26;
            if (TooltipText is System.String n27)
                castedNode.TooltipText = n27;
            if (FocusNeighborLeft is Godot.NodePath n28)
                castedNode.FocusNeighborLeft = n28;
            if (FocusNeighborTop is Godot.NodePath n29)
                castedNode.FocusNeighborTop = n29;
            if (FocusNeighborRight is Godot.NodePath n30)
                castedNode.FocusNeighborRight = n30;
            if (FocusNeighborBottom is Godot.NodePath n31)
                castedNode.FocusNeighborBottom = n31;
            if (FocusNext is Godot.NodePath n32)
                castedNode.FocusNext = n32;
            if (FocusPrevious is Godot.NodePath n33)
                castedNode.FocusPrevious = n33;
            if (FocusMode is Godot.Control.FocusModeEnum n34)
                castedNode.FocusMode = n34;
            if (MouseFilter is Godot.Control.MouseFilterEnum n35)
                castedNode.MouseFilter = n35;
            if (MouseForcePassScrollEvents is System.Boolean n36)
                castedNode.MouseForcePassScrollEvents = n36;
            if (MouseDefaultCursorShape is Godot.Control.CursorShape n37)
                castedNode.MouseDefaultCursorShape = n37;
            if (ShortcutContext is Godot.Node n38)
                castedNode.ShortcutContext = n38;
            if (Theme is Godot.Theme n39)
                castedNode.Theme = n39;
            if (ThemeTypeVariation is Godot.StringName n40)
                castedNode.ThemeTypeVariation = n40;
            if (Visible is System.Boolean n41)
                castedNode.Visible = n41;
            if (Modulate is Godot.Color n42)
                castedNode.Modulate = n42;
            if (SelfModulate is Godot.Color n43)
                castedNode.SelfModulate = n43;
            if (ShowBehindParent is System.Boolean n44)
                castedNode.ShowBehindParent = n44;
            if (TopLevel is System.Boolean n45)
                castedNode.TopLevel = n45;
            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n46)
                castedNode.ClipChildren = n46;
            if (LightMask is System.Int32 n47)
                castedNode.LightMask = n47;
            if (VisibilityLayer is System.UInt32 n48)
                castedNode.VisibilityLayer = n48;
            if (ZIndex is System.Int32 n49)
                castedNode.ZIndex = n49;
            if (ZAsRelative is System.Boolean n50)
                castedNode.ZAsRelative = n50;
            if (YSortEnabled is System.Boolean n51)
                castedNode.YSortEnabled = n51;
            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n52)
                castedNode.TextureFilter = n52;
            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n53)
                castedNode.TextureRepeat = n53;
            if (Material is Godot.Material n54)
                castedNode.Material = n54;
            if (UseParentMaterial is System.Boolean n55)
                castedNode.UseParentMaterial = n55;
            if (Name is Godot.StringName n56)
                castedNode.Name = n56;
            if (UniqueNameInOwner is System.Boolean n57)
                castedNode.UniqueNameInOwner = n57;
            if (SceneFilePath is System.String n58)
                castedNode.SceneFilePath = n58;
            if (Owner is Godot.Node n59)
                castedNode.Owner = n59;
            if (ProcessMode is Godot.Node.ProcessModeEnum n60)
                castedNode.ProcessMode = n60;
            if (ProcessPriority is System.Int32 n61)
                castedNode.ProcessPriority = n61;
            if (ProcessPhysicsPriority is System.Int32 n62)
                castedNode.ProcessPhysicsPriority = n62;
            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n63)
                castedNode.ProcessThreadGroup = n63;
            if (ProcessThreadGroupOrder is System.Int32 n64)
                castedNode.ProcessThreadGroupOrder = n64;
            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n65)
                castedNode.ProcessThreadMessages = n65;
            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n66)
                castedNode.PhysicsInterpolationMode = n66;
            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n67)
                castedNode.AutoTranslateMode = n67;
            if (EditorDescription is System.String n68)
                castedNode.EditorDescription = n68;
            if (Resized is System.Action e0)
                castedNode.Resized += e0;
            if (GuiInput is Godot.Control.GuiInputEventHandler e1)
                castedNode.GuiInput += e1;
            if (MouseEntered is System.Action e2)
                castedNode.MouseEntered += e2;
            if (MouseExited is System.Action e3)
                castedNode.MouseExited += e3;
            if (FocusEntered is System.Action e4)
                castedNode.FocusEntered += e4;
            if (FocusExited is System.Action e5)
                castedNode.FocusExited += e5;
            if (SizeFlagsChanged is System.Action e6)
                castedNode.SizeFlagsChanged += e6;
            if (MinimumSizeChanged is System.Action e7)
                castedNode.MinimumSizeChanged += e7;
            if (ThemeChanged is System.Action e8)
                castedNode.ThemeChanged += e8;
            if (Draw is System.Action e9)
                castedNode.Draw += e9;
            if (VisibilityChanged is System.Action e10)
                castedNode.VisibilityChanged += e10;
            if (Hidden is System.Action e11)
                castedNode.Hidden += e11;
            if (ItemRectChanged is System.Action e12)
                castedNode.ItemRectChanged += e12;
            if (Ready is System.Action e13)
                castedNode.Ready += e13;
            if (Renamed is System.Action e14)
                castedNode.Renamed += e14;
            if (TreeEntered is System.Action e15)
                castedNode.TreeEntered += e15;
            if (TreeExiting is System.Action e16)
                castedNode.TreeExiting += e16;
            if (TreeExited is System.Action e17)
                castedNode.TreeExited += e17;
            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e18)
                castedNode.ChildEnteredTree += e18;
            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e19)
                castedNode.ChildExitingTree += e19;
            if (ChildOrderChanged is System.Action e20)
                castedNode.ChildOrderChanged += e20;
            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e21)
                castedNode.ReplacingBy += e21;
            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e22)
                castedNode.EditorDescriptionChanged += e22;
            if (ScriptChanged is System.Action e23)
                castedNode.ScriptChanged += e23;
            if (PropertyListChanged is System.Action e24)
                castedNode.PropertyListChanged += e24;
        }
    }
}