namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GVSeparator : Godot.VSeparator, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}