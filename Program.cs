﻿// See https://aka.ms/new-console-template for more information

namespace Olato
{
    public class Program
    {
        static void Main(string[] args)
        {

            var account = new BankAccount("Tobi", 1000, "1011234567");
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

            account.MakeWithdrawal(0, DateTime.Now, "Rent payment");
            Console.WriteLine($"{account.Balance}");
            account.MakeDeposit(0, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());

        }
    }
}

