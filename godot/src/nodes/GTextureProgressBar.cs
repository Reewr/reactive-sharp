namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GTextureProgressBar : Godot.TextureProgressBar, ReactiveSharpGodot.IGNode<Godot.TextureProgressBar>
    {
        public Godot.Node Node => this;
    }
}