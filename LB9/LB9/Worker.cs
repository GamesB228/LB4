using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB9
{
    public class Worker : Employee, INotificationReceiver
    {
        public Worker(string name) : base(name) { }

        public void ReceiveNotification(string message)
        {
            MessageBox.Show(
                "Робітник: Перевірити картку\n" + message,
                "Сповіщення"
            );
        }
    }
}
