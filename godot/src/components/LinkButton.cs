namespace ReactiveSharpGodot.Components
{
    public class LinkButton : BaseButton
    {
        public System.String? Text { protected get; init; }
        public Godot.LinkButton.UnderlineMode? Underline { protected get; init; }
        public System.String? Uri { protected get; init; }
        public Godot.Control.TextDirection? TextDirection { protected get; init; }
        public System.String? Language { protected get; init; }
        public Godot.TextServer.StructuredTextParser? StructuredTextBidiOverride { protected get; init; }
        public Godot.Collections.Array? StructuredTextBidiOverrideOptions { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GLinkButton(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.LinkButton)node.Node;
            base.UpdateProperties(node);
            if (Text is System.String n0)
                castedNode.Text = n0;
            if (Underline is Godot.LinkButton.UnderlineMode n1)
                castedNode.Underline = n1;
            if (Uri is System.String n2)
                castedNode.Uri = n2;
            if (TextDirection is Godot.Control.TextDirection n3)
                castedNode.TextDirection = n3;
            if (Language is System.String n4)
                castedNode.Language = n4;
            if (StructuredTextBidiOverride is Godot.TextServer.StructuredTextParser n5)
                castedNode.StructuredTextBidiOverride = n5;
            if (StructuredTextBidiOverrideOptions is Godot.Collections.Array n6)
                castedNode.StructuredTextBidiOverrideOptions = n6;
        }
    }
}