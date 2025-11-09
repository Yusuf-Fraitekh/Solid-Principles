using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesPractice.SimpleCompany.Before
{
    public class Staff:Employee,IEntitlement
    {
        public decimal CalculateBonus()
        {
            return Salary * 0.05m;
        }
        public decimal CalculateHealthInsurance()
        { 
            return 300m;
        } 

        public decimal CalculatePension()
        {
           return .025m * Salary;
        }

        public decimal CalculateRentalSubsidy()
        {
            return 150;
        }

        public decimal CalculateTransportationReimbursement()
        {
            throw new NotSupportedException("Staff TransportationReimbursement");
        }
          

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
