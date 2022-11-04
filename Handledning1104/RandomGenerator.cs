namespace Handledning1104;

public class RandomGenerator
{
    private int _min;
    private int _max;

    public RandomGenerator(int min, int max)
    {
        _min = min;
        _max = max;
    }

    public int GenerateNext()
    {
        return _min + Environment.TickCount % (_max - _min + 1);
    }
}
