
namespace Olato
{
    public class BankAccount
    {
        public string Number { get; set; }
        public string Owner { get; set; }
        public decimal Balance { get; }



        public BankAccount(string name, decimal initialBalance, string accountNumber)
        {
            Owner = name;
            Balance = initialBalance;

            // Check if the accountNumber is not 10 characters in length
            if (accountNumber.Length != 10)
            {
                throw new ArgumentException("Account number must be 10 characters long.", nameof(accountNumber));
            }

            Number = accountNumber;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            
            
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            // Implementation for making a withdrawal
        }
    }
}
