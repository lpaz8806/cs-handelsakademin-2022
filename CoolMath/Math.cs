namespace CoolMath;

public class Math
{
    /// <summary>
    /// Computes the sum of x and y
    /// </summary>
    public int Add(int x, int y) => x + y;

    public int Sub(int x, int y) => x - y;
    /// <summary>
    /// Computes the absolute value of x
    /// </summary>
    public int Abs(int x) => x < 0 ? -x : x;
}