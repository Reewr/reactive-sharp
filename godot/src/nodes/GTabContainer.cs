namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GTabContainer : Godot.TabContainer, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}