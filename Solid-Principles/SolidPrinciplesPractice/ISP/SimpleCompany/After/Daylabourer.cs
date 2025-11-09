

namespace SolidPrinciplesPractice.SimpleCompany.After
{
    public class Daylabourer : Employee, IHealthInsuranceEntitlment, ITransportationReimbursementEntitlment
    {
        public decimal CalculateHealthInsurance() => 300m;

        public decimal CalculateTransportationReimbursement() => 150;

        protected override decimal CalculateNetSalary()
        {
            return Salary
                + CalculateHealthInsurance()
                + CalculateTransportationReimbursement();

        }

        public override void PrintSalarySlip()
        {
            Console.WriteLine("Print");
        }
    }
}
