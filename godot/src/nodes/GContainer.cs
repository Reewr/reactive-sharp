namespace ReactiveSharpGodot.Nodes
{
    public class GContainer : Godot.Container, ReactiveSharpGodot.IGNode<Godot.Container>
    {
        public Godot.Node Node => this;
    }
}