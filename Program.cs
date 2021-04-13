using System;

namespace Constructor
{
    class Program
    {
        public Program()
        {
            Console.WriteLine("Constructor invokes !!");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.ReadLine();
        }
    }
}
