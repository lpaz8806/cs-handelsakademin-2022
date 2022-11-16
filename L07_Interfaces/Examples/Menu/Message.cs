namespace L07_Interfaces.Examples.Menu;

public class Message : IMenuItem
{
    private string _message;

    public Message(string message)
    {
        _message = message;
    }

    public string DisplayName => "SaySomething I'm giving up on you";
    public void Execute(AppContext context)
    {
        Console.WriteLine(_message);
    }
}