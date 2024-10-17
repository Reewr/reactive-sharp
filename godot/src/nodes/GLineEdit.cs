namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GLineEdit : Godot.LineEdit, ReactiveSharpGodot.IGNode<Godot.LineEdit>
    {
        public Godot.Node Node => this;
    }
}