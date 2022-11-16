namespace L07_Interfaces.Examples.Menu;

public class App
{
    private IMenuItem[] _menu;
    private AppContext _context;
    public App()
    {
        InitializeMenu();
        _context = new AppContext();
    }
    
    public void Run()
    {
        while (!_context.HaltResquested)
        {
            Console.Clear();
            PrintMenu();
            var i = ReadOption();
            var menuItem = _menu[i - 1];
            menuItem.Execute(_context);

            Thread.Sleep(1000);
        }

        Console.WriteLine("Hej då!");
    }

    private void PrintMenu()
    {
        for (int i = 0; i < _menu.Length; i++)
            Console.WriteLine($"{i+1}. {_menu[i].DisplayName}");
        Console.WriteLine();
    }

    private int ReadOption()
    {
        Console.Write("Choose: ");
        return int.Parse(Console.ReadLine());
    }
    
    private void InitializeMenu()
    {
        _menu = new IMenuItem[]
        {
            new Sell(),
            new Buy(),
            new Message("Hello World!"),
            new Quit()
        };
    }
}