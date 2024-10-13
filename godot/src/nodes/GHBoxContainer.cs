namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GHBoxContainer : Godot.HBoxContainer, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}