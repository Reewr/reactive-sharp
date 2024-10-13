namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GBoxContainer : Godot.BoxContainer, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}