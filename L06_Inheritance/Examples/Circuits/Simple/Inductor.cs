namespace L06_Inheritance.Examples.Circuits.Simple;

public class Inductor : Circuit
{
    private double _inductance;

    public Inductor(double inductance)
    {
        _inductance = inductance;
    }

    public override double Impedance(double frequency)
    {
        return _inductance * frequency;
    }
}