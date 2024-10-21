# Reactive Sharp - Godot

This is the Reactive Sharp Godot module. It allows you to use Reactive Sharp in your Godot projects.

## Installation

TODO

## Usage

You can use Reactive Sharp in your Godot projects by either creating an instance of `ReactiveSharpGodot.Renderer` or by extending `ReactiveSharpGodot.Renderer` in your own script.

Either way, you should add it to the scene tree and call `Renderer.Render(new MyComponent())` to render your component.

```csharp
using ReactiveSharpGodot;

public class MyComponent : Component
{
	public override void Render()
	{
		var counter = UseState(0);
		return new VBoxContainer {
			new Label { Text = $"Counter: {counter.Value}" },
			new Button {
				Text = "Increment",
				OnPressed = () => counter.Value++
			}
		};
	}
}

public class MyScene : Renderer
{
	public override void _Ready()
	{
		Render(new MyComponent());
	}
}
```
