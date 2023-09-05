using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    class Square : Shape
    {

        public double side;
        public double Side { get; set; }

        public Square(string name, double side) : base(name)
        {
            Side = side;
        }

        public override double Area()
        {
            return Side * Side;
        }

        public override double Perimeter()
        {
            return 4 * Side;
        }

        public override void Input()
        {
            Console.Write("Enter square side: ");
            Side = Convert.ToDouble(Console.ReadLine());
        }

        public override void Output()
        {
            Console.WriteLine($"Square: Name = {Name}, Side = {Side}, Area = {Area():F2}, Perimeter = {Perimeter():F2}");
        }

    }
}
