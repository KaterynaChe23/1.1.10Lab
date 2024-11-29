using lab1v10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1laba10V
{
    class Program
    {
        static public void Main()
        {
            EquationOfThePlane plane = new EquationOfThePlane(6, 5, -9.3, 11);
            double x = 0;
            double y = 0;
            double z = 11 / 9.3;
            Console.WriteLine(plane.Coordinates(0));
            Console.WriteLine(plane.Coordinates(1));
            Console.WriteLine(plane.Coordinates(2));

            bool Point = plane.IsPointOnPlane(x, y, z);
            plane.Print(x, y, z, Point);

        }
    }
}