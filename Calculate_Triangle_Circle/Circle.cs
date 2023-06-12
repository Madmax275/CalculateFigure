using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Triangle_Circle
{
    public class Circle:Figure
    {
        public double Radius { get; set; }
        public Circle(double r)
        {
            Radius = r;
        }
        public override double GetArea()
        {
            Area = Math.PI * Math.Pow(Radius, 2);
            return Area;
        }
        public override double GetPerimeter()
        {
            Perimeter = 2 * Math.PI * Radius;
            return Perimeter;
        }
    }
}
