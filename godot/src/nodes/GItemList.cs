namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GItemList : Godot.ItemList, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}