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
        }
    }
}
