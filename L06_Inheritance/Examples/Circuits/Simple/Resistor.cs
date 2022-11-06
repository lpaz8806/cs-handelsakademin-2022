namespace L06_Inheritance.Examples.Circuits.Simple;

public class Resistor : Circuit
{
    private double _resistance;

    public Resistor(double resistance)
    {
        _resistance = resistance;
    }

    public override double Impedance(double frequency)
    {
        // Even though the impedance of a resistor does not depend
        // on the frequency, this parameter must be added for
        // the method to be polymorphic
        return _resistance;
    }
}