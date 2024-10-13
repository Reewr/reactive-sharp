namespace ReactiveSharpGodot.Components
{
    public class CodeEdit : TextEdit
    {
        public System.Boolean? SymbolLookupOnClick { protected get; init; }
        public System.Boolean? LineFolding { protected get; init; }
        public Godot.Collections.Array<System.Int32>? LineLengthGuidelines { protected get; init; }
        public System.Boolean? GuttersDrawBreakpointsGutter { protected get; init; }
        public System.Boolean? GuttersDrawBookmarks { protected get; init; }
        public System.Boolean? GuttersDrawExecutingLines { protected get; init; }
        public System.Boolean? GuttersDrawLineNumbers { protected get; init; }
        public System.Boolean? GuttersZeroPadLineNumbers { protected get; init; }
        public System.Boolean? GuttersDrawFoldGutter { protected get; init; }
        public Godot.Collections.Array<System.String>? DelimiterStrings { protected get; init; }
        public Godot.Collections.Array<System.String>? DelimiterComments { protected get; init; }
        public System.Boolean? CodeCompletionEnabled { protected get; init; }
        public Godot.Collections.Array<System.String>? CodeCompletionPrefixes { protected get; init; }
        public System.Int32? IndentSize { protected get; init; }
        public System.Boolean? IndentUseSpaces { protected get; init; }
        public System.Boolean? IndentAutomatic { protected get; init; }
        public Godot.Collections.Array<System.String>? IndentAutomaticPrefixes { protected get; init; }
        public System.Boolean? AutoBraceCompletionEnabled { protected get; init; }
        public System.Boolean? AutoBraceCompletionHighlightMatching { protected get; init; }
        public Godot.Collections.Dictionary? AutoBraceCompletionPairs { protected get; init; }
        public Godot.CodeEdit.BreakpointToggledEventHandler? BreakpointToggled { protected get; init; }
        public System.Action? CodeCompletionRequested { protected get; init; }
        public Godot.CodeEdit.SymbolLookupEventHandler? SymbolLookup { protected get; init; }
        public Godot.CodeEdit.SymbolValidateEventHandler? SymbolValidate { protected get; init; }

        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GCodeEdit(), builtChildren);
        public override void UpdateProperties(ReactiveSharpGodot.IGNode node)
        {
            var castedNode = (Godot.CodeEdit)node.Node;
            base.UpdateProperties(node);
            if (SymbolLookupOnClick is System.Boolean n0)
                castedNode.SymbolLookupOnClick = n0;
            if (LineFolding is System.Boolean n1)
                castedNode.LineFolding = n1;
            if (LineLengthGuidelines is Godot.Collections.Array<System.Int32> n2)
                castedNode.LineLengthGuidelines = n2;
            if (GuttersDrawBreakpointsGutter is System.Boolean n3)
                castedNode.GuttersDrawBreakpointsGutter = n3;
            if (GuttersDrawBookmarks is System.Boolean n4)
                castedNode.GuttersDrawBookmarks = n4;
            if (GuttersDrawExecutingLines is System.Boolean n5)
                castedNode.GuttersDrawExecutingLines = n5;
            if (GuttersDrawLineNumbers is System.Boolean n6)
                castedNode.GuttersDrawLineNumbers = n6;
            if (GuttersZeroPadLineNumbers is System.Boolean n7)
                castedNode.GuttersZeroPadLineNumbers = n7;
            if (GuttersDrawFoldGutter is System.Boolean n8)
                castedNode.GuttersDrawFoldGutter = n8;
            if (DelimiterStrings is Godot.Collections.Array<System.String> n9)
                castedNode.DelimiterStrings = n9;
            if (DelimiterComments is Godot.Collections.Array<System.String> n10)
                castedNode.DelimiterComments = n10;
            if (CodeCompletionEnabled is System.Boolean n11)
                castedNode.CodeCompletionEnabled = n11;
            if (CodeCompletionPrefixes is Godot.Collections.Array<System.String> n12)
                castedNode.CodeCompletionPrefixes = n12;
            if (IndentSize is System.Int32 n13)
                castedNode.IndentSize = n13;
            if (IndentUseSpaces is System.Boolean n14)
                castedNode.IndentUseSpaces = n14;
            if (IndentAutomatic is System.Boolean n15)
                castedNode.IndentAutomatic = n15;
            if (IndentAutomaticPrefixes is Godot.Collections.Array<System.String> n16)
                castedNode.IndentAutomaticPrefixes = n16;
            if (AutoBraceCompletionEnabled is System.Boolean n17)
                castedNode.AutoBraceCompletionEnabled = n17;
            if (AutoBraceCompletionHighlightMatching is System.Boolean n18)
                castedNode.AutoBraceCompletionHighlightMatching = n18;
            if (AutoBraceCompletionPairs is Godot.Collections.Dictionary n19)
                castedNode.AutoBraceCompletionPairs = n19;
            if (BreakpointToggled is Godot.CodeEdit.BreakpointToggledEventHandler e0)
                castedNode.BreakpointToggled += e0;
            if (CodeCompletionRequested is System.Action e1)
                castedNode.CodeCompletionRequested += e1;
            if (SymbolLookup is Godot.CodeEdit.SymbolLookupEventHandler e2)
                castedNode.SymbolLookup += e2;
            if (SymbolValidate is Godot.CodeEdit.SymbolValidateEventHandler e3)
                castedNode.SymbolValidate += e3;
        }
    }
}