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
            int Totalwage = 0;
            int WagePerHr = 20;
            int NumberOfDaysPerMonth = 20;
            for (int i = 0; i < NumberOfDaysPerMonth; i++)
            {
                Random random = new Random();
                int number = random.Next(0, 3);
                Program program = new Program();
                int empHrs = program.GetEmpHrs(number);

                Totalwage = Totalwage + WagePerHr * empHrs;
            }
            Console.WriteLine("Total wage is " + Totalwage);
        }

        public int GetEmpHrs(int number)
        {
            int empHrs = 0;
            switch (number)
            {
                case IsFullTime:
                    empHrs = 8;
                    break;
                case IsPartTime:
                    empHrs = 4;
                    break;
                case IsAbsent:
                    empHrs = 0;
                    break;


            }
            return empHrs;

        }
    }
}

