using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
        public class BankAccount
        {
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
            }

            public void MakeWithdrawl(decimal amount, DateTime date, string note)
            {

            }

        }
}
