using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(int id, string name, double fixedSalary)
            : base(id, name, fixedSalary)
        {
        }

        public override double CalculateSalary()
        {
            return BaseSalary; // Fixed salary
        }
    }

}
