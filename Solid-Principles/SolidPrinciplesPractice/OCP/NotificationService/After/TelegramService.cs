using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesPractice.NotificationService.After
{
    public class clsTelegramService:INotification
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"\nSending Telegram to {to} :{message}");
        }
    }
}
