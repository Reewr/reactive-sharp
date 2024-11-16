namespace ReactiveSharp;

public abstract class StateBase
{
	protected StateBase() { }

	internal abstract object? GetValueAsObject();
}
