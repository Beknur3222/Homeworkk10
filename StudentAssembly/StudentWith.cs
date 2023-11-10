using PersonAssembly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAssembly
{
    public class StudentWith : Person
    {
        public int StudentId { get; set; }

        public override void Print()
        {
            Console.WriteLine($"Student ID: {StudentId}, {base.ToString()}");
        }

        public override string ToString()
        {
            return $"Student ID: {StudentId}, {base.ToString()}";
        }

        public static Student RandomStudent()
        {
            Random random = new Random();
            return new Student { Name = "RandomStudent", Age = random.Next(18, 25), StudentId = random.Next(1000, 9999) };
        }
    }
}
