namespace ReactiveSharpGodot.Components
{
    public class Label : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GLabel>
    {
        public System.String? Text { protected get; init; }
        public Godot.LabelSettings? LabelSettings { protected get; init; }
        public Godot.HorizontalAlignment? HorizontalAlignment { protected get; init; }
        public Godot.VerticalAlignment? VerticalAlignment { protected get; init; }
        public Godot.TextServer.AutowrapMode? AutowrapMode { protected get; init; }
        public Godot.TextServer.JustificationFlag? JustificationFlags { protected get; init; }
        public System.Boolean? ClipText { protected get; init; }
        public Godot.TextServer.OverrunBehavior? TextOverrunBehavior { protected get; init; }
        public System.String? EllipsisChar { protected get; init; }
        public System.Boolean? Uppercase { protected get; init; }
        public System.Single[]? TabStops { protected get; init; }
        public System.Int32? LinesSkipped { protected get; init; }
        public System.Int32? MaxLinesVisible { protected get; init; }
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

        public override ReactiveSharpGodot.Nodes.GLabel Build(List<ReactiveSharp.INode> builtChildren)
        {
            var node = new ReactiveSharpGodot.Nodes.GLabel();
            var igNode = (ReactiveSharp.INode)node;
            UpdateProperties(node);
            foreach (var child in builtChildren)
                igNode.AddChild(child);
            return node;
        }

        public override void UpdateProperties(ReactiveSharpGodot.Nodes.GLabel node)
        {
            var castedNode = (Godot.Label)node.Node;
            if (Text is System.String n0)
                castedNode.Text = n0;
            if (LabelSettings is Godot.LabelSettings n1)
                castedNode.LabelSettings = n1;
            if (HorizontalAlignment is Godot.HorizontalAlignment n2)
                castedNode.HorizontalAlignment = n2;
            if (VerticalAlignment is Godot.VerticalAlignment n3)
                castedNode.VerticalAlignment = n3;
            if (AutowrapMode is Godot.TextServer.AutowrapMode n4)
                castedNode.AutowrapMode = n4;
            if (JustificationFlags is Godot.TextServer.JustificationFlag n5)
                castedNode.JustificationFlags = n5;
            if (ClipText is System.Boolean n6)
                castedNode.ClipText = n6;
            if (TextOverrunBehavior is Godot.TextServer.OverrunBehavior n7)
                castedNode.TextOverrunBehavior = n7;
            if (EllipsisChar is System.String n8)
                castedNode.EllipsisChar = n8;
            if (Uppercase is System.Boolean n9)
                castedNode.Uppercase = n9;
            if (TabStops is System.Single[] n10)
                castedNode.TabStops = n10;
            if (LinesSkipped is System.Int32 n11)
                castedNode.LinesSkipped = n11;
            if (MaxLinesVisible is System.Int32 n12)
                castedNode.MaxLinesVisible = n12;
            if (VisibleCharacters is System.Int32 n13)
                castedNode.VisibleCharacters = n13;
            if (VisibleCharactersBehavior is Godot.TextServer.VisibleCharactersBehavior n14)
                castedNode.VisibleCharactersBehavior = n14;
            if (VisibleRatio is System.Single n15)
                castedNode.VisibleRatio = n15;
            if (TextDirection is Godot.Control.TextDirection n16)
                castedNode.TextDirection = n16;
            if (Language is System.String n17)
                castedNode.Language = n17;
            if (StructuredTextBidiOverride is Godot.TextServer.StructuredTextParser n18)
                castedNode.StructuredTextBidiOverride = n18;
            if (StructuredTextBidiOverrideOptions is Godot.Collections.Array n19)
                castedNode.StructuredTextBidiOverrideOptions = n19;
            if (ClipContents is System.Boolean n20)
                castedNode.ClipContents = n20;
            if (CustomMinimumSize is Godot.Vector2 n21)
                castedNode.CustomMinimumSize = n21;
            if (LayoutDirection is Godot.Control.LayoutDirectionEnum n22)
                castedNode.LayoutDirection = n22;
            if (LayoutMode is System.Int32 n23)
                castedNode.LayoutMode = n23;
            if (AnchorsPreset is System.Int32 n24)
                castedNode.AnchorsPreset = n24;
            if (AnchorLeft is System.Single n25)
                castedNode.AnchorLeft = n25;
            if (AnchorTop is System.Single n26)
                castedNode.AnchorTop = n26;
            if (AnchorRight is System.Single n27)
                castedNode.AnchorRight = n27;
            if (AnchorBottom is System.Single n28)
                castedNode.AnchorBottom = n28;
            if (OffsetLeft is System.Single n29)
                castedNode.OffsetLeft = n29;
            if (OffsetTop is System.Single n30)
                castedNode.OffsetTop = n30;
            if (OffsetRight is System.Single n31)
                castedNode.OffsetRight = n31;
            if (OffsetBottom is System.Single n32)
                castedNode.OffsetBottom = n32;
            if (GrowHorizontal is Godot.Control.GrowDirection n33)
                castedNode.GrowHorizontal = n33;
            if (GrowVertical is Godot.Control.GrowDirection n34)
                castedNode.GrowVertical = n34;
            if (Size is Godot.Vector2 n35)
                castedNode.Size = n35;
            if (Position is Godot.Vector2 n36)
                castedNode.Position = n36;
            if (GlobalPosition is Godot.Vector2 n37)
                castedNode.GlobalPosition = n37;
            if (Rotation is System.Single n38)
                castedNode.Rotation = n38;
            if (RotationDegrees is System.Single n39)
                castedNode.RotationDegrees = n39;
            if (Scale is Godot.Vector2 n40)
                castedNode.Scale = n40;
            if (PivotOffset is Godot.Vector2 n41)
                castedNode.PivotOffset = n41;
            if (SizeFlagsHorizontal is Godot.Control.SizeFlags n42)
                castedNode.SizeFlagsHorizontal = n42;
            if (SizeFlagsVertical is Godot.Control.SizeFlags n43)
                castedNode.SizeFlagsVertical = n43;
            if (SizeFlagsStretchRatio is System.Single n44)
                castedNode.SizeFlagsStretchRatio = n44;
            if (LocalizeNumeralSystem is System.Boolean n45)
                castedNode.LocalizeNumeralSystem = n45;
            if (AutoTranslate is System.Boolean n46)
                castedNode.AutoTranslate = n46;
            if (TooltipText is System.String n47)
                castedNode.TooltipText = n47;
            if (FocusNeighborLeft is Godot.NodePath n48)
                castedNode.FocusNeighborLeft = n48;
            if (FocusNeighborTop is Godot.NodePath n49)
                castedNode.FocusNeighborTop = n49;
            if (FocusNeighborRight is Godot.NodePath n50)
                castedNode.FocusNeighborRight = n50;
            if (FocusNeighborBottom is Godot.NodePath n51)
                castedNode.FocusNeighborBottom = n51;
            if (FocusNext is Godot.NodePath n52)
                castedNode.FocusNext = n52;
            if (FocusPrevious is Godot.NodePath n53)
                castedNode.FocusPrevious = n53;
            if (FocusMode is Godot.Control.FocusModeEnum n54)
                castedNode.FocusMode = n54;
            if (MouseFilter is Godot.Control.MouseFilterEnum n55)
                castedNode.MouseFilter = n55;
            if (MouseForcePassScrollEvents is System.Boolean n56)
                castedNode.MouseForcePassScrollEvents = n56;
            if (MouseDefaultCursorShape is Godot.Control.CursorShape n57)
                castedNode.MouseDefaultCursorShape = n57;
            if (ShortcutContext is Godot.Node n58)
                castedNode.ShortcutContext = n58;
            if (Theme is Godot.Theme n59)
                castedNode.Theme = n59;
            if (ThemeTypeVariation is Godot.StringName n60)
                castedNode.ThemeTypeVariation = n60;
            if (Visible is System.Boolean n61)
                castedNode.Visible = n61;
            if (Modulate is Godot.Color n62)
                castedNode.Modulate = n62;
            if (SelfModulate is Godot.Color n63)
                castedNode.SelfModulate = n63;
            if (ShowBehindParent is System.Boolean n64)
                castedNode.ShowBehindParent = n64;
            if (TopLevel is System.Boolean n65)
                castedNode.TopLevel = n65;
            if (ClipChildren is Godot.CanvasItem.ClipChildrenMode n66)
                castedNode.ClipChildren = n66;
            if (LightMask is System.Int32 n67)
                castedNode.LightMask = n67;
            if (VisibilityLayer is System.UInt32 n68)
                castedNode.VisibilityLayer = n68;
            if (ZIndex is System.Int32 n69)
                castedNode.ZIndex = n69;
            if (ZAsRelative is System.Boolean n70)
                castedNode.ZAsRelative = n70;
            if (YSortEnabled is System.Boolean n71)
                castedNode.YSortEnabled = n71;
            if (TextureFilter is Godot.CanvasItem.TextureFilterEnum n72)
                castedNode.TextureFilter = n72;
            if (TextureRepeat is Godot.CanvasItem.TextureRepeatEnum n73)
                castedNode.TextureRepeat = n73;
            if (Material is Godot.Material n74)
                castedNode.Material = n74;
            if (UseParentMaterial is System.Boolean n75)
                castedNode.UseParentMaterial = n75;
            if (Name is Godot.StringName n76)
                castedNode.Name = n76;
            if (UniqueNameInOwner is System.Boolean n77)
                castedNode.UniqueNameInOwner = n77;
            if (SceneFilePath is System.String n78)
                castedNode.SceneFilePath = n78;
            if (Owner is Godot.Node n79)
                castedNode.Owner = n79;
            if (ProcessMode is Godot.Node.ProcessModeEnum n80)
                castedNode.ProcessMode = n80;
            if (ProcessPriority is System.Int32 n81)
                castedNode.ProcessPriority = n81;
            if (ProcessPhysicsPriority is System.Int32 n82)
                castedNode.ProcessPhysicsPriority = n82;
            if (ProcessThreadGroup is Godot.Node.ProcessThreadGroupEnum n83)
                castedNode.ProcessThreadGroup = n83;
            if (ProcessThreadGroupOrder is System.Int32 n84)
                castedNode.ProcessThreadGroupOrder = n84;
            if (ProcessThreadMessages is Godot.Node.ProcessThreadMessagesEnum n85)
                castedNode.ProcessThreadMessages = n85;
            if (PhysicsInterpolationMode is Godot.Node.PhysicsInterpolationModeEnum n86)
                castedNode.PhysicsInterpolationMode = n86;
            if (AutoTranslateMode is Godot.Node.AutoTranslateModeEnum n87)
                castedNode.AutoTranslateMode = n87;
            if (EditorDescription is System.String n88)
                castedNode.EditorDescription = n88;
            if (Resized is System.Action e0)
                castedNode.Resized += e0;
            if (GuiInput is Godot.Control.GuiInputEventHandler e1)
                castedNode.GuiInput += e1;
            if (MouseEntered is System.Action e2)
                castedNode.MouseEntered += e2;
            if (MouseExited is System.Action e3)
                castedNode.MouseExited += e3;
            if (FocusEntered is System.Action e4)
                castedNode.FocusEntered += e4;
            if (FocusExited is System.Action e5)
                castedNode.FocusExited += e5;
            if (SizeFlagsChanged is System.Action e6)
                castedNode.SizeFlagsChanged += e6;
            if (MinimumSizeChanged is System.Action e7)
                castedNode.MinimumSizeChanged += e7;
            if (ThemeChanged is System.Action e8)
                castedNode.ThemeChanged += e8;
            if (Draw is System.Action e9)
                castedNode.Draw += e9;
            if (VisibilityChanged is System.Action e10)
                castedNode.VisibilityChanged += e10;
            if (Hidden is System.Action e11)
                castedNode.Hidden += e11;
            if (ItemRectChanged is System.Action e12)
                castedNode.ItemRectChanged += e12;
            if (Ready is System.Action e13)
                castedNode.Ready += e13;
            if (Renamed is System.Action e14)
                castedNode.Renamed += e14;
            if (TreeEntered is System.Action e15)
                castedNode.TreeEntered += e15;
            if (TreeExiting is System.Action e16)
                castedNode.TreeExiting += e16;
            if (TreeExited is System.Action e17)
                castedNode.TreeExited += e17;
            if (ChildEnteredTree is Godot.Node.ChildEnteredTreeEventHandler e18)
                castedNode.ChildEnteredTree += e18;
            if (ChildExitingTree is Godot.Node.ChildExitingTreeEventHandler e19)
                castedNode.ChildExitingTree += e19;
            if (ChildOrderChanged is System.Action e20)
                castedNode.ChildOrderChanged += e20;
            if (ReplacingBy is Godot.Node.ReplacingByEventHandler e21)
                castedNode.ReplacingBy += e21;
            if (EditorDescriptionChanged is Godot.Node.EditorDescriptionChangedEventHandler e22)
                castedNode.EditorDescriptionChanged += e22;
            if (ScriptChanged is System.Action e23)
                castedNode.ScriptChanged += e23;
            if (PropertyListChanged is System.Action e24)
                castedNode.PropertyListChanged += e24;
        }
    }
}