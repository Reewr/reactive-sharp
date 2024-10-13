namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GRichTextLabel : Godot.RichTextLabel, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}