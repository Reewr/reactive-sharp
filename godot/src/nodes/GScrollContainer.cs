namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GScrollContainer : Godot.ScrollContainer, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}