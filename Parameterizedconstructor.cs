using System;

namespace Constructor
{
    class Employees
    {
        int EmpId;
        string EmpName;
        int EmpAge;

        public Employees(int EmpId, string EmpName, int Empage)
        {

        }
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
