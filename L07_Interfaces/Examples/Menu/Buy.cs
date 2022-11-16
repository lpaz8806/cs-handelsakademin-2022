namespace L07_Interfaces.Examples.Menu;

public class Buy : IMenuItem
{
    public string DisplayName => "Buy";
    public void Execute(AppContext context)
    {
        Console.WriteLine("Im buying something");
    }
}