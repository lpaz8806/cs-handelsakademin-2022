namespace ProgsharpSolutions;

static class Kapitel5
{
    public static void Exercise5_11()
    {
        string[,] map =
        {
            { "A", "B", "C", "D" },
            { "E", "F", "G", "H" },
            { "I", "J", "K", "L" },
            { "M", "N", "O", "P" }
        };
        
        var row = 0;
        var col = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Du står på '{map[row, col]}' (X:{col}, Y:{row})");
            Console.Write("Välj en riktning: ");
            Console.WriteLine("w = upp, s = ner, a = vänster, d = höger, e = avsluta");
            var movement = Console.ReadLine();
            
            if(string.IsNullOrEmpty(movement))
                break;
            
            switch (movement)
            {
                case "w":
                    row = Math.Max(0, row - 1);
                    break;
                case "s":
                    row = Math.Min(3, row + 1);
                    break;
                case "a":
                    col = Math.Max(0, col - 1);
                    break;
                case "d":
                    col = Math.Min(3, col + 1);
                    break;
                default:
                    Console.WriteLine("Invalid move");
                    break;
            }
        }

        Console.WriteLine($"You ended up at '{map[row, col]}' (X:{col}, Y:{row})");
    }
}
