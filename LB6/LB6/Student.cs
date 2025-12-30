using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB6
{
    public class Student : IComparable<Student>
    {
        public string FullName { get; set; }
        public int Course { get; set; }
        public string Group { get; set; }
        public double Result { get; set; } // час забігу

        public Student() { }

        public Student(string fullName, int course, string group, double result)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("ПІБ не може бути порожнім");

            if (course < 1 || course > 6)
                throw new ArgumentException("Невірний курс");

            if (result <= 0)
                throw new ArgumentException("Результат має бути > 0");

            FullName = fullName;
            Course = course;
            Group = group;
            Result = result;
        }

        // Сортування за результатом (менше = краще)
        public int CompareTo(Student other)
        {
            return Result.CompareTo(other.Result);
        }

        public override string ToString()
        {
            return $"{FullName} | Курс {Course} | Група {Group} | {Result} сек";
        }
    }
}
