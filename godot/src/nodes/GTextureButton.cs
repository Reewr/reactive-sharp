namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GTextureButton : Godot.TextureButton, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}