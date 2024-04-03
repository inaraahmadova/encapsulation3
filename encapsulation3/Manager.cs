using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation3
{
    internal class Manager
    {
        protected internal void GetPromotion(Employee employee)
        {
            if (employee.Salary > 0)
            {
                employee.Salary += 100;
                Console.WriteLine("salary 100 vahid artdi");
            }
        }
    }
}
