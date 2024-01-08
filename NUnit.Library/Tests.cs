namespace NUnit.Library;

[TestFixture]
public class Tests
{
    private Guid TransientIdentifier { get; } = Guid.NewGuid();

    [Test]
    public void IdentifierTestOne()
    {
        TestContext.WriteLine(TransientIdentifier);
        Assert.That(TransientIdentifier, Is.Not.EqualTo(Guid.Empty));
    }

    [Test]
    public void IdentifierTestTwo()
    {
        TestContext.WriteLine(TransientIdentifier);
        Assert.That(TransientIdentifier, Is.Not.EqualTo(Guid.Empty));
    }
}
