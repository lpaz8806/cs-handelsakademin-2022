namespace L09_IO;

public class Animal
{
    public string Name { get; set; }
    public string Race { get; set; }

    public override string ToString()
    {
        return $"{Name}({Race})";
    }
}