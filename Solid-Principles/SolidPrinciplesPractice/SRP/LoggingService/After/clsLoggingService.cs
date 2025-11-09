using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesPractice.SRP.LoggingService.After
{
    public class clsLoggingService
    {
        public void Log(string message, enLoggingType LoggingType)
        {

            if (LoggingType == enLoggingType.TOFILE)
            {
                FileLoggingService.Log(message);
            }
            else if (LoggingType == enLoggingType.TOEVENTLOG)
            {
                EventLogService.Log(message);
            }
            else if (LoggingType == enLoggingType.TODATABASE)
            {
                DatabaseLoggingService.Log(message);
            }
        }
    }
}
