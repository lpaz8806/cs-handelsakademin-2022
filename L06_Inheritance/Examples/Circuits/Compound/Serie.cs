namespace L06_Inheritance.Examples.Circuits.Compound;

public class Serie : CompoundCircuit
{
    public Serie(Circuit c1, Circuit c2) : base(c1, c2)
    {
    }

    public override double Impedance(double frequency)
    {
        return C1.Impedance(frequency) +
               C2.Impedance(frequency);
    }
}