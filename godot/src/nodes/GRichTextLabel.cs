namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GRichTextLabel : Godot.RichTextLabel, ReactiveSharpGodot.IGNode<Godot.RichTextLabel>
    {
        public Godot.Node Node => this;
    }
}