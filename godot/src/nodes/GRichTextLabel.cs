namespace ReactiveSharpGodot.Nodes
{
    public class GRichTextLabel : Godot.RichTextLabel, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}