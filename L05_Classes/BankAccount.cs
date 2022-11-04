namespace L05_Classes;

public class BankAccount
{
    private decimal _saldo;
    private string _owner;
    
    public decimal Saldo => _saldo;
    public string Owner => _owner;

    public BankAccount(string owner, decimal initialSaldo)
    {
        if (initialSaldo < 0)
            throw new ArgumentOutOfRangeException(
                nameof(initialSaldo),
                "Must be non-negative");
        
        _saldo = initialSaldo;
        _owner = owner;
    }
    
    public void Withdraw(decimal amount)
    {
        if (amount > _saldo)
            throw new InvalidOperationException();
        
        if (amount < 0)
            throw new ArgumentOutOfRangeException();
        
        _saldo -= amount;
    }
    
    public void Deposit(decimal amount)
    {
        if (amount < 0)
            throw new ArgumentOutOfRangeException();
        _saldo += amount;
    }

    public void Transfer(BankAccount target, decimal amount)
    {
        Withdraw(amount);
        target.Deposit(amount);
    }
}