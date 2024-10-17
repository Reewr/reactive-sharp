namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GMenuBar : Godot.MenuBar, ReactiveSharpGodot.IGNode<Godot.MenuBar>
    {
        public Godot.Node Node => this;
    }
}