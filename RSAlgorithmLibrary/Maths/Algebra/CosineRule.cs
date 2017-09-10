using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSL.Maths.Algebra
{
    public static class CosineRule
    {
        /// <summary>
        /// Противолежащая сторона к углу
        /// </summary>
        public static double OppositeSide(double angle, double adjacentSide1, double adjacentSide2)
        {
            double cosA = Math.Cos(angle * Constants.DegToRad);
            double s1 = adjacentSide1;
            double s2 = adjacentSide2;
            double res = (s1 * s1) + (s2 * s2) - (2 * s1 * s2 * cosA);
            return Math.Sqrt(res);
        }

        /// <summary>
        /// Прилежащая сторона к углу.
        /// </summary>
        public static List<double> AdjacentSide(double angle, double adjacentSide, double oppositeSide)
        {
            double cosA = Math.Cos(angle * Constants.DegToRad);
            double sA = adjacentSide;
            double sO = oppositeSide;

            double a = 1;
            double b = -2 * sA * cosA;
            double c = (sA * sA) - (sO * sO);
            return QuadraticEquation.Calculate(a, b, c);
        }
    }
}
