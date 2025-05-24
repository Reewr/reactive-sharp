
using ReactiveSharp;
using ReactiveSharpGodot.Components;

namespace ReactiveSharpGodotTest;

public partial class TicTacToe
{
	public class WinScreen : Component
	{
		public required User WinningUser { get; set; }
		public required Action OnPressed { get; set; }

		public override Component Render() => new VBoxContainer
			{
				new Label { Text = $"Player {WinningUser} won" } ,
				new Button { Text = "Restart", Pressed = OnPressed }
			};
	}
}
