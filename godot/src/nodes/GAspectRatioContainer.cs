namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GAspectRatioContainer : Godot.AspectRatioContainer, ReactiveSharpGodot.IGNode<Godot.AspectRatioContainer>
    {
        public Godot.Node Node => this;
    }
}