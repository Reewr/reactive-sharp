namespace ReactiveSharp;

using System;
using System.Collections;
using System.Collections.Generic;

public abstract class Component : IEnumerable
{
	private static readonly Random random = new();
	private readonly long _id = random.NextInt64(100000);

	private int _stateIndex = 0;
	private string _componentId = "";
	private WeakReference<Component>? _parent;

	public string Key { get => _componentId; set => _componentId = value ?? _componentId; }
	public List<Component?> Children { get; set; } = [];

	internal WeakReference<Component>? Parent
	{
		get => _parent;
		set
		{
			_parent = value;
			SetComponentId();
		}
	}

	private Component? GetParent()
	{
		if (Parent is not null && Parent.TryGetTarget(out var p))
			return p;
		return null;
	}

	private void SetComponentId()
	{
		var parent = GetParent();
		var childIndex = parent?.Children.FindIndex(x => x == this);
		var parentId = parent?.Key ?? "root";
		_componentId = $"{parentId}-{GetFullTypeName()}";
		if (childIndex != -1) _componentId += $"-{childIndex}";
	}

	protected Component()
	{
		Parent = Renderer.GetCurrentRenderer()?.CurrentRenderingComponent is Component parent
			? new WeakReference<Component>(parent)
			: null;
	}

	public abstract Component Render();

	public override string ToString()
	{
		return $"<{GetType().Name}#{_id}-{_componentId}>";
	}

	internal Component RenderWithReset()
	{
		_stateIndex = 0;
		Renderer.GetCurrentRenderer()!.CurrentRenderingComponent = this;
		return Render();
	}

	private string GetFullTypeName() => GetType().FullName ?? throw new InvalidTypeException($"{GetType().Name} has no type");

	public State<T> UseState<T>(T initialValue)
	{
		int currentIndex = _stateIndex++;
		return Renderer.GetCurrentStateManager()!.GetState(this, _componentId, currentIndex, initialValue);
	}

	internal void ReleaseState()
	{
		Renderer.GetCurrentStateManager()!.ReleaseStateFor(_componentId);
	}

	public void UseEffect(Func<Action> callback, params object[] dependencies)
	{
		int currentIndex = _stateIndex++;
		Renderer.GetCurrentEffectManager()!.StoreEffect(_componentId, currentIndex, callback, dependencies);
	}

	public void UseEffect(Action callback, params object[] dependencies)
	{
		int currentIndex = _stateIndex++;
		Renderer.GetCurrentEffectManager()!.StoreEffect(_componentId, currentIndex, callback, dependencies);
	}

	public T UseContext<C, T>() where C : ContextProvider<T>
	{
		return ContextManager.GetContext<C, T>(this).GetContextValue();
	}

	public void Add(Component? component)
	{
		Children.Add(component);
		if (component is not null)
			component.Parent = new WeakReference<Component>(this);
	}

	public void Add(params Component[] components)
	{
		foreach (var component in components)
			Add(component);
	}

	public void Add(List<Component> components)
	{
		foreach (var component in components)
			Add(component);
	}

	public IEnumerator GetEnumerator() => Children.GetEnumerator();
}

[Serializable]
internal class InvalidTypeException : Exception
{
	public InvalidTypeException()
	{
	}

	public InvalidTypeException(string? message) : base(message)
	{
	}

	public InvalidTypeException(string? message, Exception? innerException) : base(message, innerException)
	{
	}
}

[Serializable]
internal class InvalidComponentStateException : Exception
{
	public InvalidComponentStateException()
	{
	}

	public InvalidComponentStateException(string? message) : base(message)
	{
	}

	public InvalidComponentStateException(string? message, Exception? innerException) : base(message, innerException)
	{
	}
}
