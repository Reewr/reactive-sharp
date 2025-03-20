namespace ReactiveSharpGodot.Components
{
    public class HScrollBar : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GHScrollBar>
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
        public Dictionary<string, int> ThemeConstantOverrides { protected get; init; } = [];

        public override ReactiveSharpGodot.Nodes.GHScrollBar Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GHScrollBar();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GHScrollBar node)
        {
            var castedNode = (Godot.HScrollBar)node.Node;
            if (CustomStep is System.Single n0)
            {
                NodeStateManager.AddPropertyState(castedNode, "CustomStep", castedNode.CustomStep);
                castedNode.CustomStep = n0;
            }

            if (MinValue is System.Double n1)
            {
                NodeStateManager.AddPropertyState(castedNode, "MinValue", castedNode.MinValue);
                castedNode.MinValue = n1;
            }

            if (MaxValue is System.Double n2)
            {
                NodeStateManager.AddPropertyState(castedNode, "MaxValue", castedNode.MaxValue);
                castedNode.MaxValue = n2;
            }

            if (Step is System.Double n3)
            {
                NodeStateManager.AddPropertyState(castedNode, "Step", castedNode.Step);
                castedNode.Step = n3;
            }

            if (Page is System.Double n4)
            {
                NodeStateManager.AddPropertyState(castedNode, "Page", castedNode.Page);
                castedNode.Page = n4;
            }

            if (Value is System.Double n5)
            {
                NodeStateManager.AddPropertyState(castedNode, "Value", castedNode.Value);
                castedNode.Value = n5;
            }

            if (Ratio is System.Double n6)
            {
                NodeStateManager.AddPropertyState(castedNode, "Ratio", castedNode.Ratio);
                castedNode.Ratio = n6;
            }

            if (ExpEdit is System.Boolean n7)
            {
                NodeStateManager.AddPropertyState(castedNode, "ExpEdit", castedNode.ExpEdit);
                castedNode.ExpEdit = n7;
            }

            if (Rounded is System.Boolean n8)
            {
                NodeStateManager.AddPropertyState(castedNode, "Rounded", castedNode.Rounded);
                castedNode.Rounded = n8;
            }

            if (AllowGreater is System.Boolean n9)
            {
                NodeStateManager.AddPropertyState(castedNode, "AllowGreater", castedNode.AllowGreater);
                castedNode.AllowGreater = n9;
            }

            if (AllowLesser is System.Boolean n10)
            {
                NodeStateManager.AddPropertyState(castedNode, "AllowLesser", castedNode.AllowLesser);
                castedNode.AllowLesser = n10;
            }

            if (ClipContents is System.Boolean n11)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipContents", castedNode.ClipContents);
                castedNode.ClipContents = n11;
            }

            if (CustomMinimumSize is Godot.Vector2 n12)
            {
                NodeStateManager.AddPropertyState(castedNode, "CustomMinimumSize", castedNode.CustomMinimumSize);
                castedNode.CustomMinimumSize = n12;
            }

            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n13)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutDirection", castedNode.LayoutDirection);
                castedNode.LayoutDirection = n13;
            }

            if (LayoutMode is System.Int32 n14)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutMode", castedNode.LayoutMode);
                castedNode.LayoutMode = n14;
            }

            if (AnchorsPreset is System.Int32 n15)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorsPreset", castedNode.AnchorsPreset);
                castedNode.AnchorsPreset = n15;
            }

            if (AnchorLeft is System.Single n16)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorLeft", castedNode.AnchorLeft);
                castedNode.AnchorLeft = n16;
            }

            if (AnchorTop is System.Single n17)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorTop", castedNode.AnchorTop);
                castedNode.AnchorTop = n17;
            }

            if (AnchorRight is System.Single n18)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorRight", castedNode.AnchorRight);
                castedNode.AnchorRight = n18;
            }

            if (AnchorBottom is System.Single n19)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorBottom", castedNode.AnchorBottom);
                castedNode.AnchorBottom = n19;
            }

            if (OffsetLeft is System.Single n20)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetLeft", castedNode.OffsetLeft);
                castedNode.OffsetLeft = n20;
            }

            if (OffsetTop is System.Single n21)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetTop", castedNode.OffsetTop);
                castedNode.OffsetTop = n21;
            }

            if (OffsetRight is System.Single n22)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetRight", castedNode.OffsetRight);
                castedNode.OffsetRight = n22;
            }

            if (OffsetBottom is System.Single n23)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetBottom", castedNode.OffsetBottom);
                castedNode.OffsetBottom = n23;
            }

            if (GrowHorizontal is Godot.Control.GrowDirection n24)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowHorizontal", castedNode.GrowHorizontal);
                castedNode.GrowHorizontal = n24;
            }

            if (GrowVertical is Godot.Control.GrowDirection n25)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowVertical", castedNode.GrowVertical);
                castedNode.GrowVertical = n25;
            }

            if (Size is Godot.Vector2 n26)
            {
                NodeStateManager.AddPropertyState(castedNode, "Size", castedNode.Size);
                castedNode.Size = n26;
            }

            if (Position is Godot.Vector2 n27)
            {
                NodeStateManager.AddPropertyState(castedNode, "Position", castedNode.Position);
                castedNode.Position = n27;
            }

            if (GlobalPosition is Godot.Vector2 n28)
            {
                NodeStateManager.AddPropertyState(castedNode, "GlobalPosition", castedNode.GlobalPosition);
                castedNode.GlobalPosition = n28;
            }

            if (Rotation is System.Single n29)
            {
                NodeStateManager.AddPropertyState(castedNode, "Rotation", castedNode.Rotation);
                castedNode.Rotation = n29;
            }

            if (RotationDegrees is System.Single n30)
            {
                NodeStateManager.AddPropertyState(castedNode, "RotationDegrees", castedNode.RotationDegrees);
                castedNode.RotationDegrees = n30;
            }

            if (Scale is Godot.Vector2 n31)
            {
                NodeStateManager.AddPropertyState(castedNode, "Scale", castedNode.Scale);
                castedNode.Scale = n31;
            }

            if (PivotOffset is Godot.Vector2 n32)
            {
                NodeStateManager.AddPropertyState(castedNode, "PivotOffset", castedNode.PivotOffset);
                castedNode.PivotOffset = n32;
            }

            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n33)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsHorizontal", castedNode.SizeFlagsHorizontal);
                castedNode.SizeFlagsHorizontal = n33;
            }

            if (SizeFlagsVertical is Godot.Control.SizeFlags n34)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsVertical", castedNode.SizeFlagsVertical);
                castedNode.SizeFlagsVertical = n34;
            }

            if (SizeFlagsStretchRatio is System.Single n35)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsStretchRatio", castedNode.SizeFlagsStretchRatio);
                castedNode.SizeFlagsStretchRatio = n35;
            }

            if (LocalizeNumeralSystem is System.Boolean n36)
            {
                NodeStateManager.AddPropertyState(castedNode, "LocalizeNumeralSystem", castedNode.LocalizeNumeralSystem);
                castedNode.LocalizeNumeralSystem = n36;
            }

            if (AutoTranslate is System.Boolean n37)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslate", castedNode.AutoTranslate);
                castedNode.AutoTranslate = n37;
            }

            if (TooltipText is System.String n38)
            {
                NodeStateManager.AddPropertyState(castedNode, "TooltipText", castedNode.TooltipText);
                castedNode.TooltipText = n38;
            }

            if (FocusNeighborLeft is Godot.NodePath n39)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborLeft", castedNode.FocusNeighborLeft);
                castedNode.FocusNeighborLeft = n39;
            }

            if (FocusNeighborTop is Godot.NodePath n40)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborTop", castedNode.FocusNeighborTop);
                castedNode.FocusNeighborTop = n40;
            }

            if (FocusNeighborRight is Godot.NodePath n41)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborRight", castedNode.FocusNeighborRight);
                castedNode.FocusNeighborRight = n41;
            }

            if (FocusNeighborBottom is Godot.NodePath n42)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborBottom", castedNode.FocusNeighborBottom);
                castedNode.FocusNeighborBottom = n42;
            }

            if (FocusNext is Godot.NodePath n43)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNext", castedNode.FocusNext);
                castedNode.FocusNext = n43;
            }

            if (FocusPrevious is Godot.NodePath n44)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusPrevious", castedNode.FocusPrevious);
                castedNode.FocusPrevious = n44;
            }

            if (FocusMode is Godot.Control.FocusModeEnum n45)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusMode", castedNode.FocusMode);
                castedNode.FocusMode = n45;
            }

            if (MouseFilter is Godot.Control.MouseFilterEnum n46)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseFilter", castedNode.MouseFilter);
                castedNode.MouseFilter = n46;
            }

            if (MouseForcePassScrollEvents is System.Boolean n47)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseForcePassScrollEvents", castedNode.MouseForcePassScrollEvents);
                castedNode.MouseForcePassScrollEvents = n47;
            }

            if (MouseDefaultCursorShape is Godot.Control.CursorShape n48)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseDefaultCursorShape", castedNode.MouseDefaultCursorShape);
                castedNode.MouseDefaultCursorShape = n48;
            }

            if (ShortcutContext is Godot.Node n49)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutContext", castedNode.ShortcutContext);
                castedNode.ShortcutContext = n49;
            }

            if (Theme is Godot.Theme n50)
            {
                NodeStateManager.AddPropertyState(castedNode, "Theme", castedNode.Theme);
                castedNode.Theme = n50;
            }

            if (ThemeTypeVariation is Godot.StringName n51)
            {
                NodeStateManager.AddPropertyState(castedNode, "ThemeTypeVariation", castedNode.ThemeTypeVariation);
                castedNode.ThemeTypeVariation = n51;
            }

            if (Visible is System.Boolean n52)
            {
                NodeStateManager.AddPropertyState(castedNode, "Visible", castedNode.Visible);
                castedNode.Visible = n52;
            }

            if (Modulate is Godot.Color n53)
            {
                NodeStateManager.AddPropertyState(castedNode, "Modulate", castedNode.Modulate);
                castedNode.Modulate = n53;
            }

            if (SelfModulate is Godot.Color n54)
            {
                NodeStateManager.AddPropertyState(castedNode, "SelfModulate", castedNode.SelfModulate);
                castedNode.SelfModulate = n54;
            }

            if (ShowBehindParent is System.Boolean n55)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowBehindParent", castedNode.ShowBehindParent);
                castedNode.ShowBehindParent = n55;
            }

            if (TopLevel is System.Boolean n56)
            {
                NodeStateManager.AddPropertyState(castedNode, "TopLevel", castedNode.TopLevel);
                castedNode.TopLevel = n56;
            }

            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n57)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipChildren", castedNode.ClipChildren);
                castedNode.ClipChildren = n57;
            }

            if (LightMask is System.Int32 n58)
            {
                NodeStateManager.AddPropertyState(castedNode, "LightMask", castedNode.LightMask);
                castedNode.LightMask = n58;
            }

            if (VisibilityLayer is System.UInt32 n59)
            {
                NodeStateManager.AddPropertyState(castedNode, "VisibilityLayer", castedNode.VisibilityLayer);
                castedNode.VisibilityLayer = n59;
            }

            if (ZIndex is System.Int32 n60)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZIndex", castedNode.ZIndex);
                castedNode.ZIndex = n60;
            }

            if (ZAsRelative is System.Boolean n61)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZAsRelative", castedNode.ZAsRelative);
                castedNode.ZAsRelative = n61;
            }

            if (YSortEnabled is System.Boolean n62)
            {
                NodeStateManager.AddPropertyState(castedNode, "YSortEnabled", castedNode.YSortEnabled);
                castedNode.YSortEnabled = n62;
            }

            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n63)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureFilter", castedNode.TextureFilter);
                castedNode.TextureFilter = n63;
            }

            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n64)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureRepeat", castedNode.TextureRepeat);
                castedNode.TextureRepeat = n64;
            }

            if (Material is Godot.Material n65)
            {
                NodeStateManager.AddPropertyState(castedNode, "Material", castedNode.Material);
                castedNode.Material = n65;
            }

            if (UseParentMaterial is System.Boolean n66)
            {
                NodeStateManager.AddPropertyState(castedNode, "UseParentMaterial", castedNode.UseParentMaterial);
                castedNode.UseParentMaterial = n66;
            }

            if (Name is Godot.StringName n67)
            {
                NodeStateManager.AddPropertyState(castedNode, "Name", castedNode.Name);
                castedNode.Name = n67;
            }

            if (UniqueNameInOwner is System.Boolean n68)
            {
                NodeStateManager.AddPropertyState(castedNode, "UniqueNameInOwner", castedNode.UniqueNameInOwner);
                castedNode.UniqueNameInOwner = n68;
            }

            if (SceneFilePath is System.String n69)
            {
                NodeStateManager.AddPropertyState(castedNode, "SceneFilePath", castedNode.SceneFilePath);
                castedNode.SceneFilePath = n69;
            }

            if (Owner is Godot.Node n70)
            {
                NodeStateManager.AddPropertyState(castedNode, "Owner", castedNode.Owner);
                castedNode.Owner = n70;
            }

            if (ProcessMode is Godot.Node.ProcessModeEnum n71)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessMode", castedNode.ProcessMode);
                castedNode.ProcessMode = n71;
            }

            if (ProcessPriority is System.Int32 n72)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPriority", castedNode.ProcessPriority);
                castedNode.ProcessPriority = n72;
            }

            if (ProcessPhysicsPriority is System.Int32 n73)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPhysicsPriority", castedNode.ProcessPhysicsPriority);
                castedNode.ProcessPhysicsPriority = n73;
            }

            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n74)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroup", castedNode.ProcessThreadGroup);
                castedNode.ProcessThreadGroup = n74;
            }

            if (ProcessThreadGroupOrder is System.Int32 n75)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroupOrder", castedNode.ProcessThreadGroupOrder);
                castedNode.ProcessThreadGroupOrder = n75;
            }

            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n76)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadMessages", castedNode.ProcessThreadMessages);
                castedNode.ProcessThreadMessages = n76;
            }

            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n77)
            {
                NodeStateManager.AddPropertyState(castedNode, "PhysicsInterpolationMode", castedNode.PhysicsInterpolationMode);
                castedNode.PhysicsInterpolationMode = n77;
            }

            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n78)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslateMode", castedNode.AutoTranslateMode);
                castedNode.AutoTranslateMode = n78;
            }

            if (EditorDescription is System.String n79)
            {
                NodeStateManager.AddPropertyState(castedNode, "EditorDescription", castedNode.EditorDescription);
                castedNode.EditorDescription = n79;
            }

            if (Scrolling is System.Action e0)
            {
                NodeStateManager.AddEventHandler(castedNode, "Scrolling", e0);
                castedNode.Scrolling += e0;
            }

            if (ValueChanged is Godot.Range.ValueChangedEventHandler e1)
            {
                NodeStateManager.AddEventHandler(castedNode, "ValueChanged", e1);
                castedNode.ValueChanged += e1;
            }

            if (Changed is System.Action e2)
            {
                NodeStateManager.AddEventHandler(castedNode, "Changed", e2);
                castedNode.Changed += e2;
            }

            if (Resized is System.Action e3)
            {
                NodeStateManager.AddEventHandler(castedNode, "Resized", e3);
                castedNode.Resized += e3;
            }

            if (GuiInput is Godot.Control.GuiInputEventHandler e4)
            {
                NodeStateManager.AddEventHandler(castedNode, "GuiInput", e4);
                castedNode.GuiInput += e4;
            }

            if (MouseEntered is System.Action e5)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseEntered", e5);
                castedNode.MouseEntered += e5;
            }

            if (MouseExited is System.Action e6)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseExited", e6);
                castedNode.MouseExited += e6;
            }

            if (FocusEntered is System.Action e7)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusEntered", e7);
                castedNode.FocusEntered += e7;
            }

            if (FocusExited is System.Action e8)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusExited", e8);
                castedNode.FocusExited += e8;
            }

            if (SizeFlagsChanged is System.Action e9)
            {
                NodeStateManager.AddEventHandler(castedNode, "SizeFlagsChanged", e9);
                castedNode.SizeFlagsChanged += e9;
            }

            if (MinimumSizeChanged is System.Action e10)
            {
                NodeStateManager.AddEventHandler(castedNode, "MinimumSizeChanged", e10);
                castedNode.MinimumSizeChanged += e10;
            }

            if (ThemeChanged is System.Action e11)
            {
                NodeStateManager.AddEventHandler(castedNode, "ThemeChanged", e11);
                castedNode.ThemeChanged += e11;
            }

            if (Draw is System.Action e12)
            {
                NodeStateManager.AddEventHandler(castedNode, "Draw", e12);
                castedNode.Draw += e12;
            }

            if (VisibilityChanged is System.Action e13)
            {
                NodeStateManager.AddEventHandler(castedNode, "VisibilityChanged", e13);
                castedNode.VisibilityChanged += e13;
            }

            if (Hidden is System.Action e14)
            {
                NodeStateManager.AddEventHandler(castedNode, "Hidden", e14);
                castedNode.Hidden += e14;
            }

            if (ItemRectChanged is System.Action e15)
            {
                NodeStateManager.AddEventHandler(castedNode, "ItemRectChanged", e15);
                castedNode.ItemRectChanged += e15;
            }

            if (Ready is System.Action e16)
            {
                NodeStateManager.AddEventHandler(castedNode, "Ready", e16);
                castedNode.Ready += e16;
            }

            if (Renamed is System.Action e17)
            {
                NodeStateManager.AddEventHandler(castedNode, "Renamed", e17);
                castedNode.Renamed += e17;
            }

            if (TreeEntered is System.Action e18)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeEntered", e18);
                castedNode.TreeEntered += e18;
            }

            if (TreeExiting is System.Action e19)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExiting", e19);
                castedNode.TreeExiting += e19;
            }

            if (TreeExited is System.Action e20)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExited", e20);
                castedNode.TreeExited += e20;
            }

            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e21)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildEnteredTree", e21);
                castedNode.ChildEnteredTree += e21;
            }

            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e22)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildExitingTree", e22);
                castedNode.ChildExitingTree += e22;
            }

            if (ChildOrderChanged is System.Action e23)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildOrderChanged", e23);
                castedNode.ChildOrderChanged += e23;
            }

            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e24)
            {
                NodeStateManager.AddEventHandler(castedNode, "ReplacingBy", e24);
                castedNode.ReplacingBy += e24;
            }

            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e25)
            {
                NodeStateManager.AddEventHandler(castedNode, "EditorDescriptionChanged", e25);
                castedNode.EditorDescriptionChanged += e25;
            }

            if (ScriptChanged is System.Action e26)
            {
                NodeStateManager.AddEventHandler(castedNode, "ScriptChanged", e26);
                castedNode.ScriptChanged += e26;
            }

            if (PropertyListChanged is System.Action e27)
            {
                NodeStateManager.AddEventHandler(castedNode, "PropertyListChanged", e27);
                castedNode.PropertyListChanged += e27;
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