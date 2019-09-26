using DailyKata.Katas.Employees;

namespace DailyKata.Katas
{
    public class PolymorphicRefactoringKata
    {
        private readonly Employee _employee;

        public PolymorphicRefactoringKata(Employee employee)
        {
            _employee = employee;
        }

        public double GetSalary()
        {
            return _employee.GetSalary();
        }
    }
}
