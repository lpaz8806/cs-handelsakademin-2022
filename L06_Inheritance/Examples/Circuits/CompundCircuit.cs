namespace L06_Inheritance.Examples.Circuits;

public abstract class CompoundCircuit : Circuit
{
    protected Circuit[] Circuits { get; }

    protected CompoundCircuit(Circuit[] circuits)
    {
        if (circuits.Length < 2)
            throw new ArgumentException("Compound circuits must have at least two circuits");
        
        Circuits = circuits;
    }
}