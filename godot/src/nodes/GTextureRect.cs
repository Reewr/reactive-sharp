namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GTextureRect : Godot.TextureRect, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}