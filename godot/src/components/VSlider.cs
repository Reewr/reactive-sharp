namespace ReactiveSharpGodot.Components
{
    public class VSlider : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GVSlider>
    {
        public System.Boolean? Editable { protected get; init; }
        public System.Boolean? Scrollable { protected get; init; }
        public System.Int32? TickCount { protected get; init; }
        public System.Boolean? TicksOnBorders { protected get; init; }
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
        public System.Action? DragStarted { protected get; init; }
        public Godot.Slider.DragEndedEventHandler? DragEnded { protected get; init; }
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

        public override ReactiveSharpGodot.Nodes.GVSlider Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GVSlider();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GVSlider node)
        {
            var castedNode = (Godot.VSlider)node.Node;
            if (Editable is System.Boolean n0)
            {
                NodeStateManager.AddPropertyState(castedNode, "Editable", castedNode.Editable);
                castedNode.Editable = n0;
            }

            if (Scrollable is System.Boolean n1)
            {
                NodeStateManager.AddPropertyState(castedNode, "Scrollable", castedNode.Scrollable);
                castedNode.Scrollable = n1;
            }

            if (TickCount is System.Int32 n2)
            {
                NodeStateManager.AddPropertyState(castedNode, "TickCount", castedNode.TickCount);
                castedNode.TickCount = n2;
            }

            if (TicksOnBorders is System.Boolean n3)
            {
                NodeStateManager.AddPropertyState(castedNode, "TicksOnBorders", castedNode.TicksOnBorders);
                castedNode.TicksOnBorders = n3;
            }

            if (MinValue is System.Double n4)
            {
                NodeStateManager.AddPropertyState(castedNode, "MinValue", castedNode.MinValue);
                castedNode.MinValue = n4;
            }

            if (MaxValue is System.Double n5)
            {
                NodeStateManager.AddPropertyState(castedNode, "MaxValue", castedNode.MaxValue);
                castedNode.MaxValue = n5;
            }

            if (Step is System.Double n6)
            {
                NodeStateManager.AddPropertyState(castedNode, "Step", castedNode.Step);
                castedNode.Step = n6;
            }

            if (Page is System.Double n7)
            {
                NodeStateManager.AddPropertyState(castedNode, "Page", castedNode.Page);
                castedNode.Page = n7;
            }

            if (Value is System.Double n8)
            {
                NodeStateManager.AddPropertyState(castedNode, "Value", castedNode.Value);
                castedNode.Value = n8;
            }

            if (Ratio is System.Double n9)
            {
                NodeStateManager.AddPropertyState(castedNode, "Ratio", castedNode.Ratio);
                castedNode.Ratio = n9;
            }

            if (ExpEdit is System.Boolean n10)
            {
                NodeStateManager.AddPropertyState(castedNode, "ExpEdit", castedNode.ExpEdit);
                castedNode.ExpEdit = n10;
            }

            if (Rounded is System.Boolean n11)
            {
                NodeStateManager.AddPropertyState(castedNode, "Rounded", castedNode.Rounded);
                castedNode.Rounded = n11;
            }

            if (AllowGreater is System.Boolean n12)
            {
                NodeStateManager.AddPropertyState(castedNode, "AllowGreater", castedNode.AllowGreater);
                castedNode.AllowGreater = n12;
            }

            if (AllowLesser is System.Boolean n13)
            {
                NodeStateManager.AddPropertyState(castedNode, "AllowLesser", castedNode.AllowLesser);
                castedNode.AllowLesser = n13;
            }

            if (ClipContents is System.Boolean n14)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipContents", castedNode.ClipContents);
                castedNode.ClipContents = n14;
            }

            if (CustomMinimumSize is Godot.Vector2 n15)
            {
                NodeStateManager.AddPropertyState(castedNode, "CustomMinimumSize", castedNode.CustomMinimumSize);
                castedNode.CustomMinimumSize = n15;
            }

            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n16)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutDirection", castedNode.LayoutDirection);
                castedNode.LayoutDirection = n16;
            }

            if (LayoutMode is System.Int32 n17)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutMode", castedNode.LayoutMode);
                castedNode.LayoutMode = n17;
            }

            if (AnchorsPreset is System.Int32 n18)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorsPreset", castedNode.AnchorsPreset);
                castedNode.AnchorsPreset = n18;
            }

            if (AnchorLeft is System.Single n19)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorLeft", castedNode.AnchorLeft);
                castedNode.AnchorLeft = n19;
            }

            if (AnchorTop is System.Single n20)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorTop", castedNode.AnchorTop);
                castedNode.AnchorTop = n20;
            }

            if (AnchorRight is System.Single n21)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorRight", castedNode.AnchorRight);
                castedNode.AnchorRight = n21;
            }

            if (AnchorBottom is System.Single n22)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorBottom", castedNode.AnchorBottom);
                castedNode.AnchorBottom = n22;
            }

            if (OffsetLeft is System.Single n23)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetLeft", castedNode.OffsetLeft);
                castedNode.OffsetLeft = n23;
            }

            if (OffsetTop is System.Single n24)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetTop", castedNode.OffsetTop);
                castedNode.OffsetTop = n24;
            }

            if (OffsetRight is System.Single n25)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetRight", castedNode.OffsetRight);
                castedNode.OffsetRight = n25;
            }

            if (OffsetBottom is System.Single n26)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetBottom", castedNode.OffsetBottom);
                castedNode.OffsetBottom = n26;
            }

            if (GrowHorizontal is Godot.Control.GrowDirection n27)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowHorizontal", castedNode.GrowHorizontal);
                castedNode.GrowHorizontal = n27;
            }

            if (GrowVertical is Godot.Control.GrowDirection n28)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowVertical", castedNode.GrowVertical);
                castedNode.GrowVertical = n28;
            }

            if (Size is Godot.Vector2 n29)
            {
                NodeStateManager.AddPropertyState(castedNode, "Size", castedNode.Size);
                castedNode.Size = n29;
            }

            if (Position is Godot.Vector2 n30)
            {
                NodeStateManager.AddPropertyState(castedNode, "Position", castedNode.Position);
                castedNode.Position = n30;
            }

            if (GlobalPosition is Godot.Vector2 n31)
            {
                NodeStateManager.AddPropertyState(castedNode, "GlobalPosition", castedNode.GlobalPosition);
                castedNode.GlobalPosition = n31;
            }

            if (Rotation is System.Single n32)
            {
                NodeStateManager.AddPropertyState(castedNode, "Rotation", castedNode.Rotation);
                castedNode.Rotation = n32;
            }

            if (RotationDegrees is System.Single n33)
            {
                NodeStateManager.AddPropertyState(castedNode, "RotationDegrees", castedNode.RotationDegrees);
                castedNode.RotationDegrees = n33;
            }

            if (Scale is Godot.Vector2 n34)
            {
                NodeStateManager.AddPropertyState(castedNode, "Scale", castedNode.Scale);
                castedNode.Scale = n34;
            }

            if (PivotOffset is Godot.Vector2 n35)
            {
                NodeStateManager.AddPropertyState(castedNode, "PivotOffset", castedNode.PivotOffset);
                castedNode.PivotOffset = n35;
            }

            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n36)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsHorizontal", castedNode.SizeFlagsHorizontal);
                castedNode.SizeFlagsHorizontal = n36;
            }

            if (SizeFlagsVertical is Godot.Control.SizeFlags n37)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsVertical", castedNode.SizeFlagsVertical);
                castedNode.SizeFlagsVertical = n37;
            }

            if (SizeFlagsStretchRatio is System.Single n38)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsStretchRatio", castedNode.SizeFlagsStretchRatio);
                castedNode.SizeFlagsStretchRatio = n38;
            }

            if (LocalizeNumeralSystem is System.Boolean n39)
            {
                NodeStateManager.AddPropertyState(castedNode, "LocalizeNumeralSystem", castedNode.LocalizeNumeralSystem);
                castedNode.LocalizeNumeralSystem = n39;
            }

            if (AutoTranslate is System.Boolean n40)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslate", castedNode.AutoTranslate);
                castedNode.AutoTranslate = n40;
            }

            if (TooltipText is System.String n41)
            {
                NodeStateManager.AddPropertyState(castedNode, "TooltipText", castedNode.TooltipText);
                castedNode.TooltipText = n41;
            }

            if (FocusNeighborLeft is Godot.NodePath n42)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborLeft", castedNode.FocusNeighborLeft);
                castedNode.FocusNeighborLeft = n42;
            }

            if (FocusNeighborTop is Godot.NodePath n43)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborTop", castedNode.FocusNeighborTop);
                castedNode.FocusNeighborTop = n43;
            }

            if (FocusNeighborRight is Godot.NodePath n44)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborRight", castedNode.FocusNeighborRight);
                castedNode.FocusNeighborRight = n44;
            }

            if (FocusNeighborBottom is Godot.NodePath n45)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborBottom", castedNode.FocusNeighborBottom);
                castedNode.FocusNeighborBottom = n45;
            }

            if (FocusNext is Godot.NodePath n46)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNext", castedNode.FocusNext);
                castedNode.FocusNext = n46;
            }

            if (FocusPrevious is Godot.NodePath n47)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusPrevious", castedNode.FocusPrevious);
                castedNode.FocusPrevious = n47;
            }

            if (FocusMode is Godot.Control.FocusModeEnum n48)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusMode", castedNode.FocusMode);
                castedNode.FocusMode = n48;
            }

            if (MouseFilter is Godot.Control.MouseFilterEnum n49)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseFilter", castedNode.MouseFilter);
                castedNode.MouseFilter = n49;
            }

            if (MouseForcePassScrollEvents is System.Boolean n50)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseForcePassScrollEvents", castedNode.MouseForcePassScrollEvents);
                castedNode.MouseForcePassScrollEvents = n50;
            }

            if (MouseDefaultCursorShape is Godot.Control.CursorShape n51)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseDefaultCursorShape", castedNode.MouseDefaultCursorShape);
                castedNode.MouseDefaultCursorShape = n51;
            }

            if (ShortcutContext is Godot.Node n52)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutContext", castedNode.ShortcutContext);
                castedNode.ShortcutContext = n52;
            }

            if (Theme is Godot.Theme n53)
            {
                NodeStateManager.AddPropertyState(castedNode, "Theme", castedNode.Theme);
                castedNode.Theme = n53;
            }

            if (ThemeTypeVariation is Godot.StringName n54)
            {
                NodeStateManager.AddPropertyState(castedNode, "ThemeTypeVariation", castedNode.ThemeTypeVariation);
                castedNode.ThemeTypeVariation = n54;
            }

            if (Visible is System.Boolean n55)
            {
                NodeStateManager.AddPropertyState(castedNode, "Visible", castedNode.Visible);
                castedNode.Visible = n55;
            }

            if (Modulate is Godot.Color n56)
            {
                NodeStateManager.AddPropertyState(castedNode, "Modulate", castedNode.Modulate);
                castedNode.Modulate = n56;
            }

            if (SelfModulate is Godot.Color n57)
            {
                NodeStateManager.AddPropertyState(castedNode, "SelfModulate", castedNode.SelfModulate);
                castedNode.SelfModulate = n57;
            }

            if (ShowBehindParent is System.Boolean n58)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowBehindParent", castedNode.ShowBehindParent);
                castedNode.ShowBehindParent = n58;
            }

            if (TopLevel is System.Boolean n59)
            {
                NodeStateManager.AddPropertyState(castedNode, "TopLevel", castedNode.TopLevel);
                castedNode.TopLevel = n59;
            }

            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n60)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipChildren", castedNode.ClipChildren);
                castedNode.ClipChildren = n60;
            }

            if (LightMask is System.Int32 n61)
            {
                NodeStateManager.AddPropertyState(castedNode, "LightMask", castedNode.LightMask);
                castedNode.LightMask = n61;
            }

            if (VisibilityLayer is System.UInt32 n62)
            {
                NodeStateManager.AddPropertyState(castedNode, "VisibilityLayer", castedNode.VisibilityLayer);
                castedNode.VisibilityLayer = n62;
            }

            if (ZIndex is System.Int32 n63)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZIndex", castedNode.ZIndex);
                castedNode.ZIndex = n63;
            }

            if (ZAsRelative is System.Boolean n64)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZAsRelative", castedNode.ZAsRelative);
                castedNode.ZAsRelative = n64;
            }

            if (YSortEnabled is System.Boolean n65)
            {
                NodeStateManager.AddPropertyState(castedNode, "YSortEnabled", castedNode.YSortEnabled);
                castedNode.YSortEnabled = n65;
            }

            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n66)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureFilter", castedNode.TextureFilter);
                castedNode.TextureFilter = n66;
            }

            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n67)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureRepeat", castedNode.TextureRepeat);
                castedNode.TextureRepeat = n67;
            }

            if (Material is Godot.Material n68)
            {
                NodeStateManager.AddPropertyState(castedNode, "Material", castedNode.Material);
                castedNode.Material = n68;
            }

            if (UseParentMaterial is System.Boolean n69)
            {
                NodeStateManager.AddPropertyState(castedNode, "UseParentMaterial", castedNode.UseParentMaterial);
                castedNode.UseParentMaterial = n69;
            }

            if (Name is Godot.StringName n70)
            {
                NodeStateManager.AddPropertyState(castedNode, "Name", castedNode.Name);
                castedNode.Name = n70;
            }

            if (UniqueNameInOwner is System.Boolean n71)
            {
                NodeStateManager.AddPropertyState(castedNode, "UniqueNameInOwner", castedNode.UniqueNameInOwner);
                castedNode.UniqueNameInOwner = n71;
            }

            if (SceneFilePath is System.String n72)
            {
                NodeStateManager.AddPropertyState(castedNode, "SceneFilePath", castedNode.SceneFilePath);
                castedNode.SceneFilePath = n72;
            }

            if (Owner is Godot.Node n73)
            {
                NodeStateManager.AddPropertyState(castedNode, "Owner", castedNode.Owner);
                castedNode.Owner = n73;
            }

            if (ProcessMode is Godot.Node.ProcessModeEnum n74)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessMode", castedNode.ProcessMode);
                castedNode.ProcessMode = n74;
            }

            if (ProcessPriority is System.Int32 n75)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPriority", castedNode.ProcessPriority);
                castedNode.ProcessPriority = n75;
            }

            if (ProcessPhysicsPriority is System.Int32 n76)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPhysicsPriority", castedNode.ProcessPhysicsPriority);
                castedNode.ProcessPhysicsPriority = n76;
            }

            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n77)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroup", castedNode.ProcessThreadGroup);
                castedNode.ProcessThreadGroup = n77;
            }

            if (ProcessThreadGroupOrder is System.Int32 n78)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroupOrder", castedNode.ProcessThreadGroupOrder);
                castedNode.ProcessThreadGroupOrder = n78;
            }

            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n79)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadMessages", castedNode.ProcessThreadMessages);
                castedNode.ProcessThreadMessages = n79;
            }

            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n80)
            {
                NodeStateManager.AddPropertyState(castedNode, "PhysicsInterpolationMode", castedNode.PhysicsInterpolationMode);
                castedNode.PhysicsInterpolationMode = n80;
            }

            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n81)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslateMode", castedNode.AutoTranslateMode);
                castedNode.AutoTranslateMode = n81;
            }

            if (EditorDescription is System.String n82)
            {
                NodeStateManager.AddPropertyState(castedNode, "EditorDescription", castedNode.EditorDescription);
                castedNode.EditorDescription = n82;
            }

            if (DragStarted is System.Action e0)
            {
                NodeStateManager.AddEventHandler(castedNode, "DragStarted", e0);
                castedNode.DragStarted += e0;
            }

            if (DragEnded is Godot.Slider.DragEndedEventHandler e1)
            {
                NodeStateManager.AddEventHandler(castedNode, "DragEnded", e1);
                castedNode.DragEnded += e1;
            }

            if (ValueChanged is Godot.Range.ValueChangedEventHandler e2)
            {
                NodeStateManager.AddEventHandler(castedNode, "ValueChanged", e2);
                castedNode.ValueChanged += e2;
            }

            if (Changed is System.Action e3)
            {
                NodeStateManager.AddEventHandler(castedNode, "Changed", e3);
                castedNode.Changed += e3;
            }

            if (Resized is System.Action e4)
            {
                NodeStateManager.AddEventHandler(castedNode, "Resized", e4);
                castedNode.Resized += e4;
            }

            if (GuiInput is Godot.Control.GuiInputEventHandler e5)
            {
                NodeStateManager.AddEventHandler(castedNode, "GuiInput", e5);
                castedNode.GuiInput += e5;
            }

            if (MouseEntered is System.Action e6)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseEntered", e6);
                castedNode.MouseEntered += e6;
            }

            if (MouseExited is System.Action e7)
            {
                NodeStateManager.AddEventHandler(castedNode, "MouseExited", e7);
                castedNode.MouseExited += e7;
            }

            if (FocusEntered is System.Action e8)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusEntered", e8);
                castedNode.FocusEntered += e8;
            }

            if (FocusExited is System.Action e9)
            {
                NodeStateManager.AddEventHandler(castedNode, "FocusExited", e9);
                castedNode.FocusExited += e9;
            }

            if (SizeFlagsChanged is System.Action e10)
            {
                NodeStateManager.AddEventHandler(castedNode, "SizeFlagsChanged", e10);
                castedNode.SizeFlagsChanged += e10;
            }

            if (MinimumSizeChanged is System.Action e11)
            {
                NodeStateManager.AddEventHandler(castedNode, "MinimumSizeChanged", e11);
                castedNode.MinimumSizeChanged += e11;
            }

            if (ThemeChanged is System.Action e12)
            {
                NodeStateManager.AddEventHandler(castedNode, "ThemeChanged", e12);
                castedNode.ThemeChanged += e12;
            }

            if (Draw is System.Action e13)
            {
                NodeStateManager.AddEventHandler(castedNode, "Draw", e13);
                castedNode.Draw += e13;
            }

            if (VisibilityChanged is System.Action e14)
            {
                NodeStateManager.AddEventHandler(castedNode, "VisibilityChanged", e14);
                castedNode.VisibilityChanged += e14;
            }

            if (Hidden is System.Action e15)
            {
                NodeStateManager.AddEventHandler(castedNode, "Hidden", e15);
                castedNode.Hidden += e15;
            }

            if (ItemRectChanged is System.Action e16)
            {
                NodeStateManager.AddEventHandler(castedNode, "ItemRectChanged", e16);
                castedNode.ItemRectChanged += e16;
            }

            if (Ready is System.Action e17)
            {
                NodeStateManager.AddEventHandler(castedNode, "Ready", e17);
                castedNode.Ready += e17;
            }

            if (Renamed is System.Action e18)
            {
                NodeStateManager.AddEventHandler(castedNode, "Renamed", e18);
                castedNode.Renamed += e18;
            }

            if (TreeEntered is System.Action e19)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeEntered", e19);
                castedNode.TreeEntered += e19;
            }

            if (TreeExiting is System.Action e20)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExiting", e20);
                castedNode.TreeExiting += e20;
            }

            if (TreeExited is System.Action e21)
            {
                NodeStateManager.AddEventHandler(castedNode, "TreeExited", e21);
                castedNode.TreeExited += e21;
            }

            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e22)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildEnteredTree", e22);
                castedNode.ChildEnteredTree += e22;
            }

            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e23)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildExitingTree", e23);
                castedNode.ChildExitingTree += e23;
            }

            if (ChildOrderChanged is System.Action e24)
            {
                NodeStateManager.AddEventHandler(castedNode, "ChildOrderChanged", e24);
                castedNode.ChildOrderChanged += e24;
            }

            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e25)
            {
                NodeStateManager.AddEventHandler(castedNode, "ReplacingBy", e25);
                castedNode.ReplacingBy += e25;
            }

            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e26)
            {
                NodeStateManager.AddEventHandler(castedNode, "EditorDescriptionChanged", e26);
                castedNode.EditorDescriptionChanged += e26;
            }

            if (ScriptChanged is System.Action e27)
            {
                NodeStateManager.AddEventHandler(castedNode, "ScriptChanged", e27);
                castedNode.ScriptChanged += e27;
            }

            if (PropertyListChanged is System.Action e28)
            {
                NodeStateManager.AddEventHandler(castedNode, "PropertyListChanged", e28);
                castedNode.PropertyListChanged += e28;
            }
        }
    }
}