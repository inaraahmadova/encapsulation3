using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation3
{
        internal class Assistan : Manager
        {
            public void GetFeedback(Employee employee)
            {
                if (employee.IsSuccessful)
                {
                    GetPromotion(employee);
                }
            }
        }
}
