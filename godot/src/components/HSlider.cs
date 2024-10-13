namespace ReactiveSharpGodot.Components
{
    public class HSlider : Slider
    {
        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GHSlider(), builtChildren);
    }
}