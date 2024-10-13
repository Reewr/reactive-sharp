namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GColorRect : Godot.ColorRect, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}