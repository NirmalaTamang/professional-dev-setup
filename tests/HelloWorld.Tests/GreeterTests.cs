using Xunit;

namespace HelloWorld.Tests;

public class GreeterTests
{
    [Fact]
    public void Greet_ReturnsExpectedMessage()
    {
        Assert.Equal("Hello, World!", Greeter.Greet("World"));
    }

    [Fact]
    public void Greet_WorksWithCustomName()
    {
        Assert.Equal("Hello, Hero!", Greeter.Greet("Hero"));
    }

    [Fact]
    public void Greet_ThrowsOnNull()
    {
        Assert.Throws<ArgumentException>(() => Greeter.Greet(null!));
    }

    [Fact]
    public void Greet_ThrowsOnBlank()
    {
        Assert.Throws<ArgumentException>(() => Greeter.Greet("   "));
    }
}
