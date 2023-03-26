using System;
using System.Collections.Generic;

interface IHello
{
    void SayHello();
}

class HelloInRussian : IHello
{
    public void SayHello()
    {
        Console.WriteLine("Привет");
    }
}

class HelloInEnglish : IHello
{
    public void SayHello()
    {
        Console.WriteLine("Hello");
    }
}

class HelloInFrench : IHello
{
    public void SayHello()
    {
        Console.WriteLine("Bonjour");
    }
}

class HelloInGerman : IHello
{
    public void SayHello()
    {
        Console.WriteLine("Guten Tag");
    }
}

class HelloInSpanish : IHello
{
    public void SayHello()
    {
        Console.WriteLine("Hola");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<IHello> helloList = new List<IHello>();

        helloList.Add(new HelloInRussian());
        helloList.Add(new HelloInEnglish());
        helloList.Add(new HelloInFrench());
        helloList.Add(new HelloInGerman());
        helloList.Add(new HelloInSpanish());

        foreach (IHello hello in helloList)
        {
            hello.SayHello();
        }

        Console.ReadKey( true );
    }
}
