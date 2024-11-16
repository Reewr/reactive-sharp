using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ReactiveSharp;

public class Effect
{
	public required object?[] Dependencies { get; set; }
	public required Func<Action> Callback { get; set; }
	public Action UnloadEffect { get; set; } = () => { };
	public bool RunOnNextRun { get; set; }

	public void Run()
	{
		if (RunOnNextRun)
		{
			UnloadEffect();
			UnloadEffect = Callback();
			RunOnNextRun = false;
		}
	}

	public void ResetIfDependenciesChanged(params object?[] dependencies)
	{
		if (Dependencies == null || Dependencies.Length != dependencies.Length)
		{
			RunOnNextRun = true;
			Dependencies = dependencies;
		}
		else if (Dependencies.Length == 0)
		{
			RunOnNextRun = true;
			Dependencies = dependencies;
		}
		else
		{
			for (int i = 0; i < dependencies.Length; i++)
			{
				if (!Dependencies[i]?.Equals(dependencies[i]) ?? true)
				{
					RunOnNextRun = true;
					Dependencies = dependencies;
					break;
				}
			}
		}

	}
}

class EffectManager
{
	private static readonly ConditionalWeakTable<string, List<Effect?>> EffectStore = [];

	public static void RunAllEffects()
	{
		foreach (var componentCallbacks in EffectStore)
		{
			foreach (var effect in componentCallbacks.Value)
			{
				effect?.Run();
			}
		}
	}

	public static void StoreEffect(string componentId, int stateIndex, Action callback, params object[] dependencies)
	{
		StoreEffect(componentId, stateIndex, () =>
		{
			callback();
			return () => { };
		}, dependencies);
	}

	private static object?[] ExtractDependenciesFromState(params object?[] dependencies)
	{
		return dependencies.Select(dependency =>
		{
			if (dependency is StateBase state)
				return state.GetValueAsObject();
			return dependency;
		}).ToArray();
	}

	public static void StoreEffect(string componentId, int stateIndex, Func<Action> callback, params object?[] dependencies)
	{
		var extractedDependencies = ExtractDependenciesFromState(dependencies);
		if (!EffectStore.TryGetValue(componentId, out var componentCallbacks))
		{
			componentCallbacks = [];
			EffectStore.Add(componentId, componentCallbacks);
		}

		// Expand the list if necessary
		while (componentCallbacks.Count <= stateIndex)
			componentCallbacks.Add(null);

		if (componentCallbacks[stateIndex] is Effect existingCallback)
		{
			existingCallback.ResetIfDependenciesChanged(extractedDependencies);
			return;
		}


		componentCallbacks[stateIndex] = new Effect()
		{
			Callback = callback,
			Dependencies = extractedDependencies,
			RunOnNextRun = true
		};
	}
}
