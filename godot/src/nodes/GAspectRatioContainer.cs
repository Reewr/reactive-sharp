namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GAspectRatioContainer : Godot.AspectRatioContainer, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}