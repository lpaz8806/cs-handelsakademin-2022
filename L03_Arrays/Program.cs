namespace L03_Arrays;

class Program
{
    static void Main(string[] args)
    {
        int[] collectionOfNumbers = { 8, 3, 9, 1, 7, 5};
        var secondMin = Exercises.SecondSmallest(collectionOfNumbers);
        Console.WriteLine(secondMin);
    }
}

/*
Declaration
Creation
Data access
Memory structure
Common methods for array
Generics
params
IList<T>
Multidimensional arrays
Jagged arrays (irregular matrices)
*/
