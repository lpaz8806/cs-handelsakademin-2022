namespace ProgsharpSolutions;

static class Kapitel4
{
    /// <summary>
    /// Skapa ett program som beräknar siffersumman av ett
    /// tal som användaren skriver in. Siffersumman fås om
    /// man beräknar summan av varje siffra i ett tal.
    /// </summary>
    /// <example>
    /// Så är siffersumman av 527 lika med 14 eftersom 5 + 2 + 7 = 14
    /// </example>
    public static void Exercise4_7()
    {
        Console.Write("Type a number: ");
        var digits = Console.ReadLine();
            
        int sum = 0;
        
        for (int i = 0; i < digits.Length; i++)
        {
            // convert a char representing a digit to int
            var digit = digits[i] - '0';
            sum += digit;
        }
        
        Console.WriteLine(sum);
    }

    public static void Exercise4_8()
    {
        Console.WriteLine("Exer 4.8");
    }
    
}