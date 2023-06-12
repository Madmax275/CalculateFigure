using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculate_Triangle_Circle;

namespace FigureTest
{
    [TestClass]
    public class CirlceTest
    {
        [TestMethod]
        public void CircleArea()
        {
            double r = 8;
            double expected = 201.06192982974676;

            Circle circle = new Circle(r);
            double actual = circle.GetArea();

            Assert.AreEqual(expected, actual, "Method is incorrect");
        }

        [TestMethod]
        public void CirclePerimeter() 
        {
            double r = 4;
            double expected = 25.132741228718345907701147955385;

            Circle circle1 = new Circle(r);
            double actual = circle1.GetPerimeter();

            Assert.AreEqual(expected, actual, "Method is incorrect");
        }
    }
}
