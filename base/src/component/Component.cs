namespace ReactiveSharp;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public abstract class Component : IEnumerable
{
	private static readonly Random random = new();
	private readonly long _id = random.NextInt64(100000);

	private int _stateIndex = 0;
	private string _componentId;

	public string? Key { set => _componentId = value ?? _componentId; }
	public List<Component?> Children { get; set; } = [];

	internal WeakReference<Component>? Parent { get; set; }

	protected Component([CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = 0)
	{
		_componentId = $"{GetFullTypeName()}:{memberName}:{lineNumber}";
		Parent = Renderer.CurrentRenderer?.CurrentRenderingComponent is Component parent
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
		if (Renderer.CurrentRenderer != null)
			Renderer.CurrentRenderer.CurrentRenderingComponent = this;
		return Render();
	}

	private string GetFullTypeName() => GetType().FullName ?? "UnknownType";

	protected State<T> UseState<T>(T initialValue)
	{
		int currentIndex = _stateIndex++;
		return StateManager.GetState(this, _componentId, currentIndex, initialValue);
	}

	protected void UseEffect(Func<Action> callback, params object[] dependencies)
	{
		int currentIndex = _stateIndex++;
		EffectManager.StoreEffect(_componentId, currentIndex, callback, dependencies);
	}

	protected void UseEffect(Action callback, params object[] dependencies)
	{
		int currentIndex = _stateIndex++;
		EffectManager.StoreEffect(_componentId, currentIndex, callback, dependencies);
	}

	protected T UseContext<C, T>() where C : ContextProvider<T>
	{
		return ContextManager.GetContext<C, T>(this).GetContextValue();
	}

	public void Add(Component component)
	{
		Children.Add(component);
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
