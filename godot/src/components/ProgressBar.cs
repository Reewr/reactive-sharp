namespace ReactiveSharpGodot.Components
{
    public class ProgressBar : Range
    {
        public System.Int32? FillMode { protected get; init; }
        public System.Boolean? ShowPercentage { protected get; init; }
        public System.Boolean? Indeterminate { protected get; init; }
        public System.Boolean? EditorPreviewIndeterminate { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.INode> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GProgressBar(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.ProgressBar)node.Node;
            base.UpdateProperties(node);
            if (FillMode is System.Int32 n0)
                castedNode.FillMode = n0;
            if (ShowPercentage is System.Boolean n1)
                castedNode.ShowPercentage = n1;
            if (Indeterminate is System.Boolean n2)
                castedNode.Indeterminate = n2;
            if (EditorPreviewIndeterminate is System.Boolean n3)
                castedNode.EditorPreviewIndeterminate = n3;
        }
    }
}
