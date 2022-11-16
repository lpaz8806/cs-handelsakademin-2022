namespace L08_FunctionalProgramming.Examples;

public class Delegates
{
    public static void ForEach<T>(IEnumerable<T> collection, Action<T> action)
    {
        foreach (var item in collection)
            action(item);
    }
    
    public static T Aggregate<T>(T[] items, Func<T, T, T> f)
    {
        var acc = items[0];
        for (int i = 1; i < items.Length; i++)
            acc = f(acc, items[i]);
        return acc;
    }
    
    public static int FindFirst<T>(T[] items, Predicate<T> condition)
    {
        for (int i = 0; i < items.Length; i++)
            if (condition(items[i]))
                return i;
        
        return -1;
        Predicate<int> x;
    }
    
    public static IEnumerable<W> Map<T, W>(IEnumerable<T> collection, Func<T, W> mapper)
    {
        foreach (var item in collection)
            yield return mapper(item);
    }
    public static IEnumerable<T> Filter<T>(IEnumerable<T> collection, Predicate<T> condition)
    {
        foreach (var item in collection)
            if (condition(item))
                yield return item;
    }

    public static Func<T1, TResult> Compound<T1, T2, TResult>(Func<T2, TResult> f, Func<T1, T2> g)
    {
        return x => f(g(x));
    }
    
    public static Func<int, int> Sum(Func<int, int> f, Func<int, int> g)
    {
        return x => f(x) + g(x);
    }
    
    // bool (int)
    public static bool EqualsTo5(int n) => n == 5;
    // bool (int)
    public static bool IsEven(int n) => n % 2 == 0;
    // int (int)
    public static int Neg(int x) => -x;
    // int (int, int)
    public static int Mul(int x, int y) => x * y;
}
