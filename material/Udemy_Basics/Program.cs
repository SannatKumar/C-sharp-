using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hei Bud");
            // Ask user for fave number
            Console.Write("Enter your favorite number!: ");



            // Turn that answer into an int

            //Attempt 1: use implicit conversion
            //int faveNumber = Console.ReadLine();

            //Attempt 2: use explicit conversion
            int faveNumber = (int)Console.ReadLine();

            //Attempt 3: use Convert method

            int faveNumber = Convert.ToInt32(Console.ReadLine());
        }
    }
}
