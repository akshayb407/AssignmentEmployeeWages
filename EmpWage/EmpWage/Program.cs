using System;

namespace EmpWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeWage dMart = new EmployeeWage("dMart", 20, 2, 10);
            EmployeeWage Tata = new EmployeeWage("Tata", 30, 4, 20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.tostring());
            Tata.computeEmpWage();
            Console.WriteLine(Tata.tostring());

        }
    }
    
}

