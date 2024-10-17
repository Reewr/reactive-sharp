namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GGraphFrame : Godot.GraphFrame, ReactiveSharpGodot.IGNode<Godot.GraphFrame>
    {
        public Godot.Node Node => this;
    }
}