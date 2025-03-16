namespace ReactiveSharp.Dom.Tests;

public abstract class TestComponent : Component
{
	protected Renderer Renderer { get; init; }
	protected DivNode CurrentDOM { get; init; }

	protected TestComponent()
	{
		CurrentDOM = new DivNode();
		Renderer = new Renderer(CurrentDOM);
	}

	protected string RenderToString(Component component)
	{
		Renderer.Render(component);
		return RerenderToString();
	}

	protected string RerenderToString()
	{
		while (Renderer.RenderingRequested())
			Renderer.RenderRequested();

		var topNode = CurrentDOM.GetChild(0);
		return topNode is not null ? ((DomNode)topNode).ToTree() : "";
	}
}
