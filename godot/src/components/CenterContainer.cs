namespace ReactiveSharpGodot.Components
{
    public class CenterContainer : Container
    {
        public System.Boolean? UseTopLeft { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GCenterContainer(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.CenterContainer)node.Node;
            base.UpdateProperties(node);
            if (UseTopLeft is System.Boolean n0)
                castedNode.UseTopLeft = n0;
        }
    }
}