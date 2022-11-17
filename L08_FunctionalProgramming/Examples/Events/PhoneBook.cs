namespace L08_FunctionalProgramming.Examples.Events;
// triggered, fired or raised

public class PhoneBook
{
    public string Owner { get; }
    
    // Declare an event
    public event EventHandler<EntryAddedEventArgs> EntryAdded;
    
    public PhoneBook(string name)
    {
        Owner = name;
    }
    
    public void Add(string name, string phone)
    {
        // adding the entry
        
        // fire the event. notify every subscriber
        OnEntryAdded(new EntryAddedEventArgs(name, phone));
    }
    public void Remove(string name)
    {
        
    }

    // Allow children classes to rise the event
    protected virtual void OnEntryAdded(EntryAddedEventArgs e)
    {
        if (EntryAdded != null)
            EntryAdded(this, e);
    }
    
    public override string ToString()
    {
        return $"{Owner}'s phonebook";
    }
}

public class SuperPhoneBook : PhoneBook
{
    public SuperPhoneBook(string name) : base(name)
    {
    }

    // Redefine the way the event is triggered
    protected override void OnEntryAdded(EntryAddedEventArgs e)
    {
        Console.WriteLine("Whatever");
        // Call the parent "trigger"
        base.OnEntryAdded(e);   
    }
}