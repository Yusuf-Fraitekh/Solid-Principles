namespace SolidPrinciplesPractice.SimpleCompany.Before
{
    public class Consultant : Employee, IEntitlement
    {
        public decimal CalculateBonus()
        {
          return  Salary * 0.05m;
        }
        public decimal CalculateHealthInsurance()
        {
            return 300m;
        }
       
        public decimal CalculateTransportationReimbursement()
        {
            return 150m;
        }
        public decimal CalculatePension()
        {
            throw new NotSupportedException("Consultant Pension not supported");
        }
        public decimal CalculateRentalSubsidy()
        {
            throw new NotSupportedException("Consultant Rental Subsidy not supported");
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
