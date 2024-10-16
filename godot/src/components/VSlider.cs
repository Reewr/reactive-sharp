namespace ReactiveSharpGodot.Components
{
    public class VSlider : Slider
    {
        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.INode> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GVSlider(), builtChildren);
    }
}
