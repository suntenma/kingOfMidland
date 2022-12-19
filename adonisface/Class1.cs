using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonisface
{
    internal class Class1
    {
        static public double X1(double a, double b, double c)
        {
            double disc = Math.Pow(b, 2) - 4 * a * c;
            if (disc > 0)
            {
                double x1 = (-b - Math.Sqrt(disc)) / 2 * a;
                return x1;
            }
            else 
                return 0;
        }

        static public double X2(double a, double b, double c)
        {
            double disc = Math.Pow(b, 2) - 4 * a * c;
            if (disc > 0)
            {
                double x1 = (-b + Math.Sqrt(disc)) / 2 * a;
                return x1;
            }
            else
                return 0;
        }
    }
}
