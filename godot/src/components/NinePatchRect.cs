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
        public Dictionary<string, int> ThemeConstantOverrides { protected get; init; } = [];

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
            {
                NodeStateManager.AddPropertyState(castedNode, "Texture", castedNode.Texture);
                castedNode.Texture = n0;
            }

            if (DrawCenter is System.Boolean n1)
            {
                NodeStateManager.AddPropertyState(castedNode, "DrawCenter", castedNode.DrawCenter);
                castedNode.DrawCenter = n1;
            }

            if (RegionRect is Godot.Rect2 n2)
            {
                NodeStateManager.AddPropertyState(castedNode, "RegionRect", castedNode.RegionRect);
                castedNode.RegionRect = n2;
            }

            if (PatchMarginLeft is System.Int32 n3)
            {
                NodeStateManager.AddPropertyState(castedNode, "PatchMarginLeft", castedNode.PatchMarginLeft);
                castedNode.PatchMarginLeft = n3;
            }

            if (PatchMarginTop is System.Int32 n4)
            {
                NodeStateManager.AddPropertyState(castedNode, "PatchMarginTop", castedNode.PatchMarginTop);
                castedNode.PatchMarginTop = n4;
            }

            if (PatchMarginRight is System.Int32 n5)
            {
                NodeStateManager.AddPropertyState(castedNode, "PatchMarginRight", castedNode.PatchMarginRight);
                castedNode.PatchMarginRight = n5;
            }

            if (PatchMarginBottom is System.Int32 n6)
            {
                NodeStateManager.AddPropertyState(castedNode, "PatchMarginBottom", castedNode.PatchMarginBottom);
                castedNode.PatchMarginBottom = n6;
            }

            if (AxisStretchHorizontal is Godot.NinePatchRect.AxisStretchMode n7)
            {
                NodeStateManager.AddPropertyState(castedNode, "AxisStretchHorizontal", castedNode.AxisStretchHorizontal);
                castedNode.AxisStretchHorizontal = n7;
            }

            if (AxisStretchVertical is Godot.NinePatchRect.AxisStretchMode n8)
            {
                NodeStateManager.AddPropertyState(castedNode, "AxisStretchVertical", castedNode.AxisStretchVertical);
                castedNode.AxisStretchVertical = n8;
            }

            if (ClipContents is System.Boolean n9)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipContents", castedNode.ClipContents);
                castedNode.ClipContents = n9;
            }

            if (CustomMinimumSize is Godot.Vector2 n10)
            {
                NodeStateManager.AddPropertyState(castedNode, "CustomMinimumSize", castedNode.CustomMinimumSize);
                castedNode.CustomMinimumSize = n10;
            }

            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n11)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutDirection", castedNode.LayoutDirection);
                castedNode.LayoutDirection = n11;
            }

            if (LayoutMode is System.Int32 n12)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutMode", castedNode.LayoutMode);
                castedNode.LayoutMode = n12;
            }

            if (AnchorsPreset is System.Int32 n13)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorsPreset", castedNode.AnchorsPreset);
                castedNode.AnchorsPreset = n13;
            }

            if (AnchorLeft is System.Single n14)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorLeft", castedNode.AnchorLeft);
                castedNode.AnchorLeft = n14;
            }

            if (AnchorTop is System.Single n15)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorTop", castedNode.AnchorTop);
                castedNode.AnchorTop = n15;
            }

            if (AnchorRight is System.Single n16)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorRight", castedNode.AnchorRight);
                castedNode.AnchorRight = n16;
            }

            if (AnchorBottom is System.Single n17)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorBottom", castedNode.AnchorBottom);
                castedNode.AnchorBottom = n17;
            }

            if (OffsetLeft is System.Single n18)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetLeft", castedNode.OffsetLeft);
                castedNode.OffsetLeft = n18;
            }

            if (OffsetTop is System.Single n19)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetTop", castedNode.OffsetTop);
                castedNode.OffsetTop = n19;
            }

            if (OffsetRight is System.Single n20)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetRight", castedNode.OffsetRight);
                castedNode.OffsetRight = n20;
            }

            if (OffsetBottom is System.Single n21)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetBottom", castedNode.OffsetBottom);
                castedNode.OffsetBottom = n21;
            }

            if (GrowHorizontal is Godot.Control.GrowDirection n22)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowHorizontal", castedNode.GrowHorizontal);
                castedNode.GrowHorizontal = n22;
            }

            if (GrowVertical is Godot.Control.GrowDirection n23)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowVertical", castedNode.GrowVertical);
                castedNode.GrowVertical = n23;
            }

            if (Size is Godot.Vector2 n24)
            {
                NodeStateManager.AddPropertyState(castedNode, "Size", castedNode.Size);
                castedNode.Size = n24;
            }

            if (Position is Godot.Vector2 n25)
            {
                NodeStateManager.AddPropertyState(castedNode, "Position", castedNode.Position);
                castedNode.Position = n25;
            }

            if (GlobalPosition is Godot.Vector2 n26)
            {
                NodeStateManager.AddPropertyState(castedNode, "GlobalPosition", castedNode.GlobalPosition);
                castedNode.GlobalPosition = n26;
            }

            if (Rotation is System.Single n27)
            {
                NodeStateManager.AddPropertyState(castedNode, "Rotation", castedNode.Rotation);
                castedNode.Rotation = n27;
            }

            if (RotationDegrees is System.Single n28)
            {
                NodeStateManager.AddPropertyState(castedNode, "RotationDegrees", castedNode.RotationDegrees);
                castedNode.RotationDegrees = n28;
            }

            if (Scale is Godot.Vector2 n29)
            {
                NodeStateManager.AddPropertyState(castedNode, "Scale", castedNode.Scale);
                castedNode.Scale = n29;
            }

            if (PivotOffset is Godot.Vector2 n30)
            {
                NodeStateManager.AddPropertyState(castedNode, "PivotOffset", castedNode.PivotOffset);
                castedNode.PivotOffset = n30;
            }

            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n31)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsHorizontal", castedNode.SizeFlagsHorizontal);
                castedNode.SizeFlagsHorizontal = n31;
            }

            if (SizeFlagsVertical is Godot.Control.SizeFlags n32)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsVertical", castedNode.SizeFlagsVertical);
                castedNode.SizeFlagsVertical = n32;
            }

            if (SizeFlagsStretchRatio is System.Single n33)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsStretchRatio", castedNode.SizeFlagsStretchRatio);
                castedNode.SizeFlagsStretchRatio = n33;
            }

            if (LocalizeNumeralSystem is System.Boolean n34)
            {
                NodeStateManager.AddPropertyState(castedNode, "LocalizeNumeralSystem", castedNode.LocalizeNumeralSystem);
                castedNode.LocalizeNumeralSystem = n34;
            }

            if (AutoTranslate is System.Boolean n35)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslate", castedNode.AutoTranslate);
                castedNode.AutoTranslate = n35;
            }

            if (TooltipText is System.String n36)
            {
                NodeStateManager.AddPropertyState(castedNode, "TooltipText", castedNode.TooltipText);
                castedNode.TooltipText = n36;
            }

            if (FocusNeighborLeft is Godot.NodePath n37)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborLeft", castedNode.FocusNeighborLeft);
                castedNode.FocusNeighborLeft = n37;
            }

            if (FocusNeighborTop is Godot.NodePath n38)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborTop", castedNode.FocusNeighborTop);
                castedNode.FocusNeighborTop = n38;
            }

            if (FocusNeighborRight is Godot.NodePath n39)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborRight", castedNode.FocusNeighborRight);
                castedNode.FocusNeighborRight = n39;
            }

            if (FocusNeighborBottom is Godot.NodePath n40)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborBottom", castedNode.FocusNeighborBottom);
                castedNode.FocusNeighborBottom = n40;
            }

            if (FocusNext is Godot.NodePath n41)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNext", castedNode.FocusNext);
                castedNode.FocusNext = n41;
            }

            if (FocusPrevious is Godot.NodePath n42)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusPrevious", castedNode.FocusPrevious);
                castedNode.FocusPrevious = n42;
            }

            if (FocusMode is Godot.Control.FocusModeEnum n43)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusMode", castedNode.FocusMode);
                castedNode.FocusMode = n43;
            }

            if (MouseFilter is Godot.Control.MouseFilterEnum n44)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseFilter", castedNode.MouseFilter);
                castedNode.MouseFilter = n44;
            }

            if (MouseForcePassScrollEvents is System.Boolean n45)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseForcePassScrollEvents", castedNode.MouseForcePassScrollEvents);
                castedNode.MouseForcePassScrollEvents = n45;
            }

            if (MouseDefaultCursorShape is Godot.Control.CursorShape n46)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseDefaultCursorShape", castedNode.MouseDefaultCursorShape);
                castedNode.MouseDefaultCursorShape = n46;
            }

            if (ShortcutContext is Godot.Node n47)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutContext", castedNode.ShortcutContext);
                castedNode.ShortcutContext = n47;
            }

            if (Theme is Godot.Theme n48)
            {
                NodeStateManager.AddPropertyState(castedNode, "Theme", castedNode.Theme);
                castedNode.Theme = n48;
            }

            if (ThemeTypeVariation is Godot.StringName n49)
            {
                NodeStateManager.AddPropertyState(castedNode, "ThemeTypeVariation", castedNode.ThemeTypeVariation);
                castedNode.ThemeTypeVariation = n49;
            }

            if (Visible is System.Boolean n50)
            {
                NodeStateManager.AddPropertyState(castedNode, "Visible", castedNode.Visible);
                castedNode.Visible = n50;
            }

            if (Modulate is Godot.Color n51)
            {
                NodeStateManager.AddPropertyState(castedNode, "Modulate", castedNode.Modulate);
                castedNode.Modulate = n51;
            }

            if (SelfModulate is Godot.Color n52)
            {
                NodeStateManager.AddPropertyState(castedNode, "SelfModulate", castedNode.SelfModulate);
                castedNode.SelfModulate = n52;
            }

            if (ShowBehindParent is System.Boolean n53)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowBehindParent", castedNode.ShowBehindParent);
                castedNode.ShowBehindParent = n53;
            }

            if (TopLevel is System.Boolean n54)
            {
                NodeStateManager.AddPropertyState(castedNode, "TopLevel", castedNode.TopLevel);
                castedNode.TopLevel = n54;
            }

            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n55)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipChildren", castedNode.ClipChildren);
                castedNode.ClipChildren = n55;
            }

            if (LightMask is System.Int32 n56)
            {
                NodeStateManager.AddPropertyState(castedNode, "LightMask", castedNode.LightMask);
                castedNode.LightMask = n56;
            }

            if (VisibilityLayer is System.UInt32 n57)
            {
                NodeStateManager.AddPropertyState(castedNode, "VisibilityLayer", castedNode.VisibilityLayer);
                castedNode.VisibilityLayer = n57;
            }

            if (ZIndex is System.Int32 n58)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZIndex", castedNode.ZIndex);
                castedNode.ZIndex = n58;
            }

            if (ZAsRelative is System.Boolean n59)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZAsRelative", castedNode.ZAsRelative);
                castedNode.ZAsRelative = n59;
            }

            if (YSortEnabled is System.Boolean n60)
            {
                NodeStateManager.AddPropertyState(castedNode, "YSortEnabled", castedNode.YSortEnabled);
                castedNode.YSortEnabled = n60;
            }

            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n61)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureFilter", castedNode.TextureFilter);
                castedNode.TextureFilter = n61;
            }

            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n62)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureRepeat", castedNode.TextureRepeat);
                castedNode.TextureRepeat = n62;
            }

            if (Material is Godot.Material n63)
            {
                NodeStateManager.AddPropertyState(castedNode, "Material", castedNode.Material);
                castedNode.Material = n63;
            }

            if (UseParentMaterial is System.Boolean n64)
            {
                NodeStateManager.AddPropertyState(castedNode, "UseParentMaterial", castedNode.UseParentMaterial);
                castedNode.UseParentMaterial = n64;
            }

            if (Name is Godot.StringName n65)
            {
                NodeStateManager.AddPropertyState(castedNode, "Name", castedNode.Name);
                castedNode.Name = n65;
            }

            if (UniqueNameInOwner is System.Boolean n66)
            {
                NodeStateManager.AddPropertyState(castedNode, "UniqueNameInOwner", castedNode.UniqueNameInOwner);
                castedNode.UniqueNameInOwner = n66;
            }

            if (SceneFilePath is System.String n67)
            {
                NodeStateManager.AddPropertyState(castedNode, "SceneFilePath", castedNode.SceneFilePath);
                castedNode.SceneFilePath = n67;
            }

            if (Owner is Godot.Node n68)
            {
                NodeStateManager.AddPropertyState(castedNode, "Owner", castedNode.Owner);
                castedNode.Owner = n68;
            }

            if (ProcessMode is Godot.Node.ProcessModeEnum n69)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessMode", castedNode.ProcessMode);
                castedNode.ProcessMode = n69;
            }

            if (ProcessPriority is System.Int32 n70)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPriority", castedNode.ProcessPriority);
                castedNode.ProcessPriority = n70;
            }

            if (ProcessPhysicsPriority is System.Int32 n71)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPhysicsPriority", castedNode.ProcessPhysicsPriority);
                castedNode.ProcessPhysicsPriority = n71;
            }

            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n72)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroup", castedNode.ProcessThreadGroup);
                castedNode.ProcessThreadGroup = n72;
            }

            if (ProcessThreadGroupOrder is System.Int32 n73)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroupOrder", castedNode.ProcessThreadGroupOrder);
                castedNode.ProcessThreadGroupOrder = n73;
            }

            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n74)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadMessages", castedNode.ProcessThreadMessages);
                castedNode.ProcessThreadMessages = n74;
            }

            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n75)
            {
                NodeStateManager.AddPropertyState(castedNode, "PhysicsInterpolationMode", castedNode.PhysicsInterpolationMode);
                castedNode.PhysicsInterpolationMode = n75;
            }

            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n76)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslateMode", castedNode.AutoTranslateMode);
                castedNode.AutoTranslateMode = n76;
            }

            if (EditorDescription is System.String n77)
            {
                NodeStateManager.AddPropertyState(castedNode, "EditorDescription", castedNode.EditorDescription);
                castedNode.EditorDescription = n77;
            }

            if (TextureChanged is System.Action e0)
            {
                NodeStateManager.AddEventHandler(castedNode, "TextureChanged", e0);
                castedNode.TextureChanged += e0;
            }

            if (Resized is System.Action e1)
            {
                NodeStateManager.AddEventHandler(castedNode, "Resized", e1);
                castedNode.Resized += e1;
            }

            if (GuiInput is Godot.Control.GuiInputEventHandler e2)
            {
                NodeStateManager.AddEventHandler(castedNode, "GuiInput", e2);
                castedNode.GuiInput += e2;
            }

            if (MouseEntered is System.Action e3)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseEntered", e3);
                castedNode.MouseEntered += e3;
            }

            if (MouseExited is System.Action e4)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseExited", e4);
                castedNode.MouseExited += e4;
            }

            if (FocusEntered is System.Action e5)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusEntered", e5);
                castedNode.FocusEntered += e5;
            }

            if (FocusExited is System.Action e6)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusExited", e6);
                castedNode.FocusExited += e6;
            }

            if (SizeFlagsChanged is System.Action e7)
            {
                NodeStateManager.AddEventHandler(castedNode, "SizeFlagsChanged", e7);
                castedNode.SizeFlagsChanged += e7;
            }

            if (MinimumSizeChanged is System.Action e8)
            {
                NodeStateManager.AddEventHandler(castedNode, "MinimumSizeChanged", e8);
                castedNode.MinimumSizeChanged += e8;
            }

            if (ThemeChanged is System.Action e9)
            {
                NodeStateManager.AddEventHandler(castedNode, "ThemeChanged", e9);
                castedNode.ThemeChanged += e9;
            }

            if (Draw is System.Action e10)
            {
                NodeStateManager.AddEventHandler(castedNode, "Draw", e10);
                castedNode.Draw += e10;
            }

            if (VisibilityChanged is System.Action e11)
            {
                NodeStateManager.AddEventHandler(castedNode, "VisibilityChanged", e11);
                castedNode.VisibilityChanged += e11;
            }

            if (Hidden is System.Action e12)
            {
                NodeStateManager.AddEventHandler(castedNode, "Hidden", e12);
                castedNode.Hidden += e12;
            }

            if (ItemRectChanged is System.Action e13)
            {
                NodeStateManager.AddEventHandler(castedNode, "ItemRectChanged", e13);
                castedNode.ItemRectChanged += e13;
            }

            if (Ready is System.Action e14)
            {
                NodeStateManager.AddEventHandler(castedNode, "Ready", e14);
                castedNode.Ready += e14;
            }

            if (Renamed is System.Action e15)
            {
                NodeStateManager.AddEventHandler(castedNode, "Renamed", e15);
                castedNode.Renamed += e15;
            }

            if (TreeEntered is System.Action e16)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeEntered", e16);
                castedNode.TreeEntered += e16;
            }

            if (TreeExiting is System.Action e17)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExiting", e17);
                castedNode.TreeExiting += e17;
            }

            if (TreeExited is System.Action e18)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExited", e18);
                castedNode.TreeExited += e18;
            }

            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e19)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildEnteredTree", e19);
                castedNode.ChildEnteredTree += e19;
            }

            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e20)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildExitingTree", e20);
                castedNode.ChildExitingTree += e20;
            }

            if (ChildOrderChanged is System.Action e21)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildOrderChanged", e21);
                castedNode.ChildOrderChanged += e21;
            }

            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e22)
            {
                NodeStateManager.AddEventHandler(castedNode, "ReplacingBy", e22);
                castedNode.ReplacingBy += e22;
            }

            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e23)
            {
                NodeStateManager.AddEventHandler(castedNode, "EditorDescriptionChanged", e23);
                castedNode.EditorDescriptionChanged += e23;
            }

            if (ScriptChanged is System.Action e24)
            {
                NodeStateManager.AddEventHandler(castedNode, "ScriptChanged", e24);
                castedNode.ScriptChanged += e24;
            }

            if (PropertyListChanged is System.Action e25)
            {
                NodeStateManager.AddEventHandler(castedNode, "PropertyListChanged", e25);
                castedNode.PropertyListChanged += e25;
            }

            castedNode.BeginBulkThemeOverride();
            foreach (var(key, value)in ThemeConstantOverrides)
            {
                castedNode.AddThemeConstantOverride(key, value);
            }

            castedNode.EndBulkThemeOverride();
        }
    }
}