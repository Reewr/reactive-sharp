namespace ReactiveSharp;

using System.Collections.Generic;

public static class StateManager
{
	private static readonly Dictionary<string, List<StateBase?>> StateStore = new();

	public static State<T> GetState<T>(Component component, string componentId, int stateIndex, T initialValue)
	{
		if (!StateStore.TryGetValue(componentId, out var componentStates))
		{
			componentStates = new List<StateBase?>();
			StateStore[componentId] = componentStates;
		}

		// Expand the list if necessary
		while (componentStates.Count <= stateIndex)
			componentStates.Add(null);

		if (componentStates[stateIndex] is State<T> existingState)
			return existingState;

		var newState = new State<T>(
			initialValue,
			() => Renderer.CurrentRenderer?.RequestRender(component)
		);

		componentStates[stateIndex] = newState;
		return newState;
	}
}
