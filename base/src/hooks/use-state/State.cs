using System.Collections.Generic;

namespace ReactiveSharp;

public class State<T> : StateBase
{
	private T _value;
	public T Value
	{
		get => _value;
		set
		{
			if (EqualityComparer<T>.Default.Equals(_value, value))
				return;

			_value = value;
			_onStateChanged();
		}
	}
	private readonly System.Action _onStateChanged;

	public State(T value, System.Action onStateChanged)
	{
		_value = value;
		_onStateChanged = onStateChanged;
	}

	public void SetValue(T value) => Value = value;
}
