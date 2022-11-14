namespace L07_Interfaces.Examples.Implementations;

public class FooGoo : IFoo, IGoo
{
    private int _count = 5;

    public int Count => _count;
    
    void IFoo.DoSomething()
    {
        Console.WriteLine("Foo doing something");
    }

    void IGoo.DoSomething()
    {
        Console.WriteLine("Goo is doing something");
    }
    
    
    
    public void GoogleIt()
    {
        Console.WriteLine("Im googling it");
    }
}