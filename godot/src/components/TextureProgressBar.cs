namespace ReactiveSharpGodot.Components
{
    public class TextureProgressBar : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GTextureProgressBar>
    {
        public System.Int32? FillMode { protected get; init; }
        public System.Single? RadialInitialAngle { protected get; init; }
        public System.Single? RadialFillDegrees { protected get; init; }
        public Godot.Vector2? RadialCenterOffset { protected get; init; }
        public System.Boolean? NinePatchStretch { protected get; init; }
        public System.Int32? StretchMarginLeft { protected get; init; }
        public System.Int32? StretchMarginTop { protected get; init; }
        public System.Int32? StretchMarginRight { protected get; init; }
        public System.Int32? StretchMarginBottom { protected get; init; }
        public Godot.Texture2D? TextureUnder { protected get; init; }
        public Godot.Texture2D? TextureOver { protected get; init; }
        public Godot.Texture2D? TextureProgress { protected get; init; }
        public Godot.Vector2? TextureProgressOffset { protected get; init; }
        public Godot.Color? TintUnder { protected get; init; }
        public Godot.Color? TintOver { protected get; init; }
        public Godot.Color? TintProgress { protected get; init; }
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

        public override ReactiveSharpGodot.Nodes.GTextureProgressBar Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GTextureProgressBar();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GTextureProgressBar node)
        {
            var castedNode = (Godot.TextureProgressBar)node.Node;
            if (FillMode is System.Int32 n0)
                castedNode.FillMode = n0;
            if (RadialInitialAngle is System.Single n1)
                castedNode.RadialInitialAngle = n1;
            if (RadialFillDegrees is System.Single n2)
                castedNode.RadialFillDegrees = n2;
            if (RadialCenterOffset is Godot.Vector2 n3)
                castedNode.RadialCenterOffset = n3;
            if (NinePatchStretch is System.Boolean n4)
                castedNode.NinePatchStretch = n4;
            if (StretchMarginLeft is System.Int32 n5)
                castedNode.StretchMarginLeft = n5;
            if (StretchMarginTop is System.Int32 n6)
                castedNode.StretchMarginTop = n6;
            if (StretchMarginRight is System.Int32 n7)
                castedNode.StretchMarginRight = n7;
            if (StretchMarginBottom is System.Int32 n8)
                castedNode.StretchMarginBottom = n8;
            if (TextureUnder is Godot.Texture2D n9)
                castedNode.TextureUnder = n9;
            if (TextureOver is Godot.Texture2D n10)
                castedNode.TextureOver = n10;
            if (TextureProgress is Godot.Texture2D n11)
                castedNode.TextureProgress = n11;
            if (TextureProgressOffset is Godot.Vector2 n12)
                castedNode.TextureProgressOffset = n12;
            if (TintUnder is Godot.Color n13)
                castedNode.TintUnder = n13;
            if (TintOver is Godot.Color n14)
                castedNode.TintOver = n14;
            if (TintProgress is Godot.Color n15)
                castedNode.TintProgress = n15;
            if (MinValue is System.Double n16)
                castedNode.MinValue = n16;
            if (MaxValue is System.Double n17)
                castedNode.MaxValue = n17;
            if (Step is System.Double n18)
                castedNode.Step = n18;
            if (Page is System.Double n19)
                castedNode.Page = n19;
            if (Value is System.Double n20)
                castedNode.Value = n20;
            if (Ratio is System.Double n21)
                castedNode.Ratio = n21;
            if (ExpEdit is System.Boolean n22)
                castedNode.ExpEdit = n22;
            if (Rounded is System.Boolean n23)
                castedNode.Rounded = n23;
            if (AllowGreater is System.Boolean n24)
                castedNode.AllowGreater = n24;
            if (AllowLesser is System.Boolean n25)
                castedNode.AllowLesser = n25;
            if (ClipContents is System.Boolean n26)
                castedNode.ClipContents = n26;
            if (CustomMinimumSize is Godot.Vector2 n27)
                castedNode.CustomMinimumSize = n27;
            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n28)
                castedNode.LayoutDirection = n28;
            if (LayoutMode is System.Int32 n29)
                castedNode.LayoutMode = n29;
            if (AnchorsPreset is System.Int32 n30)
                castedNode.AnchorsPreset = n30;
            if (AnchorLeft is System.Single n31)
                castedNode.AnchorLeft = n31;
            if (AnchorTop is System.Single n32)
                castedNode.AnchorTop = n32;
            if (AnchorRight is System.Single n33)
                castedNode.AnchorRight = n33;
            if (AnchorBottom is System.Single n34)
                castedNode.AnchorBottom = n34;
            if (OffsetLeft is System.Single n35)
                castedNode.OffsetLeft = n35;
            if (OffsetTop is System.Single n36)
                castedNode.OffsetTop = n36;
            if (OffsetRight is System.Single n37)
                castedNode.OffsetRight = n37;
            if (OffsetBottom is System.Single n38)
                castedNode.OffsetBottom = n38;
            if (GrowHorizontal is Godot.Control.GrowDirection n39)
                castedNode.GrowHorizontal = n39;
            if (GrowVertical is Godot.Control.GrowDirection n40)
                castedNode.GrowVertical = n40;
            if (Size is Godot.Vector2 n41)
                castedNode.Size = n41;
            if (Position is Godot.Vector2 n42)
                castedNode.Position = n42;
            if (GlobalPosition is Godot.Vector2 n43)
                castedNode.GlobalPosition = n43;
            if (Rotation is System.Single n44)
                castedNode.Rotation = n44;
            if (RotationDegrees is System.Single n45)
                castedNode.RotationDegrees = n45;
            if (Scale is Godot.Vector2 n46)
                castedNode.Scale = n46;
            if (PivotOffset is Godot.Vector2 n47)
                castedNode.PivotOffset = n47;
            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n48)
                castedNode.SizeFlagsHorizontal = n48;
            if (SizeFlagsVertical is Godot.Control.SizeFlags n49)
                castedNode.SizeFlagsVertical = n49;
            if (SizeFlagsStretchRatio is System.Single n50)
                castedNode.SizeFlagsStretchRatio = n50;
            if (LocalizeNumeralSystem is System.Boolean n51)
                castedNode.LocalizeNumeralSystem = n51;
            if (AutoTranslate is System.Boolean n52)
                castedNode.AutoTranslate = n52;
            if (TooltipText is System.String n53)
                castedNode.TooltipText = n53;
            if (FocusNeighborLeft is Godot.NodePath n54)
                castedNode.FocusNeighborLeft = n54;
            if (FocusNeighborTop is Godot.NodePath n55)
                castedNode.FocusNeighborTop = n55;
            if (FocusNeighborRight is Godot.NodePath n56)
                castedNode.FocusNeighborRight = n56;
            if (FocusNeighborBottom is Godot.NodePath n57)
                castedNode.FocusNeighborBottom = n57;
            if (FocusNext is Godot.NodePath n58)
                castedNode.FocusNext = n58;
            if (FocusPrevious is Godot.NodePath n59)
                castedNode.FocusPrevious = n59;
            if (FocusMode is Godot.Control.FocusModeEnum n60)
                castedNode.FocusMode = n60;
            if (MouseFilter is Godot.Control.MouseFilterEnum n61)
                castedNode.MouseFilter = n61;
            if (MouseForcePassScrollEvents is System.Boolean n62)
                castedNode.MouseForcePassScrollEvents = n62;
            if (MouseDefaultCursorShape is Godot.Control.CursorShape n63)
                castedNode.MouseDefaultCursorShape = n63;
            if (ShortcutContext is Godot.Node n64)
                castedNode.ShortcutContext = n64;
            if (Theme is Godot.Theme n65)
                castedNode.Theme = n65;
            if (ThemeTypeVariation is Godot.StringName n66)
                castedNode.ThemeTypeVariation = n66;
            if (Visible is System.Boolean n67)
                castedNode.Visible = n67;
            if (Modulate is Godot.Color n68)
                castedNode.Modulate = n68;
            if (SelfModulate is Godot.Color n69)
                castedNode.SelfModulate = n69;
            if (ShowBehindParent is System.Boolean n70)
                castedNode.ShowBehindParent = n70;
            if (TopLevel is System.Boolean n71)
                castedNode.TopLevel = n71;
            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n72)
                castedNode.ClipChildren = n72;
            if (LightMask is System.Int32 n73)
                castedNode.LightMask = n73;
            if (VisibilityLayer is System.UInt32 n74)
                castedNode.VisibilityLayer = n74;
            if (ZIndex is System.Int32 n75)
                castedNode.ZIndex = n75;
            if (ZAsRelative is System.Boolean n76)
                castedNode.ZAsRelative = n76;
            if (YSortEnabled is System.Boolean n77)
                castedNode.YSortEnabled = n77;
            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n78)
                castedNode.TextureFilter = n78;
            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n79)
                castedNode.TextureRepeat = n79;
            if (Material is Godot.Material n80)
                castedNode.Material = n80;
            if (UseParentMaterial is System.Boolean n81)
                castedNode.UseParentMaterial = n81;
            if (Name is Godot.StringName n82)
                castedNode.Name = n82;
            if (UniqueNameInOwner is System.Boolean n83)
                castedNode.UniqueNameInOwner = n83;
            if (SceneFilePath is System.String n84)
                castedNode.SceneFilePath = n84;
            if (Owner is Godot.Node n85)
                castedNode.Owner = n85;
            if (ProcessMode is Godot.Node.ProcessModeEnum n86)
                castedNode.ProcessMode = n86;
            if (ProcessPriority is System.Int32 n87)
                castedNode.ProcessPriority = n87;
            if (ProcessPhysicsPriority is System.Int32 n88)
                castedNode.ProcessPhysicsPriority = n88;
            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n89)
                castedNode.ProcessThreadGroup = n89;
            if (ProcessThreadGroupOrder is System.Int32 n90)
                castedNode.ProcessThreadGroupOrder = n90;
            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n91)
                castedNode.ProcessThreadMessages = n91;
            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n92)
                castedNode.PhysicsInterpolationMode = n92;
            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n93)
                castedNode.AutoTranslateMode = n93;
            if (EditorDescription is System.String n94)
                castedNode.EditorDescription = n94;
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