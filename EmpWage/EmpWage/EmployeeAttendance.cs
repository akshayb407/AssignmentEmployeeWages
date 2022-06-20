using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    internal class EmployeeAttendance
    {
        static int WagePerHour = 20;
        static int MaxNoOfWorkingDays = 20;
        static int MaxNumberOfHours = 100;
        static int WorkingHours = 0;
        static int WorkingDays = 0;
        static int TotalSalary = 0;

        public void getAttendance()

        {

            Random random = new Random();
            while (WorkingDays <= MaxNoOfWorkingDays && WorkingHours <= MaxNumberOfHours)
            {
                int number = random.Next(0, 3);
                CheckAttendance(number);
            }
        }


        public static void CheckAttendance(int number)
        {
            int hours;
            switch (number)
            {
                case 0:

                    Console.WriteLine("employee is absent");
                    hours = 0;
                    CalculateSalary(hours);
                    break;

                case 1:
                    Console.WriteLine("Employee is present part time");
                    hours = 4;
                    WorkingDays++;
                    WorkingHours = WorkingHours + hours;
                    CalculateSalary(hours);
                    break;

                case 2:

                    Console.WriteLine("Employee is present full time");
                    hours = 8;
                    WorkingDays++;
                    WorkingHours = WorkingHours + hours;
                    CalculateSalary(hours);
                    break;

            }
        }

        public static void CalculateSalary(int hours)
        {
            int salary = WagePerHour * hours;
            Console.WriteLine("Salary is " + salary);
        }

    }
}
