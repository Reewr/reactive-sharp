namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GGraphEdit : Godot.GraphEdit, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}