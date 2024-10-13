namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GGraphNode : Godot.GraphNode, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}