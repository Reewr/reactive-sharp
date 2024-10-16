namespace ReactiveSharpGodot.Components
{
    public class VideoStreamPlayer : Control
    {
        public System.Int32? AudioTrack { protected get; init; }
        public Godot.VideoStream? Stream { protected get; init; }
        public System.Single? VolumeDb { protected get; init; }
        public System.Single? Volume { protected get; init; }
        public System.Boolean? Autoplay { protected get; init; }
        public System.Boolean? Paused { protected get; init; }
        public System.Boolean? Expand { protected get; init; }
        public System.Boolean? Loop { protected get; init; }
        public System.Int32? BufferingMsec { protected get; init; }
        public System.Double? StreamPosition { protected get; init; }
        public Godot.StringName? Bus { protected get; init; }
        public System.Action? Finished { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.INode> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GVideoStreamPlayer(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.VideoStreamPlayer)node.Node;
            base.UpdateProperties(node);
            if (AudioTrack is System.Int32 n0)
                castedNode.AudioTrack = n0;
            if (Stream is Godot.VideoStream n1)
                castedNode.Stream = n1;
            if (VolumeDb is System.Single n2)
                castedNode.VolumeDb = n2;
            if (Volume is System.Single n3)
                castedNode.Volume = n3;
            if (Autoplay is System.Boolean n4)
                castedNode.Autoplay = n4;
            if (Paused is System.Boolean n5)
                castedNode.Paused = n5;
            if (Expand is System.Boolean n6)
                castedNode.Expand = n6;
            if (Loop is System.Boolean n7)
                castedNode.Loop = n7;
            if (BufferingMsec is System.Int32 n8)
                castedNode.BufferingMsec = n8;
            if (StreamPosition is System.Double n9)
                castedNode.StreamPosition = n9;
            if (Bus is Godot.StringName n10)
                castedNode.Bus = n10;
            if (Finished is System.Action e0)
                castedNode.Finished += e0;
        }
    }
}
