namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GVideoStreamPlayer : Godot.VideoStreamPlayer, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}