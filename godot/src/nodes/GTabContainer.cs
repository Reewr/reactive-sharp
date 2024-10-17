namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GTabContainer : Godot.TabContainer, ReactiveSharpGodot.IGNode<Godot.TabContainer>
    {
        public Godot.Node Node => this;
    }
}