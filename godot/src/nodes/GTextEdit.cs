namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GTextEdit : Godot.TextEdit, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}