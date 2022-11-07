namespace L06_Inheritance.Examples.BankAccounts;

public class TransferAccount : BankAccount
{
    public decimal MaxTransfer { get; }

    public TransferAccount(
        string owner,
        decimal initialBalance,
        decimal maxTransferAmount)
        : base(owner, initialBalance)
    {
        MaxTransfer = maxTransferAmount;
    }

    public void Transfer(decimal amount, BankAccount other)
    {
        if (amount > MaxTransfer)
            throw new InvalidOperationException();
        
        Withdraw(amount);
        other.Deposit(amount);
    }
}