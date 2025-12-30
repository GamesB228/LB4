using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB9
{
    public class EventJournal
{
    public List<string> Records { get; } = new();

    public void LogSalary(string message)
    {
        Records.Add($"{DateTime.Now}: {message}");
    }

    public void LogVacation(string employeeName)
    {
        Records.Add($"{DateTime.Now}: Запит на відпустку від {employeeName}");
    }
}
}
