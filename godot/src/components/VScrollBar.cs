namespace ReactiveSharpGodot.Components
{
    public class VScrollBar : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GVScrollBar>
    {
        public System.Single? CustomStep { protected get; init; }
        public System.Double? MinValue { protected get; init; }
        public System.Double? MaxValue { protected get; init; }
        public System.Double? Step { protected get; init; }
        public System.Double? Page { protected get; init; }
        public System.Double? Value { protected get; init; }
        public System.Double? Ratio { protected get; init; }
        public System.Boolean? ExpEdit { protected get; init; }
        public System.Boolean? Rounded { protected get; init; }
        public System.Boolean? AllowGreater { protected get; init; }
        public System.Boolean? AllowLesser { protected get; init; }
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
        public System.Action? Scrolling { protected get; init; }
        public Godot.Range.ValueChangedEventHandler? ValueChanged { protected get; init; }
        public System.Action? Changed { protected get; init; }
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

        public override ReactiveSharpGodot.Nodes.GVScrollBar Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GVScrollBar();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GVScrollBar node)
        {
            var castedNode = (Godot.VScrollBar)node.Node;
            if (CustomStep is System.Single n0)
                castedNode.CustomStep = n0;
            if (MinValue is System.Double n1)
                castedNode.MinValue = n1;
            if (MaxValue is System.Double n2)
                castedNode.MaxValue = n2;
            if (Step is System.Double n3)
                castedNode.Step = n3;
            if (Page is System.Double n4)
                castedNode.Page = n4;
            if (Value is System.Double n5)
                castedNode.Value = n5;
            if (Ratio is System.Double n6)
                castedNode.Ratio = n6;
            if (ExpEdit is System.Boolean n7)
                castedNode.ExpEdit = n7;
            if (Rounded is System.Boolean n8)
                castedNode.Rounded = n8;
            if (AllowGreater is System.Boolean n9)
                castedNode.AllowGreater = n9;
            if (AllowLesser is System.Boolean n10)
                castedNode.AllowLesser = n10;
            if (ClipContents is System.Boolean n11)
                castedNode.ClipContents = n11;
            if (CustomMinimumSize is Godot.Vector2 n12)
                castedNode.CustomMinimumSize = n12;
            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n13)
                castedNode.LayoutDirection = n13;
            if (LayoutMode is System.Int32 n14)
                castedNode.LayoutMode = n14;
            if (AnchorsPreset is System.Int32 n15)
                castedNode.AnchorsPreset = n15;
            if (AnchorLeft is System.Single n16)
                castedNode.AnchorLeft = n16;
            if (AnchorTop is System.Single n17)
                castedNode.AnchorTop = n17;
            if (AnchorRight is System.Single n18)
                castedNode.AnchorRight = n18;
            if (AnchorBottom is System.Single n19)
                castedNode.AnchorBottom = n19;
            if (OffsetLeft is System.Single n20)
                castedNode.OffsetLeft = n20;
            if (OffsetTop is System.Single n21)
                castedNode.OffsetTop = n21;
            if (OffsetRight is System.Single n22)
                castedNode.OffsetRight = n22;
            if (OffsetBottom is System.Single n23)
                castedNode.OffsetBottom = n23;
            if (GrowHorizontal is Godot.Control.GrowDirection n24)
                castedNode.GrowHorizontal = n24;
            if (GrowVertical is Godot.Control.GrowDirection n25)
                castedNode.GrowVertical = n25;
            if (Size is Godot.Vector2 n26)
                castedNode.Size = n26;
            if (Position is Godot.Vector2 n27)
                castedNode.Position = n27;
            if (GlobalPosition is Godot.Vector2 n28)
                castedNode.GlobalPosition = n28;
            if (Rotation is System.Single n29)
                castedNode.Rotation = n29;
            if (RotationDegrees is System.Single n30)
                castedNode.RotationDegrees = n30;
            if (Scale is Godot.Vector2 n31)
                castedNode.Scale = n31;
            if (PivotOffset is Godot.Vector2 n32)
                castedNode.PivotOffset = n32;
            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n33)
                castedNode.SizeFlagsHorizontal = n33;
            if (SizeFlagsVertical is Godot.Control.SizeFlags n34)
                castedNode.SizeFlagsVertical = n34;
            if (SizeFlagsStretchRatio is System.Single n35)
                castedNode.SizeFlagsStretchRatio = n35;
            if (LocalizeNumeralSystem is System.Boolean n36)
                castedNode.LocalizeNumeralSystem = n36;
            if (AutoTranslate is System.Boolean n37)
                castedNode.AutoTranslate = n37;
            if (TooltipText is System.String n38)
                castedNode.TooltipText = n38;
            if (FocusNeighborLeft is Godot.NodePath n39)
                castedNode.FocusNeighborLeft = n39;
            if (FocusNeighborTop is Godot.NodePath n40)
                castedNode.FocusNeighborTop = n40;
            if (FocusNeighborRight is Godot.NodePath n41)
                castedNode.FocusNeighborRight = n41;
            if (FocusNeighborBottom is Godot.NodePath n42)
                castedNode.FocusNeighborBottom = n42;
            if (FocusNext is Godot.NodePath n43)
                castedNode.FocusNext = n43;
            if (FocusPrevious is Godot.NodePath n44)
                castedNode.FocusPrevious = n44;
            if (FocusMode is Godot.Control.FocusModeEnum n45)
                castedNode.FocusMode = n45;
            if (MouseFilter is Godot.Control.MouseFilterEnum n46)
                castedNode.MouseFilter = n46;
            if (MouseForcePassScrollEvents is System.Boolean n47)
                castedNode.MouseForcePassScrollEvents = n47;
            if (MouseDefaultCursorShape is Godot.Control.CursorShape n48)
                castedNode.MouseDefaultCursorShape = n48;
            if (ShortcutContext is Godot.Node n49)
                castedNode.ShortcutContext = n49;
            if (Theme is Godot.Theme n50)
                castedNode.Theme = n50;
            if (ThemeTypeVariation is Godot.StringName n51)
                castedNode.ThemeTypeVariation = n51;
            if (Visible is System.Boolean n52)
                castedNode.Visible = n52;
            if (Modulate is Godot.Color n53)
                castedNode.Modulate = n53;
            if (SelfModulate is Godot.Color n54)
                castedNode.SelfModulate = n54;
            if (ShowBehindParent is System.Boolean n55)
                castedNode.ShowBehindParent = n55;
            if (TopLevel is System.Boolean n56)
                castedNode.TopLevel = n56;
            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n57)
                castedNode.ClipChildren = n57;
            if (LightMask is System.Int32 n58)
                castedNode.LightMask = n58;
            if (VisibilityLayer is System.UInt32 n59)
                castedNode.VisibilityLayer = n59;
            if (ZIndex is System.Int32 n60)
                castedNode.ZIndex = n60;
            if (ZAsRelative is System.Boolean n61)
                castedNode.ZAsRelative = n61;
            if (YSortEnabled is System.Boolean n62)
                castedNode.YSortEnabled = n62;
            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n63)
                castedNode.TextureFilter = n63;
            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n64)
                castedNode.TextureRepeat = n64;
            if (Material is Godot.Material n65)
                castedNode.Material = n65;
            if (UseParentMaterial is System.Boolean n66)
                castedNode.UseParentMaterial = n66;
            if (Name is Godot.StringName n67)
                castedNode.Name = n67;
            if (UniqueNameInOwner is System.Boolean n68)
                castedNode.UniqueNameInOwner = n68;
            if (SceneFilePath is System.String n69)
                castedNode.SceneFilePath = n69;
            if (Owner is Godot.Node n70)
                castedNode.Owner = n70;
            if (ProcessMode is Godot.Node.ProcessModeEnum n71)
                castedNode.ProcessMode = n71;
            if (ProcessPriority is System.Int32 n72)
                castedNode.ProcessPriority = n72;
            if (ProcessPhysicsPriority is System.Int32 n73)
                castedNode.ProcessPhysicsPriority = n73;
            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n74)
                castedNode.ProcessThreadGroup = n74;
            if (ProcessThreadGroupOrder is System.Int32 n75)
                castedNode.ProcessThreadGroupOrder = n75;
            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n76)
                castedNode.ProcessThreadMessages = n76;
            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n77)
                castedNode.PhysicsInterpolationMode = n77;
            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n78)
                castedNode.AutoTranslateMode = n78;
            if (EditorDescription is System.String n79)
                castedNode.EditorDescription = n79;
            if (Scrolling is System.Action e0)
                castedNode.Scrolling += e0;
            if (ValueChanged is Godot.Range.ValueChangedEventHandler e1)
                castedNode.ValueChanged += e1;
            if (Changed is System.Action e2)
                castedNode.Changed += e2;
            if (Resized is System.Action e3)
                castedNode.Resized += e3;
            if (GuiInput is Godot.Control.GuiInputEventHandler e4)
                castedNode.GuiInput += e4;
            if (MouseEntered is System.Action e5)
                castedNode.MouseEntered += e5;
            if (MouseExited is System.Action e6)
                castedNode.MouseExited += e6;
            if (FocusEntered is System.Action e7)
                castedNode.FocusEntered += e7;
            if (FocusExited is System.Action e8)
                castedNode.FocusExited += e8;
            if (SizeFlagsChanged is System.Action e9)
                castedNode.SizeFlagsChanged += e9;
            if (MinimumSizeChanged is System.Action e10)
                castedNode.MinimumSizeChanged += e10;
            if (ThemeChanged is System.Action e11)
                castedNode.ThemeChanged += e11;
            if (Draw is System.Action e12)
                castedNode.Draw += e12;
            if (VisibilityChanged is System.Action e13)
                castedNode.VisibilityChanged += e13;
            if (Hidden is System.Action e14)
                castedNode.Hidden += e14;
            if (ItemRectChanged is System.Action e15)
                castedNode.ItemRectChanged += e15;
            if (Ready is System.Action e16)
                castedNode.Ready += e16;
            if (Renamed is System.Action e17)
                castedNode.Renamed += e17;
            if (TreeEntered is System.Action e18)
                castedNode.TreeEntered += e18;
            if (TreeExiting is System.Action e19)
                castedNode.TreeExiting += e19;
            if (TreeExited is System.Action e20)
                castedNode.TreeExited += e20;
            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e21)
                castedNode.ChildEnteredTree += e21;
            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e22)
                castedNode.ChildExitingTree += e22;
            if (ChildOrderChanged is System.Action e23)
                castedNode.ChildOrderChanged += e23;
            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e24)
                castedNode.ReplacingBy += e24;
            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e25)
                castedNode.EditorDescriptionChanged += e25;
            if (ScriptChanged is System.Action e26)
                castedNode.ScriptChanged += e26;
            if (PropertyListChanged is System.Action e27)
                castedNode.PropertyListChanged += e27;
        }
    }
}