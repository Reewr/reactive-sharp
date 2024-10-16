namespace ReactiveSharpGodot.Components
{
    public class SpinBox : Range
    {
        public Godot.HorizontalAlignment? Alignment { protected get; init; }
        public System.Boolean? Editable { protected get; init; }
        public System.Boolean? UpdateOnTextChanged { protected get; init; }
        public System.String? Prefix { protected get; init; }
        public System.String? Suffix { protected get; init; }
        public System.Double? CustomArrowStep { protected get; init; }
        public System.Boolean? SelectAllOnFocus { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.INode> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GSpinBox(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.SpinBox)node.Node;
            base.UpdateProperties(node);
            if (Alignment is Godot.HorizontalAlignment n0)
                castedNode.Alignment = n0;
            if (Editable is System.Boolean n1)
                castedNode.Editable = n1;
            if (UpdateOnTextChanged is System.Boolean n2)
                castedNode.UpdateOnTextChanged = n2;
            if (Prefix is System.String n3)
                castedNode.Prefix = n3;
            if (Suffix is System.String n4)
                castedNode.Suffix = n4;
            if (CustomArrowStep is System.Double n5)
                castedNode.CustomArrowStep = n5;
            if (SelectAllOnFocus is System.Boolean n6)
                castedNode.SelectAllOnFocus = n6;
        }
    }
}
