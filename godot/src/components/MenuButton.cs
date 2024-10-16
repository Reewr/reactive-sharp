namespace ReactiveSharpGodot.Components
{
    public class MenuButton : Button
    {
        public System.Boolean? SwitchOnHover { protected get; init; }
        public System.Int32? ItemCount { protected get; init; }
        public System.Action? AboutToPopup { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.INode> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GMenuButton(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.MenuButton)node.Node;
            base.UpdateProperties(node);
            if (SwitchOnHover is System.Boolean n0)
                castedNode.SwitchOnHover = n0;
            if (ItemCount is System.Int32 n1)
                castedNode.ItemCount = n1;
            if (AboutToPopup is System.Action e0)
                castedNode.AboutToPopup += e0;
        }
    }
}
