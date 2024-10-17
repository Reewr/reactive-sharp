namespace ReactiveSharpGodot.Nodes
{
    [PropertyInterceptor]
    public class GCheckBox : Godot.CheckBox, ReactiveSharpGodot.IGNode<Godot.CheckBox>
    {
        public Godot.Node Node => this;
    }
}