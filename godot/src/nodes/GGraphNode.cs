namespace ReactiveSharpGodot.Nodes
{
    public class GGraphNode : Godot.GraphNode, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}