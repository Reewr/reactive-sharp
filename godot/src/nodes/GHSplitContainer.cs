namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GHSplitContainer : Godot.HSplitContainer, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}