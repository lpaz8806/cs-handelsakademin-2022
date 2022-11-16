namespace L08_FunctionalProgramming.Examples.Events;

public class PhoneBookExample
{
    public static void Run()
    {
        var pb = new PhoneBook("Luis");
        // we want to do something when
        // a new entry is added to the phonebook

        // subscribe to EntryAdded event
        pb.EntryAdded += OnEntryAdded;
        
        // events
        pb.Add("Ola", "123455");
    }
    
    public static void RunOverride()
    {
        var pb = new PhoneBook("Luis");
        var spb = new SuperPhoneBook("Foo");
        // we want to do something when
        // a new entry is added to the phonebook

        // subscribe to EntryAdded event
        pb.EntryAdded += OnEntryAdded;
        spb.EntryAdded += OnEntryAdded;
        
        // events
        pb.Add("Ola", "123455");
        spb.Add("Aasa", "7846578365");
    }
    
    static void OnEntryAdded(object? o, EntryAddedEventArgs e)
    {
        Console.WriteLine($"Entry '{e.Name}' added to {o}");
    }
}