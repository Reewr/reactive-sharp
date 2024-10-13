namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GLineEdit : Godot.LineEdit, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}