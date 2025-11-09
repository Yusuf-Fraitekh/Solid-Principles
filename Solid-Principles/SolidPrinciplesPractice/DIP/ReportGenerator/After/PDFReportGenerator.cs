namespace SolidPrinciplesPractice.DIP.ReportGenerator.After;

public class PDFReportGenerator:IReport
{
    public void Generate()
    {
        Console.WriteLine("PDF report generated");
    }
}
