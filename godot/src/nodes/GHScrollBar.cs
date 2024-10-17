namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GHScrollBar : Godot.HScrollBar, ReactiveSharpGodot.IGNode<Godot.HScrollBar>
    {
        public Godot.Node Node => this;
    }
}