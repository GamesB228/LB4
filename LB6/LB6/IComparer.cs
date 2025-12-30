using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB6
{
    public class StudentResultComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.Result.CompareTo(y.Result);
        }
    }
}
