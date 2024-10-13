namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GHSlider : Godot.HSlider, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}