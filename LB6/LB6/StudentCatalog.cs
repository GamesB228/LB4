using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB6
{
    public class StudentCatalog
    {
        public List<Student> Students { get; } = new List<Student>();

        public void Add(Student student) => Students.Add(student);

        public void Remove(Student student) => Students.Remove(student);

        public void Sort()
        {
            Students.Sort();
        }

        public List<Student> GetWinners()
        {
            var sorted = Students.OrderBy(s => s.Result).ToList();
            if (sorted.Count < 3)
                return sorted;

            double thirdResult = sorted[2].Result;

            return sorted
                .Where(s => s.Result <= thirdResult)
                .OrderBy(s => s.Result)
                .ToList();
        }
    }
}
