namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GMenuButton : Godot.MenuButton, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}