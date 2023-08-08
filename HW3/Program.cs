using System;

namespace HW3
{
    class Program
    {                           
        static void Main(string[] args)
        {

            //Homework 1
            Console.WriteLine("Enter the text: ");
            string textFromConsole = Console.ReadLine();

            int numA = 0, numO = 0, numI = 0, numE = 0;

            foreach (char num in textFromConsole)
            {
                switch (char.ToLower(num))
                {
                    case 'a':
                        numA++;
                        break;
                    case 'o':
                        numO++;
                        break;
                    case 'i':
                        numI++;
                        break;
                    case 'e':
                        numE++;
                        break;
                    default:

                        break;
                }
            }

            Console.WriteLine($"Count of a: {numA}");
            Console.WriteLine($"Count of o: {numO}");
            Console.WriteLine($"Count of i: {numI}");
            Console.WriteLine($"Count of e: {numE}");



            //Homework 2
            Console.WriteLine("Enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the month: ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The number of days in {month}: ");
            Console.WriteLine(DateTime.DaysInMonth(year, month));

            Console.WriteLine($"Is {year} leap?");
            Console.WriteLine(DateTime.IsLeapYear(year));



            //Homework 3
            Console.WriteLine("Enter 10 integers: ");
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Number {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            }

            int sum = 0;
            int product = 1;

            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] > 0)
                {
                    sum += numbers[i];
                }
                else
                {
                    for (int j = 5; j < 10; j++)
                    {
                        product *= numbers[j];
                    }

                }
            }

            if (product == 1)
            {
                Console.WriteLine($"The sum of first 5 elements: {sum}");
            }
            else
            {
                Console.WriteLine($"Product of last 5 element: {product}");
            }
        }
    }
}