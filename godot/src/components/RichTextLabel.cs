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
        public System.Action? ScriptChanged { protected get; init; }
        public System.Action? PropertyListChanged { protected get; init; }

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

            if (CustomEffects is Godot.Collections.Array n9)
            {
                NodeStateManager.AddPropertyState(castedNode, "CustomEffects", castedNode.CustomEffects);
                castedNode.CustomEffects = n9;
            }

            if (MetaUnderlined is System.Boolean n10)
            {
                NodeStateManager.AddPropertyState(castedNode, "MetaUnderlined", castedNode.MetaUnderlined);
                castedNode.MetaUnderlined = n10;
            }

            if (HintUnderlined is System.Boolean n11)
            {
                NodeStateManager.AddPropertyState(castedNode, "HintUnderlined", castedNode.HintUnderlined);
                castedNode.HintUnderlined = n11;
            }

            if (Threaded is System.Boolean n12)
            {
                NodeStateManager.AddPropertyState(castedNode, "Threaded", castedNode.Threaded);
                castedNode.Threaded = n12;
            }

            if (ProgressBarDelay is System.Int32 n13)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProgressBarDelay", castedNode.ProgressBarDelay);
                castedNode.ProgressBarDelay = n13;
            }

            if (SelectionEnabled is System.Boolean n14)
            {
                NodeStateManager.AddPropertyState(castedNode, "SelectionEnabled", castedNode.SelectionEnabled);
                castedNode.SelectionEnabled = n14;
            }

            if (DeselectOnFocusLossEnabled is System.Boolean n15)
            {
                NodeStateManager.AddPropertyState(castedNode, "DeselectOnFocusLossEnabled", castedNode.DeselectOnFocusLossEnabled);
                castedNode.DeselectOnFocusLossEnabled = n15;
            }

            if (DragAndDropSelectionEnabled is System.Boolean n16)
            {
                NodeStateManager.AddPropertyState(castedNode, "DragAndDropSelectionEnabled", castedNode.DragAndDropSelectionEnabled);
                castedNode.DragAndDropSelectionEnabled = n16;
            }

            if (VisibleCharacters is System.Int32 n17)
            {
                NodeStateManager.AddPropertyState(castedNode, "VisibleCharacters", castedNode.VisibleCharacters);
                castedNode.VisibleCharacters = n17;
            }

            if (VisibleCharactersBehavior is Godot.TextServer.VisibleCharactersBehavior n18)
            {
                NodeStateManager.AddPropertyState(castedNode, "VisibleCharactersBehavior", castedNode.VisibleCharactersBehavior);
                castedNode.VisibleCharactersBehavior = n18;
            }

            if (VisibleRatio is System.Single n19)
            {
                NodeStateManager.AddPropertyState(castedNode, "VisibleRatio", castedNode.VisibleRatio);
                castedNode.VisibleRatio = n19;
            }

            if (TextDirection is Godot.Control.TextDirection n20)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextDirection", castedNode.TextDirection);
                castedNode.TextDirection = n20;
            }

            if (Language is System.String n21)
            {
                NodeStateManager.AddPropertyState(castedNode, "Language", castedNode.Language);
                castedNode.Language = n21;
            }

            if (StructuredTextBidiOverride is Godot.TextServer.StructuredTextParser n22)
            {
                NodeStateManager.AddPropertyState(castedNode, "StructuredTextBidiOverride", castedNode.StructuredTextBidiOverride);
                castedNode.StructuredTextBidiOverride = n22;
            }

            if (StructuredTextBidiOverrideOptions is Godot.Collections.Array n23)
            {
                NodeStateManager.AddPropertyState(castedNode, "StructuredTextBidiOverrideOptions", castedNode.StructuredTextBidiOverrideOptions);
                castedNode.StructuredTextBidiOverrideOptions = n23;
            }

            if (ClipContents is System.Boolean n24)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipContents", castedNode.ClipContents);
                castedNode.ClipContents = n24;
            }

            if (CustomMinimumSize is Godot.Vector2 n25)
            {
                NodeStateManager.AddPropertyState(castedNode, "CustomMinimumSize", castedNode.CustomMinimumSize);
                castedNode.CustomMinimumSize = n25;
            }

            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n26)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutDirection", castedNode.LayoutDirection);
                castedNode.LayoutDirection = n26;
            }

            if (LayoutMode is System.Int32 n27)
            {
                NodeStateManager.AddPropertyState(castedNode, "LayoutMode", castedNode.LayoutMode);
                castedNode.LayoutMode = n27;
            }

            if (AnchorsPreset is System.Int32 n28)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorsPreset", castedNode.AnchorsPreset);
                castedNode.AnchorsPreset = n28;
            }

            if (AnchorLeft is System.Single n29)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorLeft", castedNode.AnchorLeft);
                castedNode.AnchorLeft = n29;
            }

            if (AnchorTop is System.Single n30)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorTop", castedNode.AnchorTop);
                castedNode.AnchorTop = n30;
            }

            if (AnchorRight is System.Single n31)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorRight", castedNode.AnchorRight);
                castedNode.AnchorRight = n31;
            }

            if (AnchorBottom is System.Single n32)
            {
                NodeStateManager.AddPropertyState(castedNode, "AnchorBottom", castedNode.AnchorBottom);
                castedNode.AnchorBottom = n32;
            }

            if (OffsetLeft is System.Single n33)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetLeft", castedNode.OffsetLeft);
                castedNode.OffsetLeft = n33;
            }

            if (OffsetTop is System.Single n34)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetTop", castedNode.OffsetTop);
                castedNode.OffsetTop = n34;
            }

            if (OffsetRight is System.Single n35)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetRight", castedNode.OffsetRight);
                castedNode.OffsetRight = n35;
            }

            if (OffsetBottom is System.Single n36)
            {
                NodeStateManager.AddPropertyState(castedNode, "OffsetBottom", castedNode.OffsetBottom);
                castedNode.OffsetBottom = n36;
            }

            if (GrowHorizontal is Godot.Control.GrowDirection n37)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowHorizontal", castedNode.GrowHorizontal);
                castedNode.GrowHorizontal = n37;
            }

            if (GrowVertical is Godot.Control.GrowDirection n38)
            {
                NodeStateManager.AddPropertyState(castedNode, "GrowVertical", castedNode.GrowVertical);
                castedNode.GrowVertical = n38;
            }

            if (Size is Godot.Vector2 n39)
            {
                NodeStateManager.AddPropertyState(castedNode, "Size", castedNode.Size);
                castedNode.Size = n39;
            }

            if (Position is Godot.Vector2 n40)
            {
                NodeStateManager.AddPropertyState(castedNode, "Position", castedNode.Position);
                castedNode.Position = n40;
            }

            if (GlobalPosition is Godot.Vector2 n41)
            {
                NodeStateManager.AddPropertyState(castedNode, "GlobalPosition", castedNode.GlobalPosition);
                castedNode.GlobalPosition = n41;
            }

            if (Rotation is System.Single n42)
            {
                NodeStateManager.AddPropertyState(castedNode, "Rotation", castedNode.Rotation);
                castedNode.Rotation = n42;
            }

            if (RotationDegrees is System.Single n43)
            {
                NodeStateManager.AddPropertyState(castedNode, "RotationDegrees", castedNode.RotationDegrees);
                castedNode.RotationDegrees = n43;
            }

            if (Scale is Godot.Vector2 n44)
            {
                NodeStateManager.AddPropertyState(castedNode, "Scale", castedNode.Scale);
                castedNode.Scale = n44;
            }

            if (PivotOffset is Godot.Vector2 n45)
            {
                NodeStateManager.AddPropertyState(castedNode, "PivotOffset", castedNode.PivotOffset);
                castedNode.PivotOffset = n45;
            }

            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n46)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsHorizontal", castedNode.SizeFlagsHorizontal);
                castedNode.SizeFlagsHorizontal = n46;
            }

            if (SizeFlagsVertical is Godot.Control.SizeFlags n47)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsVertical", castedNode.SizeFlagsVertical);
                castedNode.SizeFlagsVertical = n47;
            }

            if (SizeFlagsStretchRatio is System.Single n48)
            {
                NodeStateManager.AddPropertyState(castedNode, "SizeFlagsStretchRatio", castedNode.SizeFlagsStretchRatio);
                castedNode.SizeFlagsStretchRatio = n48;
            }

            if (LocalizeNumeralSystem is System.Boolean n49)
            {
                NodeStateManager.AddPropertyState(castedNode, "LocalizeNumeralSystem", castedNode.LocalizeNumeralSystem);
                castedNode.LocalizeNumeralSystem = n49;
            }

            if (AutoTranslate is System.Boolean n50)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslate", castedNode.AutoTranslate);
                castedNode.AutoTranslate = n50;
            }

            if (TooltipText is System.String n51)
            {
                NodeStateManager.AddPropertyState(castedNode, "TooltipText", castedNode.TooltipText);
                castedNode.TooltipText = n51;
            }

            if (FocusNeighborLeft is Godot.NodePath n52)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborLeft", castedNode.FocusNeighborLeft);
                castedNode.FocusNeighborLeft = n52;
            }

            if (FocusNeighborTop is Godot.NodePath n53)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborTop", castedNode.FocusNeighborTop);
                castedNode.FocusNeighborTop = n53;
            }

            if (FocusNeighborRight is Godot.NodePath n54)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborRight", castedNode.FocusNeighborRight);
                castedNode.FocusNeighborRight = n54;
            }

            if (FocusNeighborBottom is Godot.NodePath n55)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNeighborBottom", castedNode.FocusNeighborBottom);
                castedNode.FocusNeighborBottom = n55;
            }

            if (FocusNext is Godot.NodePath n56)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusNext", castedNode.FocusNext);
                castedNode.FocusNext = n56;
            }

            if (FocusPrevious is Godot.NodePath n57)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusPrevious", castedNode.FocusPrevious);
                castedNode.FocusPrevious = n57;
            }

            if (FocusMode is Godot.Control.FocusModeEnum n58)
            {
                NodeStateManager.AddPropertyState(castedNode, "FocusMode", castedNode.FocusMode);
                castedNode.FocusMode = n58;
            }

            if (MouseFilter is Godot.Control.MouseFilterEnum n59)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseFilter", castedNode.MouseFilter);
                castedNode.MouseFilter = n59;
            }

            if (MouseForcePassScrollEvents is System.Boolean n60)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseForcePassScrollEvents", castedNode.MouseForcePassScrollEvents);
                castedNode.MouseForcePassScrollEvents = n60;
            }

            if (MouseDefaultCursorShape is Godot.Control.CursorShape n61)
            {
                NodeStateManager.AddPropertyState(castedNode, "MouseDefaultCursorShape", castedNode.MouseDefaultCursorShape);
                castedNode.MouseDefaultCursorShape = n61;
            }

            if (ShortcutContext is Godot.Node n62)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShortcutContext", castedNode.ShortcutContext);
                castedNode.ShortcutContext = n62;
            }

            if (Theme is Godot.Theme n63)
            {
                NodeStateManager.AddPropertyState(castedNode, "Theme", castedNode.Theme);
                castedNode.Theme = n63;
            }

            if (ThemeTypeVariation is Godot.StringName n64)
            {
                NodeStateManager.AddPropertyState(castedNode, "ThemeTypeVariation", castedNode.ThemeTypeVariation);
                castedNode.ThemeTypeVariation = n64;
            }

            if (Visible is System.Boolean n65)
            {
                NodeStateManager.AddPropertyState(castedNode, "Visible", castedNode.Visible);
                castedNode.Visible = n65;
            }

            if (Modulate is Godot.Color n66)
            {
                NodeStateManager.AddPropertyState(castedNode, "Modulate", castedNode.Modulate);
                castedNode.Modulate = n66;
            }

            if (SelfModulate is Godot.Color n67)
            {
                NodeStateManager.AddPropertyState(castedNode, "SelfModulate", castedNode.SelfModulate);
                castedNode.SelfModulate = n67;
            }

            if (ShowBehindParent is System.Boolean n68)
            {
                NodeStateManager.AddPropertyState(castedNode, "ShowBehindParent", castedNode.ShowBehindParent);
                castedNode.ShowBehindParent = n68;
            }

            if (TopLevel is System.Boolean n69)
            {
                NodeStateManager.AddPropertyState(castedNode, "TopLevel", castedNode.TopLevel);
                castedNode.TopLevel = n69;
            }

            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n70)
            {
                NodeStateManager.AddPropertyState(castedNode, "ClipChildren", castedNode.ClipChildren);
                castedNode.ClipChildren = n70;
            }

            if (LightMask is System.Int32 n71)
            {
                NodeStateManager.AddPropertyState(castedNode, "LightMask", castedNode.LightMask);
                castedNode.LightMask = n71;
            }

            if (VisibilityLayer is System.UInt32 n72)
            {
                NodeStateManager.AddPropertyState(castedNode, "VisibilityLayer", castedNode.VisibilityLayer);
                castedNode.VisibilityLayer = n72;
            }

            if (ZIndex is System.Int32 n73)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZIndex", castedNode.ZIndex);
                castedNode.ZIndex = n73;
            }

            if (ZAsRelative is System.Boolean n74)
            {
                NodeStateManager.AddPropertyState(castedNode, "ZAsRelative", castedNode.ZAsRelative);
                castedNode.ZAsRelative = n74;
            }

            if (YSortEnabled is System.Boolean n75)
            {
                NodeStateManager.AddPropertyState(castedNode, "YSortEnabled", castedNode.YSortEnabled);
                castedNode.YSortEnabled = n75;
            }

            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n76)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureFilter", castedNode.TextureFilter);
                castedNode.TextureFilter = n76;
            }

            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n77)
            {
                NodeStateManager.AddPropertyState(castedNode, "TextureRepeat", castedNode.TextureRepeat);
                castedNode.TextureRepeat = n77;
            }

            if (Material is Godot.Material n78)
            {
                NodeStateManager.AddPropertyState(castedNode, "Material", castedNode.Material);
                castedNode.Material = n78;
            }

            if (UseParentMaterial is System.Boolean n79)
            {
                NodeStateManager.AddPropertyState(castedNode, "UseParentMaterial", castedNode.UseParentMaterial);
                castedNode.UseParentMaterial = n79;
            }

            if (Name is Godot.StringName n80)
            {
                NodeStateManager.AddPropertyState(castedNode, "Name", castedNode.Name);
                castedNode.Name = n80;
            }

            if (UniqueNameInOwner is System.Boolean n81)
            {
                NodeStateManager.AddPropertyState(castedNode, "UniqueNameInOwner", castedNode.UniqueNameInOwner);
                castedNode.UniqueNameInOwner = n81;
            }

            if (SceneFilePath is System.String n82)
            {
                NodeStateManager.AddPropertyState(castedNode, "SceneFilePath", castedNode.SceneFilePath);
                castedNode.SceneFilePath = n82;
            }

            if (Owner is Godot.Node n83)
            {
                NodeStateManager.AddPropertyState(castedNode, "Owner", castedNode.Owner);
                castedNode.Owner = n83;
            }

            if (ProcessMode is Godot.Node.ProcessModeEnum n84)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessMode", castedNode.ProcessMode);
                castedNode.ProcessMode = n84;
            }

            if (ProcessPriority is System.Int32 n85)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPriority", castedNode.ProcessPriority);
                castedNode.ProcessPriority = n85;
            }

            if (ProcessPhysicsPriority is System.Int32 n86)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessPhysicsPriority", castedNode.ProcessPhysicsPriority);
                castedNode.ProcessPhysicsPriority = n86;
            }

            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n87)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroup", castedNode.ProcessThreadGroup);
                castedNode.ProcessThreadGroup = n87;
            }

            if (ProcessThreadGroupOrder is System.Int32 n88)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadGroupOrder", castedNode.ProcessThreadGroupOrder);
                castedNode.ProcessThreadGroupOrder = n88;
            }

            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n89)
            {
                NodeStateManager.AddPropertyState(castedNode, "ProcessThreadMessages", castedNode.ProcessThreadMessages);
                castedNode.ProcessThreadMessages = n89;
            }

            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n90)
            {
                NodeStateManager.AddPropertyState(castedNode, "PhysicsInterpolationMode", castedNode.PhysicsInterpolationMode);
                castedNode.PhysicsInterpolationMode = n90;
            }

            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n91)
            {
                NodeStateManager.AddPropertyState(castedNode, "AutoTranslateMode", castedNode.AutoTranslateMode);
                castedNode.AutoTranslateMode = n91;
            }

            if (EditorDescription is System.String n92)
            {
                NodeStateManager.AddPropertyState(castedNode, "EditorDescription", castedNode.EditorDescription);
                castedNode.EditorDescription = n92;
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