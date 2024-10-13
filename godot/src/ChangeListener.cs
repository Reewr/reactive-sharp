namespace ReactiveSharpGodot;

using MethodDecorator.Fody.Interfaces;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class)]
public class PropertyInterceptorAttribute : Attribute, IMethodDecorator
{
	private static readonly Dictionary<object, Dictionary<string, object>> _propertyStates = [];

	private object? _instance;
	private string? _propertyName;

	public void Init(object instance, MethodBase method, object[] args)
	{
		_instance = instance;
		// If the method is a property setter, extract the property name
		if (method.IsSpecialName && method.Name.StartsWith("set_"))
		{
			_propertyName = method.Name[4..];
		}
	}

	// Called before the decorated method execution
	public void OnEntry()
	{
		if (_instance == null || string.IsNullOrEmpty(_propertyName))
			return;

		if (!_propertyStates.ContainsKey(_instance)) _propertyStates[_instance] = [];

		var state = _propertyStates[_instance];
		if (!state.ContainsKey(_propertyName))
		{
			var property = _instance.GetType().GetProperty(_propertyName);
			if (property != null)
			{
				var currentValue = property.GetValue(_instance);
				if (currentValue != null) state[_propertyName] = currentValue;
			}
		}
	}

	// Called after the decorated method execution
	public void OnExit()
	{
		// No action needed on exit for this scenario
	}

	// Called if the decorated method throws an exception
	public void OnException(Exception exception)
	{
		// Handle exceptions if necessary
	}

	// Method to reset properties to their previous states
	public static void Reset(object instance)
	{
		if (!_propertyStates.TryGetValue(instance, out var state)) return;

		foreach (var entry in state)
		{
			var property = instance.GetType().GetProperty(entry.Key);
			if (property != null && property.CanWrite)
			{
				property.SetValue(instance, entry.Value);
			}
		}

		_propertyStates.Remove(instance);
	}
}
