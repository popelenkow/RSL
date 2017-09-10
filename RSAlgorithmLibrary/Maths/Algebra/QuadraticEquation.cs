using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSL.Maths.Algebra
{
    public static class QuadraticEquation
    {
        public static List<double> Calculate(double a, double b, double c)
        {
            double d = Discriminant(a, b, c);
            List<double> res = new List<double>();

            if (d == 0.0)
            {
                double bb = -b / 2.0;
                res.Add(bb);
            }
            else if (d > 0.0)
            {
                double dd = Math.Sqrt(d);
                double bb = -b / 2.0;
                res.Add(bb - dd);
                res.Add(bb + dd);
            }

            return res;
        }
        private static double Discriminant(double a, double b, double c)
        {
            return b * b / 4.0 - a * c;
        }
    }
}
