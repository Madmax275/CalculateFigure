using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Triangle_Circle
{
    public class Triangle:Figure
    {

        public double A_Side { get; set; }
        public double B_Side { get; set; }
        public double C_Side { get; set; }
        public Triangle(double a, double b, double c)
        {
            if (A_Side * A_Side + B_Side * B_Side == C_Side * C_Side)
            {
                Console.WriteLine("Triangle is right!");
            }
            this.A_Side = a;
            this.B_Side = b;
            this.C_Side = c;
            
        }
        public override double GetArea()
        {
            double p = GetPerimeter() / 2;
            Area = Math.Sqrt(p * (p - A_Side) * (p - B_Side) * (p - C_Side));
            return Area;
        }
        public override double GetPerimeter()
        {
            Perimeter = A_Side + B_Side + C_Side;
            return Perimeter;
        }
    }
}
