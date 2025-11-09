using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesPractice.NotificationService.After
{
    public class clsEmailService:INotification
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"\nSending Email to {to} :{message}");
        }
    }
}
