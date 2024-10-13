namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GGridContainer : Godot.GridContainer, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}