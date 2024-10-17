namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GPanelContainer : Godot.PanelContainer, ReactiveSharpGodot.IGNode<Godot.PanelContainer>
    {
        public Godot.Node Node => this;
    }
}