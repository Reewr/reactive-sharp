namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GTabBar : Godot.TabBar, ReactiveSharpGodot.IGNode<Godot.TabBar>
    {
        public Godot.Node Node => this;
    }
}