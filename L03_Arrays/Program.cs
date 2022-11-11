namespace L03_Arrays;

class Program
{
    static void Main(string[] args)
    {
        var col = 3;
        var row = 0;
        for (int i = 0; i < 9; i++)
        {
            Console.WriteLine($"i = {row + i / 3}, j = {col + i % 3}");
        }

        return;
        int[,] numbers = new int[3, 2];
        char[,] letters =
        {
            {'l', 'o', 'c'},
            {'o', 'l', 'o'},
            {'q', 'u', 'i'},
            {'t', 'o', 'w'}
        };

        int[][] arr =
        {
            new[] { 1 },
            new[] { 2, 3 },
            new[] { 4, 5, 6 }
        };
        var x = arr[2][1];
        Console.WriteLine(x);
        
        
        // PrintMatrix(letters);
    }
    // invariant
    static int Max(int[] numbers)
    {
        var max = numbers[0];
        for (var i = 1; i < numbers.Length; i++)
            if (numbers[i] > max) // loop invariant
                max = numbers[i]; // max contains the max up to position i
        return max;
    }

    static int Sum(params int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
            sum += numbers[i];
        return sum;
    }
    
    static void PrintLines<T>(T[] items)
    {
        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine(items[i]);
        }
    }

    static void PrintMatrix<T>(T[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write($"{matrix[row, col]}  ");
            }

            Console.WriteLine();
        }
    }
}

/*
- Memory structure
- Common methods for array
Generics
params
IList<T>
Multidimensional arrays
*/

/*
- Declaration
- Creation
- Data access
https://zoom.us/j/8804372030
*/


