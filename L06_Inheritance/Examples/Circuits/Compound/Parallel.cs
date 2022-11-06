namespace L06_Inheritance.Examples.Circuits.Compound;

public class Parallel : CompoundCircuit
{
    public Parallel(params Circuit[] circuits) : base(circuits)
    {
    }

    public override double Impedance(double frequency)
    {
        var sumOfImpedanceReciprocal = 0.0;

        foreach (var circuit in Circuits)
            sumOfImpedanceReciprocal += 1.0 / circuit.Impedance(frequency);

        return 1.0 / sumOfImpedanceReciprocal;
    }
}