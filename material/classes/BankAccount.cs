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
            public decimal Balance { get; }

            //methods of the class BankAccount
            public void MakeDeposit(decimal amount, DateTime date, string note)
            {

            }

            //Constructor assigning the values

            public BankAccount(string name, decimal initialBalance)
            {
                this.Owner = name;
                this.Balance = initialBalance;
                this.Number = accountNumberSeed.ToString();
                accountNumberSeed++;
            }

            public void MakeWithdrawl(decimal amount, DateTime date, string note)
            {

            }

        }
}
