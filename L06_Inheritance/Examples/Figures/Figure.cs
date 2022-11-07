namespace L06_Inheritance.Examples.Figures;

public abstract class Figure
{
    public abstract double Area {get; }

    public void PrintArea()
    {
        Console.WriteLine(Area);
    }
    public void WhoAmI()
    {
        Console.WriteLine(this.GetType().ToString());
    }
    
    public static double TotalArea(params Figure[] figures)
    {
        var total = 0.0;

        foreach (var figure in figures)
            total += figure.Area;

        return total;
    }
}