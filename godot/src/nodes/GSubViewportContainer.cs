namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GSubViewportContainer : Godot.SubViewportContainer, ReactiveSharpGodot.IGNode<Godot.SubViewportContainer>
    {
        public Godot.Node Node => this;
    }
}