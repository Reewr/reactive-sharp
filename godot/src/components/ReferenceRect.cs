namespace ReactiveSharpGodot.Components
{
    public class ReferenceRect : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GReferenceRect>
    {
        public Godot.Color? BorderColor { protected get; init; }
        public System.Single? BorderWidth { protected get; init; }
        public System.Boolean? EditorOnly { protected get; init; }
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

        public override ReactiveSharpGodot.Nodes.GReferenceRect Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GReferenceRect();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GReferenceRect node)
        {
            var castedNode = (Godot.ReferenceRect)node.Node;
            if (BorderColor is Godot.Color n0)
                castedNode.BorderColor = n0;
            if (BorderWidth is System.Single n1)
                castedNode.BorderWidth = n1;
            if (EditorOnly is System.Boolean n2)
                castedNode.EditorOnly = n2;
            if (ClipContents is System.Boolean n3)
                castedNode.ClipContents = n3;
            if (CustomMinimumSize is Godot.Vector2 n4)
                castedNode.CustomMinimumSize = n4;
            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n5)
                castedNode.LayoutDirection = n5;
            if (LayoutMode is System.Int32 n6)
                castedNode.LayoutMode = n6;
            if (AnchorsPreset is System.Int32 n7)
                castedNode.AnchorsPreset = n7;
            if (AnchorLeft is System.Single n8)
                castedNode.AnchorLeft = n8;
            if (AnchorTop is System.Single n9)
                castedNode.AnchorTop = n9;
            if (AnchorRight is System.Single n10)
                castedNode.AnchorRight = n10;
            if (AnchorBottom is System.Single n11)
                castedNode.AnchorBottom = n11;
            if (OffsetLeft is System.Single n12)
                castedNode.OffsetLeft = n12;
            if (OffsetTop is System.Single n13)
                castedNode.OffsetTop = n13;
            if (OffsetRight is System.Single n14)
                castedNode.OffsetRight = n14;
            if (OffsetBottom is System.Single n15)
                castedNode.OffsetBottom = n15;
            if (GrowHorizontal is Godot.Control.GrowDirection n16)
                castedNode.GrowHorizontal = n16;
            if (GrowVertical is Godot.Control.GrowDirection n17)
                castedNode.GrowVertical = n17;
            if (Size is Godot.Vector2 n18)
                castedNode.Size = n18;
            if (Position is Godot.Vector2 n19)
                castedNode.Position = n19;
            if (GlobalPosition is Godot.Vector2 n20)
                castedNode.GlobalPosition = n20;
            if (Rotation is System.Single n21)
                castedNode.Rotation = n21;
            if (RotationDegrees is System.Single n22)
                castedNode.RotationDegrees = n22;
            if (Scale is Godot.Vector2 n23)
                castedNode.Scale = n23;
            if (PivotOffset is Godot.Vector2 n24)
                castedNode.PivotOffset = n24;
            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n25)
                castedNode.SizeFlagsHorizontal = n25;
            if (SizeFlagsVertical is Godot.Control.SizeFlags n26)
                castedNode.SizeFlagsVertical = n26;
            if (SizeFlagsStretchRatio is System.Single n27)
                castedNode.SizeFlagsStretchRatio = n27;
            if (LocalizeNumeralSystem is System.Boolean n28)
                castedNode.LocalizeNumeralSystem = n28;
            if (AutoTranslate is System.Boolean n29)
                castedNode.AutoTranslate = n29;
            if (TooltipText is System.String n30)
                castedNode.TooltipText = n30;
            if (FocusNeighborLeft is Godot.NodePath n31)
                castedNode.FocusNeighborLeft = n31;
            if (FocusNeighborTop is Godot.NodePath n32)
                castedNode.FocusNeighborTop = n32;
            if (FocusNeighborRight is Godot.NodePath n33)
                castedNode.FocusNeighborRight = n33;
            if (FocusNeighborBottom is Godot.NodePath n34)
                castedNode.FocusNeighborBottom = n34;
            if (FocusNext is Godot.NodePath n35)
                castedNode.FocusNext = n35;
            if (FocusPrevious is Godot.NodePath n36)
                castedNode.FocusPrevious = n36;
            if (FocusMode is Godot.Control.FocusModeEnum n37)
                castedNode.FocusMode = n37;
            if (MouseFilter is Godot.Control.MouseFilterEnum n38)
                castedNode.MouseFilter = n38;
            if (MouseForcePassScrollEvents is System.Boolean n39)
                castedNode.MouseForcePassScrollEvents = n39;
            if (MouseDefaultCursorShape is Godot.Control.CursorShape n40)
                castedNode.MouseDefaultCursorShape = n40;
            if (ShortcutContext is Godot.Node n41)
                castedNode.ShortcutContext = n41;
            if (Theme is Godot.Theme n42)
                castedNode.Theme = n42;
            if (ThemeTypeVariation is Godot.StringName n43)
                castedNode.ThemeTypeVariation = n43;
            if (Visible is System.Boolean n44)
                castedNode.Visible = n44;
            if (Modulate is Godot.Color n45)
                castedNode.Modulate = n45;
            if (SelfModulate is Godot.Color n46)
                castedNode.SelfModulate = n46;
            if (ShowBehindParent is System.Boolean n47)
                castedNode.ShowBehindParent = n47;
            if (TopLevel is System.Boolean n48)
                castedNode.TopLevel = n48;
            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n49)
                castedNode.ClipChildren = n49;
            if (LightMask is System.Int32 n50)
                castedNode.LightMask = n50;
            if (VisibilityLayer is System.UInt32 n51)
                castedNode.VisibilityLayer = n51;
            if (ZIndex is System.Int32 n52)
                castedNode.ZIndex = n52;
            if (ZAsRelative is System.Boolean n53)
                castedNode.ZAsRelative = n53;
            if (YSortEnabled is System.Boolean n54)
                castedNode.YSortEnabled = n54;
            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n55)
                castedNode.TextureFilter = n55;
            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n56)
                castedNode.TextureRepeat = n56;
            if (Material is Godot.Material n57)
                castedNode.Material = n57;
            if (UseParentMaterial is System.Boolean n58)
                castedNode.UseParentMaterial = n58;
            if (Name is Godot.StringName n59)
                castedNode.Name = n59;
            if (UniqueNameInOwner is System.Boolean n60)
                castedNode.UniqueNameInOwner = n60;
            if (SceneFilePath is System.String n61)
                castedNode.SceneFilePath = n61;
            if (Owner is Godot.Node n62)
                castedNode.Owner = n62;
            if (ProcessMode is Godot.Node.ProcessModeEnum n63)
                castedNode.ProcessMode = n63;
            if (ProcessPriority is System.Int32 n64)
                castedNode.ProcessPriority = n64;
            if (ProcessPhysicsPriority is System.Int32 n65)
                castedNode.ProcessPhysicsPriority = n65;
            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n66)
                castedNode.ProcessThreadGroup = n66;
            if (ProcessThreadGroupOrder is System.Int32 n67)
                castedNode.ProcessThreadGroupOrder = n67;
            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n68)
                castedNode.ProcessThreadMessages = n68;
            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n69)
                castedNode.PhysicsInterpolationMode = n69;
            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n70)
                castedNode.AutoTranslateMode = n70;
            if (EditorDescription is System.String n71)
                castedNode.EditorDescription = n71;
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