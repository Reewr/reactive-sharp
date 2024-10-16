namespace ReactiveSharpGodot.Components
{
    public class HSlider : Slider
    {
        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.INode> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GHSlider(), builtChildren);
    }
}
