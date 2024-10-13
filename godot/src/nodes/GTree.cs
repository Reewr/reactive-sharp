namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GTree : Godot.Tree, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}