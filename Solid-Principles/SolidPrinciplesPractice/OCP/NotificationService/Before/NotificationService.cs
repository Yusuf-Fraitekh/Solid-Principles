using SolidPrinciplesPractice.NotificationService.After;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesPractice.NotificationService.Before
{
    public partial class clsNotificationService
    {
       
        public void SendNotification(string to,string message,EnNotificationType notificationType)
        {
            if (notificationType == EnNotificationType.SMS)
                clsSMSService.Send(to, message);
            else
                if(notificationType == EnNotificationType.EMAIL)
                clsEmailService.Send(to, message);
            else
                if (notificationType == EnNotificationType.FAX)
                clsFaxService.Send(to, message);
            else
                if (notificationType == EnNotificationType.TELEGRAM)
                clsTelegramService.Send(to, message);
        }
      
    }
}
