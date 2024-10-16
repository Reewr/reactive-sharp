namespace ReactiveSharpGodot.Components
{
    public class BaseButton : Control
    {
        public System.Boolean? Disabled { protected get; init; }
        public System.Boolean? ToggleMode { protected get; init; }
        public System.Boolean? ButtonPressed { protected get; init; }
        public Godot.BaseButton.ActionModeEnum? ActionMode { protected get; init; }
        public Godot.MouseButtonMask? ButtonMask { protected get; init; }
        public System.Boolean? KeepPressedOutside { protected get; init; }
        public Godot.ButtonGroup? ButtonGroup { protected get; init; }
        public Godot.Shortcut? Shortcut { protected get; init; }
        public System.Boolean? ShortcutFeedback { protected get; init; }
        public System.Boolean? ShortcutInTooltip { protected get; init; }
        public System.Action? Pressed { protected get; init; }
        public System.Action? ButtonUp { protected get; init; }
        public System.Action? ButtonDown { protected get; init; }
        public Godot.BaseButton.ToggledEventHandler? Toggled { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.INode> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GBaseButton(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.BaseButton)node.Node;
            base.UpdateProperties(node);
            if (Disabled is System.Boolean n0)
                castedNode.Disabled = n0;
            if (ToggleMode is System.Boolean n1)
                castedNode.ToggleMode = n1;
            if (ButtonPressed is System.Boolean n2)
                castedNode.ButtonPressed = n2;
            if (ActionMode is Godot.BaseButton.ActionModeEnum n3)
                castedNode.ActionMode = n3;
            if (ButtonMask is Godot.MouseButtonMask n4)
                castedNode.ButtonMask = n4;
            if (KeepPressedOutside is System.Boolean n5)
                castedNode.KeepPressedOutside = n5;
            if (ButtonGroup is Godot.ButtonGroup n6)
                castedNode.ButtonGroup = n6;
            if (Shortcut is Godot.Shortcut n7)
                castedNode.Shortcut = n7;
            if (ShortcutFeedback is System.Boolean n8)
                castedNode.ShortcutFeedback = n8;
            if (ShortcutInTooltip is System.Boolean n9)
                castedNode.ShortcutInTooltip = n9;
            if (Pressed is System.Action e0)
                castedNode.Pressed += e0;
            if (ButtonUp is System.Action e1)
                castedNode.ButtonUp += e1;
            if (ButtonDown is System.Action e2)
                castedNode.ButtonDown += e2;
            if (Toggled is Godot.BaseButton.ToggledEventHandler e3)
                castedNode.Toggled += e3;
        }
    }
}
