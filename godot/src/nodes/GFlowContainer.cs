namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GFlowContainer : Godot.FlowContainer, ReactiveSharpGodot.IGNode<Godot.FlowContainer>
    {
        public Godot.Node Node => this;
    }
}