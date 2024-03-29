namespace Sandbox;

public class ExtensionMethodTest
{
    [Test]
    public void Test1()
    {
        Assert.That(
            ""
                .AddLetter('f')
                .AddLetter('o')
                .AddLetter('o'), 
            Is.EqualTo("foo"));
    }
}