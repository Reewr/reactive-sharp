namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GCheckBox : Godot.CheckBox, ReactiveSharpGodot.IGNode
    {
        public Godot.Node Node => this;
    }
}