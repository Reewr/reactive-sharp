namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GVFlowContainer : Godot.VFlowContainer, ReactiveSharpGodot.IGNode<Godot.VFlowContainer>
    {
        public Godot.Node Node => this;
    }
}