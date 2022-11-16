namespace L08_FunctionalProgramming.Examples.Events;

public class Person
{
    public static event EventHandler Called;
    public string Name { get; }

    public Person(string name)
    {
        Name = name;
    }

    public void Call()
    {
        if(Called != null)
            Called(this, EventArgs.Empty);
    }

    protected static void OnCalled(Person sender)
    {
        if(Called != null)
            Called(sender, EventArgs.Empty);
    }
}

class Teacher : Person
{
    public Teacher(string name) : base(name)
    {
        OnCalled(this);
    }
}