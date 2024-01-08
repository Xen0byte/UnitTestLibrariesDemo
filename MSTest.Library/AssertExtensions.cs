namespace MSTest.Library;

public static class AssertExtensions
{
    public static void AllAreTrue(this Assert assert, params Action[] assertions)
    {
        if (assertions.Any().Equals(false)) return;

        List<Exception> exceptions = [];

        foreach (Action action in assertions)
        {
            try
            {
                action.Invoke();
            }

            catch (Exception exception)
            {
                exceptions.Add(exception);
            }
        }

        if (exceptions.Any())
        {
            string result = string.Join(Environment.NewLine + Environment.NewLine, exceptions);

            Assert.Fail(result);
        }
    }
}
