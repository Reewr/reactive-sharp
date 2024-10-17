namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GCodeEdit : Godot.CodeEdit, ReactiveSharpGodot.IGNode<Godot.CodeEdit>
    {
        public Godot.Node Node => this;
    }
}