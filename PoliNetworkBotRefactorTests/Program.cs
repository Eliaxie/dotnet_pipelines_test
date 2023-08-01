using PoliNetworkBotRefactor;
using Xunit;

namespace PoliNetworkBotRefactorTests;

public class HelloWorldTests
{
    [Fact]
    public void TestSayHello()
    {
        // Arrange
        HelloWorld helloWorld = new HelloWorld();

        // Act
        string result = helloWorld.SayHello();

        // Assert
        Assert.Equal("Hello, World!", result);
    }
}