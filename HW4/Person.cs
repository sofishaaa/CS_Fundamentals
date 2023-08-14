using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Net.Cache;
using System.Runtime.CompilerServices;

namespace HW4
{
    internal class Person
    {

        private string name;
        private DateTime birthYear;

        public string Name
        {   
            set { name = value; }
            get { return name; }
        }

        public DateTime BirthYear
        {
            set { birthYear = value; }
            get { return birthYear; }
            
        }

        public Person()    //конструктор за замовчуванням
        {
            name = "Sofiia";
            birthYear = new DateTime(2005, 5, 16);
        }

        public Person(string name, DateTime birthYear)    //конструктор з параметрами
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public static Person Input(int i)
        {
            Console.WriteLine("Enter the name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter birthday year: ");
            DateTime birthYear = Convert.ToDateTime(Console.ReadLine());

            Person person = new Person(name, birthYear);
            return person;
        }

        public int GetAge()
        {
            DateTime currentYear = DateTime.Now;
            int age = currentYear.Year - birthYear.Year;
            return age;
        }

        public void Output()
        {
            Console.WriteLine($"Name: {name} \nAge: " + GetAge());
        }

        public string ChangeName()
        {
            if (GetAge() < 16)
            {
                name = "VeryYoung!";
                
            }
            return name;
        }

        public static bool operator == (Person a, Person b)
        {
            return (a.name == b.name);
        }
        public static bool operator != (Person a, Person b)
        {
            return (a.name != b.name);
        }

        public override string ToString()
        {
            return "Name: " + name + "\nAge: " + GetAge();
        }
    }   
}
