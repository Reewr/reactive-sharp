namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GGridContainer : Godot.GridContainer, ReactiveSharpGodot.IGNode<Godot.GridContainer>
    {
        public Godot.Node Node => this;
    }
}