namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GHBoxContainer : Godot.HBoxContainer, ReactiveSharpGodot.IGNode<Godot.HBoxContainer>
    {
        public Godot.Node Node => this;
    }
}