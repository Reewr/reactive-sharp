namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GColorPicker : Godot.ColorPicker, ReactiveSharpGodot.IGNode<Godot.ColorPicker>
    {
        public Godot.Node Node => this;
    }
}