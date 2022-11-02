namespace L05_Classes;

// How to define the class and its members?
// What is the purpose of this class?

// [visibility] class [class name]

public class Person
{
    #region FIELDS
    // internal representation
    // needs to be remembered
    
    // [visibility] [type] [name];
    // [visibility] [type] [name] = [constant-value];
    private int _age;
    private string _name;

    #endregion

    #region Constructor
    
    // Ctor is a special kind of method that will be called
    // to initialize the object
    public Person(string name)
    {
        _name = name;
        _age = 0;
    }
    
    public Person(string name, int age)
    {
        _name = name;
        _age = age;
    }
    
    public Person(int age)
    {
        _name = "John Doe";
        _age = age;
    }
    
    #endregion
    
    #region PROPERTIES
    
    // [visibility] [type] [name] => expression
    public int Age => _age;
    
    // [visibility] [type] [name] { [get part]? [set part]? }
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            // value is a keyword, representing
            // the value assigned to the property
            _name = value;
        }
    }
    
    #endregion

    #region METHODS

    /*
    [visibility] [return-type | void] [name] (<arguments_list>) {
        // method body
    }
    */
    public void FyllaÅr()
    {
        _age++;
    }
    
    #endregion
}

// visibility indicates the scope of the class
// (where this class can be accessed)
// private | public

// Members
// fields, properties, methods


#region Naming Conventions

// Class name should be in PascalCase

// Fields follow this convention
// if private, starts with underscore followed by camelCase name

// Properties names should be in PascalCase


#endregion



