namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GGraphElement : Godot.GraphElement, ReactiveSharpGodot.IGNode<Godot.GraphElement>
    {
        public Godot.Node Node => this;
    }
}