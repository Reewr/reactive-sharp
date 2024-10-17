namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GLinkButton : Godot.LinkButton, ReactiveSharpGodot.IGNode<Godot.LinkButton>
    {
        public Godot.Node Node => this;
    }
}