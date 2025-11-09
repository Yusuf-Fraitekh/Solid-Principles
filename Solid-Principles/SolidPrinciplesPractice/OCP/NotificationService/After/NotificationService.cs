using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesPractice.NotificationService.After
{
    public class clsNotificationService
    {
        private readonly INotification _Notification;
        public clsNotificationService(INotification Notification)
        {
            _Notification = Notification;
        }
        public void SendNotification(string to,string message)
        {
            _Notification.Send(to,message);
        }
      
    }
}
