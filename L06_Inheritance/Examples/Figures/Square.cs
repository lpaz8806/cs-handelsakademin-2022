namespace L06_Inheritance.Examples.Figures;

// Square is a rectangle (Math fact)

// What about the representation of
// a Square respect of the representation of a Rectangle?

public class Square : Figure
{
    public double Side { get; set; }

    public Square(double side)
    {
        Side = side;
    }

    public override double Area => Side * Side;
}


// Even though (mathematically) a Square is a Rectangle
// The class Square (representing a square) is not
// a Rectangle (the class representing a rectangle)
// The reason is that you can't use a Square when a
// Rectangle is expected, because setting the height
// of the Square will also set the Width (in order
// to maintain the square property). This means that,
// from the Rectangle point of view, that a change
// in one property (Height) also causes another
// property (Width) to change.

// Classes REPRESENT ideas or concepts in the
// application domain, or the real-life if you want.
// Representing a thing is one thing, but being the
// thing represented is another.
// Just because a square (mathematically) is a
// rectangle, it does not mean that the representation
// of a square (the class Square) is also a
// Rectangle