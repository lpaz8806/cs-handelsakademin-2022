using Handledning1104;

class Program
{
    static void Main()
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
