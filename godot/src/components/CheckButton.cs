namespace ReactiveSharpGodot.Components
{
    public class CheckButton : Button
    {
        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.Node> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GCheckButton(), builtChildren);
    }
}