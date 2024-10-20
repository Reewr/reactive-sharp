namespace ReactiveSharpGodot.Nodes
{
    public class GVideoStreamPlayer : Godot.VideoStreamPlayer, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}