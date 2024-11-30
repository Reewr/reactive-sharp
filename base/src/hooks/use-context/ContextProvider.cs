namespace ReactiveSharp;

public interface IContextProvider { }

public abstract class ContextProvider<T>(T value) : Component, IContextProvider
{
	private readonly T Value = value;
	public T GetContextValue() => Value;
	public override Component Render() => new Fragment() { Children = Children };
}
