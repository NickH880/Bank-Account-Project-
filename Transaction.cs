public class Transaction //Works but doesnt do anything
{
    private decimal balance; //Current balance of the account
    private string[] transactionHistory; //To hold transactions
    private int transactionCount; //Number of recorded transactions
    private const int maxTransactions = 100; //Maximum number of transactions

    public Transaction(decimal initialBalance = 0.0m)
    {
        balance = initialBalance; //Initialize with an initial balance
        transactionHistory = new string[maxTransactions]; // Initialize transaction history 
        transactionCount = 0; //Start with nothing 
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive.");
        }

        balance += amount; //Increase balance
        RecordTransaction($"Deposited: ${amount:F2} on {DateTime.Now}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be positive."); //For positive amount
        }

        if (amount <= balance)
        {
            balance -= amount; //Decrease balance
            RecordTransaction($"Withdrew: ${amount:F2} on {DateTime.Now}");
        }
        else
        {
            throw new InvalidOperationException("Insufficient funds.");
        }
    }

    private void RecordTransaction(string transaction) //Records transaction
    {
        if (transactionCount >= maxTransactions)
        {
            Array.Copy(transactionHistory, 1, transactionHistory, 0, maxTransactions - 1); //Shift transactions left and overwrite the oldest
            transactionCount--; //Decrease transaction count
        }
        transactionHistory[transactionCount++] = transaction; //Add new transaction
    }

    public string[] GetRecentTransactions(int count)
    {
        int start = Math.Max(0, transactionCount - count);
        string[] recentTransactions = new string[transactionCount - start];
        Array.Copy(transactionHistory, start, recentTransactions, 0, transactionCount - start);
        return recentTransactions; //Return recent transactions
    }

    public decimal Balance => balance; //To get the current balance

    public string GetFormattedBalance()
    {
        return $"Current Balance: ${balance:F2}"; //Format balance as currency
    }
}
//WHEN I RUN THE CODE IT WORKS BUT IT SHOWS NOTHING
