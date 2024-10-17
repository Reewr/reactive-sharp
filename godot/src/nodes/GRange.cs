namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GRange : Godot.Range, ReactiveSharpGodot.IGNode<Godot.Range>
    {
        public Godot.Node Node => this;
    }
}