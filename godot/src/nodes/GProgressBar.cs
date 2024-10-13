namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GProgressBar : Godot.ProgressBar, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}