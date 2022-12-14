namespace Handledning1104;

public static class Extensions
{
    public static void ForEach<T>(this IEnumerable<T> items,
        Action<T> action)
    {
        foreach (var item in items)
            action(item);
    }
}