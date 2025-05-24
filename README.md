# ReactiveSharp

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

-   `ReactiveSharp.Dom` - Sets up some basic node components that can be used to
    create a reactive user interface.that turns into HTML. It is mostly used for
    testing and debugging purposes.

-   `ReactiveSharp.Godot` - Sets up the required components to create a
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

## Hooks

The following hooks are available as of now:

### `UseState<T>(initialValue) => State<T>`

Creates a state that is reactive. Modifying the internal value by either
setting it manually through `SetValue` or by directly assigning to
`Value` will cause the framework to queue your component for
re-rendering. Once `Renderer.RenderRequested` is called again, the
render tree with be updated.

### `UseContext<Provider, T>() -> T`

This requires you to have a Provider further up in the tree. The
Provider component is a special component that simply serves as a way to
store some state.

Should the Provider value be updated, all those components that depend
on the Provider through the use of `UseContext` will also be updated.

### `UseEffect(Func, [dependencies])`

The function given to this hook will be run when the component is
initially rendered. The given function can also return another function
that should be exectuted before calling the initial function again. If
given dependencies, if any of the dependencies change, the intial
function will be rerun (when it renders again)

## Setup - Godot

As of now, this is quite usable in Godot. Setting this up is quite
simple. You can see how it is done in `godot.test`

1. Update the `project.csproj` with the library paths to `base` and `godot`
2. Add a new class `<YourName>Renderer` that extends `ReactiveSharpGodot.Renderer`
3. Within a scene, attach this class to an existing UI node.
4. Within the `<YourName>Renderer`, override the `_ready` function and call `Render(new MyComponent())`

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

### Godot Example

To see how this works in Godot, please see [godot.test/tests](./godot.test/tests) for more examples.

#### [godot.test/tests/counter](./godot.test/tests/counter)

This show cases a simple counter example. You can start this in Godot by loading the project and running it.

#### [godot.test/tests/ticktactoe](./godot.test/tests/tictactoe)

This is a more complex example of UI being controlled by ReactiveSharp, as it needs multiple different components,
