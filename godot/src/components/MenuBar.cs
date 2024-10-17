namespace ReactiveSharpGodot.Components
{
    public class MenuBar : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GMenuBar>
    {
        public System.Boolean? Flat { protected get; init; }
        public System.Int32? StartIndex { protected get; init; }
        public System.Boolean? SwitchOnHover { protected get; init; }
        public System.Boolean? PreferGlobalMenu { protected get; init; }
        public Godot.Control.TextDirection? TextDirection { protected get; init; }
        public System.String? Language { protected get; init; }
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

        public override ReactiveSharpGodot.Nodes.GMenuBar Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GMenuBar();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GMenuBar node)
        {
            var castedNode = (Godot.MenuBar)node.Node;
            if (Flat is System.Boolean n0)
                castedNode.Flat = n0;
            if (StartIndex is System.Int32 n1)
                castedNode.StartIndex = n1;
            if (SwitchOnHover is System.Boolean n2)
                castedNode.SwitchOnHover = n2;
            if (PreferGlobalMenu is System.Boolean n3)
                castedNode.PreferGlobalMenu = n3;
            if (TextDirection is Godot.Control.TextDirection n4)
                castedNode.TextDirection = n4;
            if (Language is System.String n5)
                castedNode.Language = n5;
            if (ClipContents is System.Boolean n6)
                castedNode.ClipContents = n6;
            if (CustomMinimumSize is Godot.Vector2 n7)
                castedNode.CustomMinimumSize = n7;
            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n8)
                castedNode.LayoutDirection = n8;
            if (LayoutMode is System.Int32 n9)
                castedNode.LayoutMode = n9;
            if (AnchorsPreset is System.Int32 n10)
                castedNode.AnchorsPreset = n10;
            if (AnchorLeft is System.Single n11)
                castedNode.AnchorLeft = n11;
            if (AnchorTop is System.Single n12)
                castedNode.AnchorTop = n12;
            if (AnchorRight is System.Single n13)
                castedNode.AnchorRight = n13;
            if (AnchorBottom is System.Single n14)
                castedNode.AnchorBottom = n14;
            if (OffsetLeft is System.Single n15)
                castedNode.OffsetLeft = n15;
            if (OffsetTop is System.Single n16)
                castedNode.OffsetTop = n16;
            if (OffsetRight is System.Single n17)
                castedNode.OffsetRight = n17;
            if (OffsetBottom is System.Single n18)
                castedNode.OffsetBottom = n18;
            if (GrowHorizontal is Godot.Control.GrowDirection n19)
                castedNode.GrowHorizontal = n19;
            if (GrowVertical is Godot.Control.GrowDirection n20)
                castedNode.GrowVertical = n20;
            if (Size is Godot.Vector2 n21)
                castedNode.Size = n21;
            if (Position is Godot.Vector2 n22)
                castedNode.Position = n22;
            if (GlobalPosition is Godot.Vector2 n23)
                castedNode.GlobalPosition = n23;
            if (Rotation is System.Single n24)
                castedNode.Rotation = n24;
            if (RotationDegrees is System.Single n25)
                castedNode.RotationDegrees = n25;
            if (Scale is Godot.Vector2 n26)
                castedNode.Scale = n26;
            if (PivotOffset is Godot.Vector2 n27)
                castedNode.PivotOffset = n27;
            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n28)
                castedNode.SizeFlagsHorizontal = n28;
            if (SizeFlagsVertical is Godot.Control.SizeFlags n29)
                castedNode.SizeFlagsVertical = n29;
            if (SizeFlagsStretchRatio is System.Single n30)
                castedNode.SizeFlagsStretchRatio = n30;
            if (LocalizeNumeralSystem is System.Boolean n31)
                castedNode.LocalizeNumeralSystem = n31;
            if (AutoTranslate is System.Boolean n32)
                castedNode.AutoTranslate = n32;
            if (TooltipText is System.String n33)
                castedNode.TooltipText = n33;
            if (FocusNeighborLeft is Godot.NodePath n34)
                castedNode.FocusNeighborLeft = n34;
            if (FocusNeighborTop is Godot.NodePath n35)
                castedNode.FocusNeighborTop = n35;
            if (FocusNeighborRight is Godot.NodePath n36)
                castedNode.FocusNeighborRight = n36;
            if (FocusNeighborBottom is Godot.NodePath n37)
                castedNode.FocusNeighborBottom = n37;
            if (FocusNext is Godot.NodePath n38)
                castedNode.FocusNext = n38;
            if (FocusPrevious is Godot.NodePath n39)
                castedNode.FocusPrevious = n39;
            if (FocusMode is Godot.Control.FocusModeEnum n40)
                castedNode.FocusMode = n40;
            if (MouseFilter is Godot.Control.MouseFilterEnum n41)
                castedNode.MouseFilter = n41;
            if (MouseForcePassScrollEvents is System.Boolean n42)
                castedNode.MouseForcePassScrollEvents = n42;
            if (MouseDefaultCursorShape is Godot.Control.CursorShape n43)
                castedNode.MouseDefaultCursorShape = n43;
            if (ShortcutContext is Godot.Node n44)
                castedNode.ShortcutContext = n44;
            if (Theme is Godot.Theme n45)
                castedNode.Theme = n45;
            if (ThemeTypeVariation is Godot.StringName n46)
                castedNode.ThemeTypeVariation = n46;
            if (Visible is System.Boolean n47)
                castedNode.Visible = n47;
            if (Modulate is Godot.Color n48)
                castedNode.Modulate = n48;
            if (SelfModulate is Godot.Color n49)
                castedNode.SelfModulate = n49;
            if (ShowBehindParent is System.Boolean n50)
                castedNode.ShowBehindParent = n50;
            if (TopLevel is System.Boolean n51)
                castedNode.TopLevel = n51;
            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n52)
                castedNode.ClipChildren = n52;
            if (LightMask is System.Int32 n53)
                castedNode.LightMask = n53;
            if (VisibilityLayer is System.UInt32 n54)
                castedNode.VisibilityLayer = n54;
            if (ZIndex is System.Int32 n55)
                castedNode.ZIndex = n55;
            if (ZAsRelative is System.Boolean n56)
                castedNode.ZAsRelative = n56;
            if (YSortEnabled is System.Boolean n57)
                castedNode.YSortEnabled = n57;
            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n58)
                castedNode.TextureFilter = n58;
            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n59)
                castedNode.TextureRepeat = n59;
            if (Material is Godot.Material n60)
                castedNode.Material = n60;
            if (UseParentMaterial is System.Boolean n61)
                castedNode.UseParentMaterial = n61;
            if (Name is Godot.StringName n62)
                castedNode.Name = n62;
            if (UniqueNameInOwner is System.Boolean n63)
                castedNode.UniqueNameInOwner = n63;
            if (SceneFilePath is System.String n64)
                castedNode.SceneFilePath = n64;
            if (Owner is Godot.Node n65)
                castedNode.Owner = n65;
            if (ProcessMode is Godot.Node.ProcessModeEnum n66)
                castedNode.ProcessMode = n66;
            if (ProcessPriority is System.Int32 n67)
                castedNode.ProcessPriority = n67;
            if (ProcessPhysicsPriority is System.Int32 n68)
                castedNode.ProcessPhysicsPriority = n68;
            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n69)
                castedNode.ProcessThreadGroup = n69;
            if (ProcessThreadGroupOrder is System.Int32 n70)
                castedNode.ProcessThreadGroupOrder = n70;
            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n71)
                castedNode.ProcessThreadMessages = n71;
            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n72)
                castedNode.PhysicsInterpolationMode = n72;
            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n73)
                castedNode.AutoTranslateMode = n73;
            if (EditorDescription is System.String n74)
                castedNode.EditorDescription = n74;
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