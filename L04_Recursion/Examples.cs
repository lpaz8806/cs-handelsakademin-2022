namespace L04_Recursion;

public class Examples
{
    public static void HanoiMove(int n, int start, int end, int aux)
    {
        if(n ==0) return;
        
        if (n == 1)
        {
            Console.WriteLine($"Move from tower {start} to tower {end}");
            // Console.ReadKey(true);
            return;
        }

        HanoiMove(n - 1, start, aux, end);
        HanoiMove(1, start, end, aux);
        HanoiMove(n - 1, aux, end, start);
    }
    
    public static uint Add(uint x, uint y)
    {
        if (x == 0)
            return y;

        return Add(x - 1, y + 1);
    }

    public static string DecimalToBinaryString(uint number)
    {
        if (number == 0)
            return "0";

        var digit = number % 2;
        var rest = DecimalToBinaryString(number / 2);
        
        return rest + digit;
    }

    public static void CountDown(int v)
    {
        if(v == 0)
            return;
        
        Console.WriteLine(v);
        CountDown(v - 1);
        Console.WriteLine(v);
    } 
    
    public static int BinarySearch(int[] sortedArray, int item)
    {
        return BinarySearch(
            sortedArray, 
            item, 0, sortedArray.Length - 1);
    }
    static int BinarySearch(
        int[] sortedArray, 
        int item, int start, int end)
    {
        var mid = (start + end) / 2;
        if (sortedArray[mid] == item)
            return mid;

        if (start == end)
            return -1;

        if (item < sortedArray[mid])
            return BinarySearch(sortedArray, item, start, mid - 1);
        
        return BinarySearch(sortedArray, item, mid + 1, end);
    }
}