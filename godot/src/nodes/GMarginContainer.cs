namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GMarginContainer : Godot.MarginContainer, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}