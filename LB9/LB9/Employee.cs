using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB9
{
    public class Employee
    {
        public string Name { get; set; }

        // Делегати
        public delegate void SalaryPaidHandler(string message);
        public delegate void VacationRequestedHandler(string employeeName);

        // Події
        public event SalaryPaidHandler SalaryPaid;               // широкомовна
        public event VacationRequestedHandler VacationRequested; // звичайна

        public Employee(string name)
        {
            Name = name;
        }

        public void PaySalary()
        {
            SalaryPaid?.Invoke($"Зарплату виплачено для {Name}");
        }

        public void RequestVacation()
        {
            VacationRequested?.Invoke(Name);
        }
    }
}
