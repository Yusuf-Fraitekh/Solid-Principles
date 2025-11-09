using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesPractice.SRP.LoggingService.Before
{
    public partial class clsLoggingService
    {

        public void Log(string message, enLoggingType LoggingType)
        {

            if (LoggingType == enLoggingType.TOFILE)
            {
                LogToFile(message);
            }
            else if (LoggingType == enLoggingType.TOEVENTLOG)
            {
                LogToEventLog(message);
            }
            else if (LoggingType == enLoggingType.TODATABASE)
            {
                LogToDatabse(message);
            }
        }
        private void LogToFile(string message)
        {
            Console.WriteLine($"\nLog to file: {message}");
        }
        private void LogToEventLog(string message)
        {
            Console.WriteLine($"\nLog to Event Log: {message}");
        }
        private void LogToDatabse(string message)
        {
            Console.WriteLine($"\nLog to Database: {message}");
        }

    }
}
