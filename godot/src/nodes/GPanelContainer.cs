namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GPanelContainer : Godot.PanelContainer, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}