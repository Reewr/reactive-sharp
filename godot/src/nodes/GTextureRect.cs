namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GTextureRect : Godot.TextureRect, ReactiveSharpGodot.IGNode<Godot.TextureRect>
    {
        public Godot.Node Node => this;
    }
}