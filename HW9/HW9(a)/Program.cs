using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace HW9
{
    class Program
    {
        public static void Main(string[] args)
        {

            List<Shape> shapes = new List<Shape>();

            Console.WriteLine("Enter the data about 10 shapes (circle and square): ");
        a1:
            try
            {
                for (int i = 0; i < 6; i++)
                {

                    Console.Write("Enter shape type: ");
                    string shapeType = Console.ReadLine();
                    if (shapeType.ToLower() == "circle" || shapeType.ToLower() == "square")
                    {
                        if (shapeType.ToLower() == "circle")
                        {
                            Console.Write($"Enter the name of {shapeType}: ");
                            string shapeName = Console.ReadLine();
                            Console.Write("Enter the radius of circle: ");
                            double radius = Convert.ToDouble(Console.ReadLine());
                            shapes.Add(new Circle(shapeName, radius));
                        }
                        else if (shapeType.ToLower() == "square")
                        {
                            Console.Write($"Enter the name of {shapeType}: ");
                            string shapeName = Console.ReadLine();
                            Console.Write($"Enter side length for the square: ");
                            double side = Convert.ToDouble(Console.ReadLine());
                            shapes.Add(new Square(shapeName, side));
                        }
                    }
                    else
                    {
                        throw new ApplicationException("Try again. Enter the shape type - circle or square");
                    }
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                goto a1;
            }
            catch (ApplicationException exmy)
            {
                Console.WriteLine(exmy.Message);
                goto a1;
            }
            catch (Exception ecx)
            {
                Console.WriteLine(ecx.Message);
                goto a1;
            }

            Console.WriteLine("Information about shapes: ");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($" Name: {shape.Name}, Perimeter: {shape.Perimeter():F2}, Area: {shape.Area():F2}");
            }


            IEnumerable<Shape> areaOfFigures = shapes.Where(shape => shape.Area() >= 10 && shape.Area() <= 100);
            IEnumerable<Shape> containsTheLetter = shapes.Where(shape => shape.Name.ToLower().Contains("a"));
            using (StreamWriter writeShapes = new StreamWriter(@"Z:\Desktop\updatedFigures.txt"))
            {
                writeShapes.WriteLine("Shapes with area from range [10,100]: ");
                foreach (Shape shape in areaOfFigures)
                {
                    writeShapes.WriteLine($"Name: {shape.Name}, Perimeter: {shape.Perimeter():F2}, Area: {shape.Area():F2}");
                }

                writeShapes.WriteLine("shapes which name contains letter 'a': ");
                foreach (Shape shape in containsTheLetter)
                {
                    writeShapes.WriteLine($"Name: {shape.Name}, Perimeter: {shape.Perimeter():F2}, Area: {shape.Area():F2}");
                }
            }

            shapes.RemoveAll(shape => shape.Perimeter() < 5);
            Console.WriteLine("Remove all shapes with perimeter less then 5: ");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($" Name: {shape.Name}, Perimeter: {shape.Perimeter():F2}, Area: {shape.Area():F2}");
            }

        }
    }
}