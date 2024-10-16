namespace ReactiveSharpGodot.Components
{
    public class GridContainer : Container
    {
        public System.Int32? Columns { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.INode> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GGridContainer(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.GridContainer)node.Node;
            base.UpdateProperties(node);
            if (Columns is System.Int32 n0)
                castedNode.Columns = n0;
        }
    }
}
