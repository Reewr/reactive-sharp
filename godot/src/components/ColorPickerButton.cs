namespace ReactiveSharpGodot.Components
{
    public class ColorPickerButton : Button
    {
        public Godot.Color? Color { protected get; init; }
        public System.Boolean? EditAlpha { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GColorPickerButton(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.ColorPickerButton)node.Node;
            base.UpdateProperties(node);
            if (Color is Godot.Color n0)
                castedNode.Color = n0;
            if (EditAlpha is System.Boolean n1)
                castedNode.EditAlpha = n1;
        }
    }
}