namespace L04_Recursion;

public class Exercises
{
    #region Tail recursion and some others not-tail

    /// <summary>
    /// Computes the sum of x and y.
    /// </summary>
    /// <remarks>
    /// The operations + and - only be used if one of the operands is 1
    /// </remarks>
    /// <example>
    /// x + 1 is allowed
    /// 1 + x is allowed
    /// x + 5 is not allowed
    /// x + y is not allowed
    /// </example>
    public static uint Add(uint x, uint y)
    {
        if (y == 0)
            return x;
        
        // tail recursion
        return Add(x + 1, y - 1);
    }
    
    /*
    add(3,2) => 5
    add(4,1) => 5
    add(5,0)  => 5
     */
    
    /// <summary>
    /// Computes the subtraction of x and y.
    /// </summary>
    /// <remarks>
    /// The operations + and - only be used if one of the operands is 1
    /// </remarks>
    /// <example>
    /// x + 1 is allowed
    /// 1 + x is allowed
    /// x + 5 is not allowed
    /// x + y is not allowed
    /// </example>
    public static uint Sub(uint x, uint y)
    {
        if (y == 0)
            return x;

        return Add(x - 1, y - 1);
    }
    
    /// <summary>
    /// Computes the product of x and y.
    /// Assume x and y non-negatives
    /// </summary>
    /// <remarks>
    /// The operations *, / and % are not allowed.
    /// </remarks>
    public static uint Mul(uint x, uint y)
    {
        if (y == 0)
            return 0;

        return x + Mul(x, y - 1);
    }
    
    /// <summary>
    /// Computes the integer division of x and y.
    /// Assume x >= 0 and y > 0
    /// </summary>
    /// <remarks>
    /// The operations * and / are not allowed.
    /// </remarks>
    public static uint Div(uint x, uint y)
    {
        if (x < y)
            return 0;

        return 1 + Div(x - y, y);
    }
    
    /// <summary>
    /// Computes the reminder in the division of x by y.
    /// Assume y != 0
    /// </summary>
    /// <remarks>
    /// The operations *, / and % are not allowed.
    /// </remarks>
    public static uint Mod(uint x, uint y)
    {
        if (x < y)
            return x;

        return Mod(x - y, y);
    }

    /// <summary>Computes the opposite of x</summary>
    /// <remarks>
    /// The operations + and - only be used if one of the operands is 1.
    /// No other arithmetic operation or mathematical function is allowed
    /// </remarks>
    /// <example>
    /// Neg(0) = 0
    /// Neg(-5) = 5
    /// Neg(8) = -8
    /// </example>
    public static int Neg(int x)
    {
        if (x == 0)
            return 0;

        if (x > 0)
            return Neg(x - 1) - 1;
        
        return Neg(x + 1) + 1;
    }
    
    /// <summary>
    /// Computes x to the power of y.
    /// Assume that x and y are not 0 at the same time.
    /// This means:
    /// if x is 0 then y is not 0.
    /// if y is 0 then x is not 0.
    /// </summary>
    public static uint Pow(uint x, uint y)
    {
        if (y == 0)
            return 1;

        return x * Pow(x, y - 1);
    }
    
    /// <summary>
    /// Computes the sum of the digits of the specified
    /// non-negative number.
    ///
    /// Hint: Given a number, how to compute its least significant
    /// digit? (the right-most digit)
    /// </summary>
    /// <example>
    /// DigitsSum(1) = 1
    /// DigitsSum(12) = 3
    /// DigitsSum(135) = 9
    /// DigitsSum(2022) = 6
    /// </example>
    public static int DigitsSum(int n)
    {
        var lastDigit = n % 10;
        var nExceptLastDigit = n / 10;
        
        if (n == 0)
            return 0;
        
        return lastDigit + DigitsSum(nExceptLastDigit);
    }
    
    /// <summary>
    /// Counts the number of occurrences of the digit d in n.
    /// Assume n >= 0 and d between 0 and 9
    /// </summary>
    /// <example>
    /// CountDigit(0, 0) = 1
    /// CountDigit(10, 0) = 1
    /// CountDigit(1, 1) = 1
    /// CountDigit(1233, 3) = 2
    /// CountDigit(11325345, 8) = 0
    /// </example>
    public static int CountDigit(int n, int d)
    {
        var lastDigit = n % 10;
        var nExceptLastDigit = n / 10;

        var count = lastDigit == d ? 1 : 0;

        var areThereMoreDigitsToExplore = nExceptLastDigit > 0;
        if (areThereMoreDigitsToExplore)
            count += CountDigit(nExceptLastDigit, d);

        return count;
    }
    /// <summary>
    /// Counts the number of 1s (ones) in the binary number n
    /// </summary>
    public static int CountOnes(int n)
    {
        return 0;
    }


    /// <summary>
    /// Computes the Fibonacci sequence up the n-th term
    /// </summary>
    /// <example>
    /// FSeq(3) = {1,1,2,3}
    /// FSeq(6) = {1,1,2,3,5,8,13}
    /// </example>
    public static ulong[] FibonacciSequence(int n)
    {
        var seq = new ulong[n];
        // Initialize the two known cases so you don't need to
        // have base cases
        Array.Fill(seq, 1UL, 0, Math.Min(n, 2));
        
        if(n > 2)
            FillFibonacciSequence(n, seq);
        
        return seq;
    }
    
    static void FillFibonacciSequence(int n, ulong[] seq)
    {
        var posInSeq = n - 1; 
        
        if (seq[posInSeq] != 0)
            return;
        
        FillFibonacciSequence(n - 1, seq);
        seq[posInSeq] = seq[posInSeq - 1] + seq[posInSeq - 2];
    }
    
    #endregion

    #region Divide and Conquer

    /// <summary>
    /// Computes x to the power of y.
    /// Assume that x and y are not 0 at the same time.
    /// 
    /// Use the divide and conquer approach to reduce the
    /// amount of multiplications 
    /// </summary>
    public static uint FastPow(uint x, uint y)
    {
        if (y == 0)
            return 1;

        // Recursively compute the pow up to half the exponent
        var halfPow = FastPow(x, y / 2);
        // combine to get the whole power
        var pow = halfPow * halfPow;
        
        // Notice that this is pow is only valid when the exponent is even
        
        if (y % 2 == 1) // if the exponent is odd
            pow *= x;   // we need to include the one more x
        
        return pow;
    }

    /// <summary>
    /// Merges (blandar) the specified SORTED arrays and
    /// returns another sorted array.
    ///
    /// This problem can be solved iteratively (using loops)
    /// </summary>
    /// <example>
    /// MergeSortedArrays({1,2}, {3,4,5}) => {1,2,3,4,5}
    /// MergeSortedArrays({3,4,5}, {1,2}) => {1,2,3,4,5} 
    /// MergeSortedArrays({1,3,5}, {2,7,9,11}) => {1,2,3,5,7,9,11} 
    /// </example>
    public static int[] MergeSortedArrays(int[] arr1, int[] arr2)
    {
        var result = new int[arr1.Length + arr2.Length];

        var i = 0; // use with arr1
        var j = 0; // use with arr2
        var k = 0; // use with result
        
        while (i < arr1.Length && j < arr2.Length)
            result[k++] = arr1[i] < arr2[j] 
                ? arr1[i++] 
                : arr2[j++];
        
        
        while (i < arr1.Length)
            result[k++] = arr1[i++];

        while (j < arr2.Length)
            result[k++] = arr2[j++];

        return result;
    }

    /// <summary>
    /// Sorts the specified array.
    /// Make use of MergeSortedArrays
    /// </summary>
    public static void SortArray(int[] arr)
    {
        // an array of zero or one elements is already sorted
        if(arr.Length < 2)
            return;
        
        var midIndex = arr.Length / 2;
        
        // notice that midIndex here is the length of the subarray, not the end index
        var leftSubArray = arr[..midIndex];
        
        // the right subarray goes from midIndex to the end
        var rightSubArray = arr[midIndex..];
        
        // Recursively sort the left subarray
        SortArray(leftSubArray);
        // Recursively sort the right subarray
        SortArray(rightSubArray);
        
        // Merge sorted subarrays
        var mergedSubarrays = MergeSortedArrays(leftSubArray, rightSubArray);
        
        // copy the result to the original array
        Array.Copy(mergedSubarrays, arr, arr.Length);
    }
    
    #endregion

    #region Cool section
    
    /// <summary>
    /// Determines whether the specified number is a Wirth number.
    /// 
    /// Definition:
    /// - 1 is Wirth
    /// - if k (int) is Wirth then
    ///   2 * k + 1 is Wirth and
    ///   3 * k + 1 is Wirth
    /// </summary>
    /// <example>
    /// 1, 3, 4, 7, 9, 10, 13 ... are Wirth
    /// </example>
    /// <returns>true if n is a Wirth number, false otherwise</returns>
    public static bool IsWirth(int n)
    {
        return IsWirth(n, 1);
    }
    
    static bool IsWirth(int n, int currentWirthNumber)
    {
        if (n == currentWirthNumber)
            return true;

        if (currentWirthNumber > n)
            return false;
        
        return
            IsWirth(n, 2 * currentWirthNumber + 1) ||
            IsWirth(n, 3 * currentWirthNumber + 1);
    }
    
    /// <summary>
    /// Alternative implementation without helper method
    /// </summary>
    public static bool IsWirthBottomTop(int n)
    {
        return
            n == 1 ||
            n % 2 == 1 && IsWirthBottomTop(n / 2) ||
            n % 3 == 1 && IsWirthBottomTop(n / 3);
    }
    
    
    /// <summary>
    /// Computes the area of the largest island in the map
    /// </summary>
    /// /// <example>
    /// 0 1 0 1
    /// 1 1 0 1     =>  3
    /// 0 0 0 0
    ///
    /// 0 0 0 1
    /// 1 0 0 1     =>  4
    /// 0 0 1 1
    ///
    /// 1 0 0 0
    /// 0 1 0 0     =>  3
    /// 0 0 1 0
    /// </example>
    /// <param name="map"></param>
    /// <returns>The area of the largest island in the map</returns>
    public static int ComputeAreaOfLargestIsland(bool[,] map)
    {
        map = (bool[,])map.Clone();
        
        var maxArea = 0;
        for (var i = 0; i < map.GetLength(0); i++)
        for (var j = 0; j < map.GetLength(1); j++)
            if (map[i, j])
                maxArea = Math.Max(maxArea, ComputeAreaOfIsland(map, i, j));

        return maxArea;
    }

    private static int ComputeAreaOfIsland(bool[,] map, int i, int j)
    {
        // checking in bound
        if(i < 0 || i >= map.GetLength(0))
            return 0;
        
        // checking in bound
        if(j < 0 || j >= map.GetLength(1))
            return 0;

        if (map[i, j] == false) // in case of water
            return 0;

        map[i, j] = false;  // make the land to be water
        var area = 1;
        
        // for each possible direction (-1, 0, 1) of row and column
        for (var directionInI = -1; directionInI <= 1; directionInI++)
        for (var directionInJ = -1; directionInJ <= 1; directionInJ++)
            area += ComputeAreaOfIsland(map, i + directionInI, j + directionInJ);

        return area;
    }
    
    #endregion
}