namespace ReactiveSharpGodot.Components
{
    public class Range : Control
    {
        public System.Double? MinValue { protected get; init; }
        public System.Double? MaxValue { protected get; init; }
        public System.Double? Step { protected get; init; }
        public System.Double? Page { protected get; init; }
        public System.Double? Value { protected get; init; }
        public System.Double? Ratio { protected get; init; }
        public System.Boolean? ExpEdit { protected get; init; }
        public System.Boolean? Rounded { protected get; init; }
        public System.Boolean? AllowGreater { protected get; init; }
        public System.Boolean? AllowLesser { protected get; init; }
        public Godot.Range.ValueChangedEventHandler? ValueChanged { protected get; init; }
        public System.Action? Changed { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GRange(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.Range)node.Node;
            base.UpdateProperties(node);
            if (MinValue is System.Double n0)
                castedNode.MinValue = n0;
            if (MaxValue is System.Double n1)
                castedNode.MaxValue = n1;
            if (Step is System.Double n2)
                castedNode.Step = n2;
            if (Page is System.Double n3)
                castedNode.Page = n3;
            if (Value is System.Double n4)
                castedNode.Value = n4;
            if (Ratio is System.Double n5)
                castedNode.Ratio = n5;
            if (ExpEdit is System.Boolean n6)
                castedNode.ExpEdit = n6;
            if (Rounded is System.Boolean n7)
                castedNode.Rounded = n7;
            if (AllowGreater is System.Boolean n8)
                castedNode.AllowGreater = n8;
            if (AllowLesser is System.Boolean n9)
                castedNode.AllowLesser = n9;
            if (ValueChanged is Godot.Range.ValueChangedEventHandler e0)
                castedNode.ValueChanged += e0;
            if (Changed is System.Action e1)
                castedNode.Changed += e1;
        }
    }
}