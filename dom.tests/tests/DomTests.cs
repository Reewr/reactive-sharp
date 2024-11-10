using System.Reflection;
using Shouldly;

namespace ReactiveSharp.Dom.Tests;

public partial class DomTests
{
    public static IEnumerable<object[]> GetTestComponents()
    {
        var type = typeof(ITestRunBase);
        var testClasses = Assembly
            .GetAssembly(type)
            ?.GetTypes()
            .Where(t => t.IsClass && !t.IsAbstract && type.IsAssignableFrom(t));

        if (testClasses is null) yield break;
        ThrowIfAnyTestsIsMissingParameterlessConstructor(testClasses);
        var onlyClassses = testClasses.Where(t => t.GetCustomAttribute<TestOnlyAttribute>() is not null);
        var hasOnly = onlyClassses.Any();

        if (hasOnly)
            testClasses = onlyClassses;

        var names = string.Join(", ", testClasses.Select(t => t.Name));
        Console.WriteLine($"{(hasOnly ? "Dectected only. " : "")}Running tests: {names}");

        foreach (var testClass in testClasses)
        {
            yield return new object[] { Activator.CreateInstance(testClass)! };
        }
    }

    private static void ThrowIfAnyTestsIsMissingParameterlessConstructor(IEnumerable<Type> testClasses)
    {
        foreach (var testClass in testClasses)
        {
            var constructor = testClass.GetConstructor(Type.EmptyTypes);
            if (constructor is null)
            {
                throw new Exception($"Test class {testClass.Name} is missing a parameterless constructor.");
            }
        }
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
