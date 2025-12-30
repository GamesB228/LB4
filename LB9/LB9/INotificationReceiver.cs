using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB9
{
    public interface INotificationReceiver
    {
        void ReceiveNotification(string message);
    }
}
