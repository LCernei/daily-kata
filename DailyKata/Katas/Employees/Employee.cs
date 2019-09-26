using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyKata.Katas.Employees
{
    public abstract class Employee
    {
        public abstract double GetSalary();

        protected double GetBaseSalary()
        {
            return 100;
        }
    }
}
