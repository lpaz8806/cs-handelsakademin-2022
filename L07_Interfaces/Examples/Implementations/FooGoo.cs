namespace L07_Interfaces.Examples.Implementations;

public class FooGoo : IFoo, IGoo
{
    private int _count = 5;

    public int Count => _count;
    
    // Explicit implementation of IFoo.DoSomething
    void IFoo.DoSomething()
    {
        Console.WriteLine("Foo doing something");
    }

    void IGoo.DoSomething()
    {
        Console.WriteLine("Goo is doing something");
    }
    
    
    // Implicit implementation of GoogleIt
    public void GoogleIt()
    {
        Console.WriteLine("Im googling it");
    }
}