namespace L06_Inheritance.Examples.Figures;

public class Rectangle : Figure
{
    public virtual double Width { get; set; }
    public virtual double Heigth { get; set; }

    public override double Area => Width * Heigth;

    public double Perimeter => 2 * (Width + Heigth);
    
    public Rectangle(double width, double heigth)
    {
        Width = width;
        Heigth = heigth;
    }
    
}