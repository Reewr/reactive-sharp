namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GOptionButton : Godot.OptionButton, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}