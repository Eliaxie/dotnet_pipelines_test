// Assuming this class is part of a project referenced by your test project
namespace PoliNetworkBotRefactor;

public class HelloWorld
{
    public string SayHello()
    {
        return "Hello, World!";
    }
}

public static class Program
{
    public static void Main(string[] args)
    {
        HelloWorld helloWorld = new HelloWorld();
        string result = helloWorld.SayHello();
        Console.WriteLine(result);
    }
}