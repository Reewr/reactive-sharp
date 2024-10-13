namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GMenuBar : Godot.MenuBar, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}