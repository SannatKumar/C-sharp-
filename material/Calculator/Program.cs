using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {

        public int fNumber;
        public int sNumber;
        public int result;

        void addition()
        {
            result = fNumber + sNumber;
            Console.WriteLine(result);
            Console.ReadLine();
        }

        void subtraction()
        {
            result = fNumber - sNumber;
            Console.WriteLine(result);
            Console.ReadKey();
        }

        class Program
        {
            static void Main(string[] args)
            {
                Calculator obj = new Calculator();

                obj.fNumber = 200;
                obj.sNumber = 100;

                obj.addition();
                obj.subtraction();

            }
        }
    }
}
