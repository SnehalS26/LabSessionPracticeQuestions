using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class StudentUsingHashset
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
        static void Main(string[] args)
        {
            HashSet<StudentUsingHashset> stud = new HashSet<StudentUsingHashset>();

            stud.Add(new StudentUsingHashset { Id = 1, Name = "ABC", Marks = 70 });
            stud.Add(new StudentUsingHashset { Id = 2, Name = "MNO", Marks = 60 });
            stud.Add(new StudentUsingHashset { Id = 3, Name = "XYZ", Marks = 80 });

            foreach (StudentUsingHashset s in stud)
            {
                Console.WriteLine($"{s.Id} {s.Name} {s.Marks}");
            }
        }
    }
}
