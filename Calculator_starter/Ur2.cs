using System;

namespace Equation
{
    class Ur2
    {


        public static int CalcRoots(double a, double b, double c, out double x1, out double x2)
        {
            int i = 0;
            x1 = 0;
            x2 = 0;

            double d = b * b - 4 * a * c;

            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                i = 1;
                return i;
            }
            else if (d == 0)
            {
                x1 = x2 = -b / (2 * a);
                i = 0;
                return i;
            }
            else
            {
                i = -1;
                return i;
            }
        }
    }
}
