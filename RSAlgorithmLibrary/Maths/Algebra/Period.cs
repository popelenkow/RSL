using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSL.Maths.Algebra
{
    public static class Period
    {
        public static double Calculate(double value, double left, double right)
        {
            double res;
            double quotient;
            quotient = (value - left) / (right - left);
            quotient = Math.Floor(quotient);
            res = value - quotient * (right - left);
            return res;
        }
    }
}
