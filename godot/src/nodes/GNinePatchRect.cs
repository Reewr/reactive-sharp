namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GNinePatchRect : Godot.NinePatchRect, ReactiveSharpGodot.IGNode<Godot.NinePatchRect>
    {
        public Godot.Node Node => this;
    }
}