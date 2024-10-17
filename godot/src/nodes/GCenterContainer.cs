namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GCenterContainer : Godot.CenterContainer, ReactiveSharpGodot.IGNode<Godot.CenterContainer>
    {
        public Godot.Node Node => this;
    }
}