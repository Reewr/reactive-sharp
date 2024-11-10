using Shouldly;

namespace ReactiveSharp.Dom.Tests;

public partial class DomTests
{

    public static IEnumerable<object[]> GetTestComponents()
    {
        yield return new object[] { new SimpleComponentTest() };
        yield return new object[] { new SimpleStateComponentTest() };
        yield return new object[] { new NodeReplacementCompontentTest() };
        yield return new object[] { new SimpleContextComponentTest() };
        yield return new object[] { new FragmentComponentTest() };
    }

    [Theory]
    [MemberData(nameof(GetTestComponents))]
    public void TestRendering(ITestRunBase test)
    {
        var expected = test.GetExpected();
        var actual = test.GetActual();
        actual.ShouldBeEquivalentTo(expected);
    }
}
