using System;
using System.Collections.Generic;

namespace HW5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<IDeveloper> developers = new List<IDeveloper>();
            developers.Add(new Programmer("C++", "Visual Studio Code"));
            developers.Add(new Programmer("C#", "Visual Studio"));
            developers.Add(new Programmer("Python", "PyCharm"));
            developers.Add(new Builder("Pliers"));
            developers.Add(new Builder("Scissors"));
            developers.Add(new Builder("Mallet"));

            foreach (var developer in developers)
            {
                developer.Create();
                developer.Destroy();
                Console.WriteLine();
            }


            developers.Sort();
            Console.WriteLine("Sorted Developers: ");
            foreach (var developer in developers)
            {
                Console.WriteLine($"Tool: {developer.Tool}");
            }

        }
    }
}