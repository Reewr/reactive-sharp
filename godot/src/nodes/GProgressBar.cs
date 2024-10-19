namespace ReactiveSharpGodot.Nodes
{
    public class GProgressBar : Godot.ProgressBar, ReactiveSharpGodot.IGNode<Godot.ProgressBar>
    {
        public Godot.Node Node => this;
    }
}