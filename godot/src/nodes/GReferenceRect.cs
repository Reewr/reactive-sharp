namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GReferenceRect : Godot.ReferenceRect, ReactiveSharpGodot.IGNode<Godot.ReferenceRect>
    {
        public Godot.Node Node => this;
    }
}