using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class BankAccount
    {

        //member declaration for the bank account number

        private static int accountNumberSeed = 1234567890;

        //properties of the class BankAccount
        public string Number { get; set; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }


        //Constructor assigning the values

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;

            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance.");

        }

        // List of Objects

        private List<Transaction> allTransactions = new List<Transaction>();

        //methods of the class BankAccount
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }


        //Methods to withdraw
        public void MakeWithdrawl(decimal amount, DateTime date, string note)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Ampunt of withdrawl must be Positive")
            }
            if(Balance - amount<0)
            {
                throw new InvalidOperationException("Not Sufficient funds for this withdrawl.");
            }
            var withdrawl = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawl);
        }

    }
}
