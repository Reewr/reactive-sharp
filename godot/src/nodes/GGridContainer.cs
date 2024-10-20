namespace ReactiveSharpGodot.Nodes
{
    public class GGridContainer : Godot.GridContainer, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}