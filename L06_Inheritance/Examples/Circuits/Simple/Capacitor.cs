namespace L06_Inheritance.Examples.Circuits.Simple;

public sealed class Capacitor : Circuit
{
    private double _capacitance;

    public Capacitor(double capacitance)
    {
        _capacitance = capacitance;
    }

    public override double Impedance(double frequency)
    {
        return _capacitance / frequency;
    }
}
