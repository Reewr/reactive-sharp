namespace ReactiveSharpGodotTest;

public partial class TicTacToeTestRenderer : ReactiveSharpGodot.Renderer
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Render(new CenterContainer() { new TicTacToe() });
	}
}
