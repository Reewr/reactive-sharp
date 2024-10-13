namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GNinePatchRect : Godot.NinePatchRect, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}