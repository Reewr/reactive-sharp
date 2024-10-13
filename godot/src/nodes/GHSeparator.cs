namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GHSeparator : Godot.HSeparator, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}