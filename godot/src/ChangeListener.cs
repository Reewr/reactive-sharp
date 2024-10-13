namespace ReactiveSharpGodot;

using MethodDecorator.Fody.Interfaces;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class)]
public class PropertyInterceptorAttribute : Attribute, IMethodDecorator
{
	private static readonly Dictionary<object, Dictionary<string, object>> propertyStates = [];
	private static readonly Dictionary<object, Dictionary<string, List<Delegate>>> eventHandlers = [];

	private bool isEvent = false;
	private string? propertyName;

	public void Init(object instance, MethodBase method, object[] args)
	{
		// If the method is a property setter, extract the property name
		if (instance == null || !method.IsSpecialName) return;

		if (method.Name.StartsWith("add_") || method.Name.StartsWith("remove_"))
		{
			isEvent = true;
			propertyName = method.Name[4..];
		}
		else if (method.Name.StartsWith("set_"))
		{
			propertyName = method.Name[4..];
		}

		if (propertyName == null) return;

		if (isEvent)
		{
			eventHandlers[instance] ??= [];
			eventHandlers[instance][propertyName] ??= [];
			eventHandlers[instance][propertyName].Add((Delegate)args[0]);
		}
		else
		{
			var state = propertyStates[instance] ??= [];
			if (!state.ContainsKey(propertyName))
			{
				var property = instance.GetType().GetProperty(propertyName);
				if (property != null)
				{
					var currentValue = property.GetValue(instance);
					if (currentValue != null) state[propertyName] = currentValue;
				}
			}
		}
	}

	public void OnEntry() { }
	public void OnExit() { }
	public void OnException(Exception exception) { }

	// Method to reset properties to their previous states
	public static void Reset(object instance)
	{
		if (instance == null) return;
		if (!propertyStates.TryGetValue(instance, out var state)) return;

		foreach (var entry in state)
		{
			var property = instance.GetType().GetProperty(entry.Key);
			if (property != null && property.CanWrite)
			{
				property.SetValue(instance, entry.Value);
			}
		}

		propertyStates.Remove(instance);
	}

}
