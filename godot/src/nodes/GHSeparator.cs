namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GHSeparator : Godot.HSeparator, ReactiveSharpGodot.IGNode<Godot.HSeparator>
    {
        public Godot.Node Node => this;
    }
}