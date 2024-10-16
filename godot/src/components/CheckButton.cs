namespace ReactiveSharpGodot.Components
{
    public class CheckButton : Button
    {
        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.INode> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GCheckButton(), builtChildren);
    }
}
