namespace L07_Interfaces.Examples;

public static class StringExtensions
{
    public static IEnumerable<string> FilterByLength(this IEnumerable<string> words, int length)
    {
        foreach (var w in words)
        {
            if(w.Length < length)
                continue;
            yield return w;
        }
    }

}