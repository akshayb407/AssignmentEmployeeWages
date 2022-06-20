using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    internal class GetemployeeAttandance
    {
        public void GetEmployeeAttandance()
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
