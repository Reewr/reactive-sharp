using System;

namespace ReactiveSharp;

public class ContextManager
{
	private static C? FindContext<C, T>(Component component) where C : ContextProvider<T>
	{
		if (component is C c)
		{
			return c;
		}

		if (component.Parent?.TryGetTarget(out var parent) == true)
		{
			return FindContext<C, T>(parent);
		}

		return null;
	}

	public static C GetContext<C, T>(Component component) where C : ContextProvider<T>
	{
		return FindContext<C, T>(component) ?? throw new ContextNotFoundException<C, T>();
	}
}

[Serializable]
internal class ContextNotFoundException<C, T> : Exception where C : ContextProvider<T>
{
	public ContextNotFoundException() : base($"Unable to find the context provider {typeof(C).Name}<{typeof(T).Name}>") { }

	public ContextNotFoundException(string? message) : base(message) { }



	public ContextNotFoundException(string? message, Exception? innerException) : base(message, innerException)
	{
	}
}
