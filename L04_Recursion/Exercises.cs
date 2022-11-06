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
        return default;
    }
    
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
        return default;
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
        return default;
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
        return default;
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
        return default;
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
        return 0;
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
        return 0;
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
        return 0;
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
        return 0;
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
    public static ulong[] FibonacciSequence(uint n)
    {
        return default;
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
        return 0;
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
        return default;
    }

    /// <summary>
    /// Sorts the specified array.
    /// Make use of MergeSortedArrays
    /// </summary>
    public static void SortArray(int[] arr)
    {
        
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
        return default;
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
        return default;
    }
    
    #endregion
}