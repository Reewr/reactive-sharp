namespace ReactiveSharpGodot.Nodes
{
    public class GVideoStreamPlayer : Godot.VideoStreamPlayer, ReactiveSharpGodot.IGNode<Godot.VideoStreamPlayer>
    {
        public Godot.Node Node => this;
    }
}