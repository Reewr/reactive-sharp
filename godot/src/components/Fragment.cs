namespace ReactiveSharpGodot.Components
{
	public class Fragment : ReactiveSharp.NodeComponent<ReactiveSharpGodot.Nodes.GNode>
	{
		public override ReactiveSharpGodot.Nodes.GNode Build(List<ReactiveSharp.INode> builtChildren)
		{
			var node = new ReactiveSharpGodot.Nodes.GNode();
			var igNode = (ReactiveSharp.INode)node;
			foreach (var child in builtChildren)
				igNode.AddChild(child);
			return node;
		}

		public override void UpdateProperties(ReactiveSharpGodot.Nodes.GNode node) { }
	}
}
