using SolidPrinciplesPractice.NotificationService;
using SolidPrinciplesPractice.Exam.After;
using System;
using System.Diagnostics.Metrics;
using SolidPrinciplesPractice.DIP.ReportGenerator.After;
class Program
{
    static void Main()
    {
        var quiz = new Quiz(QuestionBank.Generate());
        quiz.Print();
        ReportGenerator reportGenerator = new ReportGenerator(new PDFReportGenerator());
        reportGenerator.GenerateReport();
        Console.ReadKey();
    }
}

