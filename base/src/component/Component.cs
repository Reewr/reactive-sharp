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
	public List<Component> Children { get; set; } = new List<Component>();

	protected Component([CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = 0)
	{
		_componentId = $"{GetFullTypeName()}:{memberName}:{lineNumber}";
	}

	public abstract Component Render();

	public override string ToString()
	{
		return $"<{GetType().Name}#{_id}-{_componentId}>";
	}

	internal Component RenderWithReset()
	{
		_stateIndex = 0;
		return Render();
	}

	private string GetFullTypeName() => GetType().FullName ?? "UnknownType";

	protected State<T> UseState<T>(T initialValue)
	{
		int currentIndex = _stateIndex++;
		return StateManager.GetState(this, _componentId, currentIndex, initialValue);
	}

	public void Add(Component component) => Children.Add(component);
	public void Add(params Component[] components) => Children.AddRange(components);
	public void Add(List<Component> components) => Children.AddRange(components);

	public IEnumerator GetEnumerator() => Children.GetEnumerator();
}
