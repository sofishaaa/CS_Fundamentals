using System;

namespace HW2
{
    class Program
    {

        //Homework 3 (part 1)
        enum HTTPError
        {

            Unauthorized = 401,
            PaymentRequired,
            Forbidden,
            NotFound

        }

        static void Main(string[] args)
        {

            //Homework 1
            Console.WriteLine("Введiть три числа: ");
            float firstNum = Convert.ToSingle(Console.ReadLine());
            float secondNum = Convert.ToSingle(Console.ReadLine());
            float thirdNum = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine((firstNum < -5 || firstNum > 5) ? "{0} не входить в промiжок" :
                (secondNum < -5 || secondNum > 5) ? "{1} не входить в промiжок" :
                (thirdNum < -5 || thirdNum > 5) ? "{2} не входить в промiжок" : "Всi числа входять в промiжок", firstNum, secondNum, thirdNum);

            Console.ReadKey();



            //Homework 2
            Console.WriteLine("Введiть перше число: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введiть друге число: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введiть третє число: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Найбiльше число: ");
            Console.WriteLine((Math.Max(Math.Max(firstNumber, secondNumber), thirdNumber)));
            Console.Write("Найменше число: ");
            Console.WriteLine((Math.Min(Math.Min(firstNumber, secondNumber), thirdNumber)));

            Console.ReadKey();



            //Homework 3 (part 2)
            Console.WriteLine("Введiть номер HTTP помилки: ");
            int error = Convert.ToInt32(Console.ReadLine());
            HTTPError numberError = (HTTPError)error; //explicit
            Console.WriteLine(numberError);

            Console.ReadKey();



            //Homework 4 (part 2)
            Dog myDog;
            Console.WriteLine("Введiть iмя собаки: ");
            myDog.name = Console.ReadLine();

            Console.WriteLine("Введiть породу собаки: ");
            myDog.mark = Console.ReadLine();

            Console.WriteLine("Введiть вiк собаки: ");
            myDog.age = Convert.ToInt32(Console.ReadLine());

            myDog.Info();

            Console.ReadKey();


        }
    }

    //Homework 4 (part 1)
    struct Dog
    {
        public string name;
        public string mark;
        public int age;

        public void Info()
        {
            Console.WriteLine("Iмя собаки: {0} \nПорода собаки: {1} \nВiк собаки: {2}", name, mark, age);
        }
    }

}
