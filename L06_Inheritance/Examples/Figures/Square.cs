namespace L06_Inheritance.Examples.Figures;

// Square is a rectangle (Math fact)

// What about the representation of
// a Square respect of the representation of a Rectangle?

public class Square : Rectangle
{
    public Square(double side) : base(side, side)
    {
    }
}