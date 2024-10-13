namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GTabBar : Godot.TabBar, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}