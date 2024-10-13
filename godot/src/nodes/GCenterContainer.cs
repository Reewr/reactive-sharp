namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GCenterContainer : Godot.CenterContainer, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}