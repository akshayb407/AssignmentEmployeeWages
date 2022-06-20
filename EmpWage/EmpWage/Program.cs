using System;

namespace EmpWage
{
    internal class Program
    {
        public const int IsPartTime = 2;
        public const int IsFullTime = 1;
        public const int IsAbsent = 0;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.GetEmployeeWage();
        }

        public void GetEmployeeWage()
        {

            int WagePerHr = 20;

            Random random = new Random();
            int number = random.Next(0, 3);
            Program program = new Program();
            int empHrs = program.GetEmpHrs(number);

            int Wage = WagePerHr * empHrs;

            Console.WriteLine("Total wage is " + Wage);
        }

        public int GetEmpHrs(int number)
        {
            int empHrs = 0;

            if (number == IsFullTime)
            {
                Console.WriteLine(number);
                empHrs = 8;
            }
            else if (number == IsPartTime)
            {
                Console.WriteLine(number);
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
                Console.WriteLine(number);
            }
            return empHrs;

        }
    }

}
