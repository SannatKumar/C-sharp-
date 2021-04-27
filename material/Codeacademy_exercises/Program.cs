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
            /* use this space to write your own short program! 
            Here's what you learned:

            DATA TYPES: int, double, char, string, bool
            VARIABLES: datatype variableName = value;
            COMMON ERRORS: wrong type, wrong value, no semicolon
            DATA TYPE CONVERSION: implicit, explicit, methods

            Good luck! */
            //Converts boolean to string
            bool hey = true;
            string convertedBool = hey.ToString();

            //Converts string to character array

            string charList = "UnListed";
            char[] ch = charList.ToCharArray();

            foreach(char c in ch)
            { 
                Console.WriteLine(c);
            }

            //Converts a datatype

            DateTime date= DateTime.Now;
            string date_str = date.ToString();
            Console.WriteLine(date_str);
            Console.WriteLine("Hei Bud");
        }
    }
}
