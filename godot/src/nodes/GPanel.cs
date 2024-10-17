namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GPanel : Godot.Panel, ReactiveSharpGodot.IGNode<Godot.Panel>
    {
        public Godot.Node Node => this;
    }
}