using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework 1
            Console.WriteLine("Введiть сторону квадрата: ");

            int sideSquare = Convert.ToInt32(Console.ReadLine());

            int perimeterSquare = sideSquare * 4;

            double areaSquare = Math.Pow(sideSquare, 2);

            Console.WriteLine("Периметр квадрата = {0} \nПлоща квадрата = {1}", perimeterSquare, areaSquare);

            Console.ReadKey();

            //Homework 2
            Console.WriteLine("Як вас звати?");
            string name = Console.ReadLine();

            Console.WriteLine("Скiльки вам рокiв, {0}?", name);
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Вас звати: {0} \nВаш вiк: {1}", name, age);

            Console.ReadKey();

            //Homework 3
            Console.WriteLine("Введiть радiус кола: ");
            double radiusCircle = Convert.ToDouble(Console.ReadLine());


            double lengthCircle = 2 * Math.PI * radiusCircle;
            double areaCircle = Math.PI * Math.Pow(radiusCircle, 2);
            double volumeCircle = 4.0 / 3.0 * Math.PI * Math.Pow(radiusCircle, 3);

            Console.WriteLine("Довжина кола = {0:F2} \nПлоща кола = {1:F2} \nОб'єм кола = {2:F2}", lengthCircle, areaCircle, volumeCircle);

            Console.ReadKey();

            //Task 1 
            Console.WriteLine("Введiть значення числа а: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введiть значення числа b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int addition = a + b;
            int substraction = a - b;
            int division = a / b;
            int multiplication = a * b;

            Console.WriteLine("a + b = {0} \na - b = {1} \na / b = {2} \na * b = {3}", addition, substraction, division, multiplication);

            Console.ReadKey();

            //Task2
            Console.WriteLine("Як ви?");
            string notAnswer = Console.ReadLine();
            string answer = notAnswer.ToLower();
            Console.WriteLine("Ви почуваєтесь {0}", answer);

            Console.ReadKey();

            //Task 3
            Console.WriteLine("Введiть перший символ: ");
            char first = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введiть другий символ: ");
            char second = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введiть третiй символ: ");
            char third = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Ви ввели: {0}, {1}, {2}", first, second, third);

            Console.ReadKey();

            //Task 4
            Console.WriteLine("Введiть перше число: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введiть друге число: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine( firstNumber > 0 && secondNumber > 0 ? "Обидва числа додатнi" : 
                               firstNumber <= 0 && secondNumber <= 0 ? "Жодне iз чисел не э додатнiм" :
                               "Лише одне число є додатнiм");

            Console.ReadKey();

            /*if (firstNumber > 0 && secondNumber > 0)
            {
                Console.WriteLine("Обидва числа э парними");
            }

            else
            {
                Console.WriteLine("Жодне iз чисел не є додатнiм");
            }

            if (firstNumber > 0 || secondNumber > 0)
            {
                Console.WriteLine("Лише одне число э додатнiм");
            }*/

        }
        
    }

}