namespace ReactiveSharpGodot.Components
{
    public class GraphEdit : Control
    {
        public System.Boolean? ArrangeNodesButtonHidden { protected get; init; }
        public System.Int32? SnapDistance { protected get; init; }
        public System.Boolean? UseSnap { protected get; init; }
        public Godot.Vector2? ScrollOffset { protected get; init; }
        public System.Boolean? ShowGrid { protected get; init; }
        public Godot.GraphEdit.GridPatternEnum? GridPattern { protected get; init; }
        public System.Boolean? SnappingEnabled { protected get; init; }
        public System.Int32? SnappingDistance { protected get; init; }
        public Godot.GraphEdit.PanningSchemeEnum? PanningScheme { protected get; init; }
        public System.Boolean? RightDisconnects { protected get; init; }
        public System.Single? ConnectionLinesCurvature { protected get; init; }
        public System.Single? ConnectionLinesThickness { protected get; init; }
        public System.Boolean? ConnectionLinesAntialiased { protected get; init; }
        public System.Single? Zoom { protected get; init; }
        public System.Single? ZoomMin { protected get; init; }
        public System.Single? ZoomMax { protected get; init; }
        public System.Single? ZoomStep { protected get; init; }
        public System.Boolean? MinimapEnabled { protected get; init; }
        public Godot.Vector2? MinimapSize { protected get; init; }
        public System.Single? MinimapOpacity { protected get; init; }
        public System.Boolean? ShowMenu { protected get; init; }
        public System.Boolean? ShowZoomLabel { protected get; init; }
        public System.Boolean? ShowZoomButtons { protected get; init; }
        public System.Boolean? ShowGridButtons { protected get; init; }
        public System.Boolean? ShowMinimapButton { protected get; init; }
        public System.Boolean? ShowArrangeButton { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GGraphEdit(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.GraphEdit)node.Node;
            base.UpdateProperties(node);
            if (ArrangeNodesButtonHidden is System.Boolean n0)
                castedNode.ArrangeNodesButtonHidden = n0;
            if (SnapDistance is System.Int32 n1)
                castedNode.SnapDistance = n1;
            if (UseSnap is System.Boolean n2)
                castedNode.UseSnap = n2;
            if (ScrollOffset is Godot.Vector2 n3)
                castedNode.ScrollOffset = n3;
            if (ShowGrid is System.Boolean n4)
                castedNode.ShowGrid = n4;
            if (GridPattern is Godot.GraphEdit.GridPatternEnum n5)
                castedNode.GridPattern = n5;
            if (SnappingEnabled is System.Boolean n6)
                castedNode.SnappingEnabled = n6;
            if (SnappingDistance is System.Int32 n7)
                castedNode.SnappingDistance = n7;
            if (PanningScheme is Godot.GraphEdit.PanningSchemeEnum n8)
                castedNode.PanningScheme = n8;
            if (RightDisconnects is System.Boolean n9)
                castedNode.RightDisconnects = n9;
            if (ConnectionLinesCurvature is System.Single n10)
                castedNode.ConnectionLinesCurvature = n10;
            if (ConnectionLinesThickness is System.Single n11)
                castedNode.ConnectionLinesThickness = n11;
            if (ConnectionLinesAntialiased is System.Boolean n12)
                castedNode.ConnectionLinesAntialiased = n12;
            if (Zoom is System.Single n13)
                castedNode.Zoom = n13;
            if (ZoomMin is System.Single n14)
                castedNode.ZoomMin = n14;
            if (ZoomMax is System.Single n15)
                castedNode.ZoomMax = n15;
            if (ZoomStep is System.Single n16)
                castedNode.ZoomStep = n16;
            if (MinimapEnabled is System.Boolean n17)
                castedNode.MinimapEnabled = n17;
            if (MinimapSize is Godot.Vector2 n18)
                castedNode.MinimapSize = n18;
            if (MinimapOpacity is System.Single n19)
                castedNode.MinimapOpacity = n19;
            if (ShowMenu is System.Boolean n20)
                castedNode.ShowMenu = n20;
            if (ShowZoomLabel is System.Boolean n21)
                castedNode.ShowZoomLabel = n21;
            if (ShowZoomButtons is System.Boolean n22)
                castedNode.ShowZoomButtons = n22;
            if (ShowGridButtons is System.Boolean n23)
                castedNode.ShowGridButtons = n23;
            if (ShowMinimapButton is System.Boolean n24)
                castedNode.ShowMinimapButton = n24;
            if (ShowArrangeButton is System.Boolean n25)
                castedNode.ShowArrangeButton = n25;
        }
    }
}