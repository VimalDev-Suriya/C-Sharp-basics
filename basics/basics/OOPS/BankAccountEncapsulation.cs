public class BankAccountEncapsulation
{
    // * Always use "_"  for private variables
    private decimal _balance = 0;
    private long _accountNumber;

    public decimal Balance
    {
        get => _balance;
        // * No Setter, where I cannot able to modify the Balance value outside the class
    }

    public long AccountNumber
    {
        get => _accountNumber;
        // * No Setter, where I cannot able to modify the AccountNumber value outside the class
    }

    public BankAccountEncapsulation(long accountNumber)
    {
        // * Value was initialized only during the constructor function
        _accountNumber = accountNumber;
    }

    public void Deposit(decimal amount)
    {
        _balance += amount;
        Console.WriteLine("Successfully Deposited");
    }

    public void Withdraw(decimal amount)
    {
        _balance -= amount;
        Console.WriteLine("Successfully Withdrawed");
    }
}

public class BankAccountEncapsulationV2
{
    private decimal _balance = 0;

    public decimal Balance {get => _balance;}
    public long AccountNumber
    {
        get;
        init; // Init explicitly stats that this value can be set only during the time of initialization
    }

    public void Deposit(decimal amount)
    {
        _balance += amount;
        Console.WriteLine("Successfully Deposited");
    }

    public void Withdraw(decimal amount)
    {
        _balance -= amount;
        Console.WriteLine("Successfully Withdrawed");
    }
}