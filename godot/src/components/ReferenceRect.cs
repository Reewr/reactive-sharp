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
        public Dictionary<string, int> ThemeConstantOverrides { protected get; init; } = [];

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
            {
                NodeStateManager.AddPropertyState(castedNode, "BorderColor", castedNode.BorderColor);
                castedNode.BorderColor = n0;
            }

            if (BorderWidth is System.Single n1)
            {
                NodeStateManager.AddPropertyState(castedNode, "BorderWidth", castedNode.BorderWidth);
                castedNode.BorderWidth = n1;
            }

            if (EditorOnly is System.Boolean n2)
            {
                NodeStateManager.AddPropertyState(castedNode, "EditorOnly", castedNode.EditorOnly);
                castedNode.EditorOnly = n2;
            }

            if (ClipContents is System.Boolean n3)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipContents", castedNode.ClipContents);
                castedNode.ClipContents = n3;
            }

            if (CustomMinimumSize is Godot.Vector2 n4)
            {
                NodeStateManager.AddPropertyState(castedNode, "CustomMinimumSize", castedNode.CustomMinimumSize);
                castedNode.CustomMinimumSize = n4;
            }

            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n5)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutDirection", castedNode.LayoutDirection);
                castedNode.LayoutDirection = n5;
            }

            if (LayoutMode is System.Int32 n6)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutMode", castedNode.LayoutMode);
                castedNode.LayoutMode = n6;
            }

            if (AnchorsPreset is System.Int32 n7)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorsPreset", castedNode.AnchorsPreset);
                castedNode.AnchorsPreset = n7;
            }

            if (AnchorLeft is System.Single n8)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorLeft", castedNode.AnchorLeft);
                castedNode.AnchorLeft = n8;
            }

            if (AnchorTop is System.Single n9)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorTop", castedNode.AnchorTop);
                castedNode.AnchorTop = n9;
            }

            if (AnchorRight is System.Single n10)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorRight", castedNode.AnchorRight);
                castedNode.AnchorRight = n10;
            }

            if (AnchorBottom is System.Single n11)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorBottom", castedNode.AnchorBottom);
                castedNode.AnchorBottom = n11;
            }

            if (OffsetLeft is System.Single n12)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetLeft", castedNode.OffsetLeft);
                castedNode.OffsetLeft = n12;
            }

            if (OffsetTop is System.Single n13)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetTop", castedNode.OffsetTop);
                castedNode.OffsetTop = n13;
            }

            if (OffsetRight is System.Single n14)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetRight", castedNode.OffsetRight);
                castedNode.OffsetRight = n14;
            }

            if (OffsetBottom is System.Single n15)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetBottom", castedNode.OffsetBottom);
                castedNode.OffsetBottom = n15;
            }

            if (GrowHorizontal is Godot.Control.GrowDirection n16)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowHorizontal", castedNode.GrowHorizontal);
                castedNode.GrowHorizontal = n16;
            }

            if (GrowVertical is Godot.Control.GrowDirection n17)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowVertical", castedNode.GrowVertical);
                castedNode.GrowVertical = n17;
            }

            if (Size is Godot.Vector2 n18)
            {
                NodeStateManager.AddPropertyState(castedNode, "Size", castedNode.Size);
                castedNode.Size = n18;
            }

            if (Position is Godot.Vector2 n19)
            {
                NodeStateManager.AddPropertyState(castedNode, "Position", castedNode.Position);
                castedNode.Position = n19;
            }

            if (GlobalPosition is Godot.Vector2 n20)
            {
                NodeStateManager.AddPropertyState(castedNode, "GlobalPosition", castedNode.GlobalPosition);
                castedNode.GlobalPosition = n20;
            }

            if (Rotation is System.Single n21)
            {
                NodeStateManager.AddPropertyState(castedNode, "Rotation", castedNode.Rotation);
                castedNode.Rotation = n21;
            }

            if (RotationDegrees is System.Single n22)
            {
                NodeStateManager.AddPropertyState(castedNode, "RotationDegrees", castedNode.RotationDegrees);
                castedNode.RotationDegrees = n22;
            }

            if (Scale is Godot.Vector2 n23)
            {
                NodeStateManager.AddPropertyState(castedNode, "Scale", castedNode.Scale);
                castedNode.Scale = n23;
            }

            if (PivotOffset is Godot.Vector2 n24)
            {
                NodeStateManager.AddPropertyState(castedNode, "PivotOffset", castedNode.PivotOffset);
                castedNode.PivotOffset = n24;
            }

            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n25)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsHorizontal", castedNode.SizeFlagsHorizontal);
                castedNode.SizeFlagsHorizontal = n25;
            }

            if (SizeFlagsVertical is Godot.Control.SizeFlags n26)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsVertical", castedNode.SizeFlagsVertical);
                castedNode.SizeFlagsVertical = n26;
            }

            if (SizeFlagsStretchRatio is System.Single n27)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsStretchRatio", castedNode.SizeFlagsStretchRatio);
                castedNode.SizeFlagsStretchRatio = n27;
            }

            if (LocalizeNumeralSystem is System.Boolean n28)
            {
                NodeStateManager.AddPropertyState(castedNode, "LocalizeNumeralSystem", castedNode.LocalizeNumeralSystem);
                castedNode.LocalizeNumeralSystem = n28;
            }

            if (AutoTranslate is System.Boolean n29)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslate", castedNode.AutoTranslate);
                castedNode.AutoTranslate = n29;
            }

            if (TooltipText is System.String n30)
            {
                NodeStateManager.AddPropertyState(castedNode, "TooltipText", castedNode.TooltipText);
                castedNode.TooltipText = n30;
            }

            if (FocusNeighborLeft is Godot.NodePath n31)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborLeft", castedNode.FocusNeighborLeft);
                castedNode.FocusNeighborLeft = n31;
            }

            if (FocusNeighborTop is Godot.NodePath n32)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborTop", castedNode.FocusNeighborTop);
                castedNode.FocusNeighborTop = n32;
            }

            if (FocusNeighborRight is Godot.NodePath n33)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborRight", castedNode.FocusNeighborRight);
                castedNode.FocusNeighborRight = n33;
            }

            if (FocusNeighborBottom is Godot.NodePath n34)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborBottom", castedNode.FocusNeighborBottom);
                castedNode.FocusNeighborBottom = n34;
            }

            if (FocusNext is Godot.NodePath n35)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNext", castedNode.FocusNext);
                castedNode.FocusNext = n35;
            }

            if (FocusPrevious is Godot.NodePath n36)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusPrevious", castedNode.FocusPrevious);
                castedNode.FocusPrevious = n36;
            }

            if (FocusMode is Godot.Control.FocusModeEnum n37)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusMode", castedNode.FocusMode);
                castedNode.FocusMode = n37;
            }

            if (MouseFilter is Godot.Control.MouseFilterEnum n38)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseFilter", castedNode.MouseFilter);
                castedNode.MouseFilter = n38;
            }

            if (MouseForcePassScrollEvents is System.Boolean n39)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseForcePassScrollEvents", castedNode.MouseForcePassScrollEvents);
                castedNode.MouseForcePassScrollEvents = n39;
            }

            if (MouseDefaultCursorShape is Godot.Control.CursorShape n40)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseDefaultCursorShape", castedNode.MouseDefaultCursorShape);
                castedNode.MouseDefaultCursorShape = n40;
            }

            if (ShortcutContext is Godot.Node n41)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutContext", castedNode.ShortcutContext);
                castedNode.ShortcutContext = n41;
            }

            if (Theme is Godot.Theme n42)
            {
                NodeStateManager.AddPropertyState(castedNode, "Theme", castedNode.Theme);
                castedNode.Theme = n42;
            }

            if (ThemeTypeVariation is Godot.StringName n43)
            {
                NodeStateManager.AddPropertyState(castedNode, "ThemeTypeVariation", castedNode.ThemeTypeVariation);
                castedNode.ThemeTypeVariation = n43;
            }

            if (Visible is System.Boolean n44)
            {
                NodeStateManager.AddPropertyState(castedNode, "Visible", castedNode.Visible);
                castedNode.Visible = n44;
            }

            if (Modulate is Godot.Color n45)
            {
                NodeStateManager.AddPropertyState(castedNode, "Modulate", castedNode.Modulate);
                castedNode.Modulate = n45;
            }

            if (SelfModulate is Godot.Color n46)
            {
                NodeStateManager.AddPropertyState(castedNode, "SelfModulate", castedNode.SelfModulate);
                castedNode.SelfModulate = n46;
            }

            if (ShowBehindParent is System.Boolean n47)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowBehindParent", castedNode.ShowBehindParent);
                castedNode.ShowBehindParent = n47;
            }

            if (TopLevel is System.Boolean n48)
            {
                NodeStateManager.AddPropertyState(castedNode, "TopLevel", castedNode.TopLevel);
                castedNode.TopLevel = n48;
            }

            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n49)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipChildren", castedNode.ClipChildren);
                castedNode.ClipChildren = n49;
            }

            if (LightMask is System.Int32 n50)
            {
                NodeStateManager.AddPropertyState(castedNode, "LightMask", castedNode.LightMask);
                castedNode.LightMask = n50;
            }

            if (VisibilityLayer is System.UInt32 n51)
            {
                NodeStateManager.AddPropertyState(castedNode, "VisibilityLayer", castedNode.VisibilityLayer);
                castedNode.VisibilityLayer = n51;
            }

            if (ZIndex is System.Int32 n52)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZIndex", castedNode.ZIndex);
                castedNode.ZIndex = n52;
            }

            if (ZAsRelative is System.Boolean n53)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZAsRelative", castedNode.ZAsRelative);
                castedNode.ZAsRelative = n53;
            }

            if (YSortEnabled is System.Boolean n54)
            {
                NodeStateManager.AddPropertyState(castedNode, "YSortEnabled", castedNode.YSortEnabled);
                castedNode.YSortEnabled = n54;
            }

            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n55)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureFilter", castedNode.TextureFilter);
                castedNode.TextureFilter = n55;
            }

            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n56)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureRepeat", castedNode.TextureRepeat);
                castedNode.TextureRepeat = n56;
            }

            if (Material is Godot.Material n57)
            {
                NodeStateManager.AddPropertyState(castedNode, "Material", castedNode.Material);
                castedNode.Material = n57;
            }

            if (UseParentMaterial is System.Boolean n58)
            {
                NodeStateManager.AddPropertyState(castedNode, "UseParentMaterial", castedNode.UseParentMaterial);
                castedNode.UseParentMaterial = n58;
            }

            if (Name is Godot.StringName n59)
            {
                NodeStateManager.AddPropertyState(castedNode, "Name", castedNode.Name);
                castedNode.Name = n59;
            }

            if (UniqueNameInOwner is System.Boolean n60)
            {
                NodeStateManager.AddPropertyState(castedNode, "UniqueNameInOwner", castedNode.UniqueNameInOwner);
                castedNode.UniqueNameInOwner = n60;
            }

            if (SceneFilePath is System.String n61)
            {
                NodeStateManager.AddPropertyState(castedNode, "SceneFilePath", castedNode.SceneFilePath);
                castedNode.SceneFilePath = n61;
            }

            if (Owner is Godot.Node n62)
            {
                NodeStateManager.AddPropertyState(castedNode, "Owner", castedNode.Owner);
                castedNode.Owner = n62;
            }

            if (ProcessMode is Godot.Node.ProcessModeEnum n63)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessMode", castedNode.ProcessMode);
                castedNode.ProcessMode = n63;
            }

            if (ProcessPriority is System.Int32 n64)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPriority", castedNode.ProcessPriority);
                castedNode.ProcessPriority = n64;
            }

            if (ProcessPhysicsPriority is System.Int32 n65)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPhysicsPriority", castedNode.ProcessPhysicsPriority);
                castedNode.ProcessPhysicsPriority = n65;
            }

            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n66)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroup", castedNode.ProcessThreadGroup);
                castedNode.ProcessThreadGroup = n66;
            }

            if (ProcessThreadGroupOrder is System.Int32 n67)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroupOrder", castedNode.ProcessThreadGroupOrder);
                castedNode.ProcessThreadGroupOrder = n67;
            }

            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n68)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadMessages", castedNode.ProcessThreadMessages);
                castedNode.ProcessThreadMessages = n68;
            }

            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n69)
            {
                NodeStateManager.AddPropertyState(castedNode, "PhysicsInterpolationMode", castedNode.PhysicsInterpolationMode);
                castedNode.PhysicsInterpolationMode = n69;
            }

            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n70)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslateMode", castedNode.AutoTranslateMode);
                castedNode.AutoTranslateMode = n70;
            }

            if (EditorDescription is System.String n71)
            {
                NodeStateManager.AddPropertyState(castedNode, "EditorDescription", castedNode.EditorDescription);
                castedNode.EditorDescription = n71;
            }

            if (Resized is System.Action e0)
            {
                NodeStateManager.AddEventHandler(castedNode, "Resized", e0);
                castedNode.Resized += e0;
            }

            if (GuiInput is Godot.Control.GuiInputEventHandler e1)
            {
                NodeStateManager.AddEventHandler(castedNode, "GuiInput", e1);
                castedNode.GuiInput += e1;
            }

            if (MouseEntered is System.Action e2)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseEntered", e2);
                castedNode.MouseEntered += e2;
            }

            if (MouseExited is System.Action e3)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseExited", e3);
                castedNode.MouseExited += e3;
            }

            if (FocusEntered is System.Action e4)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusEntered", e4);
                castedNode.FocusEntered += e4;
            }

            if (FocusExited is System.Action e5)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusExited", e5);
                castedNode.FocusExited += e5;
            }

            if (SizeFlagsChanged is System.Action e6)
            {
                NodeStateManager.AddEventHandler(castedNode, "SizeFlagsChanged", e6);
                castedNode.SizeFlagsChanged += e6;
            }

            if (MinimumSizeChanged is System.Action e7)
            {
                NodeStateManager.AddEventHandler(castedNode, "MinimumSizeChanged", e7);
                castedNode.MinimumSizeChanged += e7;
            }

            if (ThemeChanged is System.Action e8)
            {
                NodeStateManager.AddEventHandler(castedNode, "ThemeChanged", e8);
                castedNode.ThemeChanged += e8;
            }

            if (Draw is System.Action e9)
            {
                NodeStateManager.AddEventHandler(castedNode, "Draw", e9);
                castedNode.Draw += e9;
            }

            if (VisibilityChanged is System.Action e10)
            {
                NodeStateManager.AddEventHandler(castedNode, "VisibilityChanged", e10);
                castedNode.VisibilityChanged += e10;
            }

            if (Hidden is System.Action e11)
            {
                NodeStateManager.AddEventHandler(castedNode, "Hidden", e11);
                castedNode.Hidden += e11;
            }

            if (ItemRectChanged is System.Action e12)
            {
                NodeStateManager.AddEventHandler(castedNode, "ItemRectChanged", e12);
                castedNode.ItemRectChanged += e12;
            }

            if (Ready is System.Action e13)
            {
                NodeStateManager.AddEventHandler(castedNode, "Ready", e13);
                castedNode.Ready += e13;
            }

            if (Renamed is System.Action e14)
            {
                NodeStateManager.AddEventHandler(castedNode, "Renamed", e14);
                castedNode.Renamed += e14;
            }

            if (TreeEntered is System.Action e15)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeEntered", e15);
                castedNode.TreeEntered += e15;
            }

            if (TreeExiting is System.Action e16)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExiting", e16);
                castedNode.TreeExiting += e16;
            }

            if (TreeExited is System.Action e17)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExited", e17);
                castedNode.TreeExited += e17;
            }

            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e18)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildEnteredTree", e18);
                castedNode.ChildEnteredTree += e18;
            }

            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e19)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildExitingTree", e19);
                castedNode.ChildExitingTree += e19;
            }

            if (ChildOrderChanged is System.Action e20)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildOrderChanged", e20);
                castedNode.ChildOrderChanged += e20;
            }

            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e21)
            {
                NodeStateManager.AddEventHandler(castedNode, "ReplacingBy", e21);
                castedNode.ReplacingBy += e21;
            }

            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e22)
            {
                NodeStateManager.AddEventHandler(castedNode, "EditorDescriptionChanged", e22);
                castedNode.EditorDescriptionChanged += e22;
            }

            if (ScriptChanged is System.Action e23)
            {
                NodeStateManager.AddEventHandler(castedNode, "ScriptChanged", e23);
                castedNode.ScriptChanged += e23;
            }

            if (PropertyListChanged is System.Action e24)
            {
                NodeStateManager.AddEventHandler(castedNode, "PropertyListChanged", e24);
                castedNode.PropertyListChanged += e24;
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