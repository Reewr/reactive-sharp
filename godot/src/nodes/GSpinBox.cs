namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GSpinBox : Godot.SpinBox, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}