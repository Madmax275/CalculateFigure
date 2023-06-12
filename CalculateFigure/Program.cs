using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculate_Triangle_Circle;

namespace CalculateFigure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure();
            figure.Information();

            Console.WriteLine("Enter a,b and c:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            Figure triangle = new Triangle(a, b, c);
            Console.WriteLine($"Parameter:{triangle.GetPerimeter()}");
            triangle.Information();
            Console.WriteLine();

            Console.WriteLine("Enter radius:");
            double r = Convert.ToDouble(Console.ReadLine());
            Figure fig = new Circle(r);
            fig.Information();
            Console.Read();
        }
    }
}
