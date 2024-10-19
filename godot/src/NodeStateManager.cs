class NodeStateManager
{
	public static NodeStateManager CurrentManager { get; } = new NodeStateManager();

	private static readonly Dictionary<object, Dictionary<string, object>> propertyStates = [];
	private static readonly Dictionary<object, Dictionary<string, List<Delegate>>> eventHandlers = [];

	private NodeStateManager() { }

	public static void AddPropertyState(object instance, string name, object value)
	{
		if (instance == null) return;
		if (propertyStates.TryGetValue(instance, out Dictionary<string, object>? state))
		{
			if (!state.ContainsKey(name))
			{
				state[name] = value;
			}
		}
		else
		{
			propertyStates[instance] = new Dictionary<string, object> { [name] = value };
		}
	}

	public static void AddEventHandler(object instance, string name, Delegate handler)
	{
		if (instance == null) return;
		if (eventHandlers.TryGetValue(instance, out Dictionary<string, List<Delegate>>? actions))
		{
			if (!actions.ContainsKey(name))
			{
				actions[name] = [handler];
			}
		}
		else
		{
			eventHandlers[instance] = new Dictionary<string, List<Delegate>> { [name] = [handler] };
		}
	}

	public static void Reset(object instance)
	{
		if (propertyStates.TryGetValue(instance, out Dictionary<string, object>? value))
		{
			foreach (var (name, val) in value)
			{
				instance.GetType().GetProperty(name)?.SetValue(instance, val);
			}
		}

		if (eventHandlers.TryGetValue(instance, out Dictionary<string, List<Delegate>>? actions))
		{
			foreach (var (name, handlers) in actions)
			{
				var eventInfo = instance.GetType().GetEvent(name);
				if (eventInfo != null)
				{
					foreach (var handler in handlers)
					{
						eventInfo.RemoveEventHandler(instance, handler);
					}
				}
			}
		}

		propertyStates.Remove(instance);
		eventHandlers.Remove(instance);
	}
}
