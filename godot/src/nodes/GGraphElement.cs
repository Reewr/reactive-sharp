namespace ReactiveSharpGodot.Nodes
{
    public class GGraphElement : Godot.GraphElement, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}