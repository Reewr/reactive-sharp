namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GVBoxContainer : Godot.VBoxContainer, ReactiveSharpGodot.IGNode<Godot.VBoxContainer>
    {
        public Godot.Node Node => this;
    }
}