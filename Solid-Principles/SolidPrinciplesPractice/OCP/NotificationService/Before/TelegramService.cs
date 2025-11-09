using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesPractice.NotificationService.Before
{
    public class clsTelegramService
    {
        public static void Send(string to, string message)
        {
            Console.WriteLine($"\nSending Telegram to {to} :{message}");
        }
    }
}
