namespace ReactiveSharpGodot.Components
{
    public class CheckBox : Button
    {
        public override ReactiveSharpGodot.IGNode Build(System.Collections.Generic.List<ReactiveSharp.INode> builtChildren) => DefaultBuild(new ReactiveSharpGodot.Nodes.GCheckBox(), builtChildren);
    }
}
