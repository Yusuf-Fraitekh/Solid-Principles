using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesPractice.NotificationService.After
{
    public interface INotification
    {
        void Send(string to, string message);
    }
}
