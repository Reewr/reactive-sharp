namespace ReactiveSharpGodot.Nodes
{
    public class GSpinBox : Godot.SpinBox, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}