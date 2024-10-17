namespace ReactiveSharpGodot.Components
{
    public class NinePatchRect : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GNinePatchRect>
    {
        public Godot.Texture2D? Texture { protected get; init; }
        public System.Boolean? DrawCenter { protected get; init; }
        public Godot.Rect2? RegionRect { protected get; init; }
        public System.Int32? PatchMarginLeft { protected get; init; }
        public System.Int32? PatchMarginTop { protected get; init; }
        public System.Int32? PatchMarginRight { protected get; init; }
        public System.Int32? PatchMarginBottom { protected get; init; }
        public Godot.NinePatchRect.AxisStretchMode? AxisStretchHorizontal { protected get; init; }
        public Godot.NinePatchRect.AxisStretchMode? AxisStretchVertical { protected get; init; }
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
        public System.Action? TextureChanged { protected get; init; }
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

        public override ReactiveSharpGodot.Nodes.GNinePatchRect Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GNinePatchRect();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GNinePatchRect node)
        {
            var castedNode = (Godot.NinePatchRect)node.Node;
            if (Texture is Godot.Texture2D n0)
                castedNode.Texture = n0;
            if (DrawCenter is System.Boolean n1)
                castedNode.DrawCenter = n1;
            if (RegionRect is Godot.Rect2 n2)
                castedNode.RegionRect = n2;
            if (PatchMarginLeft is System.Int32 n3)
                castedNode.PatchMarginLeft = n3;
            if (PatchMarginTop is System.Int32 n4)
                castedNode.PatchMarginTop = n4;
            if (PatchMarginRight is System.Int32 n5)
                castedNode.PatchMarginRight = n5;
            if (PatchMarginBottom is System.Int32 n6)
                castedNode.PatchMarginBottom = n6;
            if (AxisStretchHorizontal is Godot.NinePatchRect.AxisStretchMode n7)
                castedNode.AxisStretchHorizontal = n7;
            if (AxisStretchVertical is Godot.NinePatchRect.AxisStretchMode n8)
                castedNode.AxisStretchVertical = n8;
            if (ClipContents is System.Boolean n9)
                castedNode.ClipContents = n9;
            if (CustomMinimumSize is Godot.Vector2 n10)
                castedNode.CustomMinimumSize = n10;
            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n11)
                castedNode.LayoutDirection = n11;
            if (LayoutMode is System.Int32 n12)
                castedNode.LayoutMode = n12;
            if (AnchorsPreset is System.Int32 n13)
                castedNode.AnchorsPreset = n13;
            if (AnchorLeft is System.Single n14)
                castedNode.AnchorLeft = n14;
            if (AnchorTop is System.Single n15)
                castedNode.AnchorTop = n15;
            if (AnchorRight is System.Single n16)
                castedNode.AnchorRight = n16;
            if (AnchorBottom is System.Single n17)
                castedNode.AnchorBottom = n17;
            if (OffsetLeft is System.Single n18)
                castedNode.OffsetLeft = n18;
            if (OffsetTop is System.Single n19)
                castedNode.OffsetTop = n19;
            if (OffsetRight is System.Single n20)
                castedNode.OffsetRight = n20;
            if (OffsetBottom is System.Single n21)
                castedNode.OffsetBottom = n21;
            if (GrowHorizontal is Godot.Control.GrowDirection n22)
                castedNode.GrowHorizontal = n22;
            if (GrowVertical is Godot.Control.GrowDirection n23)
                castedNode.GrowVertical = n23;
            if (Size is Godot.Vector2 n24)
                castedNode.Size = n24;
            if (Position is Godot.Vector2 n25)
                castedNode.Position = n25;
            if (GlobalPosition is Godot.Vector2 n26)
                castedNode.GlobalPosition = n26;
            if (Rotation is System.Single n27)
                castedNode.Rotation = n27;
            if (RotationDegrees is System.Single n28)
                castedNode.RotationDegrees = n28;
            if (Scale is Godot.Vector2 n29)
                castedNode.Scale = n29;
            if (PivotOffset is Godot.Vector2 n30)
                castedNode.PivotOffset = n30;
            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n31)
                castedNode.SizeFlagsHorizontal = n31;
            if (SizeFlagsVertical is Godot.Control.SizeFlags n32)
                castedNode.SizeFlagsVertical = n32;
            if (SizeFlagsStretchRatio is System.Single n33)
                castedNode.SizeFlagsStretchRatio = n33;
            if (LocalizeNumeralSystem is System.Boolean n34)
                castedNode.LocalizeNumeralSystem = n34;
            if (AutoTranslate is System.Boolean n35)
                castedNode.AutoTranslate = n35;
            if (TooltipText is System.String n36)
                castedNode.TooltipText = n36;
            if (FocusNeighborLeft is Godot.NodePath n37)
                castedNode.FocusNeighborLeft = n37;
            if (FocusNeighborTop is Godot.NodePath n38)
                castedNode.FocusNeighborTop = n38;
            if (FocusNeighborRight is Godot.NodePath n39)
                castedNode.FocusNeighborRight = n39;
            if (FocusNeighborBottom is Godot.NodePath n40)
                castedNode.FocusNeighborBottom = n40;
            if (FocusNext is Godot.NodePath n41)
                castedNode.FocusNext = n41;
            if (FocusPrevious is Godot.NodePath n42)
                castedNode.FocusPrevious = n42;
            if (FocusMode is Godot.Control.FocusModeEnum n43)
                castedNode.FocusMode = n43;
            if (MouseFilter is Godot.Control.MouseFilterEnum n44)
                castedNode.MouseFilter = n44;
            if (MouseForcePassScrollEvents is System.Boolean n45)
                castedNode.MouseForcePassScrollEvents = n45;
            if (MouseDefaultCursorShape is Godot.Control.CursorShape n46)
                castedNode.MouseDefaultCursorShape = n46;
            if (ShortcutContext is Godot.Node n47)
                castedNode.ShortcutContext = n47;
            if (Theme is Godot.Theme n48)
                castedNode.Theme = n48;
            if (ThemeTypeVariation is Godot.StringName n49)
                castedNode.ThemeTypeVariation = n49;
            if (Visible is System.Boolean n50)
                castedNode.Visible = n50;
            if (Modulate is Godot.Color n51)
                castedNode.Modulate = n51;
            if (SelfModulate is Godot.Color n52)
                castedNode.SelfModulate = n52;
            if (ShowBehindParent is System.Boolean n53)
                castedNode.ShowBehindParent = n53;
            if (TopLevel is System.Boolean n54)
                castedNode.TopLevel = n54;
            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n55)
                castedNode.ClipChildren = n55;
            if (LightMask is System.Int32 n56)
                castedNode.LightMask = n56;
            if (VisibilityLayer is System.UInt32 n57)
                castedNode.VisibilityLayer = n57;
            if (ZIndex is System.Int32 n58)
                castedNode.ZIndex = n58;
            if (ZAsRelative is System.Boolean n59)
                castedNode.ZAsRelative = n59;
            if (YSortEnabled is System.Boolean n60)
                castedNode.YSortEnabled = n60;
            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n61)
                castedNode.TextureFilter = n61;
            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n62)
                castedNode.TextureRepeat = n62;
            if (Material is Godot.Material n63)
                castedNode.Material = n63;
            if (UseParentMaterial is System.Boolean n64)
                castedNode.UseParentMaterial = n64;
            if (Name is Godot.StringName n65)
                castedNode.Name = n65;
            if (UniqueNameInOwner is System.Boolean n66)
                castedNode.UniqueNameInOwner = n66;
            if (SceneFilePath is System.String n67)
                castedNode.SceneFilePath = n67;
            if (Owner is Godot.Node n68)
                castedNode.Owner = n68;
            if (ProcessMode is Godot.Node.ProcessModeEnum n69)
                castedNode.ProcessMode = n69;
            if (ProcessPriority is System.Int32 n70)
                castedNode.ProcessPriority = n70;
            if (ProcessPhysicsPriority is System.Int32 n71)
                castedNode.ProcessPhysicsPriority = n71;
            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n72)
                castedNode.ProcessThreadGroup = n72;
            if (ProcessThreadGroupOrder is System.Int32 n73)
                castedNode.ProcessThreadGroupOrder = n73;
            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n74)
                castedNode.ProcessThreadMessages = n74;
            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n75)
                castedNode.PhysicsInterpolationMode = n75;
            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n76)
                castedNode.AutoTranslateMode = n76;
            if (EditorDescription is System.String n77)
                castedNode.EditorDescription = n77;
            if (TextureChanged is System.Action e0)
                castedNode.TextureChanged += e0;
            if (Resized is System.Action e1)
                castedNode.Resized += e1;
            if (GuiInput is Godot.Control.GuiInputEventHandler e2)
                castedNode.GuiInput += e2;
            if (MouseEntered is System.Action e3)
                castedNode.MouseEntered += e3;
            if (MouseExited is System.Action e4)
                castedNode.MouseExited += e4;
            if (FocusEntered is System.Action e5)
                castedNode.FocusEntered += e5;
            if (FocusExited is System.Action e6)
                castedNode.FocusExited += e6;
            if (SizeFlagsChanged is System.Action e7)
                castedNode.SizeFlagsChanged += e7;
            if (MinimumSizeChanged is System.Action e8)
                castedNode.MinimumSizeChanged += e8;
            if (ThemeChanged is System.Action e9)
                castedNode.ThemeChanged += e9;
            if (Draw is System.Action e10)
                castedNode.Draw += e10;
            if (VisibilityChanged is System.Action e11)
                castedNode.VisibilityChanged += e11;
            if (Hidden is System.Action e12)
                castedNode.Hidden += e12;
            if (ItemRectChanged is System.Action e13)
                castedNode.ItemRectChanged += e13;
            if (Ready is System.Action e14)
                castedNode.Ready += e14;
            if (Renamed is System.Action e15)
                castedNode.Renamed += e15;
            if (TreeEntered is System.Action e16)
                castedNode.TreeEntered += e16;
            if (TreeExiting is System.Action e17)
                castedNode.TreeExiting += e17;
            if (TreeExited is System.Action e18)
                castedNode.TreeExited += e18;
            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e19)
                castedNode.ChildEnteredTree += e19;
            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e20)
                castedNode.ChildExitingTree += e20;
            if (ChildOrderChanged is System.Action e21)
                castedNode.ChildOrderChanged += e21;
            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e22)
                castedNode.ReplacingBy += e22;
            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e23)
                castedNode.EditorDescriptionChanged += e23;
            if (ScriptChanged is System.Action e24)
                castedNode.ScriptChanged += e24;
            if (PropertyListChanged is System.Action e25)
                castedNode.PropertyListChanged += e25;
        }
    }
}