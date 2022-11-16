/*
 - What is an interface? X
 - Iterators X
 - yield keyword X
 - A deeper dive into Foreach loops X
 - Implicit och explicit implementation X
 - Casting X
 - Interface vs abstract class
*/

using L07_Interfaces;
using L07_Interfaces.Examples;
using L07_Interfaces.Examples.Implementations;
using L07_Interfaces.Examples.Menu;

var app = new App();
app.Run();

#if false
string[] ord = { "a", "aa", "ab", "abc", "abcd" };
foreach (var w in ord.FilterByLength(3))
{
    Console.WriteLine(w);
}
#endif

#if false
// var evenNumbers = new EvenNumbers();
var oddNumbers = OddNumbers(10);
var squareOfOddNumbers = MapSquare(oddNumbers);

foreach (var n in oddNumbers)
{
    Console.WriteLine(n);
}

IEnumerable<int> OddNumbers(int maxNumber)
{
    int n = 1;
    while (true)
    {
        if(n > maxNumber)
            yield break;
        
        yield return n;
        n += 2;
    }
}

IEnumerable<int> MapSquare(IEnumerable<int> numbers)
{
    foreach (var n in numbers)
        yield return n * n;
}
#endif

#if false
int[] numbers = { 1, 2, 3, 4, 5 };
var numbersEnumerator = numbers.GetEnumerator();
while (numbersEnumerator.MoveNext())
{
    Console.WriteLine(numbersEnumerator.Current);
}

foreach (var n in numbers)
    Console.WriteLine(n);
#endif

#if false
int[] numbers = { 1, 7, 3, 6, 9 };
double[] salaries = { 10, 20, 30, 25, 15 };

Console.WriteLine(Max(salaries));

T Max<T>(T[] numbers) where T: IComparable<T>
{
    var max = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
        if (numbers[i].CompareTo(max) > 0)
            max = numbers[i];
    return max;
}
#endif

#if false
Monster[] monsters = { new Monster(), new Monster() };
Tower[] towers = { new Tower(), new Tower() };

IDamageable[] damageables =
{
 new Monster(), new Monster(),
 new Tower(), new Tower()
};
#endif
