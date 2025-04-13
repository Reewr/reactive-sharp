// This file is auto-generated. Please do not edit
namespace ReactiveSharpGodot.Components
{
    public class VideoStreamPlayer : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GVideoStreamPlayer>
    {
        public System.Int32? AudioTrack { protected get; init; }
        public Godot.VideoStream? Stream { protected get; init; }
        public System.Single? VolumeDb { protected get; init; }
        public System.Single? Volume { protected get; init; }
        public System.Boolean? Autoplay { protected get; init; }
        public System.Boolean? Paused { protected get; init; }
        public System.Boolean? Expand { protected get; init; }
        public System.Boolean? Loop { protected get; init; }
        public System.Int32? BufferingMsec { protected get; init; }
        public System.Double? StreamPosition { protected get; init; }
        public Godot.StringName? Bus { protected get; init; }
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
        public System.Action? Finished { protected get; init; }
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
        public Action<ReactiveSharpGodot.Nodes.GVideoStreamPlayer>? CustomNodeHandling { protected get; init; }

        public override ReactiveSharpGodot.Nodes.GVideoStreamPlayer Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GVideoStreamPlayer();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GVideoStreamPlayer node)
        {
            var castedNode = (Godot.VideoStreamPlayer)node.Node;
            if (AudioTrack is System.Int32 n0)
            {
                NodeStateManager.AddPropertyState(castedNode, "AudioTrack", castedNode.AudioTrack);
                castedNode.AudioTrack = n0;
            }

            if (Stream is Godot.VideoStream n1)
            {
                NodeStateManager.AddPropertyState(castedNode, "Stream", castedNode.Stream);
                castedNode.Stream = n1;
            }

            if (VolumeDb is System.Single n2)
            {
                NodeStateManager.AddPropertyState(castedNode, "VolumeDb", castedNode.VolumeDb);
                castedNode.VolumeDb = n2;
            }

            if (Volume is System.Single n3)
            {
                NodeStateManager.AddPropertyState(castedNode, "Volume", castedNode.Volume);
                castedNode.Volume = n3;
            }

            if (Autoplay is System.Boolean n4)
            {
                NodeStateManager.AddPropertyState(castedNode, "Autoplay", castedNode.Autoplay);
                castedNode.Autoplay = n4;
            }

            if (Paused is System.Boolean n5)
            {
                NodeStateManager.AddPropertyState(castedNode, "Paused", castedNode.Paused);
                castedNode.Paused = n5;
            }

            if (Expand is System.Boolean n6)
            {
                NodeStateManager.AddPropertyState(castedNode, "Expand", castedNode.Expand);
                castedNode.Expand = n6;
            }

            if (Loop is System.Boolean n7)
            {
                NodeStateManager.AddPropertyState(castedNode, "Loop", castedNode.Loop);
                castedNode.Loop = n7;
            }

            if (BufferingMsec is System.Int32 n8)
            {
                NodeStateManager.AddPropertyState(castedNode, "BufferingMsec", castedNode.BufferingMsec);
                castedNode.BufferingMsec = n8;
            }

            if (StreamPosition is System.Double n9)
            {
                NodeStateManager.AddPropertyState(castedNode, "StreamPosition", castedNode.StreamPosition);
                castedNode.StreamPosition = n9;
            }

            if (Bus is Godot.StringName n10)
            {
                NodeStateManager.AddPropertyState(castedNode, "Bus", castedNode.Bus);
                castedNode.Bus = n10;
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

            if (TooltipAutoTranslateMode is Godot.Node.AutoTranslateModeEnum n39)
            {
                NodeStateManager.AddPropertyState(castedNode, "TooltipAutoTranslateMode", castedNode.TooltipAutoTranslateMode);
                castedNode.TooltipAutoTranslateMode = n39;
            }

            if (FocusNeighborLeft is Godot.NodePath n40)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborLeft", castedNode.FocusNeighborLeft);
                castedNode.FocusNeighborLeft = n40;
            }

            if (FocusNeighborTop is Godot.NodePath n41)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborTop", castedNode.FocusNeighborTop);
                castedNode.FocusNeighborTop = n41;
            }

            if (FocusNeighborRight is Godot.NodePath n42)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborRight", castedNode.FocusNeighborRight);
                castedNode.FocusNeighborRight = n42;
            }

            if (FocusNeighborBottom is Godot.NodePath n43)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborBottom", castedNode.FocusNeighborBottom);
                castedNode.FocusNeighborBottom = n43;
            }

            if (FocusNext is Godot.NodePath n44)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNext", castedNode.FocusNext);
                castedNode.FocusNext = n44;
            }

            if (FocusPrevious is Godot.NodePath n45)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusPrevious", castedNode.FocusPrevious);
                castedNode.FocusPrevious = n45;
            }

            if (FocusMode is Godot.Control.FocusModeEnum n46)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusMode", castedNode.FocusMode);
                castedNode.FocusMode = n46;
            }

            if (MouseFilter is Godot.Control.MouseFilterEnum n47)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseFilter", castedNode.MouseFilter);
                castedNode.MouseFilter = n47;
            }

            if (MouseForcePassScrollEvents is System.Boolean n48)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseForcePassScrollEvents", castedNode.MouseForcePassScrollEvents);
                castedNode.MouseForcePassScrollEvents = n48;
            }

            if (MouseDefaultCursorShape is Godot.Control.CursorShape n49)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseDefaultCursorShape", castedNode.MouseDefaultCursorShape);
                castedNode.MouseDefaultCursorShape = n49;
            }

            if (ShortcutContext is Godot.Node n50)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutContext", castedNode.ShortcutContext);
                castedNode.ShortcutContext = n50;
            }

            if (Theme is Godot.Theme n51)
            {
                NodeStateManager.AddPropertyState(castedNode, "Theme", castedNode.Theme);
                castedNode.Theme = n51;
            }

            if (ThemeTypeVariation is Godot.StringName n52)
            {
                NodeStateManager.AddPropertyState(castedNode, "ThemeTypeVariation", castedNode.ThemeTypeVariation);
                castedNode.ThemeTypeVariation = n52;
            }

            if (Visible is System.Boolean n53)
            {
                NodeStateManager.AddPropertyState(castedNode, "Visible", castedNode.Visible);
                castedNode.Visible = n53;
            }

            if (Modulate is Godot.Color n54)
            {
                NodeStateManager.AddPropertyState(castedNode, "Modulate", castedNode.Modulate);
                castedNode.Modulate = n54;
            }

            if (SelfModulate is Godot.Color n55)
            {
                NodeStateManager.AddPropertyState(castedNode, "SelfModulate", castedNode.SelfModulate);
                castedNode.SelfModulate = n55;
            }

            if (ShowBehindParent is System.Boolean n56)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowBehindParent", castedNode.ShowBehindParent);
                castedNode.ShowBehindParent = n56;
            }

            if (TopLevel is System.Boolean n57)
            {
                NodeStateManager.AddPropertyState(castedNode, "TopLevel", castedNode.TopLevel);
                castedNode.TopLevel = n57;
            }

            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n58)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipChildren", castedNode.ClipChildren);
                castedNode.ClipChildren = n58;
            }

            if (LightMask is System.Int32 n59)
            {
                NodeStateManager.AddPropertyState(castedNode, "LightMask", castedNode.LightMask);
                castedNode.LightMask = n59;
            }

            if (VisibilityLayer is System.UInt32 n60)
            {
                NodeStateManager.AddPropertyState(castedNode, "VisibilityLayer", castedNode.VisibilityLayer);
                castedNode.VisibilityLayer = n60;
            }

            if (ZIndex is System.Int32 n61)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZIndex", castedNode.ZIndex);
                castedNode.ZIndex = n61;
            }

            if (ZAsRelative is System.Boolean n62)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZAsRelative", castedNode.ZAsRelative);
                castedNode.ZAsRelative = n62;
            }

            if (YSortEnabled is System.Boolean n63)
            {
                NodeStateManager.AddPropertyState(castedNode, "YSortEnabled", castedNode.YSortEnabled);
                castedNode.YSortEnabled = n63;
            }

            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n64)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureFilter", castedNode.TextureFilter);
                castedNode.TextureFilter = n64;
            }

            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n65)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureRepeat", castedNode.TextureRepeat);
                castedNode.TextureRepeat = n65;
            }

            if (Material is Godot.Material n66)
            {
                NodeStateManager.AddPropertyState(castedNode, "Material", castedNode.Material);
                castedNode.Material = n66;
            }

            if (UseParentMaterial is System.Boolean n67)
            {
                NodeStateManager.AddPropertyState(castedNode, "UseParentMaterial", castedNode.UseParentMaterial);
                castedNode.UseParentMaterial = n67;
            }

            if (Name is Godot.StringName n68)
            {
                NodeStateManager.AddPropertyState(castedNode, "Name", castedNode.Name);
                castedNode.Name = n68;
            }

            if (UniqueNameInOwner is System.Boolean n69)
            {
                NodeStateManager.AddPropertyState(castedNode, "UniqueNameInOwner", castedNode.UniqueNameInOwner);
                castedNode.UniqueNameInOwner = n69;
            }

            if (SceneFilePath is System.String n70)
            {
                NodeStateManager.AddPropertyState(castedNode, "SceneFilePath", castedNode.SceneFilePath);
                castedNode.SceneFilePath = n70;
            }

            if (Owner is Godot.Node n71)
            {
                NodeStateManager.AddPropertyState(castedNode, "Owner", castedNode.Owner);
                castedNode.Owner = n71;
            }

            if (ProcessMode is Godot.Node.ProcessModeEnum n72)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessMode", castedNode.ProcessMode);
                castedNode.ProcessMode = n72;
            }

            if (ProcessPriority is System.Int32 n73)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPriority", castedNode.ProcessPriority);
                castedNode.ProcessPriority = n73;
            }

            if (ProcessPhysicsPriority is System.Int32 n74)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPhysicsPriority", castedNode.ProcessPhysicsPriority);
                castedNode.ProcessPhysicsPriority = n74;
            }

            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n75)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroup", castedNode.ProcessThreadGroup);
                castedNode.ProcessThreadGroup = n75;
            }

            if (ProcessThreadGroupOrder is System.Int32 n76)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroupOrder", castedNode.ProcessThreadGroupOrder);
                castedNode.ProcessThreadGroupOrder = n76;
            }

            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n77)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadMessages", castedNode.ProcessThreadMessages);
                castedNode.ProcessThreadMessages = n77;
            }

            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n78)
            {
                NodeStateManager.AddPropertyState(castedNode, "PhysicsInterpolationMode", castedNode.PhysicsInterpolationMode);
                castedNode.PhysicsInterpolationMode = n78;
            }

            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n79)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslateMode", castedNode.AutoTranslateMode);
                castedNode.AutoTranslateMode = n79;
            }

            if (EditorDescription is System.String n80)
            {
                NodeStateManager.AddPropertyState(castedNode, "EditorDescription", castedNode.EditorDescription);
                castedNode.EditorDescription = n80;
            }

            if (Finished is System.Action e0)
            {
                NodeStateManager.AddEventHandler(castedNode, "Finished", e0);
                castedNode.Finished += e0;
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

            if (EditorStateChanged is System.Action e24)
            {
                NodeStateManager.AddEventHandler(castedNode, "EditorStateChanged", e24);
                castedNode.EditorStateChanged += e24;
            }

            if (ScriptChanged is System.Action e25)
            {
                NodeStateManager.AddEventHandler(castedNode, "ScriptChanged", e25);
                castedNode.ScriptChanged += e25;
            }

            if (PropertyListChanged is System.Action e26)
            {
                NodeStateManager.AddEventHandler(castedNode, "PropertyListChanged", e26);
                castedNode.PropertyListChanged += e26;
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