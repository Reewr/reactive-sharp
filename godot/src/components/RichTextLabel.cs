// This file is auto-generated. Please do not edit
namespace ReactiveSharpGodot.Components
{
    public class RichTextLabel : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GRichTextLabel>
    {
        public System.Boolean? BbcodeEnabled { protected get; init; }
        public System.String? Text { protected get; init; }
        public System.Boolean? FitContent { protected get; init; }
        public System.Boolean? ScrollActive { protected get; init; }
        public System.Boolean? ScrollFollowing { protected get; init; }
        public Godot.TextServer.AutowrapMode? AutowrapMode { protected get; init; }
        public System.Int32? TabSize { protected get; init; }
        public System.Boolean? ContextMenuEnabled { protected get; init; }
        public System.Boolean? ShortcutKeysEnabled { protected get; init; }
        public Godot.HorizontalAlignment? HorizontalAlignment { protected get; init; }
        public Godot.VerticalAlignment? VerticalAlignment { protected get; init; }
        public Godot.TextServer.JustificationFlag? JustificationFlags { protected get; init; }
        public System.Single[]? TabStops { protected get; init; }
        public Godot.Collections.Array? CustomEffects { protected get; init; }
        public System.Boolean? MetaUnderlined { protected get; init; }
        public System.Boolean? HintUnderlined { protected get; init; }
        public System.Boolean? Threaded { protected get; init; }
        public System.Int32? ProgressBarDelay { protected get; init; }
        public System.Boolean? SelectionEnabled { protected get; init; }
        public System.Boolean? DeselectOnFocusLossEnabled { protected get; init; }
        public System.Boolean? DragAndDropSelectionEnabled { protected get; init; }
        public System.Int32? VisibleCharacters { protected get; init; }
        public Godot.TextServer.VisibleCharactersBehavior? VisibleCharactersBehavior { protected get; init; }
        public System.Single? VisibleRatio { protected get; init; }
        public Godot.Control.TextDirection? TextDirection { protected get; init; }
        public System.String? Language { protected get; init; }
        public Godot.TextServer.StructuredTextParser? StructuredTextBidiOverride { protected get; init; }
        public Godot.Collections.Array? StructuredTextBidiOverrideOptions { protected get; init; }
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
        public Godot.RichTextLabel.MetaClickedEventHandler? MetaClicked { protected get; init; }
        public Godot.RichTextLabel.MetaHoverStartedEventHandler? MetaHoverStarted { protected get; init; }
        public Godot.RichTextLabel.MetaHoverEndedEventHandler? MetaHoverEnded { protected get; init; }
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
        public Action<ReactiveSharpGodot.Nodes.GRichTextLabel>? CustomNodeHandling { protected get; init; }

        public override ReactiveSharpGodot.Nodes.GRichTextLabel Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GRichTextLabel();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GRichTextLabel node)
        {
            var castedNode = (Godot.RichTextLabel)node.Node;
            if (BbcodeEnabled is System.Boolean n0)
            {
                NodeStateManager.AddPropertyState(castedNode, "BbcodeEnabled", castedNode.BbcodeEnabled);
                castedNode.BbcodeEnabled = n0;
            }

            if (Text is System.String n1)
            {
                NodeStateManager.AddPropertyState(castedNode, "Text", castedNode.Text);
                castedNode.Text = n1;
            }

            if (FitContent is System.Boolean n2)
            {
                NodeStateManager.AddPropertyState(castedNode, "FitContent", castedNode.FitContent);
                castedNode.FitContent = n2;
            }

            if (ScrollActive is System.Boolean n3)
            {
                NodeStateManager.AddPropertyState(castedNode, "ScrollActive", castedNode.ScrollActive);
                castedNode.ScrollActive = n3;
            }

            if (ScrollFollowing is System.Boolean n4)
            {
                NodeStateManager.AddPropertyState(castedNode, "ScrollFollowing", castedNode.ScrollFollowing);
                castedNode.ScrollFollowing = n4;
            }

            if (AutowrapMode is Godot.TextServer.AutowrapMode n5)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutowrapMode", castedNode.AutowrapMode);
                castedNode.AutowrapMode = n5;
            }

            if (TabSize is System.Int32 n6)
            {
                NodeStateManager.AddPropertyState(castedNode, "TabSize", castedNode.TabSize);
                castedNode.TabSize = n6;
            }

            if (ContextMenuEnabled is System.Boolean n7)
            {
                NodeStateManager.AddPropertyState(castedNode, "ContextMenuEnabled", castedNode.ContextMenuEnabled);
                castedNode.ContextMenuEnabled = n7;
            }

            if (ShortcutKeysEnabled is System.Boolean n8)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutKeysEnabled", castedNode.ShortcutKeysEnabled);
                castedNode.ShortcutKeysEnabled = n8;
            }

            if (HorizontalAlignment is Godot.HorizontalAlignment n9)
            {
                NodeStateManager.AddPropertyState(castedNode, "HorizontalAlignment", castedNode.HorizontalAlignment);
                castedNode.HorizontalAlignment = n9;
            }

            if (VerticalAlignment is Godot.VerticalAlignment n10)
            {
                NodeStateManager.AddPropertyState(castedNode, "VerticalAlignment", castedNode.VerticalAlignment);
                castedNode.VerticalAlignment = n10;
            }

            if (JustificationFlags is Godot.TextServer.JustificationFlag n11)
            {
                NodeStateManager.AddPropertyState(castedNode, "JustificationFlags", castedNode.JustificationFlags);
                castedNode.JustificationFlags = n11;
            }

            if (TabStops is System.Single[] n12)
            {
                NodeStateManager.AddPropertyState(castedNode, "TabStops", castedNode.TabStops);
                castedNode.TabStops = n12;
            }

            if (CustomEffects is Godot.Collections.Array n13)
            {
                NodeStateManager.AddPropertyState(castedNode, "CustomEffects", castedNode.CustomEffects);
                castedNode.CustomEffects = n13;
            }

            if (MetaUnderlined is System.Boolean n14)
            {
                NodeStateManager.AddPropertyState(castedNode, "MetaUnderlined", castedNode.MetaUnderlined);
                castedNode.MetaUnderlined = n14;
            }

            if (HintUnderlined is System.Boolean n15)
            {
                NodeStateManager.AddPropertyState(castedNode, "HintUnderlined", castedNode.HintUnderlined);
                castedNode.HintUnderlined = n15;
            }

            if (Threaded is System.Boolean n16)
            {
                NodeStateManager.AddPropertyState(castedNode, "Threaded", castedNode.Threaded);
                castedNode.Threaded = n16;
            }

            if (ProgressBarDelay is System.Int32 n17)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProgressBarDelay", castedNode.ProgressBarDelay);
                castedNode.ProgressBarDelay = n17;
            }

            if (SelectionEnabled is System.Boolean n18)
            {
                NodeStateManager.AddPropertyState(castedNode, "SelectionEnabled", castedNode.SelectionEnabled);
                castedNode.SelectionEnabled = n18;
            }

            if (DeselectOnFocusLossEnabled is System.Boolean n19)
            {
                NodeStateManager.AddPropertyState(castedNode, "DeselectOnFocusLossEnabled", castedNode.DeselectOnFocusLossEnabled);
                castedNode.DeselectOnFocusLossEnabled = n19;
            }

            if (DragAndDropSelectionEnabled is System.Boolean n20)
            {
                NodeStateManager.AddPropertyState(castedNode, "DragAndDropSelectionEnabled", castedNode.DragAndDropSelectionEnabled);
                castedNode.DragAndDropSelectionEnabled = n20;
            }

            if (VisibleCharacters is System.Int32 n21)
            {
                NodeStateManager.AddPropertyState(castedNode, "VisibleCharacters", castedNode.VisibleCharacters);
                castedNode.VisibleCharacters = n21;
            }

            if (VisibleCharactersBehavior is Godot.TextServer.VisibleCharactersBehavior n22)
            {
                NodeStateManager.AddPropertyState(castedNode, "VisibleCharactersBehavior", castedNode.VisibleCharactersBehavior);
                castedNode.VisibleCharactersBehavior = n22;
            }

            if (VisibleRatio is System.Single n23)
            {
                NodeStateManager.AddPropertyState(castedNode, "VisibleRatio", castedNode.VisibleRatio);
                castedNode.VisibleRatio = n23;
            }

            if (TextDirection is Godot.Control.TextDirection n24)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextDirection", castedNode.TextDirection);
                castedNode.TextDirection = n24;
            }

            if (Language is System.String n25)
            {
                NodeStateManager.AddPropertyState(castedNode, "Language", castedNode.Language);
                castedNode.Language = n25;
            }

            if (StructuredTextBidiOverride is Godot.TextServer.StructuredTextParser n26)
            {
                NodeStateManager.AddPropertyState(castedNode, "StructuredTextBidiOverride", castedNode.StructuredTextBidiOverride);
                castedNode.StructuredTextBidiOverride = n26;
            }

            if (StructuredTextBidiOverrideOptions is Godot.Collections.Array n27)
            {
                NodeStateManager.AddPropertyState(castedNode, "StructuredTextBidiOverrideOptions", castedNode.StructuredTextBidiOverrideOptions);
                castedNode.StructuredTextBidiOverrideOptions = n27;
            }

            if (ClipContents is System.Boolean n28)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipContents", castedNode.ClipContents);
                castedNode.ClipContents = n28;
            }

            if (CustomMinimumSize is Godot.Vector2 n29)
            {
                NodeStateManager.AddPropertyState(castedNode, "CustomMinimumSize", castedNode.CustomMinimumSize);
                castedNode.CustomMinimumSize = n29;
            }

            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n30)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutDirection", castedNode.LayoutDirection);
                castedNode.LayoutDirection = n30;
            }

            if (LayoutMode is System.Int32 n31)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutMode", castedNode.LayoutMode);
                castedNode.LayoutMode = n31;
            }

            if (AnchorsPreset is System.Int32 n32)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorsPreset", castedNode.AnchorsPreset);
                castedNode.AnchorsPreset = n32;
            }

            if (AnchorLeft is System.Single n33)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorLeft", castedNode.AnchorLeft);
                castedNode.AnchorLeft = n33;
            }

            if (AnchorTop is System.Single n34)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorTop", castedNode.AnchorTop);
                castedNode.AnchorTop = n34;
            }

            if (AnchorRight is System.Single n35)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorRight", castedNode.AnchorRight);
                castedNode.AnchorRight = n35;
            }

            if (AnchorBottom is System.Single n36)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorBottom", castedNode.AnchorBottom);
                castedNode.AnchorBottom = n36;
            }

            if (OffsetLeft is System.Single n37)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetLeft", castedNode.OffsetLeft);
                castedNode.OffsetLeft = n37;
            }

            if (OffsetTop is System.Single n38)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetTop", castedNode.OffsetTop);
                castedNode.OffsetTop = n38;
            }

            if (OffsetRight is System.Single n39)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetRight", castedNode.OffsetRight);
                castedNode.OffsetRight = n39;
            }

            if (OffsetBottom is System.Single n40)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetBottom", castedNode.OffsetBottom);
                castedNode.OffsetBottom = n40;
            }

            if (GrowHorizontal is Godot.Control.GrowDirection n41)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowHorizontal", castedNode.GrowHorizontal);
                castedNode.GrowHorizontal = n41;
            }

            if (GrowVertical is Godot.Control.GrowDirection n42)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowVertical", castedNode.GrowVertical);
                castedNode.GrowVertical = n42;
            }

            if (Size is Godot.Vector2 n43)
            {
                NodeStateManager.AddPropertyState(castedNode, "Size", castedNode.Size);
                castedNode.Size = n43;
            }

            if (Position is Godot.Vector2 n44)
            {
                NodeStateManager.AddPropertyState(castedNode, "Position", castedNode.Position);
                castedNode.Position = n44;
            }

            if (GlobalPosition is Godot.Vector2 n45)
            {
                NodeStateManager.AddPropertyState(castedNode, "GlobalPosition", castedNode.GlobalPosition);
                castedNode.GlobalPosition = n45;
            }

            if (Rotation is System.Single n46)
            {
                NodeStateManager.AddPropertyState(castedNode, "Rotation", castedNode.Rotation);
                castedNode.Rotation = n46;
            }

            if (RotationDegrees is System.Single n47)
            {
                NodeStateManager.AddPropertyState(castedNode, "RotationDegrees", castedNode.RotationDegrees);
                castedNode.RotationDegrees = n47;
            }

            if (Scale is Godot.Vector2 n48)
            {
                NodeStateManager.AddPropertyState(castedNode, "Scale", castedNode.Scale);
                castedNode.Scale = n48;
            }

            if (PivotOffset is Godot.Vector2 n49)
            {
                NodeStateManager.AddPropertyState(castedNode, "PivotOffset", castedNode.PivotOffset);
                castedNode.PivotOffset = n49;
            }

            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n50)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsHorizontal", castedNode.SizeFlagsHorizontal);
                castedNode.SizeFlagsHorizontal = n50;
            }

            if (SizeFlagsVertical is Godot.Control.SizeFlags n51)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsVertical", castedNode.SizeFlagsVertical);
                castedNode.SizeFlagsVertical = n51;
            }

            if (SizeFlagsStretchRatio is System.Single n52)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsStretchRatio", castedNode.SizeFlagsStretchRatio);
                castedNode.SizeFlagsStretchRatio = n52;
            }

            if (LocalizeNumeralSystem is System.Boolean n53)
            {
                NodeStateManager.AddPropertyState(castedNode, "LocalizeNumeralSystem", castedNode.LocalizeNumeralSystem);
                castedNode.LocalizeNumeralSystem = n53;
            }

            if (AutoTranslate is System.Boolean n54)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslate", castedNode.AutoTranslate);
                castedNode.AutoTranslate = n54;
            }

            if (TooltipText is System.String n55)
            {
                NodeStateManager.AddPropertyState(castedNode, "TooltipText", castedNode.TooltipText);
                castedNode.TooltipText = n55;
            }

            if (TooltipAutoTranslateMode is Godot.Node.AutoTranslateModeEnum n56)
            {
                NodeStateManager.AddPropertyState(castedNode, "TooltipAutoTranslateMode", castedNode.TooltipAutoTranslateMode);
                castedNode.TooltipAutoTranslateMode = n56;
            }

            if (FocusNeighborLeft is Godot.NodePath n57)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborLeft", castedNode.FocusNeighborLeft);
                castedNode.FocusNeighborLeft = n57;
            }

            if (FocusNeighborTop is Godot.NodePath n58)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborTop", castedNode.FocusNeighborTop);
                castedNode.FocusNeighborTop = n58;
            }

            if (FocusNeighborRight is Godot.NodePath n59)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborRight", castedNode.FocusNeighborRight);
                castedNode.FocusNeighborRight = n59;
            }

            if (FocusNeighborBottom is Godot.NodePath n60)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborBottom", castedNode.FocusNeighborBottom);
                castedNode.FocusNeighborBottom = n60;
            }

            if (FocusNext is Godot.NodePath n61)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNext", castedNode.FocusNext);
                castedNode.FocusNext = n61;
            }

            if (FocusPrevious is Godot.NodePath n62)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusPrevious", castedNode.FocusPrevious);
                castedNode.FocusPrevious = n62;
            }

            if (FocusMode is Godot.Control.FocusModeEnum n63)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusMode", castedNode.FocusMode);
                castedNode.FocusMode = n63;
            }

            if (MouseFilter is Godot.Control.MouseFilterEnum n64)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseFilter", castedNode.MouseFilter);
                castedNode.MouseFilter = n64;
            }

            if (MouseForcePassScrollEvents is System.Boolean n65)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseForcePassScrollEvents", castedNode.MouseForcePassScrollEvents);
                castedNode.MouseForcePassScrollEvents = n65;
            }

            if (MouseDefaultCursorShape is Godot.Control.CursorShape n66)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseDefaultCursorShape", castedNode.MouseDefaultCursorShape);
                castedNode.MouseDefaultCursorShape = n66;
            }

            if (ShortcutContext is Godot.Node n67)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutContext", castedNode.ShortcutContext);
                castedNode.ShortcutContext = n67;
            }

            if (Theme is Godot.Theme n68)
            {
                NodeStateManager.AddPropertyState(castedNode, "Theme", castedNode.Theme);
                castedNode.Theme = n68;
            }

            if (ThemeTypeVariation is Godot.StringName n69)
            {
                NodeStateManager.AddPropertyState(castedNode, "ThemeTypeVariation", castedNode.ThemeTypeVariation);
                castedNode.ThemeTypeVariation = n69;
            }

            if (Visible is System.Boolean n70)
            {
                NodeStateManager.AddPropertyState(castedNode, "Visible", castedNode.Visible);
                castedNode.Visible = n70;
            }

            if (Modulate is Godot.Color n71)
            {
                NodeStateManager.AddPropertyState(castedNode, "Modulate", castedNode.Modulate);
                castedNode.Modulate = n71;
            }

            if (SelfModulate is Godot.Color n72)
            {
                NodeStateManager.AddPropertyState(castedNode, "SelfModulate", castedNode.SelfModulate);
                castedNode.SelfModulate = n72;
            }

            if (ShowBehindParent is System.Boolean n73)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowBehindParent", castedNode.ShowBehindParent);
                castedNode.ShowBehindParent = n73;
            }

            if (TopLevel is System.Boolean n74)
            {
                NodeStateManager.AddPropertyState(castedNode, "TopLevel", castedNode.TopLevel);
                castedNode.TopLevel = n74;
            }

            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n75)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipChildren", castedNode.ClipChildren);
                castedNode.ClipChildren = n75;
            }

            if (LightMask is System.Int32 n76)
            {
                NodeStateManager.AddPropertyState(castedNode, "LightMask", castedNode.LightMask);
                castedNode.LightMask = n76;
            }

            if (VisibilityLayer is System.UInt32 n77)
            {
                NodeStateManager.AddPropertyState(castedNode, "VisibilityLayer", castedNode.VisibilityLayer);
                castedNode.VisibilityLayer = n77;
            }

            if (ZIndex is System.Int32 n78)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZIndex", castedNode.ZIndex);
                castedNode.ZIndex = n78;
            }

            if (ZAsRelative is System.Boolean n79)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZAsRelative", castedNode.ZAsRelative);
                castedNode.ZAsRelative = n79;
            }

            if (YSortEnabled is System.Boolean n80)
            {
                NodeStateManager.AddPropertyState(castedNode, "YSortEnabled", castedNode.YSortEnabled);
                castedNode.YSortEnabled = n80;
            }

            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n81)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureFilter", castedNode.TextureFilter);
                castedNode.TextureFilter = n81;
            }

            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n82)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureRepeat", castedNode.TextureRepeat);
                castedNode.TextureRepeat = n82;
            }

            if (Material is Godot.Material n83)
            {
                NodeStateManager.AddPropertyState(castedNode, "Material", castedNode.Material);
                castedNode.Material = n83;
            }

            if (UseParentMaterial is System.Boolean n84)
            {
                NodeStateManager.AddPropertyState(castedNode, "UseParentMaterial", castedNode.UseParentMaterial);
                castedNode.UseParentMaterial = n84;
            }

            if (Name is Godot.StringName n85)
            {
                NodeStateManager.AddPropertyState(castedNode, "Name", castedNode.Name);
                castedNode.Name = n85;
            }

            if (UniqueNameInOwner is System.Boolean n86)
            {
                NodeStateManager.AddPropertyState(castedNode, "UniqueNameInOwner", castedNode.UniqueNameInOwner);
                castedNode.UniqueNameInOwner = n86;
            }

            if (SceneFilePath is System.String n87)
            {
                NodeStateManager.AddPropertyState(castedNode, "SceneFilePath", castedNode.SceneFilePath);
                castedNode.SceneFilePath = n87;
            }

            if (Owner is Godot.Node n88)
            {
                NodeStateManager.AddPropertyState(castedNode, "Owner", castedNode.Owner);
                castedNode.Owner = n88;
            }

            if (ProcessMode is Godot.Node.ProcessModeEnum n89)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessMode", castedNode.ProcessMode);
                castedNode.ProcessMode = n89;
            }

            if (ProcessPriority is System.Int32 n90)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPriority", castedNode.ProcessPriority);
                castedNode.ProcessPriority = n90;
            }

            if (ProcessPhysicsPriority is System.Int32 n91)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPhysicsPriority", castedNode.ProcessPhysicsPriority);
                castedNode.ProcessPhysicsPriority = n91;
            }

            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n92)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroup", castedNode.ProcessThreadGroup);
                castedNode.ProcessThreadGroup = n92;
            }

            if (ProcessThreadGroupOrder is System.Int32 n93)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroupOrder", castedNode.ProcessThreadGroupOrder);
                castedNode.ProcessThreadGroupOrder = n93;
            }

            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n94)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadMessages", castedNode.ProcessThreadMessages);
                castedNode.ProcessThreadMessages = n94;
            }

            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n95)
            {
                NodeStateManager.AddPropertyState(castedNode, "PhysicsInterpolationMode", castedNode.PhysicsInterpolationMode);
                castedNode.PhysicsInterpolationMode = n95;
            }

            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n96)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslateMode", castedNode.AutoTranslateMode);
                castedNode.AutoTranslateMode = n96;
            }

            if (EditorDescription is System.String n97)
            {
                NodeStateManager.AddPropertyState(castedNode, "EditorDescription", castedNode.EditorDescription);
                castedNode.EditorDescription = n97;
            }

            if (MetaClicked is Godot.RichTextLabel.MetaClickedEventHandler e0)
            {
                NodeStateManager.AddEventHandler(castedNode, "MetaClicked", e0);
                castedNode.MetaClicked += e0;
            }

            if (MetaHoverStarted is Godot.RichTextLabel.MetaHoverStartedEventHandler e1)
            {
                NodeStateManager.AddEventHandler(castedNode, "MetaHoverStarted", e1);
                castedNode.MetaHoverStarted += e1;
            }

            if (MetaHoverEnded is Godot.RichTextLabel.MetaHoverEndedEventHandler e2)
            {
                NodeStateManager.AddEventHandler(castedNode, "MetaHoverEnded", e2);
                castedNode.MetaHoverEnded += e2;
            }

            if (Finished is System.Action e3)
            {
                NodeStateManager.AddEventHandler(castedNode, "Finished", e3);
                castedNode.Finished += e3;
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

            if (EditorStateChanged is System.Action e27)
            {
                NodeStateManager.AddEventHandler(castedNode, "EditorStateChanged", e27);
                castedNode.EditorStateChanged += e27;
            }

            if (ScriptChanged is System.Action e28)
            {
                NodeStateManager.AddEventHandler(castedNode, "ScriptChanged", e28);
                castedNode.ScriptChanged += e28;
            }

            if (PropertyListChanged is System.Action e29)
            {
                NodeStateManager.AddEventHandler(castedNode, "PropertyListChanged", e29);
                castedNode.PropertyListChanged += e29;
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