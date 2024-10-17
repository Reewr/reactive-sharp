namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GBaseButton : Godot.BaseButton, ReactiveSharpGodot.IGNode<Godot.BaseButton>
    {
        public Godot.Node Node => this;
    }
}