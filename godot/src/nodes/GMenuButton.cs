namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GMenuButton : Godot.MenuButton, ReactiveSharpGodot.IGNode<Godot.MenuButton>
    {
        public Godot.Node Node => this;
    }
}