namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GHFlowContainer : Godot.HFlowContainer, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}