using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyKata.Katas.Employees
{
    class Consultant : Employee
    {
        public override double GetSalary()
        {
            return base.GetSalary() + 75 + 25 + 15;
        }
    }
}
