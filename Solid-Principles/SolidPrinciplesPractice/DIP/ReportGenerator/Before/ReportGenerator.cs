using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesPractice.DIP.ReportGenerator.Before
{
    public class ReportGenerator
    {
       private PDFReportGenerator _pdfGenerator;

        public ReportGenerator()
        {
            _pdfGenerator = new PDFReportGenerator();
        }
        public void GenerateReport()
        {
            _pdfGenerator.Generate();
        }
    }
}
