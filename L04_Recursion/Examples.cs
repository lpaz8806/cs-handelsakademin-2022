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

        var digit = number % 2; // the last digit
        var rest = DecimalToBinaryString(number / 2); // n / 2 is the rest of the number
        
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
    
    /// <summary>
    /// Given a boolean map where true means land and false means
    /// water. Counts the amount of islands in that map.
    /// A single true is a island
    /// </summary>
    /// <example>
    /// 0 1 0 1
    /// 1 1 0 1     =>  2
    /// 0 0 0 0
    ///
    /// 0 0 0 1
    /// 1 0 0 1     =>  2
    /// 0 0 1 1
    ///
    /// 1 0 0 0
    /// 0 1 0 0     =>  1
    /// 0 0 1 0
    /// </example>
    /// <returns>The amount of islands found</returns>
    public static int CountIslands(bool[,] map)
    {
        // RemoveIsland will change the map, so in order to keep
        // the input as it is, we need to clone it
        var mapClone = (bool[,])map.Clone();  // Clones the map

        var islandsCount = 0;
        
        // traverse the whole map
        for (int i = 0; i < map.GetLength(0); i++)
        for (int j = 0; j < map.GetLength(1); j++)
        {
            if (mapClone[i, j]) // if it is land
            {
                islandsCount++; // count a new  island
                DestroyIsland(mapClone, i, j); // destroy the island (make land to be water)
                // so when you visit it again, it does not count again
            }
        }
        return islandsCount;
    }

    static void DestroyIsland(bool[,] map, int i, int j)
    {
        // check boundaries
        if(i < 0 || i >= map.GetLength(0))
            return;
        
        if(j < 0 || j >= map.GetLength(1))
            return;

        if (map[i, j] == false) // in case of water
            return;

        map[i, j] = false;  // make the land to be water
        // for each possible direction (-1, 0, 1) of row and column
        for (int directionInI = -1; directionInI <= 1; directionInI++)
        for (int directionInJ = -1; directionInJ <= 1; directionInJ++)
            DestroyIsland(map, i + directionInI, j + directionInJ); // move there and recursively destroy

        /*
        DestroyIsland(map, i, j - 1);
        DestroyIsland(map, i, j + 1);
        DestroyIsland(map, i - 1, j);
        DestroyIsland(map, i - 1, j - 1);
        DestroyIsland(map, i - 1, j + 1);
        DestroyIsland(map, i + 1, j);
        DestroyIsland(map, i + 1, j - 1);
        DestroyIsland(map, i + 1, j + 1);
        */
    }
    
    /// <summary>
    /// Computes the i-th term of the Fibonacci sequence
    /// 1,1,2,3,5,8,...
    /// 0-th -> 1
    /// 1-th -> 1
    /// 2-th -> 2
    /// Definition:
    /// Fib(n) = {
    ///                   1 if n = 1 or n = 2
    /// Fib(n-1) + Fib(n-2) otherwise
    /// }
    /// </summary>
    /// <param name="i"></param>
    /// <returns></returns>
    public static uint Fibonacci(uint i)
    {
        if (i < 2)
            return 1;

        return Fibonacci(i - 1) + Fibonacci(i - 2);
    }
    
    public static ulong FibonacciIter(uint n)
    {
        if (n < 2) return 1;
        
        var f1 = 1UL;
        var f2 = 1UL;
        for (int j = 2; j <= n; j++)
        {
            var next = f1 + f2;
            f2 = f1;
            f1 = next;
        }

        return f1;
    }
}