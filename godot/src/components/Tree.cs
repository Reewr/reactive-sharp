namespace ReactiveSharpGodot.Components
{
    public class Tree : Control
    {
        public System.Int32? Columns { protected get; init; }
        public System.Boolean? ColumnTitlesVisible { protected get; init; }
        public System.Boolean? AllowReselect { protected get; init; }
        public System.Boolean? AllowRmbSelect { protected get; init; }
        public System.Boolean? AllowSearch { protected get; init; }
        public System.Boolean? HideFolding { protected get; init; }
        public System.Boolean? EnableRecursiveFolding { protected get; init; }
        public System.Boolean? HideRoot { protected get; init; }
        public System.Int32? DropModeFlags { protected get; init; }
        public Godot.Tree.SelectModeEnum? SelectMode { protected get; init; }
        public System.Boolean? ScrollHorizontalEnabled { protected get; init; }
        public System.Boolean? ScrollVerticalEnabled { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GTree(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.Tree)node.Node;
            base.UpdateProperties(node);
            if (Columns is System.Int32 n0)
                castedNode.Columns = n0;
            if (ColumnTitlesVisible is System.Boolean n1)
                castedNode.ColumnTitlesVisible = n1;
            if (AllowReselect is System.Boolean n2)
                castedNode.AllowReselect = n2;
            if (AllowRmbSelect is System.Boolean n3)
                castedNode.AllowRmbSelect = n3;
            if (AllowSearch is System.Boolean n4)
                castedNode.AllowSearch = n4;
            if (HideFolding is System.Boolean n5)
                castedNode.HideFolding = n5;
            if (EnableRecursiveFolding is System.Boolean n6)
                castedNode.EnableRecursiveFolding = n6;
            if (HideRoot is System.Boolean n7)
                castedNode.HideRoot = n7;
            if (DropModeFlags is System.Int32 n8)
                castedNode.DropModeFlags = n8;
            if (SelectMode is Godot.Tree.SelectModeEnum n9)
                castedNode.SelectMode = n9;
            if (ScrollHorizontalEnabled is System.Boolean n10)
                castedNode.ScrollHorizontalEnabled = n10;
            if (ScrollVerticalEnabled is System.Boolean n11)
                castedNode.ScrollVerticalEnabled = n11;
        }
    }
}