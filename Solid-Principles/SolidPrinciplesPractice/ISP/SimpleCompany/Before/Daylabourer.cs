namespace SolidPrinciplesPractice.SimpleCompany.Before
{
    public class Daylabourer:Employee,IEntitlement
    {
        public decimal CalculateBonus()
        { 
            throw new NotSupportedException("Day labourer Bonuses not supported");
        }

        public decimal CalculateHealthInsurance()
        {
           return 300m;
        }

        public decimal CalculatePension() 
        {
            throw new NotSupportedException("Day labourer Pension not supported");
        }


        public decimal CalculateRentalSubsidy()
        {
            throw new NotSupportedException("Day labourer Rental Subsidy not supported");
        }

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
