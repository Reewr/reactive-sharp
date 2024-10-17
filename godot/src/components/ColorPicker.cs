namespace ReactiveSharpGodot.Components
{
    public class ColorPicker : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GColorPicker>
    {
        public Godot.Color? Color { protected get; init; }
        public System.Boolean? EditAlpha { protected get; init; }
        public Godot.ColorPicker.ColorModeType? ColorMode { protected get; init; }
        public System.Boolean? DeferredMode { protected get; init; }
        public Godot.ColorPicker.PickerShapeType? PickerShape { protected get; init; }
        public System.Boolean? CanAddSwatches { protected get; init; }
        public System.Boolean? SamplerVisible { protected get; init; }
        public System.Boolean? ColorModesVisible { protected get; init; }
        public System.Boolean? SlidersVisible { protected get; init; }
        public System.Boolean? HexVisible { protected get; init; }
        public System.Boolean? PresetsVisible { protected get; init; }
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
        public Godot.ColorPicker.ColorChangedEventHandler? ColorChanged { protected get; init; }
        public Godot.ColorPicker.PresetAddedEventHandler? PresetAdded { protected get; init; }
        public Godot.ColorPicker.PresetRemovedEventHandler? PresetRemoved { protected get; init; }
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

        public override ReactiveSharpGodot.Nodes.GColorPicker Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GColorPicker();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GColorPicker node)
        {
            var castedNode = (Godot.ColorPicker)node.Node;
            if (Color is Godot.Color n0)
                castedNode.Color = n0;
            if (EditAlpha is System.Boolean n1)
                castedNode.EditAlpha = n1;
            if (ColorMode is Godot.ColorPicker.ColorModeType n2)
                castedNode.ColorMode = n2;
            if (DeferredMode is System.Boolean n3)
                castedNode.DeferredMode = n3;
            if (PickerShape is Godot.ColorPicker.PickerShapeType n4)
                castedNode.PickerShape = n4;
            if (CanAddSwatches is System.Boolean n5)
                castedNode.CanAddSwatches = n5;
            if (SamplerVisible is System.Boolean n6)
                castedNode.SamplerVisible = n6;
            if (ColorModesVisible is System.Boolean n7)
                castedNode.ColorModesVisible = n7;
            if (SlidersVisible is System.Boolean n8)
                castedNode.SlidersVisible = n8;
            if (HexVisible is System.Boolean n9)
                castedNode.HexVisible = n9;
            if (PresetsVisible is System.Boolean n10)
                castedNode.PresetsVisible = n10;
            if (Alignment is Godot.BoxContainer.AlignmentMode n11)
                castedNode.Alignment = n11;
            if (Vertical is System.Boolean n12)
                castedNode.Vertical = n12;
            if (ClipContents is System.Boolean n13)
                castedNode.ClipContents = n13;
            if (CustomMinimumSize is Godot.Vector2 n14)
                castedNode.CustomMinimumSize = n14;
            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n15)
                castedNode.LayoutDirection = n15;
            if (LayoutMode is System.Int32 n16)
                castedNode.LayoutMode = n16;
            if (AnchorsPreset is System.Int32 n17)
                castedNode.AnchorsPreset = n17;
            if (AnchorLeft is System.Single n18)
                castedNode.AnchorLeft = n18;
            if (AnchorTop is System.Single n19)
                castedNode.AnchorTop = n19;
            if (AnchorRight is System.Single n20)
                castedNode.AnchorRight = n20;
            if (AnchorBottom is System.Single n21)
                castedNode.AnchorBottom = n21;
            if (OffsetLeft is System.Single n22)
                castedNode.OffsetLeft = n22;
            if (OffsetTop is System.Single n23)
                castedNode.OffsetTop = n23;
            if (OffsetRight is System.Single n24)
                castedNode.OffsetRight = n24;
            if (OffsetBottom is System.Single n25)
                castedNode.OffsetBottom = n25;
            if (GrowHorizontal is Godot.Control.GrowDirection n26)
                castedNode.GrowHorizontal = n26;
            if (GrowVertical is Godot.Control.GrowDirection n27)
                castedNode.GrowVertical = n27;
            if (Size is Godot.Vector2 n28)
                castedNode.Size = n28;
            if (Position is Godot.Vector2 n29)
                castedNode.Position = n29;
            if (GlobalPosition is Godot.Vector2 n30)
                castedNode.GlobalPosition = n30;
            if (Rotation is System.Single n31)
                castedNode.Rotation = n31;
            if (RotationDegrees is System.Single n32)
                castedNode.RotationDegrees = n32;
            if (Scale is Godot.Vector2 n33)
                castedNode.Scale = n33;
            if (PivotOffset is Godot.Vector2 n34)
                castedNode.PivotOffset = n34;
            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n35)
                castedNode.SizeFlagsHorizontal = n35;
            if (SizeFlagsVertical is Godot.Control.SizeFlags n36)
                castedNode.SizeFlagsVertical = n36;
            if (SizeFlagsStretchRatio is System.Single n37)
                castedNode.SizeFlagsStretchRatio = n37;
            if (LocalizeNumeralSystem is System.Boolean n38)
                castedNode.LocalizeNumeralSystem = n38;
            if (AutoTranslate is System.Boolean n39)
                castedNode.AutoTranslate = n39;
            if (TooltipText is System.String n40)
                castedNode.TooltipText = n40;
            if (FocusNeighborLeft is Godot.NodePath n41)
                castedNode.FocusNeighborLeft = n41;
            if (FocusNeighborTop is Godot.NodePath n42)
                castedNode.FocusNeighborTop = n42;
            if (FocusNeighborRight is Godot.NodePath n43)
                castedNode.FocusNeighborRight = n43;
            if (FocusNeighborBottom is Godot.NodePath n44)
                castedNode.FocusNeighborBottom = n44;
            if (FocusNext is Godot.NodePath n45)
                castedNode.FocusNext = n45;
            if (FocusPrevious is Godot.NodePath n46)
                castedNode.FocusPrevious = n46;
            if (FocusMode is Godot.Control.FocusModeEnum n47)
                castedNode.FocusMode = n47;
            if (MouseFilter is Godot.Control.MouseFilterEnum n48)
                castedNode.MouseFilter = n48;
            if (MouseForcePassScrollEvents is System.Boolean n49)
                castedNode.MouseForcePassScrollEvents = n49;
            if (MouseDefaultCursorShape is Godot.Control.CursorShape n50)
                castedNode.MouseDefaultCursorShape = n50;
            if (ShortcutContext is Godot.Node n51)
                castedNode.ShortcutContext = n51;
            if (Theme is Godot.Theme n52)
                castedNode.Theme = n52;
            if (ThemeTypeVariation is Godot.StringName n53)
                castedNode.ThemeTypeVariation = n53;
            if (Visible is System.Boolean n54)
                castedNode.Visible = n54;
            if (Modulate is Godot.Color n55)
                castedNode.Modulate = n55;
            if (SelfModulate is Godot.Color n56)
                castedNode.SelfModulate = n56;
            if (ShowBehindParent is System.Boolean n57)
                castedNode.ShowBehindParent = n57;
            if (TopLevel is System.Boolean n58)
                castedNode.TopLevel = n58;
            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n59)
                castedNode.ClipChildren = n59;
            if (LightMask is System.Int32 n60)
                castedNode.LightMask = n60;
            if (VisibilityLayer is System.UInt32 n61)
                castedNode.VisibilityLayer = n61;
            if (ZIndex is System.Int32 n62)
                castedNode.ZIndex = n62;
            if (ZAsRelative is System.Boolean n63)
                castedNode.ZAsRelative = n63;
            if (YSortEnabled is System.Boolean n64)
                castedNode.YSortEnabled = n64;
            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n65)
                castedNode.TextureFilter = n65;
            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n66)
                castedNode.TextureRepeat = n66;
            if (Material is Godot.Material n67)
                castedNode.Material = n67;
            if (UseParentMaterial is System.Boolean n68)
                castedNode.UseParentMaterial = n68;
            if (Name is Godot.StringName n69)
                castedNode.Name = n69;
            if (UniqueNameInOwner is System.Boolean n70)
                castedNode.UniqueNameInOwner = n70;
            if (SceneFilePath is System.String n71)
                castedNode.SceneFilePath = n71;
            if (Owner is Godot.Node n72)
                castedNode.Owner = n72;
            if (ProcessMode is Godot.Node.ProcessModeEnum n73)
                castedNode.ProcessMode = n73;
            if (ProcessPriority is System.Int32 n74)
                castedNode.ProcessPriority = n74;
            if (ProcessPhysicsPriority is System.Int32 n75)
                castedNode.ProcessPhysicsPriority = n75;
            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n76)
                castedNode.ProcessThreadGroup = n76;
            if (ProcessThreadGroupOrder is System.Int32 n77)
                castedNode.ProcessThreadGroupOrder = n77;
            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n78)
                castedNode.ProcessThreadMessages = n78;
            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n79)
                castedNode.PhysicsInterpolationMode = n79;
            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n80)
                castedNode.AutoTranslateMode = n80;
            if (EditorDescription is System.String n81)
                castedNode.EditorDescription = n81;
            if (ColorChanged is Godot.ColorPicker.ColorChangedEventHandler e0)
                castedNode.ColorChanged += e0;
            if (PresetAdded is Godot.ColorPicker.PresetAddedEventHandler e1)
                castedNode.PresetAdded += e1;
            if (PresetRemoved is Godot.ColorPicker.PresetRemovedEventHandler e2)
                castedNode.PresetRemoved += e2;
            if (PreSortChildren is System.Action e3)
                castedNode.PreSortChildren += e3;
            if (SortChildren is System.Action e4)
                castedNode.SortChildren += e4;
            if (Resized is System.Action e5)
                castedNode.Resized += e5;
            if (GuiInput is Godot.Control.GuiInputEventHandler e6)
                castedNode.GuiInput += e6;
            if (MouseEntered is System.Action e7)
                castedNode.MouseEntered += e7;
            if (MouseExited is System.Action e8)
                castedNode.MouseExited += e8;
            if (FocusEntered is System.Action e9)
                castedNode.FocusEntered += e9;
            if (FocusExited is System.Action e10)
                castedNode.FocusExited += e10;
            if (SizeFlagsChanged is System.Action e11)
                castedNode.SizeFlagsChanged += e11;
            if (MinimumSizeChanged is System.Action e12)
                castedNode.MinimumSizeChanged += e12;
            if (ThemeChanged is System.Action e13)
                castedNode.ThemeChanged += e13;
            if (Draw is System.Action e14)
                castedNode.Draw += e14;
            if (VisibilityChanged is System.Action e15)
                castedNode.VisibilityChanged += e15;
            if (Hidden is System.Action e16)
                castedNode.Hidden += e16;
            if (ItemRectChanged is System.Action e17)
                castedNode.ItemRectChanged += e17;
            if (Ready is System.Action e18)
                castedNode.Ready += e18;
            if (Renamed is System.Action e19)
                castedNode.Renamed += e19;
            if (TreeEntered is System.Action e20)
                castedNode.TreeEntered += e20;
            if (TreeExiting is System.Action e21)
                castedNode.TreeExiting += e21;
            if (TreeExited is System.Action e22)
                castedNode.TreeExited += e22;
            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e23)
                castedNode.ChildEnteredTree += e23;
            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e24)
                castedNode.ChildExitingTree += e24;
            if (ChildOrderChanged is System.Action e25)
                castedNode.ChildOrderChanged += e25;
            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e26)
                castedNode.ReplacingBy += e26;
            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e27)
                castedNode.EditorDescriptionChanged += e27;
            if (ScriptChanged is System.Action e28)
                castedNode.ScriptChanged += e28;
            if (PropertyListChanged is System.Action e29)
                castedNode.PropertyListChanged += e29;
        }
    }
}