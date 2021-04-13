using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.People
{
    public class Person
    {
        //Fields
        public string Name;
        public int Age;
        public bool HasPet;

        //Methods
        public void Greeting()
        {
            Console.WriteLine("Hi! My Name is " + Name + " and My age is " + Age);
            Console.ReadKey();
        }
    }
}
