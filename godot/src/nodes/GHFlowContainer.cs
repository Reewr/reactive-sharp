namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GHFlowContainer : Godot.HFlowContainer, ReactiveSharpGodot.IGNode<Godot.HFlowContainer>
    {
        public Godot.Node Node => this;
    }
}