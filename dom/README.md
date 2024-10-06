# Reactive Sharp - DOM

This library provides a set of classes that can be used to create
reactive user interfaces that turn into HTML. It is mostly used for
testing and debugging purposes.

## Example

```csharp
using ReactiveSharp.Dom;
using ReactiveSharp;

class MyComponent : Component
{
	public override Component Render() => new Div()
	{
		new P { Text = "Hello, World!" }
	};
}
```
