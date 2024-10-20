namespace ReactiveSharpGodot.Nodes
{
    public class GContainer : Godot.Container, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}