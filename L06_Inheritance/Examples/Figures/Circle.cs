namespace L06_Inheritance.Examples.Figures;

public class Circle : Figure
{
    public double Radius { get; }

    public double Area => Math.PI * Radius * Radius;

    public double Perimeter => 2 * Math.PI * Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }
}