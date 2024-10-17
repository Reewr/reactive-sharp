namespace ReactiveSharpGodot.Components
{
    public class ScrollContainer : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GScrollContainer>
    {
        public System.Boolean? FollowFocus { protected get; init; }
        public System.Int32? ScrollHorizontal { protected get; init; }
        public System.Int32? ScrollVertical { protected get; init; }
        public System.Single? ScrollHorizontalCustomStep { protected get; init; }
        public System.Single? ScrollVerticalCustomStep { protected get; init; }
        public Godot.ScrollContainer.ScrollMode? HorizontalScrollMode { protected get; init; }
        public Godot.ScrollContainer.ScrollMode? VerticalScrollMode { protected get; init; }
        public System.Int32? ScrollDeadzone { protected get; init; }
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
        public System.Action? ScrollStarted { protected get; init; }
        public System.Action? ScrollEnded { protected get; init; }
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

        public override ReactiveSharpGodot.Nodes.GScrollContainer Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GScrollContainer();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GScrollContainer node)
        {
            var castedNode = (Godot.ScrollContainer)node.Node;
            if (FollowFocus is System.Boolean n0)
                castedNode.FollowFocus = n0;
            if (ScrollHorizontal is System.Int32 n1)
                castedNode.ScrollHorizontal = n1;
            if (ScrollVertical is System.Int32 n2)
                castedNode.ScrollVertical = n2;
            if (ScrollHorizontalCustomStep is System.Single n3)
                castedNode.ScrollHorizontalCustomStep = n3;
            if (ScrollVerticalCustomStep is System.Single n4)
                castedNode.ScrollVerticalCustomStep = n4;
            if (HorizontalScrollMode is Godot.ScrollContainer.ScrollMode n5)
                castedNode.HorizontalScrollMode = n5;
            if (VerticalScrollMode is Godot.ScrollContainer.ScrollMode n6)
                castedNode.VerticalScrollMode = n6;
            if (ScrollDeadzone is System.Int32 n7)
                castedNode.ScrollDeadzone = n7;
            if (ClipContents is System.Boolean n8)
                castedNode.ClipContents = n8;
            if (CustomMinimumSize is Godot.Vector2 n9)
                castedNode.CustomMinimumSize = n9;
            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n10)
                castedNode.LayoutDirection = n10;
            if (LayoutMode is System.Int32 n11)
                castedNode.LayoutMode = n11;
            if (AnchorsPreset is System.Int32 n12)
                castedNode.AnchorsPreset = n12;
            if (AnchorLeft is System.Single n13)
                castedNode.AnchorLeft = n13;
            if (AnchorTop is System.Single n14)
                castedNode.AnchorTop = n14;
            if (AnchorRight is System.Single n15)
                castedNode.AnchorRight = n15;
            if (AnchorBottom is System.Single n16)
                castedNode.AnchorBottom = n16;
            if (OffsetLeft is System.Single n17)
                castedNode.OffsetLeft = n17;
            if (OffsetTop is System.Single n18)
                castedNode.OffsetTop = n18;
            if (OffsetRight is System.Single n19)
                castedNode.OffsetRight = n19;
            if (OffsetBottom is System.Single n20)
                castedNode.OffsetBottom = n20;
            if (GrowHorizontal is Godot.Control.GrowDirection n21)
                castedNode.GrowHorizontal = n21;
            if (GrowVertical is Godot.Control.GrowDirection n22)
                castedNode.GrowVertical = n22;
            if (Size is Godot.Vector2 n23)
                castedNode.Size = n23;
            if (Position is Godot.Vector2 n24)
                castedNode.Position = n24;
            if (GlobalPosition is Godot.Vector2 n25)
                castedNode.GlobalPosition = n25;
            if (Rotation is System.Single n26)
                castedNode.Rotation = n26;
            if (RotationDegrees is System.Single n27)
                castedNode.RotationDegrees = n27;
            if (Scale is Godot.Vector2 n28)
                castedNode.Scale = n28;
            if (PivotOffset is Godot.Vector2 n29)
                castedNode.PivotOffset = n29;
            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n30)
                castedNode.SizeFlagsHorizontal = n30;
            if (SizeFlagsVertical is Godot.Control.SizeFlags n31)
                castedNode.SizeFlagsVertical = n31;
            if (SizeFlagsStretchRatio is System.Single n32)
                castedNode.SizeFlagsStretchRatio = n32;
            if (LocalizeNumeralSystem is System.Boolean n33)
                castedNode.LocalizeNumeralSystem = n33;
            if (AutoTranslate is System.Boolean n34)
                castedNode.AutoTranslate = n34;
            if (TooltipText is System.String n35)
                castedNode.TooltipText = n35;
            if (FocusNeighborLeft is Godot.NodePath n36)
                castedNode.FocusNeighborLeft = n36;
            if (FocusNeighborTop is Godot.NodePath n37)
                castedNode.FocusNeighborTop = n37;
            if (FocusNeighborRight is Godot.NodePath n38)
                castedNode.FocusNeighborRight = n38;
            if (FocusNeighborBottom is Godot.NodePath n39)
                castedNode.FocusNeighborBottom = n39;
            if (FocusNext is Godot.NodePath n40)
                castedNode.FocusNext = n40;
            if (FocusPrevious is Godot.NodePath n41)
                castedNode.FocusPrevious = n41;
            if (FocusMode is Godot.Control.FocusModeEnum n42)
                castedNode.FocusMode = n42;
            if (MouseFilter is Godot.Control.MouseFilterEnum n43)
                castedNode.MouseFilter = n43;
            if (MouseForcePassScrollEvents is System.Boolean n44)
                castedNode.MouseForcePassScrollEvents = n44;
            if (MouseDefaultCursorShape is Godot.Control.CursorShape n45)
                castedNode.MouseDefaultCursorShape = n45;
            if (ShortcutContext is Godot.Node n46)
                castedNode.ShortcutContext = n46;
            if (Theme is Godot.Theme n47)
                castedNode.Theme = n47;
            if (ThemeTypeVariation is Godot.StringName n48)
                castedNode.ThemeTypeVariation = n48;
            if (Visible is System.Boolean n49)
                castedNode.Visible = n49;
            if (Modulate is Godot.Color n50)
                castedNode.Modulate = n50;
            if (SelfModulate is Godot.Color n51)
                castedNode.SelfModulate = n51;
            if (ShowBehindParent is System.Boolean n52)
                castedNode.ShowBehindParent = n52;
            if (TopLevel is System.Boolean n53)
                castedNode.TopLevel = n53;
            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n54)
                castedNode.ClipChildren = n54;
            if (LightMask is System.Int32 n55)
                castedNode.LightMask = n55;
            if (VisibilityLayer is System.UInt32 n56)
                castedNode.VisibilityLayer = n56;
            if (ZIndex is System.Int32 n57)
                castedNode.ZIndex = n57;
            if (ZAsRelative is System.Boolean n58)
                castedNode.ZAsRelative = n58;
            if (YSortEnabled is System.Boolean n59)
                castedNode.YSortEnabled = n59;
            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n60)
                castedNode.TextureFilter = n60;
            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n61)
                castedNode.TextureRepeat = n61;
            if (Material is Godot.Material n62)
                castedNode.Material = n62;
            if (UseParentMaterial is System.Boolean n63)
                castedNode.UseParentMaterial = n63;
            if (Name is Godot.StringName n64)
                castedNode.Name = n64;
            if (UniqueNameInOwner is System.Boolean n65)
                castedNode.UniqueNameInOwner = n65;
            if (SceneFilePath is System.String n66)
                castedNode.SceneFilePath = n66;
            if (Owner is Godot.Node n67)
                castedNode.Owner = n67;
            if (ProcessMode is Godot.Node.ProcessModeEnum n68)
                castedNode.ProcessMode = n68;
            if (ProcessPriority is System.Int32 n69)
                castedNode.ProcessPriority = n69;
            if (ProcessPhysicsPriority is System.Int32 n70)
                castedNode.ProcessPhysicsPriority = n70;
            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n71)
                castedNode.ProcessThreadGroup = n71;
            if (ProcessThreadGroupOrder is System.Int32 n72)
                castedNode.ProcessThreadGroupOrder = n72;
            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n73)
                castedNode.ProcessThreadMessages = n73;
            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n74)
                castedNode.PhysicsInterpolationMode = n74;
            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n75)
                castedNode.AutoTranslateMode = n75;
            if (EditorDescription is System.String n76)
                castedNode.EditorDescription = n76;
            if (ScrollStarted is System.Action e0)
                castedNode.ScrollStarted += e0;
            if (ScrollEnded is System.Action e1)
                castedNode.ScrollEnded += e1;
            if (PreSortChildren is System.Action e2)
                castedNode.PreSortChildren += e2;
            if (SortChildren is System.Action e3)
                castedNode.SortChildren += e3;
            if (Resized is System.Action e4)
                castedNode.Resized += e4;
            if (GuiInput is Godot.Control.GuiInputEventHandler e5)
                castedNode.GuiInput += e5;
            if (MouseEntered is System.Action e6)
                castedNode.MouseEntered += e6;
            if (MouseExited is System.Action e7)
                castedNode.MouseExited += e7;
            if (FocusEntered is System.Action e8)
                castedNode.FocusEntered += e8;
            if (FocusExited is System.Action e9)
                castedNode.FocusExited += e9;
            if (SizeFlagsChanged is System.Action e10)
                castedNode.SizeFlagsChanged += e10;
            if (MinimumSizeChanged is System.Action e11)
                castedNode.MinimumSizeChanged += e11;
            if (ThemeChanged is System.Action e12)
                castedNode.ThemeChanged += e12;
            if (Draw is System.Action e13)
                castedNode.Draw += e13;
            if (VisibilityChanged is System.Action e14)
                castedNode.VisibilityChanged += e14;
            if (Hidden is System.Action e15)
                castedNode.Hidden += e15;
            if (ItemRectChanged is System.Action e16)
                castedNode.ItemRectChanged += e16;
            if (Ready is System.Action e17)
                castedNode.Ready += e17;
            if (Renamed is System.Action e18)
                castedNode.Renamed += e18;
            if (TreeEntered is System.Action e19)
                castedNode.TreeEntered += e19;
            if (TreeExiting is System.Action e20)
                castedNode.TreeExiting += e20;
            if (TreeExited is System.Action e21)
                castedNode.TreeExited += e21;
            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e22)
                castedNode.ChildEnteredTree += e22;
            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e23)
                castedNode.ChildExitingTree += e23;
            if (ChildOrderChanged is System.Action e24)
                castedNode.ChildOrderChanged += e24;
            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e25)
                castedNode.ReplacingBy += e25;
            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e26)
                castedNode.EditorDescriptionChanged += e26;
            if (ScriptChanged is System.Action e27)
                castedNode.ScriptChanged += e27;
            if (PropertyListChanged is System.Action e28)
                castedNode.PropertyListChanged += e28;
        }
    }
}