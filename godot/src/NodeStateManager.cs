namespace ReactiveSharpGodot;

class NodeStateManager
{
	public static NodeStateManager CurrentManager { get; } = new NodeStateManager();

	private static readonly Dictionary<object, Dictionary<string, object>> propertyStates = [];
	private static readonly Dictionary<object, Dictionary<string, List<Delegate>>> eventHandlers = [];
	private static readonly Dictionary<object, Dictionary<string, int>> themeConstantOverrides = [];

	private NodeStateManager() { }

	private static void SetProp<T, V>(T dict, object instance, string name, V value) where T : Dictionary<object, Dictionary<string, V>>
	{
		if (instance == null) return;
		if (dict.TryGetValue(instance, out var inner))
		{
			if (!inner.ContainsKey(name))
			{
				inner[name] = value;
			}
		}
		else
		{
			dict[instance] = new Dictionary<string, V> { [name] = value };
		}
	}

	public static void AddPropertyState(object instance, string name, object value) => SetProp(propertyStates, instance, name, value);
	public static void AddThemeConstantOverride(object instance, string name, int value) => SetProp(themeConstantOverrides, instance, name, value);

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

		if (themeConstantOverrides.TryGetValue(instance, out var instanceThemeConstantOverrides))
		{
			var control = (Godot.Control)instance;
			if (instanceThemeConstantOverrides.Count > 0)
			{
				control.BeginBulkThemeOverride();
				foreach (var (name, _) in instanceThemeConstantOverrides)
				{
					control.RemoveThemeConstantOverride(name);
				}
				control.EndBulkThemeOverride();
			}
		}

		themeConstantOverrides.Remove(instance);
		propertyStates.Remove(instance);
		eventHandlers.Remove(instance);
	}
}
