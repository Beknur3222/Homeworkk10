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
            // Создаем массив объектов Person, Student и Teacher
            Person[] people = new Person[6];
            people[0] = Person.RandomPerson();
            people[1] = Student.RandomStudent();
            people[2] = StudentWithAdvisor.RandomStudentWithAdvisor(); // Будет создано в следующем разделе
            people[3] = Teacher.RandomTeacher();
            people[4] = Teacher.RandomTeacher();
            people[5] = Teacher.RandomTeacher();

            // Выводим информацию о каждом объекте
            foreach (var person in people)
            {
                person.Print();
                Console.WriteLine(person.ToString());
                Console.WriteLine("--------");
            }

            // Пример использования GetType
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

            // Пример использования as и приведения типа
            foreach (var person in people)
            {
                if (person is Student student)
                {
                    // Приведение к типу Student успешно
                    Console.WriteLine($"Student ID: {student.StudentId}");
                }
                else
                {
                    // person не является Student
                    Console.WriteLine("Not a student");
                }
            }

            // Перевести всех студентов на следующий курс
            foreach (var person in people)
            {
                if (person is Student student)
                {
                    Console.WriteLine($"Moving student {student.Name} to the next course.");
                    // Ваш код для перевода студента на следующий курс
                }
            }
        }
    }
}
