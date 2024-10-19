namespace ReactiveSharpGodot.Nodes
{
    public class GTree : Godot.Tree, ReactiveSharpGodot.IGNode<Godot.Tree>
    {
        public Godot.Node Node => this;
    }
}