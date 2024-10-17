namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GSpinBox : Godot.SpinBox, ReactiveSharpGodot.IGNode<Godot.SpinBox>
    {
        public Godot.Node Node => this;
    }
}