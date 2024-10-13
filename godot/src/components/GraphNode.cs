namespace ReactiveSharpGodot.Components
{
    public class GraphNode : GraphElement
    {
        public System.String? Title { protected get; init; }
        public System.Boolean? IgnoreInvalidConnectionType { protected get; init; }
        public System.Action? CloseRequest { protected get; init; }
        public Godot.GraphNode.SlotUpdatedEventHandler? SlotUpdated { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GGraphNode(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.GraphNode)node.Node;
            base.UpdateProperties(node);
            if (Title is System.String n0)
                castedNode.Title = n0;
            if (IgnoreInvalidConnectionType is System.Boolean n1)
                castedNode.IgnoreInvalidConnectionType = n1;
            if (CloseRequest is System.Action e0)
                castedNode.CloseRequest += e0;
            if (SlotUpdated is Godot.GraphNode.SlotUpdatedEventHandler e1)
                castedNode.SlotUpdated += e1;
        }
    }
}