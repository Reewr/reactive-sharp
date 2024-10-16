namespace ReactiveSharpGodot.Components
{
    public class ColorPickerButton : Button
    {
        public Godot.Color? Color { protected get; init; }
        public System.Boolean? EditAlpha { protected get; init; }
        public Godot.ColorPickerButton.ColorChangedEventHandler? ColorChanged { protected get; init; }
        public System.Action? PopupClosed { protected get; init; }
        public System.Action? PickerCreated { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.INode> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GColorPickerButton(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.ColorPickerButton)node.Node;
            base.UpdateProperties(node);
            if (Color is Godot.Color n0)
                castedNode.Color = n0;
            if (EditAlpha is System.Boolean n1)
                castedNode.EditAlpha = n1;
            if (ColorChanged is Godot.ColorPickerButton.ColorChangedEventHandler e0)
                castedNode.ColorChanged += e0;
            if (PopupClosed is System.Action e1)
                castedNode.PopupClosed += e1;
            if (PickerCreated is System.Action e2)
                castedNode.PickerCreated += e2;
        }
    }
}
