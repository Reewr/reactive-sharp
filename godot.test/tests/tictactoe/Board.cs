
using ReactiveSharp;
using ReactiveSharpGodot.Components;

namespace ReactiveSharpGodotTest;

public partial class TicTacToe
{
	public class Board : Component
	{
		public required Action<int, int> OnBoardChanged { get; set; }
		public required List<List<SquareState>> Squares { get; set; }

		public override Component Render() => new VBoxContainer
			{
				Enumerable
					.Range(0, Squares.Count)
					.Select(y => new HBoxContainer()
					{
						Enumerable
							.Range(0, Squares[y].Count)
							.Select(x => new Square()
							{
								Key = $"{x},{y}",
								Value = Squares[x][y],
								OnPressed = () => OnBoardChanged(x, y)
							})
							.ToList<Component>()
					})
					.ToList<Component>()
			};
	}
}
