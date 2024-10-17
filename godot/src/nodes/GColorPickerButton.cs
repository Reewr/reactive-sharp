namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GColorPickerButton : Godot.ColorPickerButton, ReactiveSharpGodot.IGNode<Godot.ColorPickerButton>
    {
        public Godot.Node Node => this;
    }
}