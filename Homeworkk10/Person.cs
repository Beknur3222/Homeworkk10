using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkk10
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void Print()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        public override string ToString()
        {
            return $"{Name}, {Age} years old";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Person other = (Person)obj;
            return Name == other.Name && Age == other.Age;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Age);
        }

        // Static method to create a random person
        public static Person RandomPerson()
        {
            Random random = new Random();
            return new Person { Name = "RandomPerson", Age = random.Next(18, 50) };
        }
    }
}
