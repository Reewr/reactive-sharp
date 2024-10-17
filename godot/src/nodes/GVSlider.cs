namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GVSlider : Godot.VSlider, ReactiveSharpGodot.IGNode<Godot.VSlider>
    {
        public Godot.Node Node => this;
    }
}