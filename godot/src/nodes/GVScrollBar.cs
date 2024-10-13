namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GVScrollBar : Godot.VScrollBar, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}