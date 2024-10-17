namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GSplitContainer : Godot.SplitContainer, ReactiveSharpGodot.IGNode<Godot.SplitContainer>
    {
        public Godot.Node Node => this;
    }
}