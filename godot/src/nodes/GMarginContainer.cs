namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GMarginContainer : Godot.MarginContainer, ReactiveSharpGodot.IGNode<Godot.MarginContainer>
    {
        public Godot.Node Node => this;
    }
}