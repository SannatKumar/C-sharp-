using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccount.People;

namespace BankAccount
{
      
    //Main Class Program
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.Name = "Sunil";
            person.Age = 26;
            person.HasPet = true;


            person.Greeting();

        }
    }
}
