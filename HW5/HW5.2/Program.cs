using System;
using System.Collections.Generic;

namespace HW5._2
{
    class Program
    {
        public static void Main(string[] args)
        {

            Dictionary<uint, string> personIdName = new Dictionary<uint, string>();

            int countOfPeople = 7;

            for (uint i = 0; i < countOfPeople; i++)
            {
                Console.Write($"Enter ID for person {i + 1}: ");
                uint id = Convert.ToUInt32(Console.ReadLine());
                Console.Write($"Enter name for person {i + 1}: ");
                string name = Console.ReadLine();
                personIdName[id] = name;
            }

            Console.Write("Enter an ID to find person: ");
            uint idSearch = Convert.ToUInt32(Console.ReadLine());
            if (personIdName.TryGetValue(idSearch, out string personName))
            {
                Console.WriteLine(personName);
            }
            else
            {
                Console.WriteLine("Invalid ID");
            }
        }
    }
}
