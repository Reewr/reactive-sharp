namespace ReactiveSharp;

using System;
using System.Collections.Generic;

public class StateManager
{
	public required Renderer Renderer { private get; init; }
	private readonly Dictionary<string, Dictionary<int, StateBase?>> StateStore = [];

	public State<T> GetState<T>(Component component, string componentId, int stateIndex, T initialValue)
	{
		if (!StateStore.TryGetValue(componentId, out var componentStates))
		{
			componentStates = [];
			StateStore[componentId] = componentStates;
		}

		if (
			!StateStore[componentId].TryGetValue(stateIndex, out var componentState) ||
			componentState is not State<T> castedComponentState
			)
		{
			castedComponentState = new State<T>(
				initialValue,
				() => Renderer.RequestRender(component)
			);
			StateStore[componentId][stateIndex] = castedComponentState;
		}

		return castedComponentState;
	}
}
