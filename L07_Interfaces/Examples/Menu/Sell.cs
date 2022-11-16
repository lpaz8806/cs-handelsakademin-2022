namespace L07_Interfaces.Examples.Menu;

public class Sell : IMenuItem
{
    public string DisplayName => "Sell";
    public void Execute(AppContext context)
    {
        Console.WriteLine("Im selling something");
    }
}