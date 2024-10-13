namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GVFlowContainer : Godot.VFlowContainer, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}