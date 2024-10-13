namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GPanel : Godot.Panel, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}