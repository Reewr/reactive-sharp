namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GColorRect : Godot.ColorRect, ReactiveSharpGodot.IGNode<Godot.ColorRect>
    {
        public Godot.Node Node => this;
    }
}