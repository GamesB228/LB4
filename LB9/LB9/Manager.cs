using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB9
{
    public class Manager : Employee, INotificationReceiver, IVacationApprover
    {
        public Manager(string name) : base(name) { }

        public void ReceiveNotification(string message)
        {
            MessageBox.Show(
                "Менеджер отримав сповіщення:\n" + message,
                "HR"
            );
        }

        public void ApproveVacation(string employeeName)
        {
            MessageBox.Show(
                $"Менеджер: Відпустку погоджено для {employeeName}",
                "Відпустка"
            );
        }
    }
}
