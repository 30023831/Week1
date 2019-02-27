using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App6
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, per_cir;
            double PI = 3.14;
            double pie = 3.141592654;
            Console.WriteLine("Input the radius of the circle : ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Perimeter of Circle with radius {1}: {0}", Perimeter(r, pie), r);
            Console.WriteLine("Area: {0}" , FindArea(r));
            Console.Read();
        }

        static double Perimeter(double r, double pi)
        {
            return 2 * pi * r;
        }

        static double FindArea(double radius)

        {
            double area;
            area = Math.PI* radius * radius;

            return area;
        }


    }
}
