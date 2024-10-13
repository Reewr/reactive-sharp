namespace ReactiveSharpGodot.Components
{
    public class VSlider : Slider
    {
        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GVSlider(), builtChildren);
    }
}