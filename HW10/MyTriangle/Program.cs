using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MyTriangle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Triangle> triangles = new List<Triangle>();
            triangles.Add(new Triangle(new Point(1, 4), new Point(3, 5), new Point(2, 4)));
            triangles.Add(new Triangle(new Point(0, 1), new Point(2, 6), new Point(1, 2)));
            triangles.Add(new Triangle(new Point(1, 3), new Point(4, 5), new Point(0, 3)));

            foreach (var triangle in triangles)
            {
                triangle.Print();
            }

        }
    }
}


