using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_in_C_
{
    public class FullTimeEmployee : Employee
    {
        public double MonthlySalary { get; set; }
        public override double CalculateSalary()
        {
            return MonthlySalary;
        }
    }
}
