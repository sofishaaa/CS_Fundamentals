using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    internal class ReadNumbers
    {
        public int numbers;

        public int Numbers
        {

            get { return numbers; }
            set { numbers = value; }

        }

        public ReadNumbers() { }

        public ReadNumbers(int nums)
        {

            this.numbers = nums;

        }

        public int ReadNumber(int start, int end)
        {
            Console.WriteLine($"Enter integer between {start} and {end}: ");
            string input = Console.ReadLine();

            try
            {
                int number = Convert.ToInt32(input);

                if (number < start || number > end)
                {
                    throw new ArgumentOutOfRangeException("Your integer is out of range. Try again");
                }

                return number;
            }
            catch (FormatException)
            {
                throw new FormatException("Invalid input. Please enter a valid integer.");
            }
        }

        public void Input(int start, int end)
        {
            try
            {
                numbers = ReadNumber(start, end);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Input(start, end);
            }
            catch (ArgumentOutOfRangeException exc)
            {
                Console.WriteLine(exc.Message);
                Input(start, end);
            }
        }
    }
}
