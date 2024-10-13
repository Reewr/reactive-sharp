namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GCodeEdit : Godot.CodeEdit, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}