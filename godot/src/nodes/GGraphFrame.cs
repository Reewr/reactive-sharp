namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GGraphFrame : Godot.GraphFrame, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}