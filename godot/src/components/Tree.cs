namespace ReactiveSharpGodot.Components
{
    public class Tree : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GTree>
    {
        public System.Int32? Columns { protected get; init; }
        public System.Boolean? ColumnTitlesVisible { protected get; init; }
        public System.Boolean? AllowReselect { protected get; init; }
        public System.Boolean? AllowRmbSelect { protected get; init; }
        public System.Boolean? AllowSearch { protected get; init; }
        public System.Boolean? HideFolding { protected get; init; }
        public System.Boolean? EnableRecursiveFolding { protected get; init; }
        public System.Boolean? HideRoot { protected get; init; }
        public System.Int32? DropModeFlags { protected get; init; }
        public Godot.Tree.SelectModeEnum? SelectMode { protected get; init; }
        public System.Boolean? ScrollHorizontalEnabled { protected get; init; }
        public System.Boolean? ScrollVerticalEnabled { protected get; init; }
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
        public System.Action? ItemSelected { protected get; init; }
        public System.Action? CellSelected { protected get; init; }
        public Godot.Tree.MultiSelectedEventHandler? MultiSelected { protected get; init; }
        public Godot.Tree.ItemMouseSelectedEventHandler? ItemMouseSelected { protected get; init; }
        public Godot.Tree.EmptyClickedEventHandler? EmptyClicked { protected get; init; }
        public System.Action? ItemEdited { protected get; init; }
        public Godot.Tree.CustomItemClickedEventHandler? CustomItemClicked { protected get; init; }
        public System.Action? ItemIconDoubleClicked { protected get; init; }
        public Godot.Tree.ItemCollapsedEventHandler? ItemCollapsed { protected get; init; }
        public Godot.Tree.CheckPropagatedToItemEventHandler? CheckPropagatedToItem { protected get; init; }
        public Godot.Tree.ButtonClickedEventHandler? ButtonClicked { protected get; init; }
        public Godot.Tree.CustomPopupEditedEventHandler? CustomPopupEdited { protected get; init; }
        public System.Action? ItemActivated { protected get; init; }
        public Godot.Tree.ColumnTitleClickedEventHandler? ColumnTitleClicked { protected get; init; }
        public System.Action? NothingSelected { protected get; init; }
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

        public override ReactiveSharpGodot.Nodes.GTree Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GTree();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GTree node)
        {
            var castedNode = (Godot.Tree)node.Node;
            if (Columns is System.Int32 n0)
                castedNode.Columns = n0;
            if (ColumnTitlesVisible is System.Boolean n1)
                castedNode.ColumnTitlesVisible = n1;
            if (AllowReselect is System.Boolean n2)
                castedNode.AllowReselect = n2;
            if (AllowRmbSelect is System.Boolean n3)
                castedNode.AllowRmbSelect = n3;
            if (AllowSearch is System.Boolean n4)
                castedNode.AllowSearch = n4;
            if (HideFolding is System.Boolean n5)
                castedNode.HideFolding = n5;
            if (EnableRecursiveFolding is System.Boolean n6)
                castedNode.EnableRecursiveFolding = n6;
            if (HideRoot is System.Boolean n7)
                castedNode.HideRoot = n7;
            if (DropModeFlags is System.Int32 n8)
                castedNode.DropModeFlags = n8;
            if (SelectMode is Godot.Tree.SelectModeEnum n9)
                castedNode.SelectMode = n9;
            if (ScrollHorizontalEnabled is System.Boolean n10)
                castedNode.ScrollHorizontalEnabled = n10;
            if (ScrollVerticalEnabled is System.Boolean n11)
                castedNode.ScrollVerticalEnabled = n11;
            if (ClipContents is System.Boolean n12)
                castedNode.ClipContents = n12;
            if (CustomMinimumSize is Godot.Vector2 n13)
                castedNode.CustomMinimumSize = n13;
            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n14)
                castedNode.LayoutDirection = n14;
            if (LayoutMode is System.Int32 n15)
                castedNode.LayoutMode = n15;
            if (AnchorsPreset is System.Int32 n16)
                castedNode.AnchorsPreset = n16;
            if (AnchorLeft is System.Single n17)
                castedNode.AnchorLeft = n17;
            if (AnchorTop is System.Single n18)
                castedNode.AnchorTop = n18;
            if (AnchorRight is System.Single n19)
                castedNode.AnchorRight = n19;
            if (AnchorBottom is System.Single n20)
                castedNode.AnchorBottom = n20;
            if (OffsetLeft is System.Single n21)
                castedNode.OffsetLeft = n21;
            if (OffsetTop is System.Single n22)
                castedNode.OffsetTop = n22;
            if (OffsetRight is System.Single n23)
                castedNode.OffsetRight = n23;
            if (OffsetBottom is System.Single n24)
                castedNode.OffsetBottom = n24;
            if (GrowHorizontal is Godot.Control.GrowDirection n25)
                castedNode.GrowHorizontal = n25;
            if (GrowVertical is Godot.Control.GrowDirection n26)
                castedNode.GrowVertical = n26;
            if (Size is Godot.Vector2 n27)
                castedNode.Size = n27;
            if (Position is Godot.Vector2 n28)
                castedNode.Position = n28;
            if (GlobalPosition is Godot.Vector2 n29)
                castedNode.GlobalPosition = n29;
            if (Rotation is System.Single n30)
                castedNode.Rotation = n30;
            if (RotationDegrees is System.Single n31)
                castedNode.RotationDegrees = n31;
            if (Scale is Godot.Vector2 n32)
                castedNode.Scale = n32;
            if (PivotOffset is Godot.Vector2 n33)
                castedNode.PivotOffset = n33;
            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n34)
                castedNode.SizeFlagsHorizontal = n34;
            if (SizeFlagsVertical is Godot.Control.SizeFlags n35)
                castedNode.SizeFlagsVertical = n35;
            if (SizeFlagsStretchRatio is System.Single n36)
                castedNode.SizeFlagsStretchRatio = n36;
            if (LocalizeNumeralSystem is System.Boolean n37)
                castedNode.LocalizeNumeralSystem = n37;
            if (AutoTranslate is System.Boolean n38)
                castedNode.AutoTranslate = n38;
            if (TooltipText is System.String n39)
                castedNode.TooltipText = n39;
            if (FocusNeighborLeft is Godot.NodePath n40)
                castedNode.FocusNeighborLeft = n40;
            if (FocusNeighborTop is Godot.NodePath n41)
                castedNode.FocusNeighborTop = n41;
            if (FocusNeighborRight is Godot.NodePath n42)
                castedNode.FocusNeighborRight = n42;
            if (FocusNeighborBottom is Godot.NodePath n43)
                castedNode.FocusNeighborBottom = n43;
            if (FocusNext is Godot.NodePath n44)
                castedNode.FocusNext = n44;
            if (FocusPrevious is Godot.NodePath n45)
                castedNode.FocusPrevious = n45;
            if (FocusMode is Godot.Control.FocusModeEnum n46)
                castedNode.FocusMode = n46;
            if (MouseFilter is Godot.Control.MouseFilterEnum n47)
                castedNode.MouseFilter = n47;
            if (MouseForcePassScrollEvents is System.Boolean n48)
                castedNode.MouseForcePassScrollEvents = n48;
            if (MouseDefaultCursorShape is Godot.Control.CursorShape n49)
                castedNode.MouseDefaultCursorShape = n49;
            if (ShortcutContext is Godot.Node n50)
                castedNode.ShortcutContext = n50;
            if (Theme is Godot.Theme n51)
                castedNode.Theme = n51;
            if (ThemeTypeVariation is Godot.StringName n52)
                castedNode.ThemeTypeVariation = n52;
            if (Visible is System.Boolean n53)
                castedNode.Visible = n53;
            if (Modulate is Godot.Color n54)
                castedNode.Modulate = n54;
            if (SelfModulate is Godot.Color n55)
                castedNode.SelfModulate = n55;
            if (ShowBehindParent is System.Boolean n56)
                castedNode.ShowBehindParent = n56;
            if (TopLevel is System.Boolean n57)
                castedNode.TopLevel = n57;
            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n58)
                castedNode.ClipChildren = n58;
            if (LightMask is System.Int32 n59)
                castedNode.LightMask = n59;
            if (VisibilityLayer is System.UInt32 n60)
                castedNode.VisibilityLayer = n60;
            if (ZIndex is System.Int32 n61)
                castedNode.ZIndex = n61;
            if (ZAsRelative is System.Boolean n62)
                castedNode.ZAsRelative = n62;
            if (YSortEnabled is System.Boolean n63)
                castedNode.YSortEnabled = n63;
            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n64)
                castedNode.TextureFilter = n64;
            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n65)
                castedNode.TextureRepeat = n65;
            if (Material is Godot.Material n66)
                castedNode.Material = n66;
            if (UseParentMaterial is System.Boolean n67)
                castedNode.UseParentMaterial = n67;
            if (Name is Godot.StringName n68)
                castedNode.Name = n68;
            if (UniqueNameInOwner is System.Boolean n69)
                castedNode.UniqueNameInOwner = n69;
            if (SceneFilePath is System.String n70)
                castedNode.SceneFilePath = n70;
            if (Owner is Godot.Node n71)
                castedNode.Owner = n71;
            if (ProcessMode is Godot.Node.ProcessModeEnum n72)
                castedNode.ProcessMode = n72;
            if (ProcessPriority is System.Int32 n73)
                castedNode.ProcessPriority = n73;
            if (ProcessPhysicsPriority is System.Int32 n74)
                castedNode.ProcessPhysicsPriority = n74;
            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n75)
                castedNode.ProcessThreadGroup = n75;
            if (ProcessThreadGroupOrder is System.Int32 n76)
                castedNode.ProcessThreadGroupOrder = n76;
            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n77)
                castedNode.ProcessThreadMessages = n77;
            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n78)
                castedNode.PhysicsInterpolationMode = n78;
            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n79)
                castedNode.AutoTranslateMode = n79;
            if (EditorDescription is System.String n80)
                castedNode.EditorDescription = n80;
            if (ItemSelected is System.Action e0)
                castedNode.ItemSelected += e0;
            if (CellSelected is System.Action e1)
                castedNode.CellSelected += e1;
            if (MultiSelected is Godot.Tree.MultiSelectedEventHandler e2)
                castedNode.MultiSelected += e2;
            if (ItemMouseSelected is Godot.Tree.ItemMouseSelectedEventHandler e3)
                castedNode.ItemMouseSelected += e3;
            if (EmptyClicked is Godot.Tree.EmptyClickedEventHandler e4)
                castedNode.EmptyClicked += e4;
            if (ItemEdited is System.Action e5)
                castedNode.ItemEdited += e5;
            if (CustomItemClicked is Godot.Tree.CustomItemClickedEventHandler e6)
                castedNode.CustomItemClicked += e6;
            if (ItemIconDoubleClicked is System.Action e7)
                castedNode.ItemIconDoubleClicked += e7;
            if (ItemCollapsed is Godot.Tree.ItemCollapsedEventHandler e8)
                castedNode.ItemCollapsed += e8;
            if (CheckPropagatedToItem is Godot.Tree.CheckPropagatedToItemEventHandler e9)
                castedNode.CheckPropagatedToItem += e9;
            if (ButtonClicked is Godot.Tree.ButtonClickedEventHandler e10)
                castedNode.ButtonClicked += e10;
            if (CustomPopupEdited is Godot.Tree.CustomPopupEditedEventHandler e11)
                castedNode.CustomPopupEdited += e11;
            if (ItemActivated is System.Action e12)
                castedNode.ItemActivated += e12;
            if (ColumnTitleClicked is Godot.Tree.ColumnTitleClickedEventHandler e13)
                castedNode.ColumnTitleClicked += e13;
            if (NothingSelected is System.Action e14)
                castedNode.NothingSelected += e14;
            if (Resized is System.Action e15)
                castedNode.Resized += e15;
            if (GuiInput is Godot.Control.GuiInputEventHandler e16)
                castedNode.GuiInput += e16;
            if (MouseEntered is System.Action e17)
                castedNode.MouseEntered += e17;
            if (MouseExited is System.Action e18)
                castedNode.MouseExited += e18;
            if (FocusEntered is System.Action e19)
                castedNode.FocusEntered += e19;
            if (FocusExited is System.Action e20)
                castedNode.FocusExited += e20;
            if (SizeFlagsChanged is System.Action e21)
                castedNode.SizeFlagsChanged += e21;
            if (MinimumSizeChanged is System.Action e22)
                castedNode.MinimumSizeChanged += e22;
            if (ThemeChanged is System.Action e23)
                castedNode.ThemeChanged += e23;
            if (Draw is System.Action e24)
                castedNode.Draw += e24;
            if (VisibilityChanged is System.Action e25)
                castedNode.VisibilityChanged += e25;
            if (Hidden is System.Action e26)
                castedNode.Hidden += e26;
            if (ItemRectChanged is System.Action e27)
                castedNode.ItemRectChanged += e27;
            if (Ready is System.Action e28)
                castedNode.Ready += e28;
            if (Renamed is System.Action e29)
                castedNode.Renamed += e29;
            if (TreeEntered is System.Action e30)
                castedNode.TreeEntered += e30;
            if (TreeExiting is System.Action e31)
                castedNode.TreeExiting += e31;
            if (TreeExited is System.Action e32)
                castedNode.TreeExited += e32;
            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e33)
                castedNode.ChildEnteredTree += e33;
            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e34)
                castedNode.ChildExitingTree += e34;
            if (ChildOrderChanged is System.Action e35)
                castedNode.ChildOrderChanged += e35;
            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e36)
                castedNode.ReplacingBy += e36;
            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e37)
                castedNode.EditorDescriptionChanged += e37;
            if (ScriptChanged is System.Action e38)
                castedNode.ScriptChanged += e38;
            if (PropertyListChanged is System.Action e39)
                castedNode.PropertyListChanged += e39;
        }
    }
}