namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GColorPickerButton : Godot.ColorPickerButton, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}