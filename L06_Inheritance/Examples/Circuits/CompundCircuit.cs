namespace L06_Inheritance.Examples.Circuits;

public abstract class CompoundCircuit : Circuit
{
    protected Circuit[] Circuits { get; }

    protected CompoundCircuit(Circuit[] circuits)
    {
        Circuits = circuits;
    }
}