namespace SolidPrinciplesPractice.DIP.ReportGenerator.After
{
    public class WordReportGenerator:IReport
    {
        public void Generate()
        {
            Console.WriteLine("Word Report Generated");
        }
    }
}
