namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GControl : Godot.Control, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}