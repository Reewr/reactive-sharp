namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GGraphElement : Godot.GraphElement, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}