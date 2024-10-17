namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GScrollContainer : Godot.ScrollContainer, ReactiveSharpGodot.IGNode<Godot.ScrollContainer>
    {
        public Godot.Node Node => this;
    }
}