namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GVSlider : Godot.VSlider, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}