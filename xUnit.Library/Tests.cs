namespace xUnit.Library;

// xUnit Does Not Require An Attribute For A Test Class
public class Tests(ITestOutputHelper output)
{
    private Guid TransientIdentifier { get; } = Guid.NewGuid();

    private ITestOutputHelper Output { get; } = output;

    [Fact]
    public void IdentifierTestOne()
    {
        Output.WriteLine(TransientIdentifier.ToString());
        Assert.NotEqual(Guid.Empty, TransientIdentifier);
    }

    [Fact]
    public void IdentifierTestTwo()
    {
        Output.WriteLine(TransientIdentifier.ToString());
        Assert.NotEqual(Guid.Empty, TransientIdentifier);
    }
}
