namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GLabel : Godot.Label, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}