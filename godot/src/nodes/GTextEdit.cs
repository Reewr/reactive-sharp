namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GTextEdit : Godot.TextEdit, ReactiveSharpGodot.IGNode<Godot.TextEdit>
    {
        public Godot.Node Node => this;
    }
}