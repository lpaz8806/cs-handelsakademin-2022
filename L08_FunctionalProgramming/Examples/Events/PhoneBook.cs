namespace L08_FunctionalProgramming.Examples.Events;
// triggered or fired

public class PhoneBook
{
    public string Owner { get; }
    public event EventHandler<EntryAddedEventArgs> EntryAdded;
    
    public PhoneBook(string name)
    {
        Owner = name;
    }
    
    public void Add(string name, string phone)
    {
        // adding the entry
        OnEntryAdded(new EntryAddedEventArgs(name, phone));
    }
    public void Remove(string name)
    {
        
    }

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

    protected override void OnEntryAdded(EntryAddedEventArgs e)
    {
        Console.WriteLine("Whatever");
        // base.OnEntryAdded(e);
    }
}