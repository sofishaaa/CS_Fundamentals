using HW6;
using System;
using System.Security.Cryptography;
using System.Transactions;

namespace HW_6
{
    internal class Program : Divide
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter the first number: ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
                int number2 = Convert.ToInt32(Console.ReadLine());

                int result = Div(number1, number2);
                Console.WriteLine($"Result: {number1} / {number2} = {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException exe)
            {
                Console.WriteLine(exe.Message);
            }

            ReadNumbers[] numbers = new ReadNumbers[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Number {i + 1}:");

                int start, end;
                while (true)
                {
                    try
                    {
                        Console.Write("Enter start of range: ");
                        start = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter end of range: ");
                        end = Convert.ToInt32(Console.ReadLine());

                        if (start >= end)
                        {
                            Console.WriteLine("Start of range should be less than end of range. Try again.");
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter integer!");
                    }
                }

                numbers[i] = new ReadNumbers();
                numbers[i].Input(start, end);
            }

            Console.WriteLine("Entered numbers:");
            foreach (var num in numbers)
            {
                Console.WriteLine(num.numbers);
            }
        }
    }
}

    




