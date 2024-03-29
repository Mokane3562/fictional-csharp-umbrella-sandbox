namespace HelloWorldConsoleApp;

using HelloWorldClassLibrary;

class HelloWorldMain
{
    static void Main(string[] args) 
    {
        Console.WriteLine(HelloWorldUtil.SayHello());
        Console.ReadKey(); 
    } 
}
