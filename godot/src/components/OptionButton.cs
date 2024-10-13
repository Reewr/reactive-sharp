namespace ReactiveSharpGodot.Components
{
    public class OptionButton : Button
    {
        public System.Int32? Selected { protected get; init; }
        public System.Boolean? FitToLongestItem { protected get; init; }
        public System.Boolean? AllowReselect { protected get; init; }
        public System.Int32? ItemCount { protected get; init; }
        public Godot.OptionButton.ItemSelectedEventHandler? ItemSelected { protected get; init; }
        public Godot.OptionButton.ItemFocusedEventHandler? ItemFocused { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GOptionButton(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.OptionButton)node.Node;
            base.UpdateProperties(node);
            if (Selected is System.Int32 n0)
                castedNode.Selected = n0;
            if (FitToLongestItem is System.Boolean n1)
                castedNode.FitToLongestItem = n1;
            if (AllowReselect is System.Boolean n2)
                castedNode.AllowReselect = n2;
            if (ItemCount is System.Int32 n3)
                castedNode.ItemCount = n3;
            if (ItemSelected is Godot.OptionButton.ItemSelectedEventHandler e0)
                castedNode.ItemSelected += e0;
            if (ItemFocused is Godot.OptionButton.ItemFocusedEventHandler e1)
                castedNode.ItemFocused += e1;
        }
    }
}