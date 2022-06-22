using System;

namespace EmpWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeWageArray employeeWage = new EmployeeWageArray();
            employeeWage.addCompanyEmpWage("DMart", 20, 2, 10);
            employeeWage.addCompanyEmpWage("Tata", 30, 4, 20);
            employeeWage.computeEmpWage();

        }
    }
    
}

