using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculate_Triangle_Circle;

namespace FigureTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TestTrianglePerimeter() 
        {
            double a = 8;
            double b = 4;
            double c = 6;
            double expected = 18;

            
           Triangle triangle = new Triangle(a,b,c);
           double actual = triangle.GetPerimeter();
            Assert.AreEqual(expected,actual, "Method is incorrect");
        }

        [TestMethod]
        public void TestTriangleArea() 
        {
            double a = 2;
            double b = 5;
            double c = 7;
            double expected = 14;

            Triangle triangle = new Triangle(a, b, c);
            double actual = triangle.GetPerimeter();

            Assert.AreEqual(expected, actual, "Method is incorrect");
        }

    }
}
