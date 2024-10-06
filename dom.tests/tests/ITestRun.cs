
using ReactiveSharp;
using ReactiveSharp.Dom;

namespace ReactiveSharp.Dom.Tests;

public interface ITestRunBase
{
	string GetActual();
	string GetExpected();
}

public interface ITestRunWithActionsBeforeAndAndAfter<T> : ITestRunBase where T : Component, ITestRunWithActionsBeforeAndAndAfter<T>, new()
{
	string ITestRunBase.GetActual()
	{
		var dom = new DivNode();
		var renderer = new Renderer(dom);
		var component = new T();
		T.ActionBefore?.Invoke(component);
		renderer.Render(component);
		T.ActionAfter?.Invoke(component);
		renderer.RenderRequested();

		// since we inject a div node, the actual result is the first child of the div node
		var renderedNode = dom.GetChild(0);
		if (renderedNode is null) return "";
		if (renderedNode is not DomNode node)
			throw new Exception($"Expected DomNode. Got {renderedNode.GetType().Name}.");
		return node.ToTree();
	}

	string ITestRunBase.GetExpected() => T.Expected;

	abstract static Action<T>? ActionBefore { get; }
	abstract static Action<T>? ActionAfter { get; }
	abstract static string Expected { get; }
}

public interface ITestRunWithActionBefore<T> : ITestRunWithActionsBeforeAndAndAfter<T> where T : Component, ITestRunWithActionBefore<T>, new()
{
	static Action<T>? ITestRunWithActionsBeforeAndAndAfter<T>.ActionAfter => null;
}

public interface ITestRunWithActionAfter<T> : ITestRunWithActionsBeforeAndAndAfter<T> where T : Component, ITestRunWithActionAfter<T>, new()
{
	static Action<T>? ITestRunWithActionsBeforeAndAndAfter<T>.ActionBefore => null;
}

public interface ITestRun<T> : ITestRunWithActionsBeforeAndAndAfter<T> where T : Component, ITestRun<T>, new()
{
	static Action<T>? ITestRunWithActionsBeforeAndAndAfter<T>.ActionBefore => null;
	static Action<T>? ITestRunWithActionsBeforeAndAndAfter<T>.ActionAfter => null;
}
