namespace MSTest.Library;

[TestClass]
public class Tests
{
    private Guid TransientIdentifier { get; } = Guid.NewGuid();

    public TestContext TestContext { get; set; } = null!;

    [AssemblyInitialize]
    public static void AssemblyInitialize(TestContext testContext)
    {
        Debug.WriteLine($"[DEBUG] {MethodBase.GetCurrentMethod()?.DeclaringType}:{MethodBase.GetCurrentMethod()?.Name}");
    }

    [ClassInitialize]
    public static void ClassInitialize(TestContext testContext)
    {
        Debug.WriteLine($"[DEBUG] {MethodBase.GetCurrentMethod()?.DeclaringType}:{MethodBase.GetCurrentMethod()?.Name}");
    }

    [TestInitialize]
    public void TestInitialize()
    {
        Debug.WriteLine($"[DEBUG] {MethodBase.GetCurrentMethod()?.DeclaringType}:{MethodBase.GetCurrentMethod()?.Name}");
    }

    [TestMethod]
    public void IdentifierTestOne()
    {
        Debug.WriteLine($"[DEBUG] {MethodBase.GetCurrentMethod()?.DeclaringType}:{MethodBase.GetCurrentMethod()?.Name}");
        TestContext.WriteLine(TransientIdentifier.ToString());
        Assert.AreNotEqual(Guid.Empty, TransientIdentifier);
    }

    [TestMethod]
    public void IdentifierTestTwo()
    {
        Debug.WriteLine($"[DEBUG] {MethodBase.GetCurrentMethod()?.DeclaringType}:{MethodBase.GetCurrentMethod()?.Name}");
        TestContext.WriteLine(TransientIdentifier.ToString());
        Assert.AreNotEqual(Guid.Empty, TransientIdentifier);
    }

    [TestCleanup]
    public void TestCleanup()
    {
        Debug.WriteLine($"[DEBUG] {MethodBase.GetCurrentMethod()?.DeclaringType}:{MethodBase.GetCurrentMethod()?.Name}");
    }

    [ClassCleanup]
    public static void ClassCleanup()
    {
        Debug.WriteLine($"[DEBUG] {MethodBase.GetCurrentMethod()?.DeclaringType}:{MethodBase.GetCurrentMethod()?.Name}");
    }

    [AssemblyCleanup]
    public static void AssemblyCleanup()
    {
        Debug.WriteLine($"[DEBUG] {MethodBase.GetCurrentMethod()?.DeclaringType}:{MethodBase.GetCurrentMethod()?.Name}");
    }
}
