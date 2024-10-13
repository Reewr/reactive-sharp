namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GSplitContainer : Godot.SplitContainer, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}