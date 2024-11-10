using System;

namespace ReactiveSharp;

public class Fragment : Component
{
	public override Component Render() => throw new InvalidOperationException("Fragments cannot be rendered.");
}
