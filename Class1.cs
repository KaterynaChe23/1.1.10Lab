using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1v10
{
    public class EquationOfThePlane
    {
        private double[] coefficients;
        public EquationOfThePlane(double a, double b, double c, double d)
        {
            this.coefficients = new double[] { a, b, c, d };

        }
        public double this[int index]
        {
            get
            {
                if (index >= 0 && index < coefficients.Length)
                {
                    return coefficients[index];
                }
                throw new IndexOutOfRangeException("Недійсний індекс");
            }
            set
            {
                if (index >= 0 && index < coefficients.Length)
                {
                    coefficients[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Недійсний індекс");
                }
            }
        }
        public double Coordinates(int x)
        {
            if (x < 0 || x > 2)
            {
                throw new Exception("Недійсний індекс осі. Має бути 0 (x), 1 (y), або 2 (z).");
            }
            string[] axes = { "x", "y", "z" };

            if (coefficients[x] != 0)
            {
                double point_peretuny = -coefficients[3] / coefficients[x];
                Console.WriteLine($"Площина пересікаєтся з віссю {axes[x]} в точці: ");
                return point_peretuny;

            }

            else
            {
                throw new Exception($"Площина з даною віссю {coefficients[x]} не перетинається");
            }
        }

        public bool IsPointOnPlane(double x, double y, double z)
        {
            double A = coefficients[0];
            double B = coefficients[1];
            double C = coefficients[2];
            double D = coefficients[3];

            double result = A * x + B * y + C * z + D;

            double epsilon = 1e-10; // Допустима похибка

            return Math.Abs(result) < epsilon;

        }



        public void Print(double x, double y, double z, bool Point)
        {
            Console.WriteLine($"Рівняння площини: {coefficients[0]}x + {coefficients[1]}y + {coefficients[2]}z + {coefficients[3]} = 0");
            Console.WriteLine($"A ={coefficients[0]},B = {coefficients[1]}, C = {coefficients[2]}, D = {coefficients[3]}");

            Console.WriteLine($"Точка ({x} , {y}  ,{z}) {(Point ? "належить" : "не належить")} площині");
        }

    }

}
