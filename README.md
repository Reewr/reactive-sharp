# Reactive UI

This library provides a set of classes that can be used to create
reactive user interfaces. The library is based on and attempts to follow
the same principles as React.

## Components

The main class in this library is `Component`. A `Component` is a
container for other components and is finally rendered to a Node.
A `Component` can consist of other `Component`s. Some of these
components may be a `NodeComponent`, which is a `Component` that
represents a specific Node.

The base library contains just the required pieces to be able to create
an extension library that fills in the gaps.

Within this repository, you will find two extensino libraries:

-   `ReactiveUI.Dom` - Sets up some basic node components that can be used to
    create a reactive user interface.that turns into HTML. It is mostly used for
    testing and debugging purposes.

-   `ReactiveUI.Godot` - Sets up the required components to create a
    reactive user interface in Godot.

## Extension Libraries

In order to create an extension library, you will need to extend the
`NodeComponent`. This class is a special type of component that is not
meant to be rendered. It is considered a Component in order to be able
to be returned by the `Render` method, but they are meant to be built.

When the `Renderer` finds a `NodeComponent`, it will call the `Build` instead
of the `Render` method. The `Build` method should return a `Node`. How this is
done is up to the extension library.

For example, for Godot, the `NodeComponent` will return a `Node` that is
a small wrapper around whatever Godot node is being used. This allows
the `Renderer` to be able to build the entire tree of nodes and then
attach them to the parent node without having to worry about the
specifics of the node, making it interface agnostic.

## Custom Components

You can create custom components by extending the `Component` class and
implementing the `Render` method. The `Render` method should return a
`Component`.

If you require state in your component, you can use the `State` class
through the `UseState` which is reactive and will cause your component
to re-render when the it changes.

### Example

This example assumes that the following components have been made available
through other means:

-   `VBoxContainer`
-   `Label`
-   `Button`
-   `VerticalSeparator`

The example below show cases the use of state as well as context that
can be used to share state across layers of components. All of these
functionalities have been taken as direct inspiration from React. If you
have ever worked in functional React, this should feel very famililar to
you, though with a C# vibe.

```csharp
class Theme {
	public Color BackgroundColor { get; set; }
	public Color ForegroundColor { get; set; }
}

class ThemeProvider(MyTheme theme) : ReactiveSharp.ContextProvider<Theme>(theme) { }

// We can define our own hook by creating extensions
static class UseThemeHook {
	public static Theme UseTheme(this Component component) {
		return component.UseContext<ThemeProvider, Theme>();
	}
}

class Counter : ReactiveSharp.Component
{
	public override ReactiveSharp.Component Render() {
		ReactiveSharp.State<int> count = UseState(0);
		Theme theme = this.UseTheme();

		return new VBoxContainer()
		{
			new Label() { Text = $"Count: {count.Value}" },
			new Button()
			{
				Text = "Increment the count",
				OnPressed = () => count.Value++
			}
		};
	}
}

class MyApp : ReactiveSharp.Component
{
	public override ReactiveSharp.Component Render() {
		var theme = new Theme() {
			BackgroundColor = Colors.White,
			ForegroundColor = Colors.Black
		};

		return new ThemeProvider(theme)
		{
			new Fragment() {
				new Counter(),
				new VerticalSeparator(),
				new Counter()
			}
		};
	}
}
```
