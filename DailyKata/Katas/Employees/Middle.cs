using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyKata.Katas.Employees
{
    class Middle : Employee
    {
        public override double GetSalary()
        {
            return base.GetSalary() + 75;
        }
    }
}
