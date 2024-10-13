namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GReferenceRect : Godot.ReferenceRect, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}