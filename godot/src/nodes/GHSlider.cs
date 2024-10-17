namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GHSlider : Godot.HSlider, ReactiveSharpGodot.IGNode<Godot.HSlider>
    {
        public Godot.Node Node => this;
    }
}