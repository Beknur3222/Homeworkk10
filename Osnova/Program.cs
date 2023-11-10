using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonAssembly;


namespace Osnova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[6];
            people[0] = Person.RandomPerson();
            people[1] = Student.RandomStudent();
            people[2] = StudentWithAdvisor.RandomStudentWithAdvisor(); 
            people[3] = Teacher.RandomTeacher();
            people[4] = Teacher.RandomTeacher();
            people[5] = Teacher.RandomTeacher();

            foreach (var person in people)
            {
                person.Print();
                Console.WriteLine(person.ToString());
                Console.WriteLine("--------");
            }

            int personCount = 0, studentCount = 0, teacherCount = 0;

            foreach (var person in people)
            {
                if (person is Student)
                    studentCount++;
                else if (person is Teacher)
                    teacherCount++;
                else if (person is Person)
                    personCount++;
            }

            Console.WriteLine($"Person count: {personCount}");
            Console.WriteLine($"Student count: {studentCount}");
            Console.WriteLine($"Teacher count: {teacherCount}");

            foreach (var person in people)
            {
                if (person is Student student)
                {
                    Console.WriteLine($"Student ID: {student.StudentId}");
                }
                else
                {
                    Console.WriteLine("Not a student");
                }
            }

            foreach (var person in people)
            {
                if (person is Student student)
                {
                    Console.WriteLine($"Moving student {student.Name} to the next course.");
                }
            }
        }
    }
}
