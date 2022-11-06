/*
Inheritance
Interfaces
Polymorphism
virtual and override
Abstract classes
Object superclass
Casting
Operators "is" and "as"
Keyword sealed
*/

class Program
{
    static void Main(string[] args)
    {
    }

    static void Sort(int[] numbers)
    {
        for (var i = 0; i < numbers.Length-1; i++)
        for (var j = i+1; j < numbers.Length; j++)
            if (numbers[i] > numbers[j])
                // swap by tuple deconstruction (C# sugar syntax since C# 7)
                (numbers[i], numbers[j]) = (numbers[j], numbers[i]);
    }
}
