
using ReactiveSharp;
using ReactiveSharpGodot.Components;

namespace ReactiveSharpGodotTest;

public partial class TicTacToe
{
	public class Square : Component
	{
		public required System.Action OnPressed { private get; init; }
		public required SquareState Value { private get; init; }

		public override Component Render() => new Button
		{
			Text = Value switch
			{
				SquareState.Cross => "X",
				SquareState.Circle => "O",
				_ => " "
			},
			Disabled = Value != SquareState.Empty,
			CustomMinimumSize = new Godot.Vector2(50, 50),
			Pressed = OnPressed
		};
	}
}
