namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GHScrollBar : Godot.HScrollBar, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}