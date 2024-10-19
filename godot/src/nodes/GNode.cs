namespace ReactiveSharpGodot.Nodes
{
	public class GNode : Godot.Node, ReactiveSharpGodot.IGNode<Godot.Node>
	{
		public Godot.Node Node => this;
	}
}
