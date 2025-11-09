namespace SolidPrinciplesPractice.SimpleCompany.Before;
public abstract class Employee
{
    public string EmployeeNo { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }
    protected abstract decimal CalculateNetSalary();
    public abstract void PrintSalarySlip();
}