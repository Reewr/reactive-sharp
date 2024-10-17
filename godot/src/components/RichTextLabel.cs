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
                castedNode.BbcodeEnabled = n0;
            if (Text is System.String n1)
                castedNode.Text = n1;
            if (FitContent is System.Boolean n2)
                castedNode.FitContent = n2;
            if (ScrollActive is System.Boolean n3)
                castedNode.ScrollActive = n3;
            if (ScrollFollowing is System.Boolean n4)
                castedNode.ScrollFollowing = n4;
            if (AutowrapMode is Godot.TextServer.AutowrapMode n5)
                castedNode.AutowrapMode = n5;
            if (TabSize is System.Int32 n6)
                castedNode.TabSize = n6;
            if (ContextMenuEnabled is System.Boolean n7)
                castedNode.ContextMenuEnabled = n7;
            if (ShortcutKeysEnabled is System.Boolean n8)
                castedNode.ShortcutKeysEnabled = n8;
            if (CustomEffects is Godot.Collections.Array n9)
                castedNode.CustomEffects = n9;
            if (MetaUnderlined is System.Boolean n10)
                castedNode.MetaUnderlined = n10;
            if (HintUnderlined is System.Boolean n11)
                castedNode.HintUnderlined = n11;
            if (Threaded is System.Boolean n12)
                castedNode.Threaded = n12;
            if (ProgressBarDelay is System.Int32 n13)
                castedNode.ProgressBarDelay = n13;
            if (SelectionEnabled is System.Boolean n14)
                castedNode.SelectionEnabled = n14;
            if (DeselectOnFocusLossEnabled is System.Boolean n15)
                castedNode.DeselectOnFocusLossEnabled = n15;
            if (DragAndDropSelectionEnabled is System.Boolean n16)
                castedNode.DragAndDropSelectionEnabled = n16;
            if (VisibleCharacters is System.Int32 n17)
                castedNode.VisibleCharacters = n17;
            if (VisibleCharactersBehavior is Godot.TextServer.VisibleCharactersBehavior n18)
                castedNode.VisibleCharactersBehavior = n18;
            if (VisibleRatio is System.Single n19)
                castedNode.VisibleRatio = n19;
            if (TextDirection is Godot.Control.TextDirection n20)
                castedNode.TextDirection = n20;
            if (Language is System.String n21)
                castedNode.Language = n21;
            if (StructuredTextBidiOverride is Godot.TextServer.StructuredTextParser n22)
                castedNode.StructuredTextBidiOverride = n22;
            if (StructuredTextBidiOverrideOptions is Godot.Collections.Array n23)
                castedNode.StructuredTextBidiOverrideOptions = n23;
            if (ClipContents is System.Boolean n24)
                castedNode.ClipContents = n24;
            if (CustomMinimumSize is Godot.Vector2 n25)
                castedNode.CustomMinimumSize = n25;
            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n26)
                castedNode.LayoutDirection = n26;
            if (LayoutMode is System.Int32 n27)
                castedNode.LayoutMode = n27;
            if (AnchorsPreset is System.Int32 n28)
                castedNode.AnchorsPreset = n28;
            if (AnchorLeft is System.Single n29)
                castedNode.AnchorLeft = n29;
            if (AnchorTop is System.Single n30)
                castedNode.AnchorTop = n30;
            if (AnchorRight is System.Single n31)
                castedNode.AnchorRight = n31;
            if (AnchorBottom is System.Single n32)
                castedNode.AnchorBottom = n32;
            if (OffsetLeft is System.Single n33)
                castedNode.OffsetLeft = n33;
            if (OffsetTop is System.Single n34)
                castedNode.OffsetTop = n34;
            if (OffsetRight is System.Single n35)
                castedNode.OffsetRight = n35;
            if (OffsetBottom is System.Single n36)
                castedNode.OffsetBottom = n36;
            if (GrowHorizontal is Godot.Control.GrowDirection n37)
                castedNode.GrowHorizontal = n37;
            if (GrowVertical is Godot.Control.GrowDirection n38)
                castedNode.GrowVertical = n38;
            if (Size is Godot.Vector2 n39)
                castedNode.Size = n39;
            if (Position is Godot.Vector2 n40)
                castedNode.Position = n40;
            if (GlobalPosition is Godot.Vector2 n41)
                castedNode.GlobalPosition = n41;
            if (Rotation is System.Single n42)
                castedNode.Rotation = n42;
            if (RotationDegrees is System.Single n43)
                castedNode.RotationDegrees = n43;
            if (Scale is Godot.Vector2 n44)
                castedNode.Scale = n44;
            if (PivotOffset is Godot.Vector2 n45)
                castedNode.PivotOffset = n45;
            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n46)
                castedNode.SizeFlagsHorizontal = n46;
            if (SizeFlagsVertical is Godot.Control.SizeFlags n47)
                castedNode.SizeFlagsVertical = n47;
            if (SizeFlagsStretchRatio is System.Single n48)
                castedNode.SizeFlagsStretchRatio = n48;
            if (LocalizeNumeralSystem is System.Boolean n49)
                castedNode.LocalizeNumeralSystem = n49;
            if (AutoTranslate is System.Boolean n50)
                castedNode.AutoTranslate = n50;
            if (TooltipText is System.String n51)
                castedNode.TooltipText = n51;
            if (FocusNeighborLeft is Godot.NodePath n52)
                castedNode.FocusNeighborLeft = n52;
            if (FocusNeighborTop is Godot.NodePath n53)
                castedNode.FocusNeighborTop = n53;
            if (FocusNeighborRight is Godot.NodePath n54)
                castedNode.FocusNeighborRight = n54;
            if (FocusNeighborBottom is Godot.NodePath n55)
                castedNode.FocusNeighborBottom = n55;
            if (FocusNext is Godot.NodePath n56)
                castedNode.FocusNext = n56;
            if (FocusPrevious is Godot.NodePath n57)
                castedNode.FocusPrevious = n57;
            if (FocusMode is Godot.Control.FocusModeEnum n58)
                castedNode.FocusMode = n58;
            if (MouseFilter is Godot.Control.MouseFilterEnum n59)
                castedNode.MouseFilter = n59;
            if (MouseForcePassScrollEvents is System.Boolean n60)
                castedNode.MouseForcePassScrollEvents = n60;
            if (MouseDefaultCursorShape is Godot.Control.CursorShape n61)
                castedNode.MouseDefaultCursorShape = n61;
            if (ShortcutContext is Godot.Node n62)
                castedNode.ShortcutContext = n62;
            if (Theme is Godot.Theme n63)
                castedNode.Theme = n63;
            if (ThemeTypeVariation is Godot.StringName n64)
                castedNode.ThemeTypeVariation = n64;
            if (Visible is System.Boolean n65)
                castedNode.Visible = n65;
            if (Modulate is Godot.Color n66)
                castedNode.Modulate = n66;
            if (SelfModulate is Godot.Color n67)
                castedNode.SelfModulate = n67;
            if (ShowBehindParent is System.Boolean n68)
                castedNode.ShowBehindParent = n68;
            if (TopLevel is System.Boolean n69)
                castedNode.TopLevel = n69;
            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n70)
                castedNode.ClipChildren = n70;
            if (LightMask is System.Int32 n71)
                castedNode.LightMask = n71;
            if (VisibilityLayer is System.UInt32 n72)
                castedNode.VisibilityLayer = n72;
            if (ZIndex is System.Int32 n73)
                castedNode.ZIndex = n73;
            if (ZAsRelative is System.Boolean n74)
                castedNode.ZAsRelative = n74;
            if (YSortEnabled is System.Boolean n75)
                castedNode.YSortEnabled = n75;
            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n76)
                castedNode.TextureFilter = n76;
            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n77)
                castedNode.TextureRepeat = n77;
            if (Material is Godot.Material n78)
                castedNode.Material = n78;
            if (UseParentMaterial is System.Boolean n79)
                castedNode.UseParentMaterial = n79;
            if (Name is Godot.StringName n80)
                castedNode.Name = n80;
            if (UniqueNameInOwner is System.Boolean n81)
                castedNode.UniqueNameInOwner = n81;
            if (SceneFilePath is System.String n82)
                castedNode.SceneFilePath = n82;
            if (Owner is Godot.Node n83)
                castedNode.Owner = n83;
            if (ProcessMode is Godot.Node.ProcessModeEnum n84)
                castedNode.ProcessMode = n84;
            if (ProcessPriority is System.Int32 n85)
                castedNode.ProcessPriority = n85;
            if (ProcessPhysicsPriority is System.Int32 n86)
                castedNode.ProcessPhysicsPriority = n86;
            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n87)
                castedNode.ProcessThreadGroup = n87;
            if (ProcessThreadGroupOrder is System.Int32 n88)
                castedNode.ProcessThreadGroupOrder = n88;
            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n89)
                castedNode.ProcessThreadMessages = n89;
            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n90)
                castedNode.PhysicsInterpolationMode = n90;
            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n91)
                castedNode.AutoTranslateMode = n91;
            if (EditorDescription is System.String n92)
                castedNode.EditorDescription = n92;
            if (MetaClicked is Godot.RichTextLabel.MetaClickedEventHandler e0)
                castedNode.MetaClicked += e0;
            if (MetaHoverStarted is Godot.RichTextLabel.MetaHoverStartedEventHandler e1)
                castedNode.MetaHoverStarted += e1;
            if (MetaHoverEnded is Godot.RichTextLabel.MetaHoverEndedEventHandler e2)
                castedNode.MetaHoverEnded += e2;
            if (Finished is System.Action e3)
                castedNode.Finished += e3;
            if (Resized is System.Action e4)
                castedNode.Resized += e4;
            if (GuiInput is Godot.Control.GuiInputEventHandler e5)
                castedNode.GuiInput += e5;
            if (MouseEntered is System.Action e6)
                castedNode.MouseEntered += e6;
            if (MouseExited is System.Action e7)
                castedNode.MouseExited += e7;
            if (FocusEntered is System.Action e8)
                castedNode.FocusEntered += e8;
            if (FocusExited is System.Action e9)
                castedNode.FocusExited += e9;
            if (SizeFlagsChanged is System.Action e10)
                castedNode.SizeFlagsChanged += e10;
            if (MinimumSizeChanged is System.Action e11)
                castedNode.MinimumSizeChanged += e11;
            if (ThemeChanged is System.Action e12)
                castedNode.ThemeChanged += e12;
            if (Draw is System.Action e13)
                castedNode.Draw += e13;
            if (VisibilityChanged is System.Action e14)
                castedNode.VisibilityChanged += e14;
            if (Hidden is System.Action e15)
                castedNode.Hidden += e15;
            if (ItemRectChanged is System.Action e16)
                castedNode.ItemRectChanged += e16;
            if (Ready is System.Action e17)
                castedNode.Ready += e17;
            if (Renamed is System.Action e18)
                castedNode.Renamed += e18;
            if (TreeEntered is System.Action e19)
                castedNode.TreeEntered += e19;
            if (TreeExiting is System.Action e20)
                castedNode.TreeExiting += e20;
            if (TreeExited is System.Action e21)
                castedNode.TreeExited += e21;
            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e22)
                castedNode.ChildEnteredTree += e22;
            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e23)
                castedNode.ChildExitingTree += e23;
            if (ChildOrderChanged is System.Action e24)
                castedNode.ChildOrderChanged += e24;
            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e25)
                castedNode.ReplacingBy += e25;
            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e26)
                castedNode.EditorDescriptionChanged += e26;
            if (ScriptChanged is System.Action e27)
                castedNode.ScriptChanged += e27;
            if (PropertyListChanged is System.Action e28)
                castedNode.PropertyListChanged += e28;
        }
    }
}