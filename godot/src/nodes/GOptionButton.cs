namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GOptionButton : Godot.OptionButton, ReactiveSharpGodot.IGNode<Godot.OptionButton>
    {
        public Godot.Node Node => this;
    }
}