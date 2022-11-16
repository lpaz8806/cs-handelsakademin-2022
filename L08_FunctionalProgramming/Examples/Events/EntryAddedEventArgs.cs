namespace L08_FunctionalProgramming.Examples.Events;

public class EntryAddedEventArgs : EventArgs
{
    public string Name { get; }
    public string Phone { get; }

    public EntryAddedEventArgs(string name, string phone)
    {
        Name = name;
        Phone = phone;
    }
}