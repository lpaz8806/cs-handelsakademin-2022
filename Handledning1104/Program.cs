using System.Collections.Immutable;
using Handledning1104;
// more expressive
class Program
{
    static void Main()
    {
        int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9};
        numbers
            .Where(x => x % 2 == 0)
            .Select(x => x * x)
            .Where(x => x < 20)
            .ForEach(Console.WriteLine);
    }

    static void Example()
    {
        Console.WriteLine("Write a letter from [a..e], enter to quit:");
        while (true)
        {
            var c = Console.ReadKey(true);
            if ("abcde".Contains(c.KeyChar))
            {
                Console.Write(c.KeyChar);
            }

            if (c.Key == ConsoleKey.Enter)
                break;
        }
    }
}
