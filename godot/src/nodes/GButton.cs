namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GButton : Godot.Button, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}