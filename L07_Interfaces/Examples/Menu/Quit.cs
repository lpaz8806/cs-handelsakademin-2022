namespace L07_Interfaces.Examples.Menu;

public class Quit : IMenuItem
{
    public string DisplayName => "Quit";
    public void Execute(AppContext context)
    {
        context.HaltResquested = true;
    }
}