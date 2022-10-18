# C# Grund

## Lesson 1: Data types

### Integers

### Floating point (approximate)



## Lesson 2: Flow Control


## Lesson 3: Arrays

### Declaration

Specify the size
``var words = new string[5];``

Explicit delaration/creation
`int[] oneToFive = { 1, 2, 3, 4, 5 };`

// attempt to access an index outside the array
// will throw an Exception
// Console.WriteLine(oneToFive[6]);
### Creation

### Data access

### Memory structure

### Common methods for array
int[] oneToFive = { 1, 2, 3, 4, 5 };
Console.WriteLine(string.Join(", ", oneToFive));
Array.Clear(oneToFive);
Console.WriteLine(string.Join(", ", oneToFive));
Array.Fill(oneToFive, 5);
Console.WriteLine(string.Join(", ", oneToFive));
Array.Resize(ref oneToFive, 10);
Console.WriteLine(string.Join(", ", oneToFive));
### Generics

### params

### IList&lt;T&gt;

### Flerdimensionella arrayer
