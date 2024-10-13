namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GVSplitContainer : Godot.VSplitContainer, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}