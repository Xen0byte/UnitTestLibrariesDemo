namespace xUnit.Library;

// xUnit Does Not Require An Attribute For A Test Class
public class Tests : IDisposable /* or IAsyncLifetime for asynchronous setup and tear-down */, IClassFixture<TestsFixture>
{
    private Guid TransientIdentifier { get; } = Guid.NewGuid();

    private ITestOutputHelper Output { get; }

    private TestsFixture TestsFixture { get; }

    // xUnit Uses The Class Constructor For The Test Class Setup
    public Tests(ITestOutputHelper output, TestsFixture testsFixture)
    {
        Debug.WriteLine($"[DEBUG] {MethodBase.GetCurrentMethod()?.DeclaringType}:{MethodBase.GetCurrentMethod()?.Name}");
        Output = output;
        TestsFixture = testsFixture;
    }

    [Fact]
    public void IdentifierTestOne()
    {
        Debug.WriteLine($"[DEBUG] {MethodBase.GetCurrentMethod()?.DeclaringType}:{MethodBase.GetCurrentMethod()?.Name}");
        Output.WriteLine(TransientIdentifier.ToString());
        Assert.NotEqual(Guid.Empty, TransientIdentifier);
    }

    [Fact]
    public void IdentifierTestTwo()
    {
        Debug.WriteLine($"[DEBUG] {MethodBase.GetCurrentMethod()?.DeclaringType}:{MethodBase.GetCurrentMethod()?.Name}");
        Output.WriteLine(TransientIdentifier.ToString());
        Assert.NotEqual(Guid.Empty, TransientIdentifier);
    }

    [Theory]
    [InlineData("one", "two")]
    public void TestWithDataAndCompositeAssertion(string first, string second)
    {
        Debug.WriteLine($"[DEBUG] {MethodBase.GetCurrentMethod()?.DeclaringType}:{MethodBase.GetCurrentMethod()?.Name}");

        Assert.Multiple
        (
            () => { const string one = "one"; Assert.Equal(one, first); },
            () => { const string two = "two"; Assert.Equal(two, second); }
        );
    }

    // xUnit Implements IDisposable And Uses Dispose() For The Test Class Tear-Down
    public void Dispose()
    {
        Debug.WriteLine($"[DEBUG] {MethodBase.GetCurrentMethod()?.DeclaringType}:{MethodBase.GetCurrentMethod()?.Name}");
    }
}

public class TestsFixture : IDisposable
{
    // Equivalent To [OneTimeSetUp] Or [ClassInitialize]
    public TestsFixture()
    {
        Debug.WriteLine($"[DEBUG] {MethodBase.GetCurrentMethod()?.DeclaringType}:{MethodBase.GetCurrentMethod()?.Name}");
    }

    // Equivalent To [OneTimeTearDown] Or [ClassCleanup]
    public void Dispose()
    {
        Debug.WriteLine($"[DEBUG] {MethodBase.GetCurrentMethod()?.DeclaringType}:{MethodBase.GetCurrentMethod()?.Name}");
    }
}
