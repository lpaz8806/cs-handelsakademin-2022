namespace L06_Inheritance.Examples.BankAccounts;

public class BankAccount
{
    public string Owner { get; }
    public decimal Balance { get; private set; }

    public BankAccount(string owner, decimal initialBalance)
    {
        if (initialBalance < 0)
            throw new ArgumentOutOfRangeException(
                nameof(initialBalance),
                "Initial balance must be non-negative"
                );
        
        Owner = owner;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException(
                nameof(amount),
                "Amount must be positive"
            );

        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException(
                nameof(amount),
                "Amount must be positive"
            );

        if (amount > Balance)
            throw new InvalidOperationException("Not enough funds");

        Balance -= amount;
    }
}