using System;

namespace EmpWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeWage employeeWage = new EmployeeWage();

            employeeWage.GetEmployeeWage("tata", 100, 200, 300);
        }
    }
    
}

