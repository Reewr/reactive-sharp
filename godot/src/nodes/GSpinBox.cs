namespace ReactiveSharpGodot.Nodes
{
    public class GSpinBox : Godot.SpinBox, ReactiveSharpGodot.IGNode<Godot.SpinBox>
    {
        public Godot.Node Node => this;
    }
}