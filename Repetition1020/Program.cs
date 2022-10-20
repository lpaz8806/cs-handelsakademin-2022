// Data-types
// operations
// ifs
// loops
// single-dimensional arrays

// var means: Let the compiler figure out what is the type

int[] numbers = new int[3];     // Create an array of 3 integers

// feed the array
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write("Type a number: ");
    var number = int.Parse(Console.ReadLine());
    numbers[i] = number;
}

// print the numbers (do something with all elements in the array)
/*
for (int i = 0; i < numbers.Length; i++)
{
    var currentNumber = numbers[i];
    Console.WriteLine(currentNumber);
}
*/

