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

            public List<Student> GetWinners()
            {
                return Students
                    .OrderBy(s => s.Result)
                    .TakeWhile((s, index) => index < 3 || s.Result == Students[2].Result)
                    .ToList();
            }

            public List<Student> SortByCourse()
            {
                return Students
                    .OrderBy(s => s.Course)
                    .ThenBy(s => s.FullName)
                    .ToList();
            }

            public List<Student> FilterByGroup(string group)
            {
                return Students.Where(s => s.Group == group).ToList();
            }

          
            public List<Student> FilterByMinResult(double minResult)
            {
                return Students.Where(s => s.Result <= minResult).ToList();
            }

    
            public List<Student> SortByName()
            {
                return Students.OrderBy(s => s.FullName).ToList();
            }

            public List<string> GetStudentNames()
            {
                return Students.Select(s => s.FullName).ToList();
            }
            public Dictionary<int, List<Student>> GroupByCourse()
            {
                return Students.GroupBy(s => s.Course)
                               .ToDictionary(g => g.Key, g => g.ToList());
            }

            public double AverageResult()
            {
                return Students.Average(s => s.Result);
            }

            public Student GetBestStudent()
            {
                return Students.OrderBy(s => s.Result).FirstOrDefault();
            }

            public Student GetWorstStudent()
            {
                return Students.OrderByDescending(s => s.Result).FirstOrDefault();
            }

            public List<string> GetNamesWithResultBelow(double maxResult)
            {
                return Students.Where(s => s.Result < maxResult)
                               .Select(s => s.FullName)
                               .ToList();
            }

        }
    }
