using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesPractice.SimpleCompany.After
{
    public class Staff:Employee,IBonusEntitlment,IPensionEntitlment,IHealthInsuranceEntitlment,IRentalSubsidyEntitlment
    {
        public decimal CalculateBonus() => Salary * 0.05m;

        public decimal CalculateHealthInsurance() => 300m;

        public decimal CalculatePension() => .025m * Salary;

        public decimal CalculateRentalSubsidy() => 150;

        protected override decimal CalculateNetSalary()
        {
            return Salary
                   + CalculateBonus()
                   + CalculateHealthInsurance()
                   - CalculatePension()
                   + CalculateRentalSubsidy();

        }

        public override void PrintSalarySlip()
        {
            Console.WriteLine("Print");
        }
    }
}
