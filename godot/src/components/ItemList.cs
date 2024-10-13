namespace ReactiveSharpGodot.Components
{
    public class ItemList : Control
    {
        public Godot.ItemList.SelectModeEnum? SelectMode { protected get; init; }
        public System.Boolean? AllowReselect { protected get; init; }
        public System.Boolean? AllowRmbSelect { protected get; init; }
        public System.Boolean? AllowSearch { protected get; init; }
        public System.Int32? MaxTextLines { protected get; init; }
        public System.Boolean? AutoHeight { protected get; init; }
        public Godot.TextServer.OverrunBehavior? TextOverrunBehavior { protected get; init; }
        public System.Int32? ItemCount { protected get; init; }
        public System.Int32? MaxColumns { protected get; init; }
        public System.Boolean? SameColumnWidth { protected get; init; }
        public System.Int32? FixedColumnWidth { protected get; init; }
        public Godot.ItemList.IconModeEnum? IconMode { protected get; init; }
        public System.Single? IconScale { protected get; init; }
        public Godot.Vector2I? FixedIconSize { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GItemList(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.ItemList)node.Node;
            base.UpdateProperties(node);
            if (SelectMode is Godot.ItemList.SelectModeEnum n0)
                castedNode.SelectMode = n0;
            if (AllowReselect is System.Boolean n1)
                castedNode.AllowReselect = n1;
            if (AllowRmbSelect is System.Boolean n2)
                castedNode.AllowRmbSelect = n2;
            if (AllowSearch is System.Boolean n3)
                castedNode.AllowSearch = n3;
            if (MaxTextLines is System.Int32 n4)
                castedNode.MaxTextLines = n4;
            if (AutoHeight is System.Boolean n5)
                castedNode.AutoHeight = n5;
            if (TextOverrunBehavior is Godot.TextServer.OverrunBehavior n6)
                castedNode.TextOverrunBehavior = n6;
            if (ItemCount is System.Int32 n7)
                castedNode.ItemCount = n7;
            if (MaxColumns is System.Int32 n8)
                castedNode.MaxColumns = n8;
            if (SameColumnWidth is System.Boolean n9)
                castedNode.SameColumnWidth = n9;
            if (FixedColumnWidth is System.Int32 n10)
                castedNode.FixedColumnWidth = n10;
            if (IconMode is Godot.ItemList.IconModeEnum n11)
                castedNode.IconMode = n11;
            if (IconScale is System.Single n12)
                castedNode.IconScale = n12;
            if (FixedIconSize is Godot.Vector2I n13)
                castedNode.FixedIconSize = n13;
        }
    }
}