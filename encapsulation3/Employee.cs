using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation3
{
        internal class Employee : Manager
        {
            private string _name;
            private bool _isSuccessful;
            private decimal _salary;
            public string Name
            {
                get { return _name; }
                set
                {
                    _name = value;
                }
            }
            public bool IsSuccessful
            {
                get { return _isSuccessful; }
                set { _isSuccessful = value; }
            }
            public decimal Salary
            {
                get { return _salary; }
                set
                {
                    if (value > 0)
                    {
                        _salary = value;
                    }
                    else
                    {
                        Console.WriteLine("Salary 0 -dan kicik ola bilmez");
                    }
                }
            }
            public Employee(string name, bool isSuccessful, decimal salary)
            {
                Name = name;
                IsSuccessful = isSuccessful;
                Salary = salary;
            }
        }
    }

