using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonAssembly;
using StudentAssembly;

namespace TeacherAssembly
{
    public class Teacher : Person
    {
        public List<Student> Students { get; set; } = new List<Student>();

        public override void Print()
        {
            Console.WriteLine($"Teacher with {Students.Count} students, {base.ToString()}");
        }

        public override string ToString()
        {
            return $"Teacher with {Students.Count} students, {base.ToString()}";
        }

        public static Teacher RandomTeacher()
        {
            Random random = new Random();
            return new Teacher { Name = "RandomTeacher", Age = random.Next(30, 60) };
        }
    }
}
