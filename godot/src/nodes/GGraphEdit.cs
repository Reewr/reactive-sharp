namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GGraphEdit : Godot.GraphEdit, ReactiveSharpGodot.IGNode<Godot.GraphEdit>
    {
        public Godot.Node Node => this;
    }
}