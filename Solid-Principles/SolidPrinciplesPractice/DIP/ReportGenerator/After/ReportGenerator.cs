using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesPractice.DIP.ReportGenerator.After
{
    public class ReportGenerator
    {
        private IReport _Report;
        //Dependency Injection Design Pattern: constructor injection
        public ReportGenerator(IReport report)
        {
            _Report = report;
        }
        public void GenerateReport()
        {
            _Report.Generate();
        }
    }
}
