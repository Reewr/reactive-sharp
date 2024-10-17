namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GVSeparator : Godot.VSeparator, ReactiveSharpGodot.IGNode<Godot.VSeparator>
    {
        public Godot.Node Node => this;
    }
}