using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Triangle_Circle
{
    public class Figure
    {
        public double Area { get; set; }
        public double Perimeter { get; set; }
        public virtual double GetArea()
        {
            return Area;
        }
        public virtual double GetPerimeter()
        {
            return Perimeter;
        }

        public void Information()
        {
            Console.WriteLine($"Area: {Math.Round(GetArea(), 4)}");
            Console.WriteLine($"Perimeter: {Math.Round(GetPerimeter(), 4)}");

        }
    }
}
