namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GRange : Godot.Range, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}