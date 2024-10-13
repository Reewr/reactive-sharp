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
        public System.Action? ItemSelected { protected get; init; }
        public System.Action? CellSelected { protected get; init; }
        public Godot.Tree.MultiSelectedEventHandler? MultiSelected { protected get; init; }
        public Godot.Tree.ItemMouseSelectedEventHandler? ItemMouseSelected { protected get; init; }
        public Godot.Tree.EmptyClickedEventHandler? EmptyClicked { protected get; init; }
        public System.Action? ItemEdited { protected get; init; }
        public Godot.Tree.CustomItemClickedEventHandler? CustomItemClicked { protected get; init; }
        public System.Action? ItemIconDoubleClicked { protected get; init; }
        public Godot.Tree.ItemCollapsedEventHandler? ItemCollapsed { protected get; init; }
        public Godot.Tree.CheckPropagatedToItemEventHandler? CheckPropagatedToItem { protected get; init; }
        public Godot.Tree.ButtonClickedEventHandler? ButtonClicked { protected get; init; }
        public Godot.Tree.CustomPopupEditedEventHandler? CustomPopupEdited { protected get; init; }
        public System.Action? ItemActivated { protected get; init; }
        public Godot.Tree.ColumnTitleClickedEventHandler? ColumnTitleClicked { protected get; init; }
        public System.Action? NothingSelected { protected get; init; }

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
            if (ItemSelected is System.Action e0)
                castedNode.ItemSelected += e0;
            if (CellSelected is System.Action e1)
                castedNode.CellSelected += e1;
            if (MultiSelected is Godot.Tree.MultiSelectedEventHandler e2)
                castedNode.MultiSelected += e2;
            if (ItemMouseSelected is Godot.Tree.ItemMouseSelectedEventHandler e3)
                castedNode.ItemMouseSelected += e3;
            if (EmptyClicked is Godot.Tree.EmptyClickedEventHandler e4)
                castedNode.EmptyClicked += e4;
            if (ItemEdited is System.Action e5)
                castedNode.ItemEdited += e5;
            if (CustomItemClicked is Godot.Tree.CustomItemClickedEventHandler e6)
                castedNode.CustomItemClicked += e6;
            if (ItemIconDoubleClicked is System.Action e7)
                castedNode.ItemIconDoubleClicked += e7;
            if (ItemCollapsed is Godot.Tree.ItemCollapsedEventHandler e8)
                castedNode.ItemCollapsed += e8;
            if (CheckPropagatedToItem is Godot.Tree.CheckPropagatedToItemEventHandler e9)
                castedNode.CheckPropagatedToItem += e9;
            if (ButtonClicked is Godot.Tree.ButtonClickedEventHandler e10)
                castedNode.ButtonClicked += e10;
            if (CustomPopupEdited is Godot.Tree.CustomPopupEditedEventHandler e11)
                castedNode.CustomPopupEdited += e11;
            if (ItemActivated is System.Action e12)
                castedNode.ItemActivated += e12;
            if (ColumnTitleClicked is Godot.Tree.ColumnTitleClickedEventHandler e13)
                castedNode.ColumnTitleClicked += e13;
            if (NothingSelected is System.Action e14)
                castedNode.NothingSelected += e14;
        }
    }
}