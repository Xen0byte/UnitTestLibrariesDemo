namespace MSTest.Library;

[TestClass]
public class Tests
{
    private Guid TransientIdentifier { get; } = Guid.NewGuid();

    public TestContext TestContext { get; set; } = null!;

    [TestMethod]
    public void IdentifierTestOne()
    {
        TestContext.WriteLine(TransientIdentifier.ToString());
        Assert.AreNotEqual(Guid.Empty, TransientIdentifier);
    }

    [TestMethod]
    public void IdentifierTestTwo()
    {
        TestContext.WriteLine(TransientIdentifier.ToString());
        Assert.AreNotEqual(Guid.Empty, TransientIdentifier);
    }
}
