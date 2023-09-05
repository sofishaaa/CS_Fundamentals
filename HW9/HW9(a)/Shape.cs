using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    abstract class Shape
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

    }
}
