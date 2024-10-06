namespace ReactiveSharp.Dom.Tests;

public partial class DomTests
{

    public static IEnumerable<object[]> GetTestComponents()
    {
        yield return new object[] { new SimpleComponentTest() };
        yield return new object[] { new SimpleStateComponentTest() };
    }

    [Theory]
    [MemberData(nameof(GetTestComponents))]
    public void TestRendering(ITestRunBase test)
    {
        Assert.Equal(test.GetExpected(), test.GetActual());
    }
}
