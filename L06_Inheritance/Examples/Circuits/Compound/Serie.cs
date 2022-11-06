namespace L06_Inheritance.Examples.Circuits.Compound;

public class Serie : CompoundCircuit
{
    public Serie(params Circuit[] circuits) : base(circuits)
    {
    }
    public override double Impedance(double frequency)
    {
        var impedance = 0.0;

        foreach (var circuit in Circuits)
            impedance += circuit.Impedance(frequency);

        return impedance;
    }
}