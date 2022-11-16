namespace L07_Interfaces.Examples.Menu;

public interface IMenuItem
{
    string DisplayName { get; }
    void Execute(AppContext context);
}