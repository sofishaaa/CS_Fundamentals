using System;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Information about person: ");
            Person person = new Person();    //створюю об'єкт класу за конструктором без параметрів
            person.Output();

            Console.WriteLine();
            Console.WriteLine("Information about Person 1: ");
            DateTime birthDate = new DateTime(2003, 5, 10);
            Person person1 = new Person("Ostap", birthDate);    //створюю об'єкт класу за конструктором з параметрами
            person1.Output();

            Console.WriteLine();
            Console.WriteLine("Enter the information about 5 people");    //одна людина вже задана через конструктор з параметрами


            Person[] people = new Person[6];
            people[0] = person1;
            for (int i = 1; i < people.Length; i++)
            {
                Console.WriteLine($"Information about Person {i + 1}:");
                people[i] = new Person();
                people[i] = Person.Input(i);
            }


            for (int i = 0; i < people.Length; i++)
            {
                people[i].ChangeName();
            }

            for (int j = 0; j < people.Length; j++)
            {
                for (int i = j + 1; i < people.Length; i++)
                {
                    if (people[i].Name == people[j].Name)
                    {
                        Console.WriteLine($"{people[j].Name} and {people[i].Name} have the same names");
                    }

                }
            } 

           foreach (Person person in people)
            {
                person.Output();
            }


            Console.ReadKey();
        }
    }

}

