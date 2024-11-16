using System.Collections.Generic;

namespace ReactiveSharp;

public class State<T>(T value, System.Action onStateChanged) : StateBase
{
	private T _value = value;
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
	private readonly System.Action _onStateChanged = onStateChanged;

	public void SetValue(T value) => Value = value;
	internal override object? GetValueAsObject() => Value;
}
