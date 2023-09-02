using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace HW8
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            List<Shape> shapes = new List<Shape>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter shape type (circle or square) for shape {i + 1}: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "circle")
                {
                    Circle circle = new("", 0);
                    circle.Input();
                    shapes.Add(circle);
                }
                else if (input.ToLower() == "square")
                {
                    Square square = new Square("", 0);
                    square.Input();
                    shapes.Add(square);
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again!");
                }
            }

            Console.WriteLine("Information about shape:");
            foreach (Shape shape in shapes)
            {
                shape.Output();
            }

            double maxPerimeter = -1;
            Shape shapeMaxPerimeter = null;

            foreach (Shape shape in shapes)
            {
                double perimeter = shape.Perimeter();
                if (perimeter > maxPerimeter)
                {
                    maxPerimeter = perimeter;
                    shapeMaxPerimeter = shape;
                }
            }

            Console.WriteLine($"Shape with largest perimeter:");
            shapeMaxPerimeter.Output();

            shapes.Sort();
            Console.WriteLine("Shapes sorted by area:");
            foreach (Shape shape in shapes)
            {
                shape.Output();
            }

        }
    }
}