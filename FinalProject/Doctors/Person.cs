using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctors
{
    public class Person
    {
        private string name;
        private string gender;
        private int age;

        public string Name { get { return name; } }
        
        public string Gender { get { return gender; } }
        public int Age { get { return age; } }


        public Person(string name, string gender, int age)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name cannot be null or empty.", nameof(name));
            }

            if (string.IsNullOrEmpty(gender))
            {
                throw new ArgumentException("Gender cannot be null or empty.", nameof(gender));
            }

            if (age < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(age), "Age cannot be negative.");
            }
            this.name = name;
            this.gender = gender;
            this.age = age;
        }
        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Information about person: {Name}, {Gender}, {Age}");
        }

    }
}
