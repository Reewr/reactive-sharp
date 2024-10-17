namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GButton : Godot.Button, ReactiveSharpGodot.IGNode<Godot.Button>
    {
        public Godot.Node Node => this;
    }
}