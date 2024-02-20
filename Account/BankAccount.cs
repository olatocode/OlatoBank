
namespace Olato
{
    public class BankAccount
    {
        public string Number { get;  }
        public string Owner { get;  }
        public decimal Balance { get
    {
        decimal balance = 0;
        foreach (var item in _allTransactions)
        {
            balance += item.Amount;
        }

        return balance;
    } }



        public BankAccount(string name, decimal initialBalance, string accountNumber)
        {
            Owner = name;
 MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
            // Check if the accountNumber is not 10 characters in length
            if (accountNumber.Length != 10)
            {
                throw new ArgumentException("Account number must be 10 characters long.", nameof(accountNumber));
            }

            Number = accountNumber;
        }
           private List<Transaction> _allTransactions = new List<Transaction>();

           public void MakeDeposit(decimal amount, DateTime date, string note)
{
    if (amount <= 0)
    {
        throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
    }
    var deposit = new Transaction(amount, date, note);
    _allTransactions.Add(deposit);
}

public void MakeWithdrawal(decimal amount, DateTime date, string note)
{
    if (amount <= 0)
    {
        throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
    }
    if (Balance - amount < 0)
    {
        throw new InvalidOperationException("Not sufficient funds for this withdrawal");
    }
    var withdrawal = new Transaction(-amount, date, note);
    _allTransactions.Add(withdrawal);
}

    }
}
