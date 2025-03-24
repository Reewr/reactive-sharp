namespace ReactiveSharpGodot.Components
{
    public class LineEdit : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GLineEdit>
    {
        public System.String? Text { protected get; init; }
        public System.String? PlaceholderText { protected get; init; }
        public Godot.HorizontalAlignment? Alignment { protected get; init; }
        public System.Int32? MaxLength { protected get; init; }
        public System.Boolean? Editable { protected get; init; }
        public System.Boolean? ExpandToTextLength { protected get; init; }
        public System.Boolean? ContextMenuEnabled { protected get; init; }
        public System.Boolean? VirtualKeyboardEnabled { protected get; init; }
        public Godot.LineEdit.VirtualKeyboardTypeEnum? VirtualKeyboardType { protected get; init; }
        public System.Boolean? ClearButtonEnabled { protected get; init; }
        public System.Boolean? ShortcutKeysEnabled { protected get; init; }
        public System.Boolean? MiddleMousePasteEnabled { protected get; init; }
        public System.Boolean? SelectingEnabled { protected get; init; }
        public System.Boolean? DeselectOnFocusLossEnabled { protected get; init; }
        public System.Boolean? DragAndDropSelectionEnabled { protected get; init; }
        public Godot.Texture2D? RightIcon { protected get; init; }
        public System.Boolean? Flat { protected get; init; }
        public System.Boolean? DrawControlChars { protected get; init; }
        public System.Boolean? SelectAllOnFocus { protected get; init; }
        public System.Boolean? CaretBlink { protected get; init; }
        public System.Single? CaretBlinkInterval { protected get; init; }
        public System.Int32? CaretColumn { protected get; init; }
        public System.Boolean? CaretForceDisplayed { protected get; init; }
        public System.Boolean? CaretMidGrapheme { protected get; init; }
        public System.Boolean? Secret { protected get; init; }
        public System.String? SecretCharacter { protected get; init; }
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
        public Godot.LineEdit.TextChangedEventHandler? TextChanged { protected get; init; }
        public Godot.LineEdit.TextChangeRejectedEventHandler? TextChangeRejected { protected get; init; }
        public Godot.LineEdit.TextSubmittedEventHandler? TextSubmitted { protected get; init; }
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
        public Action<ReactiveSharpGodot.Nodes.GLineEdit>? CustomNodeHandling { protected get; init; }

        public override ReactiveSharpGodot.Nodes.GLineEdit Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GLineEdit();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GLineEdit node)
        {
            var castedNode = (Godot.LineEdit)node.Node;
            if (Text is System.String n0)
            {
                NodeStateManager.AddPropertyState(castedNode, "Text", castedNode.Text);
                castedNode.Text = n0;
            }

            if (PlaceholderText is System.String n1)
            {
                NodeStateManager.AddPropertyState(castedNode, "PlaceholderText", castedNode.PlaceholderText);
                castedNode.PlaceholderText = n1;
            }

            if (Alignment is Godot.HorizontalAlignment n2)
            {
                NodeStateManager.AddPropertyState(castedNode, "Alignment", castedNode.Alignment);
                castedNode.Alignment = n2;
            }

            if (MaxLength is System.Int32 n3)
            {
                NodeStateManager.AddPropertyState(castedNode, "MaxLength", castedNode.MaxLength);
                castedNode.MaxLength = n3;
            }

            if (Editable is System.Boolean n4)
            {
                NodeStateManager.AddPropertyState(castedNode, "Editable", castedNode.Editable);
                castedNode.Editable = n4;
            }

            if (ExpandToTextLength is System.Boolean n5)
            {
                NodeStateManager.AddPropertyState(castedNode, "ExpandToTextLength", castedNode.ExpandToTextLength);
                castedNode.ExpandToTextLength = n5;
            }

            if (ContextMenuEnabled is System.Boolean n6)
            {
                NodeStateManager.AddPropertyState(castedNode, "ContextMenuEnabled", castedNode.ContextMenuEnabled);
                castedNode.ContextMenuEnabled = n6;
            }

            if (VirtualKeyboardEnabled is System.Boolean n7)
            {
                NodeStateManager.AddPropertyState(castedNode, "VirtualKeyboardEnabled", castedNode.VirtualKeyboardEnabled);
                castedNode.VirtualKeyboardEnabled = n7;
            }

            if (VirtualKeyboardType is Godot.LineEdit.VirtualKeyboardTypeEnum n8)
            {
                NodeStateManager.AddPropertyState(castedNode, "VirtualKeyboardType", castedNode.VirtualKeyboardType);
                castedNode.VirtualKeyboardType = n8;
            }

            if (ClearButtonEnabled is System.Boolean n9)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClearButtonEnabled", castedNode.ClearButtonEnabled);
                castedNode.ClearButtonEnabled = n9;
            }

            if (ShortcutKeysEnabled is System.Boolean n10)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutKeysEnabled", castedNode.ShortcutKeysEnabled);
                castedNode.ShortcutKeysEnabled = n10;
            }

            if (MiddleMousePasteEnabled is System.Boolean n11)
            {
                NodeStateManager.AddPropertyState(castedNode, "MiddleMousePasteEnabled", castedNode.MiddleMousePasteEnabled);
                castedNode.MiddleMousePasteEnabled = n11;
            }

            if (SelectingEnabled is System.Boolean n12)
            {
                NodeStateManager.AddPropertyState(castedNode, "SelectingEnabled", castedNode.SelectingEnabled);
                castedNode.SelectingEnabled = n12;
            }

            if (DeselectOnFocusLossEnabled is System.Boolean n13)
            {
                NodeStateManager.AddPropertyState(castedNode, "DeselectOnFocusLossEnabled", castedNode.DeselectOnFocusLossEnabled);
                castedNode.DeselectOnFocusLossEnabled = n13;
            }

            if (DragAndDropSelectionEnabled is System.Boolean n14)
            {
                NodeStateManager.AddPropertyState(castedNode, "DragAndDropSelectionEnabled", castedNode.DragAndDropSelectionEnabled);
                castedNode.DragAndDropSelectionEnabled = n14;
            }

            if (RightIcon is Godot.Texture2D n15)
            {
                NodeStateManager.AddPropertyState(castedNode, "RightIcon", castedNode.RightIcon);
                castedNode.RightIcon = n15;
            }

            if (Flat is System.Boolean n16)
            {
                NodeStateManager.AddPropertyState(castedNode, "Flat", castedNode.Flat);
                castedNode.Flat = n16;
            }

            if (DrawControlChars is System.Boolean n17)
            {
                NodeStateManager.AddPropertyState(castedNode, "DrawControlChars", castedNode.DrawControlChars);
                castedNode.DrawControlChars = n17;
            }

            if (SelectAllOnFocus is System.Boolean n18)
            {
                NodeStateManager.AddPropertyState(castedNode, "SelectAllOnFocus", castedNode.SelectAllOnFocus);
                castedNode.SelectAllOnFocus = n18;
            }

            if (CaretBlink is System.Boolean n19)
            {
                NodeStateManager.AddPropertyState(castedNode, "CaretBlink", castedNode.CaretBlink);
                castedNode.CaretBlink = n19;
            }

            if (CaretBlinkInterval is System.Single n20)
            {
                NodeStateManager.AddPropertyState(castedNode, "CaretBlinkInterval", castedNode.CaretBlinkInterval);
                castedNode.CaretBlinkInterval = n20;
            }

            if (CaretColumn is System.Int32 n21)
            {
                NodeStateManager.AddPropertyState(castedNode, "CaretColumn", castedNode.CaretColumn);
                castedNode.CaretColumn = n21;
            }

            if (CaretForceDisplayed is System.Boolean n22)
            {
                NodeStateManager.AddPropertyState(castedNode, "CaretForceDisplayed", castedNode.CaretForceDisplayed);
                castedNode.CaretForceDisplayed = n22;
            }

            if (CaretMidGrapheme is System.Boolean n23)
            {
                NodeStateManager.AddPropertyState(castedNode, "CaretMidGrapheme", castedNode.CaretMidGrapheme);
                castedNode.CaretMidGrapheme = n23;
            }

            if (Secret is System.Boolean n24)
            {
                NodeStateManager.AddPropertyState(castedNode, "Secret", castedNode.Secret);
                castedNode.Secret = n24;
            }

            if (SecretCharacter is System.String n25)
            {
                NodeStateManager.AddPropertyState(castedNode, "SecretCharacter", castedNode.SecretCharacter);
                castedNode.SecretCharacter = n25;
            }

            if (TextDirection is Godot.Control.TextDirection n26)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextDirection", castedNode.TextDirection);
                castedNode.TextDirection = n26;
            }

            if (Language is System.String n27)
            {
                NodeStateManager.AddPropertyState(castedNode, "Language", castedNode.Language);
                castedNode.Language = n27;
            }

            if (StructuredTextBidiOverride is Godot.TextServer.StructuredTextParser n28)
            {
                NodeStateManager.AddPropertyState(castedNode, "StructuredTextBidiOverride", castedNode.StructuredTextBidiOverride);
                castedNode.StructuredTextBidiOverride = n28;
            }

            if (StructuredTextBidiOverrideOptions is Godot.Collections.Array n29)
            {
                NodeStateManager.AddPropertyState(castedNode, "StructuredTextBidiOverrideOptions", castedNode.StructuredTextBidiOverrideOptions);
                castedNode.StructuredTextBidiOverrideOptions = n29;
            }

            if (ClipContents is System.Boolean n30)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipContents", castedNode.ClipContents);
                castedNode.ClipContents = n30;
            }

            if (CustomMinimumSize is Godot.Vector2 n31)
            {
                NodeStateManager.AddPropertyState(castedNode, "CustomMinimumSize", castedNode.CustomMinimumSize);
                castedNode.CustomMinimumSize = n31;
            }

            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n32)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutDirection", castedNode.LayoutDirection);
                castedNode.LayoutDirection = n32;
            }

            if (LayoutMode is System.Int32 n33)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutMode", castedNode.LayoutMode);
                castedNode.LayoutMode = n33;
            }

            if (AnchorsPreset is System.Int32 n34)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorsPreset", castedNode.AnchorsPreset);
                castedNode.AnchorsPreset = n34;
            }

            if (AnchorLeft is System.Single n35)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorLeft", castedNode.AnchorLeft);
                castedNode.AnchorLeft = n35;
            }

            if (AnchorTop is System.Single n36)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorTop", castedNode.AnchorTop);
                castedNode.AnchorTop = n36;
            }

            if (AnchorRight is System.Single n37)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorRight", castedNode.AnchorRight);
                castedNode.AnchorRight = n37;
            }

            if (AnchorBottom is System.Single n38)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorBottom", castedNode.AnchorBottom);
                castedNode.AnchorBottom = n38;
            }

            if (OffsetLeft is System.Single n39)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetLeft", castedNode.OffsetLeft);
                castedNode.OffsetLeft = n39;
            }

            if (OffsetTop is System.Single n40)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetTop", castedNode.OffsetTop);
                castedNode.OffsetTop = n40;
            }

            if (OffsetRight is System.Single n41)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetRight", castedNode.OffsetRight);
                castedNode.OffsetRight = n41;
            }

            if (OffsetBottom is System.Single n42)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetBottom", castedNode.OffsetBottom);
                castedNode.OffsetBottom = n42;
            }

            if (GrowHorizontal is Godot.Control.GrowDirection n43)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowHorizontal", castedNode.GrowHorizontal);
                castedNode.GrowHorizontal = n43;
            }

            if (GrowVertical is Godot.Control.GrowDirection n44)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowVertical", castedNode.GrowVertical);
                castedNode.GrowVertical = n44;
            }

            if (Size is Godot.Vector2 n45)
            {
                NodeStateManager.AddPropertyState(castedNode, "Size", castedNode.Size);
                castedNode.Size = n45;
            }

            if (Position is Godot.Vector2 n46)
            {
                NodeStateManager.AddPropertyState(castedNode, "Position", castedNode.Position);
                castedNode.Position = n46;
            }

            if (GlobalPosition is Godot.Vector2 n47)
            {
                NodeStateManager.AddPropertyState(castedNode, "GlobalPosition", castedNode.GlobalPosition);
                castedNode.GlobalPosition = n47;
            }

            if (Rotation is System.Single n48)
            {
                NodeStateManager.AddPropertyState(castedNode, "Rotation", castedNode.Rotation);
                castedNode.Rotation = n48;
            }

            if (RotationDegrees is System.Single n49)
            {
                NodeStateManager.AddPropertyState(castedNode, "RotationDegrees", castedNode.RotationDegrees);
                castedNode.RotationDegrees = n49;
            }

            if (Scale is Godot.Vector2 n50)
            {
                NodeStateManager.AddPropertyState(castedNode, "Scale", castedNode.Scale);
                castedNode.Scale = n50;
            }

            if (PivotOffset is Godot.Vector2 n51)
            {
                NodeStateManager.AddPropertyState(castedNode, "PivotOffset", castedNode.PivotOffset);
                castedNode.PivotOffset = n51;
            }

            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n52)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsHorizontal", castedNode.SizeFlagsHorizontal);
                castedNode.SizeFlagsHorizontal = n52;
            }

            if (SizeFlagsVertical is Godot.Control.SizeFlags n53)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsVertical", castedNode.SizeFlagsVertical);
                castedNode.SizeFlagsVertical = n53;
            }

            if (SizeFlagsStretchRatio is System.Single n54)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsStretchRatio", castedNode.SizeFlagsStretchRatio);
                castedNode.SizeFlagsStretchRatio = n54;
            }

            if (LocalizeNumeralSystem is System.Boolean n55)
            {
                NodeStateManager.AddPropertyState(castedNode, "LocalizeNumeralSystem", castedNode.LocalizeNumeralSystem);
                castedNode.LocalizeNumeralSystem = n55;
            }

            if (AutoTranslate is System.Boolean n56)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslate", castedNode.AutoTranslate);
                castedNode.AutoTranslate = n56;
            }

            if (TooltipText is System.String n57)
            {
                NodeStateManager.AddPropertyState(castedNode, "TooltipText", castedNode.TooltipText);
                castedNode.TooltipText = n57;
            }

            if (FocusNeighborLeft is Godot.NodePath n58)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborLeft", castedNode.FocusNeighborLeft);
                castedNode.FocusNeighborLeft = n58;
            }

            if (FocusNeighborTop is Godot.NodePath n59)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborTop", castedNode.FocusNeighborTop);
                castedNode.FocusNeighborTop = n59;
            }

            if (FocusNeighborRight is Godot.NodePath n60)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborRight", castedNode.FocusNeighborRight);
                castedNode.FocusNeighborRight = n60;
            }

            if (FocusNeighborBottom is Godot.NodePath n61)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborBottom", castedNode.FocusNeighborBottom);
                castedNode.FocusNeighborBottom = n61;
            }

            if (FocusNext is Godot.NodePath n62)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNext", castedNode.FocusNext);
                castedNode.FocusNext = n62;
            }

            if (FocusPrevious is Godot.NodePath n63)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusPrevious", castedNode.FocusPrevious);
                castedNode.FocusPrevious = n63;
            }

            if (FocusMode is Godot.Control.FocusModeEnum n64)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusMode", castedNode.FocusMode);
                castedNode.FocusMode = n64;
            }

            if (MouseFilter is Godot.Control.MouseFilterEnum n65)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseFilter", castedNode.MouseFilter);
                castedNode.MouseFilter = n65;
            }

            if (MouseForcePassScrollEvents is System.Boolean n66)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseForcePassScrollEvents", castedNode.MouseForcePassScrollEvents);
                castedNode.MouseForcePassScrollEvents = n66;
            }

            if (MouseDefaultCursorShape is Godot.Control.CursorShape n67)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseDefaultCursorShape", castedNode.MouseDefaultCursorShape);
                castedNode.MouseDefaultCursorShape = n67;
            }

            if (ShortcutContext is Godot.Node n68)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutContext", castedNode.ShortcutContext);
                castedNode.ShortcutContext = n68;
            }

            if (Theme is Godot.Theme n69)
            {
                NodeStateManager.AddPropertyState(castedNode, "Theme", castedNode.Theme);
                castedNode.Theme = n69;
            }

            if (ThemeTypeVariation is Godot.StringName n70)
            {
                NodeStateManager.AddPropertyState(castedNode, "ThemeTypeVariation", castedNode.ThemeTypeVariation);
                castedNode.ThemeTypeVariation = n70;
            }

            if (Visible is System.Boolean n71)
            {
                NodeStateManager.AddPropertyState(castedNode, "Visible", castedNode.Visible);
                castedNode.Visible = n71;
            }

            if (Modulate is Godot.Color n72)
            {
                NodeStateManager.AddPropertyState(castedNode, "Modulate", castedNode.Modulate);
                castedNode.Modulate = n72;
            }

            if (SelfModulate is Godot.Color n73)
            {
                NodeStateManager.AddPropertyState(castedNode, "SelfModulate", castedNode.SelfModulate);
                castedNode.SelfModulate = n73;
            }

            if (ShowBehindParent is System.Boolean n74)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowBehindParent", castedNode.ShowBehindParent);
                castedNode.ShowBehindParent = n74;
            }

            if (TopLevel is System.Boolean n75)
            {
                NodeStateManager.AddPropertyState(castedNode, "TopLevel", castedNode.TopLevel);
                castedNode.TopLevel = n75;
            }

            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n76)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipChildren", castedNode.ClipChildren);
                castedNode.ClipChildren = n76;
            }

            if (LightMask is System.Int32 n77)
            {
                NodeStateManager.AddPropertyState(castedNode, "LightMask", castedNode.LightMask);
                castedNode.LightMask = n77;
            }

            if (VisibilityLayer is System.UInt32 n78)
            {
                NodeStateManager.AddPropertyState(castedNode, "VisibilityLayer", castedNode.VisibilityLayer);
                castedNode.VisibilityLayer = n78;
            }

            if (ZIndex is System.Int32 n79)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZIndex", castedNode.ZIndex);
                castedNode.ZIndex = n79;
            }

            if (ZAsRelative is System.Boolean n80)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZAsRelative", castedNode.ZAsRelative);
                castedNode.ZAsRelative = n80;
            }

            if (YSortEnabled is System.Boolean n81)
            {
                NodeStateManager.AddPropertyState(castedNode, "YSortEnabled", castedNode.YSortEnabled);
                castedNode.YSortEnabled = n81;
            }

            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n82)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureFilter", castedNode.TextureFilter);
                castedNode.TextureFilter = n82;
            }

            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n83)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureRepeat", castedNode.TextureRepeat);
                castedNode.TextureRepeat = n83;
            }

            if (Material is Godot.Material n84)
            {
                NodeStateManager.AddPropertyState(castedNode, "Material", castedNode.Material);
                castedNode.Material = n84;
            }

            if (UseParentMaterial is System.Boolean n85)
            {
                NodeStateManager.AddPropertyState(castedNode, "UseParentMaterial", castedNode.UseParentMaterial);
                castedNode.UseParentMaterial = n85;
            }

            if (Name is Godot.StringName n86)
            {
                NodeStateManager.AddPropertyState(castedNode, "Name", castedNode.Name);
                castedNode.Name = n86;
            }

            if (UniqueNameInOwner is System.Boolean n87)
            {
                NodeStateManager.AddPropertyState(castedNode, "UniqueNameInOwner", castedNode.UniqueNameInOwner);
                castedNode.UniqueNameInOwner = n87;
            }

            if (SceneFilePath is System.String n88)
            {
                NodeStateManager.AddPropertyState(castedNode, "SceneFilePath", castedNode.SceneFilePath);
                castedNode.SceneFilePath = n88;
            }

            if (Owner is Godot.Node n89)
            {
                NodeStateManager.AddPropertyState(castedNode, "Owner", castedNode.Owner);
                castedNode.Owner = n89;
            }

            if (ProcessMode is Godot.Node.ProcessModeEnum n90)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessMode", castedNode.ProcessMode);
                castedNode.ProcessMode = n90;
            }

            if (ProcessPriority is System.Int32 n91)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPriority", castedNode.ProcessPriority);
                castedNode.ProcessPriority = n91;
            }

            if (ProcessPhysicsPriority is System.Int32 n92)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPhysicsPriority", castedNode.ProcessPhysicsPriority);
                castedNode.ProcessPhysicsPriority = n92;
            }

            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n93)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroup", castedNode.ProcessThreadGroup);
                castedNode.ProcessThreadGroup = n93;
            }

            if (ProcessThreadGroupOrder is System.Int32 n94)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroupOrder", castedNode.ProcessThreadGroupOrder);
                castedNode.ProcessThreadGroupOrder = n94;
            }

            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n95)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadMessages", castedNode.ProcessThreadMessages);
                castedNode.ProcessThreadMessages = n95;
            }

            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n96)
            {
                NodeStateManager.AddPropertyState(castedNode, "PhysicsInterpolationMode", castedNode.PhysicsInterpolationMode);
                castedNode.PhysicsInterpolationMode = n96;
            }

            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n97)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslateMode", castedNode.AutoTranslateMode);
                castedNode.AutoTranslateMode = n97;
            }

            if (EditorDescription is System.String n98)
            {
                NodeStateManager.AddPropertyState(castedNode, "EditorDescription", castedNode.EditorDescription);
                castedNode.EditorDescription = n98;
            }

            if (TextChanged is Godot.LineEdit.TextChangedEventHandler e0)
            {
                NodeStateManager.AddEventHandler(castedNode, "TextChanged", e0);
                castedNode.TextChanged += e0;
            }

            if (TextChangeRejected is Godot.LineEdit.TextChangeRejectedEventHandler e1)
            {
                NodeStateManager.AddEventHandler(castedNode, "TextChangeRejected", e1);
                castedNode.TextChangeRejected += e1;
            }

            if (TextSubmitted is Godot.LineEdit.TextSubmittedEventHandler e2)
            {
                NodeStateManager.AddEventHandler(castedNode, "TextSubmitted", e2);
                castedNode.TextSubmitted += e2;
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

            foreach (var(key, value)in ThemeColorOverrides)
            {
                castedNode.AddThemeColorOverride(key, value);
            }

            castedNode.EndBulkThemeOverride();
            CustomNodeHandling?.Invoke(node);
        }
    }
}