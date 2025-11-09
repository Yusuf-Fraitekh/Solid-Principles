namespace SolidPrinciplesPractice.SimpleCompany.After
{
    public class Consultant:Employee , IBonusEntitlment, IHealthInsuranceEntitlment, ITransportationReimbursementEntitlment
    {
        public decimal CalculateBonus()
        {
            return Salary * 0.05m;
        }

        public decimal CalculateHealthInsurance()
        {
            return 300m;
        }

        public decimal CalculateTransportationReimbursement()
        {
            return 150;
        }
        protected override decimal CalculateNetSalary()
        {
            return Salary
                   + CalculateBonus()
                   + CalculateHealthInsurance()
                   + CalculateTransportationReimbursement();

        }

        public override void PrintSalarySlip()
        {
            Console.WriteLine("Print");
        }
    }
}
