namespace ReactiveSharpGodot.Nodes
{
    public class GItemList : Godot.ItemList, ReactiveSharpGodot.IGNode<Godot.ItemList>
    {
        public Godot.Node Node => this;
    }
}