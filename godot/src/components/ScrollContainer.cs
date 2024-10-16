namespace ReactiveSharpGodot.Components
{
    public class ScrollContainer : Container
    {
        public System.Boolean? FollowFocus { protected get; init; }
        public System.Int32? ScrollHorizontal { protected get; init; }
        public System.Int32? ScrollVertical { protected get; init; }
        public System.Single? ScrollHorizontalCustomStep { protected get; init; }
        public System.Single? ScrollVerticalCustomStep { protected get; init; }
        public Godot.ScrollContainer.ScrollMode? HorizontalScrollMode { protected get; init; }
        public Godot.ScrollContainer.ScrollMode? VerticalScrollMode { protected get; init; }
        public System.Int32? ScrollDeadzone { protected get; init; }
        public System.Action? ScrollStarted { protected get; init; }
        public System.Action? ScrollEnded { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.INode> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GScrollContainer(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.ScrollContainer)node.Node;
            base.UpdateProperties(node);
            if (FollowFocus is System.Boolean n0)
                castedNode.FollowFocus = n0;
            if (ScrollHorizontal is System.Int32 n1)
                castedNode.ScrollHorizontal = n1;
            if (ScrollVertical is System.Int32 n2)
                castedNode.ScrollVertical = n2;
            if (ScrollHorizontalCustomStep is System.Single n3)
                castedNode.ScrollHorizontalCustomStep = n3;
            if (ScrollVerticalCustomStep is System.Single n4)
                castedNode.ScrollVerticalCustomStep = n4;
            if (HorizontalScrollMode is Godot.ScrollContainer.ScrollMode n5)
                castedNode.HorizontalScrollMode = n5;
            if (VerticalScrollMode is Godot.ScrollContainer.ScrollMode n6)
                castedNode.VerticalScrollMode = n6;
            if (ScrollDeadzone is System.Int32 n7)
                castedNode.ScrollDeadzone = n7;
            if (ScrollStarted is System.Action e0)
                castedNode.ScrollStarted += e0;
            if (ScrollEnded is System.Action e1)
                castedNode.ScrollEnded += e1;
        }
    }
}
