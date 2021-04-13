using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
        public class BankAccount
        {
            public string Number { get; set; }
            public string Owner { get; set; }
            public decimal Balance { get; }

            public void MakeDeposit(decimal amount, DateTime date, string note)
            {

            }

            public void MakeWithdrawl(decimal amount, DateTime date, string note)
            {

            }

        }
}
