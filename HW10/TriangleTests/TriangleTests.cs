using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyTriangle.Test
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void DistanceBetweenPoints_2pointsWithCoordinates_returns0dot0()
        {
            //Arrange
            Point p1 = new Point(1, 2);
            Point p2 = new Point(1, 0);
            Triangle triangle = new Triangle(p1, p2, new Point(0, 0));

            //Act
            double expectedDistance = triangle.Distance(p1, p2);

            //Assert
            Assert.AreEqual(0.0, expectedDistance);
        }

        [TestMethod]
        public void PerimeterOfTriangle_3pointsWithCoordinates_returnsCorrectPerimeter()
        {
            Point p1 = new Point(1, 2);
            Point p2 = new Point(1, 0);
            Point p3 = new Point(0, 0);

            double expectedPerimeter = 5.23606797749979;
            Triangle triangle = new Triangle(p1, p2, p3);
            double actualPerimeter = triangle.Square();
            Assert.AreEqual(expectedPerimeter, actualPerimeter);

        }

        [TestMethod]
        public void SquareOfTriangle_3pointsWithCoordinates_returnsCorrectSquare()
        {
            Point p1 = new Point(1, 2);
            Point p2 = new Point(1, 0);
            Point p3 = new Point(0, 0);

            double expectedSquare = 1;
            Triangle triangle = new Triangle(p1, p2, p3);
            double actualSquare = triangle.Square();
            Assert.AreEqual(expectedSquare, actualSquare);
        }

        [TestMethod]
        public void PrintInformationAboutTriangle()
        {
            Point p1 = new Point(1, 2);
            Point p2 = new Point(1, 0);
            Point p3 = new Point(0, 0);

            Triangle triangle = new Triangle(p1, p2, p3);
            string expectedPrint = $"Perimeter is 5,23606797749979 Square is 1";
            string actualPrint = $"Perimeter is {triangle.Perimeter():F2} Square is {triangle.Square()}";
            Assert.AreEqual(expectedPrint, actualPrint);

        }

        [TestClass]
        public class PointTest
        {
            [TestMethod]
            public void ToStringTest()
            {
                Point testPoint = new Point(1, 0);

                string expected = "(1,0)";
                string actual = testPoint.ToString();

                Assert.AreEqual(expected, actual);
            }
        }
        

    }
}