using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTriangle
{
    public class Triangle
    {
        //fields of type Point
        Point vertex1; 
        Point vertex2;
        Point vertex3;

        //properties (read-only)
        public Point Vertex1
        {
            get { return vertex1; }
        }

        public Point Vertex2
        {
            get { return vertex2; }
        }

        public Point Vertex3
        {
            get { return vertex3; }
        }

        //constructor
        public Triangle(Point vertex1, Point vertex2, Point vertex3)
        {
            this.vertex1 = vertex1;
            this.vertex2 = vertex2;
            this.vertex3 = vertex3;
        }

        public double Distance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.x - p1.x, 2) * Math.Pow(p2.y - p1.y, 2));
        }
        public void SideLengths(out double sideTriangle1, out double sideTriangle2, out double sideTriangle3)
        {

            sideTriangle1 = Distance(vertex1, vertex2);
            sideTriangle2 = Distance(vertex2, vertex3);
            sideTriangle3 = Distance(vertex3, vertex1);

        }
        public double Perimeter()
        {
            SideLengths(out double sideTriangle1, out double sideTriangle2, out double sideTriangle3);
            return sideTriangle1 + sideTriangle2 + sideTriangle3;
        }

        public double Square()
        {
            SideLengths(out double sideTriangle1, out double sideTriangle2, out double sideTriangle3);
            double p = Perimeter() / 2;    //semi-perimeter
            return Math.Sqrt(p * (p - sideTriangle1) * (p - sideTriangle2) * (p - sideTriangle3));
        }

        public void Print()
        {
            Console.WriteLine($"Perimeter: {Perimeter():F2}");
            Console.WriteLine($"Square: {Square():F2}");

        }
    }
}
