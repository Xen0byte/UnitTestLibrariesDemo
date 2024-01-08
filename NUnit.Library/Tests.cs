namespace NUnit.Library;

[TestFixture]
public class Tests
{
    private Guid TransientIdentifier { get; } = Guid.NewGuid();

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        Debug.WriteLine($"[DEBUG] {MethodBase.GetCurrentMethod()?.DeclaringType}:{MethodBase.GetCurrentMethod()?.Name}");
    }

    [OneTimeSetUp]
    public void SetUp()
    {
        Debug.WriteLine($"[DEBUG] {MethodBase.GetCurrentMethod()?.DeclaringType}:{MethodBase.GetCurrentMethod()?.Name}");
    }

    [Test]
    public void IdentifierTestOne()
    {
        Debug.WriteLine($"[DEBUG] {MethodBase.GetCurrentMethod()?.DeclaringType}:{MethodBase.GetCurrentMethod()?.Name}");
        TestContext.WriteLine(TransientIdentifier);
        Assert.That(TransientIdentifier, Is.Not.EqualTo(Guid.Empty));
    }

    [Test]
    public void IdentifierTestTwo()
    {
        Debug.WriteLine($"[DEBUG] {MethodBase.GetCurrentMethod()?.DeclaringType}:{MethodBase.GetCurrentMethod()?.Name}");
        TestContext.WriteLine(TransientIdentifier);
        Assert.That(TransientIdentifier, Is.Not.EqualTo(Guid.Empty));
    }

    [Test]
    [TestCase("one", "two")]
    public void TestWithDataAndCompositeAssertion(string first, string second)
    {
        Debug.WriteLine($"[DEBUG] {MethodBase.GetCurrentMethod()?.DeclaringType}:{MethodBase.GetCurrentMethod()?.Name}");

        Assert.Multiple(() =>
        {
            const string one = "one";
            const string two = "two";

            Assert.That(first, Is.EqualTo(one));
            Assert.That(second, Is.EqualTo(two));
        });
    }

    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        Debug.WriteLine($"[DEBUG] {MethodBase.GetCurrentMethod()?.DeclaringType}:{MethodBase.GetCurrentMethod()?.Name}");
    }

    [TearDown]
    public void TearDown()
    {
        Debug.WriteLine($"[DEBUG] {MethodBase.GetCurrentMethod()?.DeclaringType}:{MethodBase.GetCurrentMethod()?.Name}");
    }
}
