namespace ReactiveSharpGodot.Nodes
{
    public class GColorPicker : Godot.ColorPicker, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}