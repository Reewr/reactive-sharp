namespace ReactiveSharpGodot.Components
{
    public class TabBar : Control
    {
        public System.Int32? CurrentTab { protected get; init; }
        public Godot.TabBar.AlignmentMode? TabAlignment { protected get; init; }
        public System.Boolean? ClipTabs { protected get; init; }
        public Godot.TabBar.CloseButtonDisplayPolicy? TabCloseDisplayPolicy { protected get; init; }
        public System.Int32? MaxTabWidth { protected get; init; }
        public System.Boolean? ScrollingEnabled { protected get; init; }
        public System.Boolean? DragToRearrangeEnabled { protected get; init; }
        public System.Int32? TabsRearrangeGroup { protected get; init; }
        public System.Boolean? ScrollToSelected { protected get; init; }
        public System.Boolean? SelectWithRmb { protected get; init; }
        public System.Boolean? DeselectEnabled { protected get; init; }
        public System.Int32? TabCount { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GTabBar(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.TabBar)node.Node;
            base.UpdateProperties(node);
            if (CurrentTab is System.Int32 n0)
                castedNode.CurrentTab = n0;
            if (TabAlignment is Godot.TabBar.AlignmentMode n1)
                castedNode.TabAlignment = n1;
            if (ClipTabs is System.Boolean n2)
                castedNode.ClipTabs = n2;
            if (TabCloseDisplayPolicy is Godot.TabBar.CloseButtonDisplayPolicy n3)
                castedNode.TabCloseDisplayPolicy = n3;
            if (MaxTabWidth is System.Int32 n4)
                castedNode.MaxTabWidth = n4;
            if (ScrollingEnabled is System.Boolean n5)
                castedNode.ScrollingEnabled = n5;
            if (DragToRearrangeEnabled is System.Boolean n6)
                castedNode.DragToRearrangeEnabled = n6;
            if (TabsRearrangeGroup is System.Int32 n7)
                castedNode.TabsRearrangeGroup = n7;
            if (ScrollToSelected is System.Boolean n8)
                castedNode.ScrollToSelected = n8;
            if (SelectWithRmb is System.Boolean n9)
                castedNode.SelectWithRmb = n9;
            if (DeselectEnabled is System.Boolean n10)
                castedNode.DeselectEnabled = n10;
            if (TabCount is System.Int32 n11)
                castedNode.TabCount = n11;
        }
    }
}