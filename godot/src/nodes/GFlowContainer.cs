namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GFlowContainer : Godot.FlowContainer, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}