using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentAssembly;
using TeacherAssembly;


namespace StudentWithAdvisorAssembly
{
    public class StudentWithAdvisor : Student
    {
        public Teacher Advisor { get; set; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Advisor: {Advisor.Name}");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Advisor: {Advisor.Name}";
        }

        public static StudentWithAdvisor RandomStudentWithAdvisor()
        {
            Random random = new Random();
            return new StudentWithAdvisor
            {
                Name = "RandomStudentWithAdvisor",
                Age = random.Next(18, 25),
                StudentId = random.Next(1000, 9999),
                Advisor = Teacher.RandomTeacher()
            };
        }
    }
}
