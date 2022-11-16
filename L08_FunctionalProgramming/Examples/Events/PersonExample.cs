namespace L08_FunctionalProgramming.Examples.Events;

public static class PersonExample
{
    public static void Run()
    {
        Person[] people = InitPeople();
        
        // subscribe to the event
        Person.Called += LogCall;
        Person.Called += SaveToDB;

        // collection of delegates
        
        ChooseToCallSomeone(people);
        
        // something happened and we don't need to save to DB anymore
        
        // unsubscribe SaveToDB
        Person.Called -= SaveToDB;
        
        ChooseToCallSomeone(people);
    }

    static void ChooseToCallSomeone(Person[] people)
    {
        Console.Write($"Choose 0-{people.Length - 1}: ");
        var j = int.Parse(Console.ReadLine());
        people[j].Call();
    }

    static void LogCall(object? sender, EventArgs e)
    {
        var p = sender as Person;
        Console.WriteLine($"{p.Name} was called");
    }
    
    static void SaveToDB(object? sender, EventArgs e)
    {
        var p = sender as Person;
        Console.WriteLine($"{p.Name} was saved to DB");
    }

    static Person[] InitPeople()
    {
        return new Person[]
        {
            new ("ana"),
            new ("banana"),
            new ("ema"),
            new ("problema")
        };
    }
}