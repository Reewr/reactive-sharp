// This file is auto-generated. Please do not edit
namespace ReactiveSharpGodot.Components
{
    public class VSeparator : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GVSeparator>
    {
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
        public Godot.Node.AutoTranslateModeEnum? TooltipAutoTranslateMode { protected get; init; }
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
        public System.Action? EditorStateChanged { protected get; init; }
        public System.Action? ScriptChanged { protected get; init; }
        public System.Action? PropertyListChanged { protected get; init; }
        public Dictionary<string, int> ThemeConstantOverrides { protected get; init; } = [];
        public Dictionary<string, Godot.Color> ThemeColorOverrides { protected get; init; } = [];
        /// <summary>
        /// This property allows you to define an action that will be called right after the node
        /// it represents is updated within Godot. As godot has many functions that can be useful
        /// making bindings for all of them, even generated ones, is a huge task.
        ///
        /// This function allows you to use all the functionality of the godot node.
        ///
        /// <b>NOTE</b>: State changes done through this function are NOT reset on re-render.
        /// Therefore, you need to keep track of the state yourself and set it on every render
        /// <example>
        /// In the below example, the component uses a button. The button has a SetPressedNoSignal function
        /// that can be used to set the toggle state on the button without triggering an event
        /// Since this is a function and not a property, it is not exposed through the Button component itself
        /// and therefore we need to use the CustomNodeHandling to set this property.
        /// <code>
        /// class MyComponent : Component {
        /// 	Component Render() {
        /// 		var isToggled = UseState(false);
        /// 		return new Button()
        /// 		{
        /// 			ToggleMode = true,
        ///			CustomNodeHandling = (Button button) =>
        /// 			{
        /// 				button.SetPressedNoSignal(isToggled.Value);
        /// 			}
        /// 		};
        /// 	}
        /// }
        /// </code>
        /// </example>
        /// </summary>
        public Action<ReactiveSharpGodot.Nodes.GVSeparator>? CustomNodeHandling { protected get; init; }

        public override ReactiveSharpGodot.Nodes.GVSeparator Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GVSeparator();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GVSeparator node)
        {
            var castedNode = (Godot.VSeparator)node.Node;
            if (ClipContents is System.Boolean n0)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipContents", castedNode.ClipContents);
                castedNode.ClipContents = n0;
            }

            if (CustomMinimumSize is Godot.Vector2 n1)
            {
                NodeStateManager.AddPropertyState(castedNode, "CustomMinimumSize", castedNode.CustomMinimumSize);
                castedNode.CustomMinimumSize = n1;
            }

            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n2)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutDirection", castedNode.LayoutDirection);
                castedNode.LayoutDirection = n2;
            }

            if (LayoutMode is System.Int32 n3)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutMode", castedNode.LayoutMode);
                castedNode.LayoutMode = n3;
            }

            if (AnchorsPreset is System.Int32 n4)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorsPreset", castedNode.AnchorsPreset);
                castedNode.AnchorsPreset = n4;
            }

            if (AnchorLeft is System.Single n5)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorLeft", castedNode.AnchorLeft);
                castedNode.AnchorLeft = n5;
            }

            if (AnchorTop is System.Single n6)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorTop", castedNode.AnchorTop);
                castedNode.AnchorTop = n6;
            }

            if (AnchorRight is System.Single n7)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorRight", castedNode.AnchorRight);
                castedNode.AnchorRight = n7;
            }

            if (AnchorBottom is System.Single n8)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorBottom", castedNode.AnchorBottom);
                castedNode.AnchorBottom = n8;
            }

            if (OffsetLeft is System.Single n9)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetLeft", castedNode.OffsetLeft);
                castedNode.OffsetLeft = n9;
            }

            if (OffsetTop is System.Single n10)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetTop", castedNode.OffsetTop);
                castedNode.OffsetTop = n10;
            }

            if (OffsetRight is System.Single n11)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetRight", castedNode.OffsetRight);
                castedNode.OffsetRight = n11;
            }

            if (OffsetBottom is System.Single n12)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetBottom", castedNode.OffsetBottom);
                castedNode.OffsetBottom = n12;
            }

            if (GrowHorizontal is Godot.Control.GrowDirection n13)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowHorizontal", castedNode.GrowHorizontal);
                castedNode.GrowHorizontal = n13;
            }

            if (GrowVertical is Godot.Control.GrowDirection n14)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowVertical", castedNode.GrowVertical);
                castedNode.GrowVertical = n14;
            }

            if (Size is Godot.Vector2 n15)
            {
                NodeStateManager.AddPropertyState(castedNode, "Size", castedNode.Size);
                castedNode.Size = n15;
            }

            if (Position is Godot.Vector2 n16)
            {
                NodeStateManager.AddPropertyState(castedNode, "Position", castedNode.Position);
                castedNode.Position = n16;
            }

            if (GlobalPosition is Godot.Vector2 n17)
            {
                NodeStateManager.AddPropertyState(castedNode, "GlobalPosition", castedNode.GlobalPosition);
                castedNode.GlobalPosition = n17;
            }

            if (Rotation is System.Single n18)
            {
                NodeStateManager.AddPropertyState(castedNode, "Rotation", castedNode.Rotation);
                castedNode.Rotation = n18;
            }

            if (RotationDegrees is System.Single n19)
            {
                NodeStateManager.AddPropertyState(castedNode, "RotationDegrees", castedNode.RotationDegrees);
                castedNode.RotationDegrees = n19;
            }

            if (Scale is Godot.Vector2 n20)
            {
                NodeStateManager.AddPropertyState(castedNode, "Scale", castedNode.Scale);
                castedNode.Scale = n20;
            }

            if (PivotOffset is Godot.Vector2 n21)
            {
                NodeStateManager.AddPropertyState(castedNode, "PivotOffset", castedNode.PivotOffset);
                castedNode.PivotOffset = n21;
            }

            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n22)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsHorizontal", castedNode.SizeFlagsHorizontal);
                castedNode.SizeFlagsHorizontal = n22;
            }

            if (SizeFlagsVertical is Godot.Control.SizeFlags n23)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsVertical", castedNode.SizeFlagsVertical);
                castedNode.SizeFlagsVertical = n23;
            }

            if (SizeFlagsStretchRatio is System.Single n24)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsStretchRatio", castedNode.SizeFlagsStretchRatio);
                castedNode.SizeFlagsStretchRatio = n24;
            }

            if (LocalizeNumeralSystem is System.Boolean n25)
            {
                NodeStateManager.AddPropertyState(castedNode, "LocalizeNumeralSystem", castedNode.LocalizeNumeralSystem);
                castedNode.LocalizeNumeralSystem = n25;
            }

            if (AutoTranslate is System.Boolean n26)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslate", castedNode.AutoTranslate);
                castedNode.AutoTranslate = n26;
            }

            if (TooltipText is System.String n27)
            {
                NodeStateManager.AddPropertyState(castedNode, "TooltipText", castedNode.TooltipText);
                castedNode.TooltipText = n27;
            }

            if (TooltipAutoTranslateMode is Godot.Node.AutoTranslateModeEnum n28)
            {
                NodeStateManager.AddPropertyState(castedNode, "TooltipAutoTranslateMode", castedNode.TooltipAutoTranslateMode);
                castedNode.TooltipAutoTranslateMode = n28;
            }

            if (FocusNeighborLeft is Godot.NodePath n29)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborLeft", castedNode.FocusNeighborLeft);
                castedNode.FocusNeighborLeft = n29;
            }

            if (FocusNeighborTop is Godot.NodePath n30)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborTop", castedNode.FocusNeighborTop);
                castedNode.FocusNeighborTop = n30;
            }

            if (FocusNeighborRight is Godot.NodePath n31)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborRight", castedNode.FocusNeighborRight);
                castedNode.FocusNeighborRight = n31;
            }

            if (FocusNeighborBottom is Godot.NodePath n32)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborBottom", castedNode.FocusNeighborBottom);
                castedNode.FocusNeighborBottom = n32;
            }

            if (FocusNext is Godot.NodePath n33)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNext", castedNode.FocusNext);
                castedNode.FocusNext = n33;
            }

            if (FocusPrevious is Godot.NodePath n34)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusPrevious", castedNode.FocusPrevious);
                castedNode.FocusPrevious = n34;
            }

            if (FocusMode is Godot.Control.FocusModeEnum n35)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusMode", castedNode.FocusMode);
                castedNode.FocusMode = n35;
            }

            if (MouseFilter is Godot.Control.MouseFilterEnum n36)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseFilter", castedNode.MouseFilter);
                castedNode.MouseFilter = n36;
            }

            if (MouseForcePassScrollEvents is System.Boolean n37)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseForcePassScrollEvents", castedNode.MouseForcePassScrollEvents);
                castedNode.MouseForcePassScrollEvents = n37;
            }

            if (MouseDefaultCursorShape is Godot.Control.CursorShape n38)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseDefaultCursorShape", castedNode.MouseDefaultCursorShape);
                castedNode.MouseDefaultCursorShape = n38;
            }

            if (ShortcutContext is Godot.Node n39)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutContext", castedNode.ShortcutContext);
                castedNode.ShortcutContext = n39;
            }

            if (Theme is Godot.Theme n40)
            {
                NodeStateManager.AddPropertyState(castedNode, "Theme", castedNode.Theme);
                castedNode.Theme = n40;
            }

            if (ThemeTypeVariation is Godot.StringName n41)
            {
                NodeStateManager.AddPropertyState(castedNode, "ThemeTypeVariation", castedNode.ThemeTypeVariation);
                castedNode.ThemeTypeVariation = n41;
            }

            if (Visible is System.Boolean n42)
            {
                NodeStateManager.AddPropertyState(castedNode, "Visible", castedNode.Visible);
                castedNode.Visible = n42;
            }

            if (Modulate is Godot.Color n43)
            {
                NodeStateManager.AddPropertyState(castedNode, "Modulate", castedNode.Modulate);
                castedNode.Modulate = n43;
            }

            if (SelfModulate is Godot.Color n44)
            {
                NodeStateManager.AddPropertyState(castedNode, "SelfModulate", castedNode.SelfModulate);
                castedNode.SelfModulate = n44;
            }

            if (ShowBehindParent is System.Boolean n45)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowBehindParent", castedNode.ShowBehindParent);
                castedNode.ShowBehindParent = n45;
            }

            if (TopLevel is System.Boolean n46)
            {
                NodeStateManager.AddPropertyState(castedNode, "TopLevel", castedNode.TopLevel);
                castedNode.TopLevel = n46;
            }

            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n47)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipChildren", castedNode.ClipChildren);
                castedNode.ClipChildren = n47;
            }

            if (LightMask is System.Int32 n48)
            {
                NodeStateManager.AddPropertyState(castedNode, "LightMask", castedNode.LightMask);
                castedNode.LightMask = n48;
            }

            if (VisibilityLayer is System.UInt32 n49)
            {
                NodeStateManager.AddPropertyState(castedNode, "VisibilityLayer", castedNode.VisibilityLayer);
                castedNode.VisibilityLayer = n49;
            }

            if (ZIndex is System.Int32 n50)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZIndex", castedNode.ZIndex);
                castedNode.ZIndex = n50;
            }

            if (ZAsRelative is System.Boolean n51)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZAsRelative", castedNode.ZAsRelative);
                castedNode.ZAsRelative = n51;
            }

            if (YSortEnabled is System.Boolean n52)
            {
                NodeStateManager.AddPropertyState(castedNode, "YSortEnabled", castedNode.YSortEnabled);
                castedNode.YSortEnabled = n52;
            }

            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n53)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureFilter", castedNode.TextureFilter);
                castedNode.TextureFilter = n53;
            }

            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n54)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureRepeat", castedNode.TextureRepeat);
                castedNode.TextureRepeat = n54;
            }

            if (Material is Godot.Material n55)
            {
                NodeStateManager.AddPropertyState(castedNode, "Material", castedNode.Material);
                castedNode.Material = n55;
            }

            if (UseParentMaterial is System.Boolean n56)
            {
                NodeStateManager.AddPropertyState(castedNode, "UseParentMaterial", castedNode.UseParentMaterial);
                castedNode.UseParentMaterial = n56;
            }

            if (Name is Godot.StringName n57)
            {
                NodeStateManager.AddPropertyState(castedNode, "Name", castedNode.Name);
                castedNode.Name = n57;
            }

            if (UniqueNameInOwner is System.Boolean n58)
            {
                NodeStateManager.AddPropertyState(castedNode, "UniqueNameInOwner", castedNode.UniqueNameInOwner);
                castedNode.UniqueNameInOwner = n58;
            }

            if (SceneFilePath is System.String n59)
            {
                NodeStateManager.AddPropertyState(castedNode, "SceneFilePath", castedNode.SceneFilePath);
                castedNode.SceneFilePath = n59;
            }

            if (Owner is Godot.Node n60)
            {
                NodeStateManager.AddPropertyState(castedNode, "Owner", castedNode.Owner);
                castedNode.Owner = n60;
            }

            if (ProcessMode is Godot.Node.ProcessModeEnum n61)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessMode", castedNode.ProcessMode);
                castedNode.ProcessMode = n61;
            }

            if (ProcessPriority is System.Int32 n62)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPriority", castedNode.ProcessPriority);
                castedNode.ProcessPriority = n62;
            }

            if (ProcessPhysicsPriority is System.Int32 n63)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPhysicsPriority", castedNode.ProcessPhysicsPriority);
                castedNode.ProcessPhysicsPriority = n63;
            }

            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n64)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroup", castedNode.ProcessThreadGroup);
                castedNode.ProcessThreadGroup = n64;
            }

            if (ProcessThreadGroupOrder is System.Int32 n65)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroupOrder", castedNode.ProcessThreadGroupOrder);
                castedNode.ProcessThreadGroupOrder = n65;
            }

            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n66)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadMessages", castedNode.ProcessThreadMessages);
                castedNode.ProcessThreadMessages = n66;
            }

            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n67)
            {
                NodeStateManager.AddPropertyState(castedNode, "PhysicsInterpolationMode", castedNode.PhysicsInterpolationMode);
                castedNode.PhysicsInterpolationMode = n67;
            }

            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n68)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslateMode", castedNode.AutoTranslateMode);
                castedNode.AutoTranslateMode = n68;
            }

            if (EditorDescription is System.String n69)
            {
                NodeStateManager.AddPropertyState(castedNode, "EditorDescription", castedNode.EditorDescription);
                castedNode.EditorDescription = n69;
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

            if (EditorStateChanged is System.Action e23)
            {
                NodeStateManager.AddEventHandler(castedNode, "EditorStateChanged", e23);
                castedNode.EditorStateChanged += e23;
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

            foreach (var(key, value)in ThemeColorOverrides)
            {
                castedNode.AddThemeColorOverride(key, value);
            }

            castedNode.EndBulkThemeOverride();
            CustomNodeHandling?.Invoke(node);
        }
    }
}