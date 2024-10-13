namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GLinkButton : Godot.LinkButton, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}