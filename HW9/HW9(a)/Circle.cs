using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    class Circle : Shape
    {

        public double radius;
        public double Radius { get; set; }

        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override void Input()
        {
            Console.Write("Enter the radius of circle: ");
            Radius = Convert.ToDouble(Console.ReadLine());
        }

        public override void Output()
        {
            Console.WriteLine($"Circle: Name = {Name}, Radius = {Radius}, Area = {Area():F2}, Perimeter = {Perimeter():F2}");
        }

    }
}
