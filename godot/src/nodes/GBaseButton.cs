namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GBaseButton : Godot.BaseButton, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}