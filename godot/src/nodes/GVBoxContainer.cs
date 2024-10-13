namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GVBoxContainer : Godot.VBoxContainer, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}