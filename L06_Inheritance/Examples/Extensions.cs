using L06_Inheritance.Examples.BankAccounts;
using L06_Inheritance.Examples.Circuits;
using L06_Inheritance.Examples.Circuits.Compound;

// Class alias to avoid collision with the .NET Parallel class
using Parallel = L06_Inheritance.Examples.Circuits.Compound.Parallel;

namespace L06_Inheritance.Examples;

static class Extensions
{
    public static CreditAccount ToCredit(this BankAccount acc, decimal interestRate)
    {
        return new CreditAccount(acc.Owner, acc.Balance, interestRate);
    }

    public static Parallel ConnectInParallel(
        this Circuit c1,
        Circuit c2)
    {
        return new Parallel(c1, c2);
    }
    public static Serie ConnectInSerie(
        this Circuit c1,
        Circuit c2)
    {
        return new Serie(c1, c2);
    }
}