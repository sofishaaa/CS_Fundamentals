using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    abstract class Shape : IComparable<Shape>
    {

        private string name;
        public string Name { get { return name; } }

        public Shape(string name)
        {
            this.name = name;
        }

        public abstract double Area();
        public abstract double Perimeter();

        public abstract void Input();
        public abstract void Output();

        public int CompareTo(Shape other)
        {
            double thisArea = Area();
            double otherArea = other.Area();

            if (thisArea < otherArea)
                return -1;
            else if (thisArea > otherArea)
                return 1;
            else
                return 0;
        }
    }
}
