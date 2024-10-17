namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GVSplitContainer : Godot.VSplitContainer, ReactiveSharpGodot.IGNode<Godot.VSplitContainer>
    {
        public Godot.Node Node => this;
    }
}