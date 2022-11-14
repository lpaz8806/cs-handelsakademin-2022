using System.Collections;

namespace L07_Interfaces.Examples;

public class EvenNumbers : IEnumerable<int>
{
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public IEnumerator<int> GetEnumerator()
    {
        var n = 0;
        while (true)
        {
            yield return n;
            n += 2;
        }
    }
}