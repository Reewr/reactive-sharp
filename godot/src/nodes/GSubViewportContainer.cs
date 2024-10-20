namespace ReactiveSharpGodot.Nodes
{
    public class GSubViewportContainer : Godot.SubViewportContainer, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}