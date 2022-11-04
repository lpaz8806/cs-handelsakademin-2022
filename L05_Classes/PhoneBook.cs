namespace L05_Classes;
// how will I store the information
// internal representation

// ["Luis", "Foo", ... ]
// ["1232", "123", ...]
public class PhoneBook
{
    /// <summary>
    /// Represents the minimum capacity allowed by the PhoneBook
    /// </summary>
    public const int MinCapacity = 2;
    
    private string[] _names;
    private string[] _phones;

    private int _count = 0;
    public bool IsFull => _count < _names.Length;

    public PhoneBook(int capacity = MinCapacity)
    {
        if (capacity < MinCapacity)
            throw new ArgumentOutOfRangeException();
        
        _names = new string[capacity];
        _phones = new string[capacity];
    }
    
    public string Search(string name)
    {
        var i = IndexOf(name);
        return i < 0 ? string.Empty : _phones[i];
    }
    
    public void Add(string name, string phoneNumber)
    {
        _names[_count] = name;
        _phones[_count] = phoneNumber;
        _count++;   // one more
    }
    public void Edit(string name, string phoneNumber)
    {
        var i = IndexOf(name);
        
        var numberExists = i >= 0; // explanatory variable
        if (numberExists)
            _phones[i] = phoneNumber;
    }
    
    public void Remove(string name)
    {
        var i = IndexOf(name);
        
        if(i < 0) return;

        _names[i] = _names[_count - 1];
        _phones[i] = _phones[_count - 1];

        _count--;
    }
    
    private int IndexOf(string name)
    {
        for (int i = 0; i < _count; i++)
            if (NameMatches(_names[i], name))
                return i;
        
        return -1; // not a valid index
    }
    
    private bool NameMatches(string name, string pattern)
    {
        return name.Equals(pattern, StringComparison.InvariantCultureIgnoreCase);
    }
}
