namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GCheckButton : Godot.CheckButton, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}