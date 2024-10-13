namespace ReactiveSharpGodot.Components
{
    public abstract class ScrollBar : Range
    {
        public System.Single? CustomStep { protected get; init; }
        public System.Action? Scrolling { protected get; init; }

        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.ScrollBar)node.Node;
            base.UpdateProperties(node);
            if (CustomStep is System.Single n0)
                castedNode.CustomStep = n0;
            if (Scrolling is System.Action e0)
                castedNode.Scrolling += e0;
        }
    }
}