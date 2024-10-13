namespace ReactiveSharpGodot.Components
{
    public class TabContainer : Container
    {
        public Godot.TabBar.AlignmentMode? TabAlignment { protected get; init; }
        public System.Int32? CurrentTab { protected get; init; }
        public Godot.TabContainer.TabPosition? TabsPosition { protected get; init; }
        public System.Boolean? ClipTabs { protected get; init; }
        public System.Boolean? TabsVisible { protected get; init; }
        public System.Boolean? AllTabsInFront { protected get; init; }
        public System.Boolean? DragToRearrangeEnabled { protected get; init; }
        public System.Int32? TabsRearrangeGroup { protected get; init; }
        public System.Boolean? UseHiddenTabsForMinSize { protected get; init; }
        public Godot.Control.FocusModeEnum? TabFocusMode { protected get; init; }
        public System.Boolean? DeselectEnabled { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GTabContainer(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.TabContainer)node.Node;
            base.UpdateProperties(node);
            if (TabAlignment is Godot.TabBar.AlignmentMode n0)
                castedNode.TabAlignment = n0;
            if (CurrentTab is System.Int32 n1)
                castedNode.CurrentTab = n1;
            if (TabsPosition is Godot.TabContainer.TabPosition n2)
                castedNode.TabsPosition = n2;
            if (ClipTabs is System.Boolean n3)
                castedNode.ClipTabs = n3;
            if (TabsVisible is System.Boolean n4)
                castedNode.TabsVisible = n4;
            if (AllTabsInFront is System.Boolean n5)
                castedNode.AllTabsInFront = n5;
            if (DragToRearrangeEnabled is System.Boolean n6)
                castedNode.DragToRearrangeEnabled = n6;
            if (TabsRearrangeGroup is System.Int32 n7)
                castedNode.TabsRearrangeGroup = n7;
            if (UseHiddenTabsForMinSize is System.Boolean n8)
                castedNode.UseHiddenTabsForMinSize = n8;
            if (TabFocusMode is Godot.Control.FocusModeEnum n9)
                castedNode.TabFocusMode = n9;
            if (DeselectEnabled is System.Boolean n10)
                castedNode.DeselectEnabled = n10;
        }
    }
}