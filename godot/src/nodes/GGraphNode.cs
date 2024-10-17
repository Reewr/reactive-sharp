namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GGraphNode : Godot.GraphNode, ReactiveSharpGodot.IGNode<Godot.GraphNode>
    {
        public Godot.Node Node => this;
    }
}