using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Raj Kumar", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");
            Console.ReadKey();

            account.MakeWithdrawl(500, DateTime.Now, "Rent Payment");
            Console.WriteLine(account.Balance);
            Console.ReadKey();
            account.MakeDeposit(100, DateTime.Now, "Friend Paid me Back");
            Console.WriteLine(account.Balance);
            Console.ReadKey();

            Console.WriteLine(account.GetHistory());
            Console.ReadKey();
        }
    }
}
