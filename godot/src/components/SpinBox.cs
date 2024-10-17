namespace ReactiveSharpGodot.Components
{
    public class SpinBox : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GSpinBox>
    {
        public Godot.HorizontalAlignment? Alignment { protected get; init; }
        public System.Boolean? Editable { protected get; init; }
        public System.Boolean? UpdateOnTextChanged { protected get; init; }
        public System.String? Prefix { protected get; init; }
        public System.String? Suffix { protected get; init; }
        public System.Double? CustomArrowStep { protected get; init; }
        public System.Boolean? SelectAllOnFocus { protected get; init; }
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

        public override ReactiveSharpGodot.Nodes.GSpinBox Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GSpinBox();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GSpinBox node)
        {
            var castedNode = (Godot.SpinBox)node.Node;
            if (Alignment is Godot.HorizontalAlignment n0)
                castedNode.Alignment = n0;
            if (Editable is System.Boolean n1)
                castedNode.Editable = n1;
            if (UpdateOnTextChanged is System.Boolean n2)
                castedNode.UpdateOnTextChanged = n2;
            if (Prefix is System.String n3)
                castedNode.Prefix = n3;
            if (Suffix is System.String n4)
                castedNode.Suffix = n4;
            if (CustomArrowStep is System.Double n5)
                castedNode.CustomArrowStep = n5;
            if (SelectAllOnFocus is System.Boolean n6)
                castedNode.SelectAllOnFocus = n6;
            if (MinValue is System.Double n7)
                castedNode.MinValue = n7;
            if (MaxValue is System.Double n8)
                castedNode.MaxValue = n8;
            if (Step is System.Double n9)
                castedNode.Step = n9;
            if (Page is System.Double n10)
                castedNode.Page = n10;
            if (Value is System.Double n11)
                castedNode.Value = n11;
            if (Ratio is System.Double n12)
                castedNode.Ratio = n12;
            if (ExpEdit is System.Boolean n13)
                castedNode.ExpEdit = n13;
            if (Rounded is System.Boolean n14)
                castedNode.Rounded = n14;
            if (AllowGreater is System.Boolean n15)
                castedNode.AllowGreater = n15;
            if (AllowLesser is System.Boolean n16)
                castedNode.AllowLesser = n16;
            if (ClipContents is System.Boolean n17)
                castedNode.ClipContents = n17;
            if (CustomMinimumSize is Godot.Vector2 n18)
                castedNode.CustomMinimumSize = n18;
            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n19)
                castedNode.LayoutDirection = n19;
            if (LayoutMode is System.Int32 n20)
                castedNode.LayoutMode = n20;
            if (AnchorsPreset is System.Int32 n21)
                castedNode.AnchorsPreset = n21;
            if (AnchorLeft is System.Single n22)
                castedNode.AnchorLeft = n22;
            if (AnchorTop is System.Single n23)
                castedNode.AnchorTop = n23;
            if (AnchorRight is System.Single n24)
                castedNode.AnchorRight = n24;
            if (AnchorBottom is System.Single n25)
                castedNode.AnchorBottom = n25;
            if (OffsetLeft is System.Single n26)
                castedNode.OffsetLeft = n26;
            if (OffsetTop is System.Single n27)
                castedNode.OffsetTop = n27;
            if (OffsetRight is System.Single n28)
                castedNode.OffsetRight = n28;
            if (OffsetBottom is System.Single n29)
                castedNode.OffsetBottom = n29;
            if (GrowHorizontal is Godot.Control.GrowDirection n30)
                castedNode.GrowHorizontal = n30;
            if (GrowVertical is Godot.Control.GrowDirection n31)
                castedNode.GrowVertical = n31;
            if (Size is Godot.Vector2 n32)
                castedNode.Size = n32;
            if (Position is Godot.Vector2 n33)
                castedNode.Position = n33;
            if (GlobalPosition is Godot.Vector2 n34)
                castedNode.GlobalPosition = n34;
            if (Rotation is System.Single n35)
                castedNode.Rotation = n35;
            if (RotationDegrees is System.Single n36)
                castedNode.RotationDegrees = n36;
            if (Scale is Godot.Vector2 n37)
                castedNode.Scale = n37;
            if (PivotOffset is Godot.Vector2 n38)
                castedNode.PivotOffset = n38;
            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n39)
                castedNode.SizeFlagsHorizontal = n39;
            if (SizeFlagsVertical is Godot.Control.SizeFlags n40)
                castedNode.SizeFlagsVertical = n40;
            if (SizeFlagsStretchRatio is System.Single n41)
                castedNode.SizeFlagsStretchRatio = n41;
            if (LocalizeNumeralSystem is System.Boolean n42)
                castedNode.LocalizeNumeralSystem = n42;
            if (AutoTranslate is System.Boolean n43)
                castedNode.AutoTranslate = n43;
            if (TooltipText is System.String n44)
                castedNode.TooltipText = n44;
            if (FocusNeighborLeft is Godot.NodePath n45)
                castedNode.FocusNeighborLeft = n45;
            if (FocusNeighborTop is Godot.NodePath n46)
                castedNode.FocusNeighborTop = n46;
            if (FocusNeighborRight is Godot.NodePath n47)
                castedNode.FocusNeighborRight = n47;
            if (FocusNeighborBottom is Godot.NodePath n48)
                castedNode.FocusNeighborBottom = n48;
            if (FocusNext is Godot.NodePath n49)
                castedNode.FocusNext = n49;
            if (FocusPrevious is Godot.NodePath n50)
                castedNode.FocusPrevious = n50;
            if (FocusMode is Godot.Control.FocusModeEnum n51)
                castedNode.FocusMode = n51;
            if (MouseFilter is Godot.Control.MouseFilterEnum n52)
                castedNode.MouseFilter = n52;
            if (MouseForcePassScrollEvents is System.Boolean n53)
                castedNode.MouseForcePassScrollEvents = n53;
            if (MouseDefaultCursorShape is Godot.Control.CursorShape n54)
                castedNode.MouseDefaultCursorShape = n54;
            if (ShortcutContext is Godot.Node n55)
                castedNode.ShortcutContext = n55;
            if (Theme is Godot.Theme n56)
                castedNode.Theme = n56;
            if (ThemeTypeVariation is Godot.StringName n57)
                castedNode.ThemeTypeVariation = n57;
            if (Visible is System.Boolean n58)
                castedNode.Visible = n58;
            if (Modulate is Godot.Color n59)
                castedNode.Modulate = n59;
            if (SelfModulate is Godot.Color n60)
                castedNode.SelfModulate = n60;
            if (ShowBehindParent is System.Boolean n61)
                castedNode.ShowBehindParent = n61;
            if (TopLevel is System.Boolean n62)
                castedNode.TopLevel = n62;
            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n63)
                castedNode.ClipChildren = n63;
            if (LightMask is System.Int32 n64)
                castedNode.LightMask = n64;
            if (VisibilityLayer is System.UInt32 n65)
                castedNode.VisibilityLayer = n65;
            if (ZIndex is System.Int32 n66)
                castedNode.ZIndex = n66;
            if (ZAsRelative is System.Boolean n67)
                castedNode.ZAsRelative = n67;
            if (YSortEnabled is System.Boolean n68)
                castedNode.YSortEnabled = n68;
            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n69)
                castedNode.TextureFilter = n69;
            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n70)
                castedNode.TextureRepeat = n70;
            if (Material is Godot.Material n71)
                castedNode.Material = n71;
            if (UseParentMaterial is System.Boolean n72)
                castedNode.UseParentMaterial = n72;
            if (Name is Godot.StringName n73)
                castedNode.Name = n73;
            if (UniqueNameInOwner is System.Boolean n74)
                castedNode.UniqueNameInOwner = n74;
            if (SceneFilePath is System.String n75)
                castedNode.SceneFilePath = n75;
            if (Owner is Godot.Node n76)
                castedNode.Owner = n76;
            if (ProcessMode is Godot.Node.ProcessModeEnum n77)
                castedNode.ProcessMode = n77;
            if (ProcessPriority is System.Int32 n78)
                castedNode.ProcessPriority = n78;
            if (ProcessPhysicsPriority is System.Int32 n79)
                castedNode.ProcessPhysicsPriority = n79;
            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n80)
                castedNode.ProcessThreadGroup = n80;
            if (ProcessThreadGroupOrder is System.Int32 n81)
                castedNode.ProcessThreadGroupOrder = n81;
            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n82)
                castedNode.ProcessThreadMessages = n82;
            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n83)
                castedNode.PhysicsInterpolationMode = n83;
            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n84)
                castedNode.AutoTranslateMode = n84;
            if (EditorDescription is System.String n85)
                castedNode.EditorDescription = n85;
            if (ValueChanged is Godot.Range.ValueChangedEventHandler e0)
                castedNode.ValueChanged += e0;
            if (Changed is System.Action e1)
                castedNode.Changed += e1;
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