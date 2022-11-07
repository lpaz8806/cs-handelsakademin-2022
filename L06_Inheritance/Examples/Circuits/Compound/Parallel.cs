namespace L06_Inheritance.Examples.Circuits.Compound;

public class Parallel : CompoundCircuit
{
    public Parallel(Circuit c1, Circuit c2) : base(c1, c2)
    {
    }

    public override double Impedance(double frequency)
    {
        var sumOfImpedanceReciprocal = 0.0;
        sumOfImpedanceReciprocal += 1.0 / C1.Impedance(frequency);
        sumOfImpedanceReciprocal += 1.0 / C2.Impedance(frequency);
        return 1.0 / sumOfImpedanceReciprocal;
    }
}