
using ReactiveSharp;
using ReactiveSharpGodot.Components;

namespace ReactiveSharpGodotTest;

public partial class TicTacToe
{
	public class DrawScreen : Component
	{
		public required System.Action OnPressed { get; set; }

		public override Component Render() => new VBoxContainer
			{
				new Label { Text = "It is a draw" },
				new Button { Text = "Restart", Pressed = OnPressed }
			};
	}
}
