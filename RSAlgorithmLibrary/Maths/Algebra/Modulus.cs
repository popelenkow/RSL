using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSL.Maths.Algebra
{
    public static class Modulus
    {
        public static double Sign(double value)
        {
            double res;
            if (IsPositive(value))
            {
                res = 1.0;
            }
            else
            {
                res = -1.0;
            }
            return res;
        }
        public static double Absolute(double value)
        {
            return value * Sign(value);
        }
        public static bool IsPositive(double value)
        {
            return value >= 0.0;
        }
        public static bool IsNegative(double value)
        {
            return value < 0.0;
        }
    }
}
