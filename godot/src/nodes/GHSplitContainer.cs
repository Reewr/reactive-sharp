namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GHSplitContainer : Godot.HSplitContainer, ReactiveSharpGodot.IGNode<Godot.HSplitContainer>
    {
        public Godot.Node Node => this;
    }
}