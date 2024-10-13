namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GColorPicker : Godot.ColorPicker, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}