namespace ReactiveSharpGodot.Components
{
    public class MenuBar : Control
    {
        public System.Boolean? Flat { protected get; init; }
        public System.Int32? StartIndex { protected get; init; }
        public System.Boolean? SwitchOnHover { protected get; init; }
        public System.Boolean? PreferGlobalMenu { protected get; init; }
        public Godot.Control.TextDirection? TextDirection { protected get; init; }
        public System.String? Language { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GMenuBar(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.MenuBar)node.Node;
            base.UpdateProperties(node);
            if (Flat is System.Boolean n0)
                castedNode.Flat = n0;
            if (StartIndex is System.Int32 n1)
                castedNode.StartIndex = n1;
            if (SwitchOnHover is System.Boolean n2)
                castedNode.SwitchOnHover = n2;
            if (PreferGlobalMenu is System.Boolean n3)
                castedNode.PreferGlobalMenu = n3;
            if (TextDirection is Godot.Control.TextDirection n4)
                castedNode.TextDirection = n4;
            if (Language is System.String n5)
                castedNode.Language = n5;
        }
    }
}