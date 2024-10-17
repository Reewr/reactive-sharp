namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GLabel : Godot.Label, ReactiveSharpGodot.IGNode<Godot.Label>
    {
        public Godot.Node Node => this;
    }
}