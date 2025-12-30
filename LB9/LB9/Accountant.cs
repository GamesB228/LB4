using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB9
{
    public class Accountant : Employee, INotificationReceiver
    {
        public Accountant(string name) : base(name) { }

        public void ReceiveNotification(string message)
        {
            MessageBox.Show(
                "Бухгалтер: Закрити відомість\n" + message,
                "Сповіщення"
            );
        }
    }
}
