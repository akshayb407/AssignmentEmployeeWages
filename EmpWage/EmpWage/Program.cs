using System;

namespace EmpWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.GetemployeeAttendance();

        }

        public void GetemployeeAttendance()
        {
            Random random = new Random();
            int value = random.Next(0, 2);
            if (value == 0)
            {
                Console.WriteLine("Employee is absent");
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine("Employee is present");
                Console.WriteLine(value);
            }
        }
    }
}
