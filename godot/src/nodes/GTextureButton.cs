namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GTextureButton : Godot.TextureButton, ReactiveSharpGodot.IGNode<Godot.TextureButton>
    {
        public Godot.Node Node => this;
    }
}