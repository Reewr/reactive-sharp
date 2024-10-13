namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GTextureProgressBar : Godot.TextureProgressBar, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}