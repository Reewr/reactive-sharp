namespace ReactiveSharpGodot.Components
{
    public class ColorPicker : VBoxContainer
    {
        public Godot.Color? Color { protected get; init; }
        public System.Boolean? EditAlpha { protected get; init; }
        public Godot.ColorPicker.ColorModeType? ColorMode { protected get; init; }
        public System.Boolean? DeferredMode { protected get; init; }
        public Godot.ColorPicker.PickerShapeType? PickerShape { protected get; init; }
        public System.Boolean? CanAddSwatches { protected get; init; }
        public System.Boolean? SamplerVisible { protected get; init; }
        public System.Boolean? ColorModesVisible { protected get; init; }
        public System.Boolean? SlidersVisible { protected get; init; }
        public System.Boolean? HexVisible { protected get; init; }
        public System.Boolean? PresetsVisible { protected get; init; }
        public Godot.ColorPicker.ColorChangedEventHandler? ColorChanged { protected get; init; }
        public Godot.ColorPicker.PresetAddedEventHandler? PresetAdded { protected get; init; }
        public Godot.ColorPicker.PresetRemovedEventHandler? PresetRemoved { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.INode> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GColorPicker(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.ColorPicker)node.Node;
            base.UpdateProperties(node);
            if (Color is Godot.Color n0)
                castedNode.Color = n0;
            if (EditAlpha is System.Boolean n1)
                castedNode.EditAlpha = n1;
            if (ColorMode is Godot.ColorPicker.ColorModeType n2)
                castedNode.ColorMode = n2;
            if (DeferredMode is System.Boolean n3)
                castedNode.DeferredMode = n3;
            if (PickerShape is Godot.ColorPicker.PickerShapeType n4)
                castedNode.PickerShape = n4;
            if (CanAddSwatches is System.Boolean n5)
                castedNode.CanAddSwatches = n5;
            if (SamplerVisible is System.Boolean n6)
                castedNode.SamplerVisible = n6;
            if (ColorModesVisible is System.Boolean n7)
                castedNode.ColorModesVisible = n7;
            if (SlidersVisible is System.Boolean n8)
                castedNode.SlidersVisible = n8;
            if (HexVisible is System.Boolean n9)
                castedNode.HexVisible = n9;
            if (PresetsVisible is System.Boolean n10)
                castedNode.PresetsVisible = n10;
            if (ColorChanged is Godot.ColorPicker.ColorChangedEventHandler e0)
                castedNode.ColorChanged += e0;
            if (PresetAdded is Godot.ColorPicker.PresetAddedEventHandler e1)
                castedNode.PresetAdded += e1;
            if (PresetRemoved is Godot.ColorPicker.PresetRemovedEventHandler e2)
                castedNode.PresetRemoved += e2;
        }
    }
}
