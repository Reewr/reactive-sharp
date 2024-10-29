namespace ReactiveSharp;

public interface IContextProvider { }

public abstract class ContextProvider<T> : Component, IContextProvider
{
	private readonly T Value;
	public ContextProvider(T value) => Value = value;
	public T GetContextValue() => Value;
}
