namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GControl : Godot.Control, ReactiveSharpGodot.IGNode<Godot.Control>
    {
        public Godot.Node Node => this;
    }
}