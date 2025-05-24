
using ReactiveSharp;
using ReactiveSharpGodot.Components;

namespace ReactiveSharpGodotTest;

public partial class TicTacToe : Component
{
	private static readonly int BoardSize = 3;
	private static List<List<T>> GenerateBoard<T>(Func<int, int, T> generator)
	{
		return Enumerable
			.Range(0, BoardSize)
			.Select(y =>
				Enumerable
					.Range(0, BoardSize)
					.Select(x => generator(x, y))
					.ToList()
			)
			.ToList();
	}

	private static bool CheckRows(List<List<SquareState>> squares, SquareState askingFor) =>
		squares.Any(row => row.All(square => square == askingFor));

	private static bool CheckColumns(List<List<SquareState>> squares, SquareState askingFor) =>
		Enumerable
			.Range(0, BoardSize)
			.Any(x => squares.All(row => row[x] == askingFor));

	private static bool CheckDiagonal(List<List<SquareState>> squares, SquareState askingFor)
	{
		for (int i = 0; i < BoardSize; i++)
			if (squares[i][i] != askingFor)
				return false;

		for (int i = BoardSize - 1; i >= 0; i--)
			if (squares[i][i] != askingFor)
				return false;

		return true;
	}

	private static User? SomeoneHasWon(List<List<SquareState>> squares)
	{
		if (CheckRows(squares, SquareState.Cross) || CheckColumns(squares, SquareState.Cross) || CheckDiagonal(squares, SquareState.Cross))
			return User.Cross;

		if (CheckRows(squares, SquareState.Circle) || CheckColumns(squares, SquareState.Circle) || CheckDiagonal(squares, SquareState.Circle))
			return User.Circle;

		return null;
	}

	private static void ResetState(List<List<State<SquareState>>> stateOfSquares)
	{
		for (int y = 0; y < BoardSize; y++)
		{
			for (int x = 0; x < BoardSize; x++)
			{
				stateOfSquares[x][y].Value = SquareState.Empty;
			}
		}
	}

	private static bool IsDraw(List<List<SquareState>> squares) =>
		squares.All(row => row.All(square => square != SquareState.Empty));

	public override Component Render()
	{
		var CurrentUser = UseState(User.Cross);
		var stateOfSquares = GenerateBoard((x, y) => UseState(SquareState.Empty));
		var squares = stateOfSquares.Select(row => row.Select(square => square.Value).ToList()).ToList();

		if (SomeoneHasWon(squares) is User userWhoWon)
			return new WinScreen { WinningUser = userWhoWon, OnPressed = () => ResetState(stateOfSquares) };
		else if (IsDraw(squares))
			return new DrawScreen { OnPressed = () => ResetState(stateOfSquares) };

		return new VBoxContainer
			{
				new Label { Text = $"{CurrentUser.Value} turn" },
				new Board {
					Squares = squares,
					OnBoardChanged = (x, y) => {
						var square = stateOfSquares[x][y];
						if (square.Value == SquareState.Empty && CurrentUser.Value == User.Cross)
						{
							square.Value = SquareState.Cross;
							CurrentUser.Value = User.Circle;
						}
						else if (square.Value == SquareState.Empty && CurrentUser.Value == User.Circle)
						{
							square.Value = SquareState.Circle;
							CurrentUser.Value = User.Cross;
						}
					}
				}
			};
	}
}
