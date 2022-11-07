namespace L06_Inheritance.Examples.BankAccounts;

// Inheritance by specialization

public class CreditAccount : BankAccount
{
    public decimal InterestRate { get; }
    
    public CreditAccount(string owner, decimal initialBalance, decimal interestRate) 
        : base(owner, initialBalance)
    {
        if (interestRate < 0m || interestRate > 1.0m)
            throw new ArgumentOutOfRangeException(
                nameof(interestRate),
                "Interest rate must be between 0 and 1"
            );
        
        InterestRate = interestRate;
    }


    public void Withdraw(decimal amount)
    {
        if(amount <= Balance)
            base.Withdraw(amount);

        Balance -= amount * (1 + InterestRate);
    }
}